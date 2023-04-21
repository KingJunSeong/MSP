using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSP.JsonObject
{
    public partial class FileResponse
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
        [JsonProperty("type_description")]
        public string TypeDescription { get; set; }

        [JsonProperty("tlsh")]
        public string Tlsh { get; set; }

        [JsonProperty("vhash")]
        public string Vhash { get; set; }

        [JsonProperty("type_tags")]
        public List<string> TypeTags { get; set; }

        [JsonProperty("creation_date")]
        public long CreationDate { get; set; }

        [JsonProperty("names")]
        public List<string> Names { get; set; }

        [JsonProperty("last_modification_date")]
        public long LastModificationDate { get; set; }

        [JsonProperty("type_tag")]
        public string TypeTag { get; set; }

        [JsonProperty("times_submitted")]
        public long TimesSubmitted { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("authentihash")]
        public string Authentihash { get; set; }

        [JsonProperty("last_submission_date")]
        public long LastSubmissionDate { get; set; }


        [JsonProperty("meaningful_name")]
        public string MeaningfulName { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("type_extension")]
        public string TypeExtension { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("last_analysis_date")]
        public long LastAnalysisDate { get; set; }

        [JsonProperty("unique_sources")]
        public long UniqueSources { get; set; }

        [JsonProperty("first_submission_date")]
        public long FirstSubmissionDate { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("ssdeep")]
        public string Ssdeep { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }


        [JsonProperty("magic")]
        public string Magic { get; set; }

        [JsonProperty("last_analysis_stats")]
        public LastAnalysisStats LastAnalysisStats { get; set; }

        [JsonProperty("reputation")]
        public long Reputation { get; set; }

    }
    public partial class LastAnalysisStats
    {
        [JsonProperty("harmless")]
        public long Harmless { get; set; }

        [JsonProperty("type-unsupported")]
        public long TypeUnsupported { get; set; }

        [JsonProperty("suspicious")]
        public long Suspicious { get; set; }

        [JsonProperty("confirmed-timeout")]
        public long ConfirmedTimeout { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }

        [JsonProperty("failure")]
        public long Failure { get; set; }

        [JsonProperty("malicious")]
        public long Malicious { get; set; }

        [JsonProperty("undetected")]
        public long Undetected { get; set; }
    }
}
