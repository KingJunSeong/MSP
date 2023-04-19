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

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("last_modification_date")]
        public long LastModificationDate { get; set; }

        [JsonProperty("times_submitted")]
        public long TimesSubmitted { get; set; }

        [JsonProperty("total_votes")]
        public TotalVotes TotalVotes { get; set; }

        [JsonProperty("threat_names")]
        public List<object> ThreatNames { get; set; }

        [JsonProperty("last_submission_date")]
        public long LastSubmissionDate { get; set; }

        [JsonProperty("last_http_response_content_length")]
        public long LastHttpResponseContentLength { get; set; }

        [JsonProperty("last_http_response_headers")]
        public LastHttpResponseHeaders LastHttpResponseHeaders { get; set; }

        [JsonProperty("reputation")]
        public long Reputation { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("last_analysis_date")]
        public long LastAnalysisDate { get; set; }

        [JsonProperty("first_submission_date")]
        public long FirstSubmissionDate { get; set; }

        [JsonProperty("categories")]
        public Categories Categories { get; set; }

        [JsonProperty("last_http_response_content_sha256")]
        public string LastHttpResponseContentSha256 { get; set; }

        [JsonProperty("last_http_response_code")]
        public long LastHttpResponseCode { get; set; }

        [JsonProperty("last_final_url")]
        public Uri LastFinalUrl { get; set; }

        [JsonProperty("trackers")]
        public Trackers Trackers { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("last_analysis_stats")]
        public LastAnalysisStats LastAnalysisStats { get; set; }

        [JsonProperty("last_analysis_results")]
        public Dictionary<string, LastAnalysisResult> LastAnalysisResults { get; set; }

        [JsonProperty("tld")]
        public string Tld { get; set; }

        [JsonProperty("html_meta")]
        public Dictionary<string, List<string>> HtmlMeta { get; set; }

        [JsonProperty("outgoing_links")]
        public List<Uri> OutgoingLinks { get; set; }
    }

    public partial class Categories
    {
        [JsonProperty("Forcepoint ThreatSeeker")]
        public string ForcepointThreatSeeker { get; set; }
    }

    public partial class LastAnalysisResult
    {
        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }

        [JsonProperty("engine_name")]
        public string EngineName { get; set; }
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

    public partial class LastHttpResponseHeaders
    {
        [JsonProperty("Content-Length")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ContentLength { get; set; }

        [JsonProperty("Content-Encoding")]
        public string ContentEncoding { get; set; }

        [JsonProperty("Set-Cookie")]
        public string SetCookie { get; set; }

        [JsonProperty("Expires")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Expires { get; set; }

        [JsonProperty("Vary")]
        public string Vary { get; set; }

        [JsonProperty("Server")]
        public string Server { get; set; }

        [JsonProperty("Last-Modified")]
        public string LastModified { get; set; }

        [JsonProperty("Connection")]
        public string Connection { get; set; }

        [JsonProperty("Pragma")]
        public string Pragma { get; set; }

        [JsonProperty("Cache-Control")]
        public string CacheControl { get; set; }

        [JsonProperty("Date")]
        public string Date { get; set; }

        [JsonProperty("P3P")]
        public string P3P { get; set; }

        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }
    }

    public partial class TotalVotes
    {
        [JsonProperty("harmless")]
        public long Harmless { get; set; }

        [JsonProperty("malicious")]
        public long Malicious { get; set; }
    }

    public partial class Trackers
    {
        [JsonProperty("Google Analytics")]
        public List<Google> GoogleAnalytics { get; set; }

        [JsonProperty("Google Tag Manager")]
        public List<Google> GoogleTagManager { get; set; }

        [JsonProperty("Google AdSense")]
        public List<GoogleAdSense> GoogleAdSense { get; set; }
    }

    public partial class GoogleAdSense
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }

    public partial class Google
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }
    }

    public enum Category { Harmless, Undetected };

    public enum Method { Blacklist };

    public enum Result { Clean, Unrated };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CategoryConverter.Singleton,
                MethodConverter.Singleton,
                ResultConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "harmless":
                    return Category.Harmless;
                case "undetected":
                    return Category.Undetected;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            switch (value)
            {
                case Category.Harmless:
                    serializer.Serialize(writer, "harmless");
                    return;
                case Category.Undetected:
                    serializer.Serialize(writer, "undetected");
                    return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }

    internal class MethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Method) || t == typeof(Method?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "blacklist")
            {
                return Method.Blacklist;
            }
            throw new Exception("Cannot unmarshal type Method");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Method)untypedValue;
            if (value == Method.Blacklist)
            {
                serializer.Serialize(writer, "blacklist");
                return;
            }
            throw new Exception("Cannot marshal type Method");
        }

        public static readonly MethodConverter Singleton = new MethodConverter();
    }

    internal class ResultConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Result) || t == typeof(Result?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "clean":
                    return Result.Clean;
                case "unrated":
                    return Result.Unrated;
            }
            throw new Exception("Cannot unmarshal type Result");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Result)untypedValue;
            switch (value)
            {
                case Result.Clean:
                    serializer.Serialize(writer, "clean");
                    return;
                case Result.Unrated:
                    serializer.Serialize(writer, "unrated");
                    return;
            }
            throw new Exception("Cannot marshal type Result");
        }

        public static readonly ResultConverter Singleton = new ResultConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
