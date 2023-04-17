using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MSP.Utils
{
    class FileScan
    {
        public static async Task APIFileScan(string hash)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://www.virustotal.com/api/v3/files/{hash}"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "x-apikey", $"{APIKey.apikey}" },
                },
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            var analysis_id = JObject.Parse(body)?["data"]?["attributes"]?["last_analysis_results"];
            var engine_name = analysis_id?
                .Values<JProperty>()
                .Where(v => v?.Value["category"]?.ToString() == "malicious")
                .Select(v => v?.Value["engine_name"]?.ToString());
            var malware = analysis_id?.Count();
            var malwareCount = engine_name.Count();

            
        }
    }
}
