using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELM_ATLAS
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer _healthPointTimer;
        private readonly HttpClient _client;
        private HealthPoint _healthPoints;
        private readonly HealthPointService _healthPointService;
        private readonly MetricsService _metricsService;

        public Form1()
        {
            InitializeComponent();
            _client = new HttpClient();
            _healthPointService = new HealthPointService(_client);
            _metricsService = new MetricsService(_client);

            LoadHealthPoints();
            InitializeTimer();
            AddButtonsToGrid();

            _ = CheckActuatorHealthAsync(updateLabels: true);
        }

        private void LoadHealthPoints()
        {
            try
            {
                const string filePath = "env2.json";
                var jsonString = File.ReadAllText(filePath);
                _healthPoints = JsonConvert.DeserializeObject<HealthPoint>(jsonString) ?? new HealthPoint();
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error loading health check configuration", ex);
                _healthPoints = new HealthPoint();
            }
        }

        private void InitializeTimer()
        {
            _healthPointTimer = new System.Windows.Forms.Timer
            {
                Interval = 30000 // 30 seconds
            };
            _healthPointTimer.Tick += async (sender, e) => await CheckActuatorHealthAsync(updateLabels: true);
            _healthPointTimer.Start();
        }

        private async Task CheckActuatorHealthAsync(bool updateLabels)
        {
            await _healthPointService.CheckHealthPointsAsync(_healthPoints);
            UpdateUI(updateLabels);
        }

        private void UpdateUI(bool updateLabels)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

            foreach (var test in _healthPoints.Healthpoint.Values)
            {
                foreach (var env in test.Environments)
                {
                    AddStatusElement(env);
                }
            }

            if (updateLabels)
            {
                UpdateLabels(_healthPoints);
            }
        }

        private void AddStatusElement(Environment env)
        {
            string pattern = @"https://(.*?)\.ch";
            Match match = Regex.Match(env.Url, pattern);

            var statusElement = new StatusElement
            {
                Title = $"{match.Groups[1].Value} - {env.Stage} ({env.Context})",
                Error = env.Status,
                PictureBoxVisible = env.Status == "UP",
                PictureBoxErrorVisible = env.Status != "UP"
            };

            flowLayoutPanel1.Controls.Add(statusElement);
        }

        private void UpdateLabels(HealthPoint healthPoint)
        {
            int upCount = healthPoint.Healthpoint.Values
                .SelectMany(env => env.Environments)
                .Count(e => e.Status == "UP");

            int errorCount = healthPoint.Healthpoint.Values
                .SelectMany(env => env.Environments)
                .Count(e => e.Status != "UP");

            int prodErrors = healthPoint.Healthpoint.Values
                .SelectMany(env => env.Environments)
                .Count(e => e.Stage == "prod" && e.Status != "UP");

            prodError.Visible = prodErrors > 0;
            prodErrorMessage.Text = $"Achtung: {prodErrors} {(prodErrors == 1 ? "produktive Umgebung ist fehlerhaft." : "produktive Umgebungen sind fehlerhaft.")}";

            successLabel.Text = upCount.ToString();
            errorLabel.Text = errorCount.ToString();
        }

        private void AddButtonsToGrid()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnCount = _healthPoints.Healthpoint.Count;

            foreach (var item in _healthPoints.Healthpoint.Values)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / _healthPoints.Healthpoint.Count));

                System.Windows.Forms.Button button = new System.Windows.Forms.Button
                {
                    Text = item.Name,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font(SystemFonts.DefaultFont.FontFamily, 15),
                    Dock = DockStyle.Fill,
                    BackColor = System.Drawing.Color.White
                };
                button.Click += (sender, e) => { panelAppInsights.Visible = true; };

                tableLayoutPanel1.Controls.Add(button, 0, 0);
            }
        }

        private async void btnAppInsights_Click(object sender, EventArgs e)
        {
            await FetchMetricsAndErrorsAsync();
        }

        private async Task FetchMetricsAndErrorsAsync()
        {
            await _metricsService.FetchMetricsAndErrorsAsync(AppProperties.apiKey, AppProperties.baseUrl, listView1);
        }

        private void ShowErrorMessage(string title, Exception ex)
        {
            MessageBox.Show($"{title}: {ex.Message}", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelAppInsights.Visible = false;
        }
    }

    // HealthPointService handles health check logic.
    public class HealthPointService
    {
        private readonly HttpClient _client;

        public HealthPointService(HttpClient client)
        {
            _client = client;
        }

        public async Task CheckHealthPointsAsync(HealthPoint healthPoints)
        {
            foreach (var test in healthPoints.Healthpoint.Values)
            {
                foreach (var env in test.Environments)
                {
                    try
                    {
                        var response = await _client.GetAsync(env.Url);
                        response.EnsureSuccessStatusCode();

                        var responseBody = await response.Content.ReadAsStringAsync();
                        var healthStatus = JsonConvert.DeserializeObject<HealthStatus>(responseBody);
                        env.Status = healthStatus?.Status ?? "Unknown";
                    }
                    catch (Exception ex)
                    {
                        env.Status = $"Error: {ex.Message}";
                    }
                }
            }
        }
    }

    // MetricsService handles metrics and error fetching from external APIs.
    public class MetricsService
    {
        private readonly HttpClient _client;

        public MetricsService(HttpClient client)
        {
            _client = client;
        }

        public async Task FetchMetricsAndErrorsAsync(string apiKey, string baseUrl, System.Windows.Forms.ListView listView)
        {
            _client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            // Get Requests Data
            string requestsQuery = "/metrics/requests/count";
            var requestsResponse = await _client.GetStringAsync($"{baseUrl}{requestsQuery}");
            var requestData = JsonConvert.DeserializeObject<RequestData>(requestsResponse);
            listView.Items.Add($"Requests Count: {requestData.value.requestsCount.sum}");

            // Get Top 3 Errors
            string topErrorsQuery = "/query?query=exceptions | order by timestamp desc | take 3";
            var errorsResponse = await _client.GetStringAsync($"{baseUrl}{topErrorsQuery}");
            var errorsData = JsonConvert.DeserializeObject<AppInsightsErrorResponse>(errorsResponse);
            //DisplayErrors(errorsData, listView);
        }

        private void DisplayErrors(AppInsightsErrorResponse errorsData, System.Windows.Forms.ListView listView)
        {
            foreach (var error in errorsData.exceptions)
            {
                listView.Items.Add($"Error: {error.problemId} - {error.message}");
            }
        }
    }

    // Model classes to represent various data structures.
    

    public class HealthStatus
    {
        public string Status { get; set; }
    }

    public class RequestData
    {
        public Value value { get; set; }
    }

    public class Value
    {
        public string start { get; set; }
        public string end { get; set; }
        [JsonProperty("requests/count")]
        public RequestCount requestsCount { get; set; }
    }

    public class RequestCount
    {
        public int sum { get; set; }
    }

    public class AppInsightsErrorResponse
    {
        public ErrorResult[] exceptions { get; set; }
    }

    public class ErrorResult
    {
        public string problemId { get; set; }
        public string message { get; set; }
    }
}
