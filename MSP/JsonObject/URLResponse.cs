using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP
{
    public partial class URLResponse
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("last_modification_date")]
        public long LastModificationDate { get; set; }

        [JsonProperty("times_submitted")]
        public long TimesSubmitted { get; set; }

        [JsonProperty("threat_names")]
        public List<object> ThreatNames { get; set; }

        [JsonProperty("last_submission_date")]
        public long LastSubmissionDate { get; set; }

        [JsonProperty("last_http_response_content_length")]
        public long LastHttpResponseContentLength { get; set; }

        [JsonProperty("reputation")]
        public long Reputation { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("last_analysis_date")]
        public long LastAnalysisDate { get; set; }

        [JsonProperty("first_submission_date")]
        public long FirstSubmissionDate { get; set; }

        [JsonProperty("last_http_response_content_sha256")]
        public string LastHttpResponseContentSha256 { get; set; }

        [JsonProperty("last_http_response_code")]
        public long LastHttpResponseCode { get; set; }

        [JsonProperty("last_final_url")]
        public Uri LastFinalUrl { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("last_analysis_stats")]
        public LastAnalysisStats LastAnalysisStats { get; set; }

        [JsonProperty("tld")]
        public string Tld { get; set; }

        [JsonProperty("html_meta")]
        public Dictionary<string, List<string>> HtmlMeta { get; set; }

        [JsonProperty("outgoing_links")]
        public List<Uri> OutgoingLinks { get; set; }
    }

    public partial class LastAnalysisStats
    {
        [JsonProperty("harmless")]
        public long Harmless { get; set; }

        [JsonProperty("malicious")]
        public long Malicious { get; set; }

        [JsonProperty("suspicious")]
        public long Suspicious { get; set; }

        [JsonProperty("undetected")]
        public long Undetected { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }
    }
}
