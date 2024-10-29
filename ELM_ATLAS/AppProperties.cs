using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM_ATLAS
{
    public static class AppProperties
    {

        public static readonly string appId = "2e1abe5d-2da7-4cc9-8895-91b0fe784704"; // Replace with your Application Insights App ID
        public static readonly string apiKey = "v4t5hx18dhemi6gw4cox1mqeg80ii1hkfrnwum0p";
        public static string ApiKey => "v4t5hx18dhemi6gw4cox1mqeg80ii1hkfrnwum0p";
        public static readonly string baseUrl = $"https://api.applicationinsights.io/v1/apps/{appId}";

    }
}
