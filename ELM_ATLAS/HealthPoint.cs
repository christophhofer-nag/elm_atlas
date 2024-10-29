using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM_ATLAS
{
    public class HealthPoint
    {
        public Dictionary<string, Customer> Healthpoint { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public List<Environment> Environments { get; set; }
        public List<AppInsight> AppInsights { get; set; }
    }

    public class Environment
    {
        public string Url { get; set; }
        public string Stage { get; set; } // "environment" is a keyword in C#
        public string Context { get; set; }

        public string Status { get; set; }
    }

    public class AppInsight
    {
        public string AppId { get; set; }
        public string ApiKey { get; set; }
        public string BaseUrl { get; set; }
        public string Context { get; set; }
    }

}
