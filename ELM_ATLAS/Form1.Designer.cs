namespace ELM_ATLAS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            flowLayoutPanel = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            errorLabel = new Label();
            successLabel = new Label();
            errorDesc = new Label();
            successDesc = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            prodErrorMessage = new Label();
            prodError = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelAppInsights = new Panel();
            btnAppInsights = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prodError).BeginInit();
            panelAppInsights.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(1, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2495, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.Location = new Point(1420, 139);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1061, 847);
            flowLayoutPanel.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 115);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(263, 258);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(338, 115);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(263, 258);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.BackColor = Color.FromArgb(255, 226, 229);
            errorLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            errorLabel.ForeColor = Color.FromArgb(52, 56, 93);
            errorLabel.Location = new Point(59, 223);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(121, 48);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "label1";
            // 
            // successLabel
            // 
            successLabel.AutoSize = true;
            successLabel.BackColor = Color.FromArgb(208, 242, 231);
            successLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            successLabel.ForeColor = Color.FromArgb(52, 56, 93);
            successLabel.Location = new Point(369, 223);
            successLabel.Name = "successLabel";
            successLabel.Size = new Size(121, 48);
            successLabel.TabIndex = 8;
            successLabel.Text = "label1";
            // 
            // errorDesc
            // 
            errorDesc.AutoSize = true;
            errorDesc.BackColor = Color.FromArgb(255, 226, 229);
            errorDesc.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            errorDesc.ForeColor = Color.FromArgb(52, 56, 93);
            errorDesc.Location = new Point(61, 281);
            errorDesc.Name = "errorDesc";
            errorDesc.Size = new Size(202, 32);
            errorDesc.TabIndex = 9;
            errorDesc.Text = "Services fehlerhaft";
            // 
            // successDesc
            // 
            successDesc.AutoSize = true;
            successDesc.BackColor = Color.FromArgb(208, 242, 231);
            successDesc.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            successDesc.ForeColor = Color.FromArgb(52, 56, 93);
            successDesc.Location = new Point(369, 281);
            successDesc.Name = "successDesc";
            successDesc.Size = new Size(166, 32);
            successDesc.TabIndex = 10;
            successDesc.Text = "Services laufen";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(52, 56, 93);
            label1.Location = new Point(103, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 48);
            label1.TabIndex = 12;
            label1.Text = "Atlas";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(prodErrorMessage);
            panel2.Controls.Add(prodError);
            panel2.Controls.Add(successDesc);
            panel2.Controls.Add(successLabel);
            panel2.Controls.Add(errorLabel);
            panel2.Controls.Add(errorDesc);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox4);
            panel2.ForeColor = Color.FromArgb(93, 95, 235);
            panel2.Location = new Point(1, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(2495, 1217);
            panel2.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(41, 517);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(2454, 683);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(52, 56, 93);
            label8.Location = new Point(35, 461);
            label8.Name = "label8";
            label8.Size = new Size(702, 32);
            label8.TabIndex = 16;
            label8.Text = "Umgebungen werden alle 30 Sekunden automatisch aktualisiert.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(250, 251, 252);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(52, 56, 93);
            label7.Location = new Point(29, 398);
            label7.Name = "label7";
            label7.Size = new Size(394, 48);
            label7.TabIndex = 15;
            label7.Text = "Kunden-Umgebungen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(250, 251, 252);
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 56, 93);
            label6.Location = new Point(37, 33);
            label6.Name = "label6";
            label6.Size = new Size(203, 48);
            label6.TabIndex = 14;
            label6.Text = "Dashboard";
            // 
            // prodErrorMessage
            // 
            prodErrorMessage.AutoSize = true;
            prodErrorMessage.BackColor = Color.FromArgb(255, 226, 229);
            prodErrorMessage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodErrorMessage.ForeColor = Color.FromArgb(250, 90, 125);
            prodErrorMessage.Location = new Point(758, 153);
            prodErrorMessage.Name = "prodErrorMessage";
            prodErrorMessage.Size = new Size(623, 38);
            prodErrorMessage.TabIndex = 13;
            prodErrorMessage.Text = "Achtung! 0 Produktive Umgebungen laufen nicht";
            // 
            // prodError
            // 
            prodError.BackgroundImage = (Image)resources.GetObject("prodError.BackgroundImage");
            prodError.Location = new Point(623, 115);
            prodError.Name = "prodError";
            prodError.Size = new Size(1267, 114);
            prodError.TabIndex = 12;
            prodError.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(1483, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(998, 88);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // panelAppInsights
            // 
            panelAppInsights.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAppInsights.Controls.Add(listView1);
            panelAppInsights.Controls.Add(btnAppInsights);
            panelAppInsights.Location = new Point(1, 106);
            panelAppInsights.Name = "panelAppInsights";
            panelAppInsights.Size = new Size(2495, 1332);
            panelAppInsights.TabIndex = 18;
            panelAppInsights.Visible = false;
            // 
            // btnAppInsights
            // 
            btnAppInsights.Location = new Point(129, 88);
            btnAppInsights.Name = "btnAppInsights";
            btnAppInsights.Size = new Size(278, 34);
            btnAppInsights.TabIndex = 0;
            btnAppInsights.Text = "APP Insights";
            btnAppInsights.UseVisualStyleBackColor = true;
            btnAppInsights.Click += btnAppInsights_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(145, 198);
            listView1.Name = "listView1";
            listView1.Size = new Size(820, 399);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 252);
            ClientSize = new Size(2493, 1318);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelAppInsights);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(flowLayoutPanel);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prodError).EndInit();
            panelAppInsights.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label errorLabel;
        private Label successLabel;
        private Label errorDesc;
        private Label successDesc;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel2;
        private PictureBox prodError;
        private Label prodErrorMessage;
        private Label label6;
        private Label label8;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelAppInsights;
        private ListView listView1;
        private Button btnAppInsights;
    }
}
