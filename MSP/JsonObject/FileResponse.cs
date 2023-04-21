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

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
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

        [JsonProperty("crowdsourced_yara_results")]
        public List<CrowdsourcedYaraResult> CrowdsourcedYaraResults { get; set; }

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

        [JsonProperty("total_votes")]
        public TotalVotes TotalVotes { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("popular_threat_classification")]
        public PopularThreatClassification PopularThreatClassification { get; set; }

        [JsonProperty("authentihash")]
        public string Authentihash { get; set; }

        [JsonProperty("last_submission_date")]
        public long LastSubmissionDate { get; set; }

        [JsonProperty("sigma_analysis_results")]
        public List<SigmaAnalysisResult> SigmaAnalysisResults { get; set; }

        [JsonProperty("meaningful_name")]
        public string MeaningfulName { get; set; }

        [JsonProperty("trid")]
        public List<Trid> Trid { get; set; }

        [JsonProperty("sigma_analysis_summary")]
        public SigmaAnalysisSummary SigmaAnalysisSummary { get; set; }

        [JsonProperty("sandbox_verdicts")]
        public SandboxVerdicts SandboxVerdicts { get; set; }

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

        [JsonProperty("pe_info")]
        public PeInfo PeInfo { get; set; }

        [JsonProperty("magic")]
        public string Magic { get; set; }

        [JsonProperty("last_analysis_stats")]
        public LastAnalysisStats LastAnalysisStats { get; set; }

        [JsonProperty("last_analysis_results")]
        public Dictionary<string, LastAnalysisResult> LastAnalysisResults { get; set; }

        [JsonProperty("reputation")]
        public long Reputation { get; set; }

        [JsonProperty("sigma_analysis_stats")]
        public SigmaAnalysisStats SigmaAnalysisStats { get; set; }
    }

    public partial class CrowdsourcedYaraResult
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public Uri Source { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("ruleset_name")]
        public string RulesetName { get; set; }

        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        [JsonProperty("ruleset_id")]
        public string RulesetId { get; set; }

        [JsonProperty("match_in_subfile", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchInSubfile { get; set; }
    }

    public partial class LastAnalysisResult
    {
        [JsonProperty("engine_name")]
        public string EngineName { get; set; }

        [JsonProperty("engine_version")]
        public string EngineVersion { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }

        [JsonProperty("engine_update")]
        public string EngineUpdate { get; set; }
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

    public partial class PeInfo
    {
        [JsonProperty("resource_details")]
        public List<ResourceDetail> ResourceDetails { get; set; }

        [JsonProperty("rich_pe_header_hash")]
        public string RichPeHeaderHash { get; set; }

        [JsonProperty("imphash")]
        public string Imphash { get; set; }

        [JsonProperty("compiler_product_versions")]
        public List<string> CompilerProductVersions { get; set; }

        [JsonProperty("resource_langs")]
        public ResourceLangs ResourceLangs { get; set; }

        [JsonProperty("machine_type")]
        public long MachineType { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("resource_types")]
        public ResourceTypes ResourceTypes { get; set; }

        [JsonProperty("sections")]
        public List<Section> Sections { get; set; }

        [JsonProperty("import_list")]
        public List<ImportList> ImportList { get; set; }

        [JsonProperty("entry_point")]
        public long EntryPoint { get; set; }
    }

    public partial class ImportList
    {
        [JsonProperty("library_name")]
        public string LibraryName { get; set; }

        [JsonProperty("imported_functions")]
        public List<string> ImportedFunctions { get; set; }
    }

    public partial class ResourceDetail
    {
        [JsonProperty("lang")]
        public Lang Lang { get; set; }

        [JsonProperty("entropy")]
        public double Entropy { get; set; }

        [JsonProperty("chi2")]
        public double Chi2 { get; set; }

        [JsonProperty("filetype")]
        public Filetype Filetype { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ResourceLangs
    {
        [JsonProperty("NEUTRAL")]
        public long Neutral { get; set; }

        [JsonProperty("ENGLISH UK")]
        public long EnglishUk { get; set; }
    }

    public partial class ResourceTypes
    {
        [JsonProperty("RT_RCDATA")]
        public long RtRcdata { get; set; }

        [JsonProperty("RT_MANIFEST")]
        public long RtManifest { get; set; }

        [JsonProperty("RT_STRING")]
        public long RtString { get; set; }

        [JsonProperty("RT_MENU")]
        public long RtMenu { get; set; }

        [JsonProperty("RT_ICON")]
        public long RtIcon { get; set; }

        [JsonProperty("RT_BITMAP")]
        public long RtBitmap { get; set; }

        [JsonProperty("RT_VERSION")]
        public long RtVersion { get; set; }

        [JsonProperty("RT_GROUP_ICON")]
        public long RtGroupIcon { get; set; }
    }

    public partial class Section
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("chi2")]
        public double Chi2 { get; set; }

        [JsonProperty("virtual_address")]
        public long VirtualAddress { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }

        [JsonProperty("raw_size")]
        public long RawSize { get; set; }

        [JsonProperty("entropy")]
        public double Entropy { get; set; }

        [JsonProperty("virtual_size")]
        public long VirtualSize { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }
    }

    public partial class PopularThreatClassification
    {
        [JsonProperty("suggested_threat_label")]
        public string SuggestedThreatLabel { get; set; }

        [JsonProperty("popular_threat_category")]
        public List<PopularThreat> PopularThreatCategory { get; set; }

        [JsonProperty("popular_threat_name")]
        public List<PopularThreat> PopularThreatName { get; set; }
    }

    public partial class PopularThreat
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class SandboxVerdicts
    {
        [JsonProperty("Zenbox")]
        public Zenbox Zenbox { get; set; }

        [JsonProperty("NSFOCUS POMA")]
        public Lastline NsfocusPoma { get; set; }

        [JsonProperty("Lastline")]
        public Lastline Lastline { get; set; }
    }

    public partial class Lastline
    {

        [JsonProperty("sandbox_name")]
        public string SandboxName { get; set; }

        [JsonProperty("malware_classification")]
        public List<string> MalwareClassification { get; set; }
    }

    public partial class Zenbox
    {

        [JsonProperty("confidence")]
        public long Confidence { get; set; }

        [JsonProperty("sandbox_name")]
        public string SandboxName { get; set; }

        [JsonProperty("malware_classification")]
        public List<string> MalwareClassification { get; set; }

        [JsonProperty("malware_names")]
        public List<string> MalwareNames { get; set; }
    }

    public partial class SigmaAnalysisResult
    {
        [JsonProperty("rule_title")]
        public string RuleTitle { get; set; }

        [JsonProperty("rule_source")]
        public string RuleSource { get; set; }

        [JsonProperty("match_context")]
        public List<MatchContext> MatchContext { get; set; }

        [JsonProperty("rule_level")]
        public string RuleLevel { get; set; }

        [JsonProperty("rule_description")]
        public string RuleDescription { get; set; }

        [JsonProperty("rule_author")]
        public string RuleAuthor { get; set; }

        [JsonProperty("rule_id")]
        public string RuleId { get; set; }
    }

    public partial class MatchContext
    {
        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public partial class Values
    {
        [JsonProperty("TerminalSessionId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? TerminalSessionId { get; set; }

        [JsonProperty("ProcessGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessGuid { get; set; }

        [JsonProperty("ProcessId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ProcessId { get; set; }

        [JsonProperty("Product", NullValueHandling = NullValueHandling.Ignore)]
        public string Product { get; set; }

        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("Company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; set; }

        [JsonProperty("ParentProcessGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentProcessGuid { get; set; }

        [JsonProperty("User", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        [JsonProperty("Hashes", NullValueHandling = NullValueHandling.Ignore)]
        public string Hashes { get; set; }

        [JsonProperty("OriginalFileName", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalFileName { get; set; }

        [JsonProperty("ParentImage", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentImage { get; set; }

        [JsonProperty("FileVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string FileVersion { get; set; }

        [JsonProperty("ParentProcessId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ParentProcessId { get; set; }

        [JsonProperty("CurrentDirectory", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentDirectory { get; set; }

        [JsonProperty("CommandLine", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandLine { get; set; }

        [JsonProperty("EventID")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long EventId { get; set; }

        [JsonProperty("LogonGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string LogonGuid { get; set; }

        [JsonProperty("LogonId", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? LogonId { get; set; }

        [JsonProperty("Image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        [JsonProperty("IntegrityLevel", NullValueHandling = NullValueHandling.Ignore)]
        public string IntegrityLevel { get; set; }

        [JsonProperty("ParentCommandLine", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentCommandLine { get; set; }

        [JsonProperty("UtcTime", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? UtcTime { get; set; }

        [JsonProperty("RuleName", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        [JsonProperty("param1", NullValueHandling = NullValueHandling.Ignore)]
        public string Param1 { get; set; }
    }

    public partial class SigmaAnalysisStats
    {
        [JsonProperty("high")]
        public long High { get; set; }

        [JsonProperty("medium")]
        public long Medium { get; set; }

        [JsonProperty("critical")]
        public long Critical { get; set; }

        [JsonProperty("low")]
        public long Low { get; set; }
    }

    public partial class SigmaAnalysisSummary
    {
        [JsonProperty("Sigma Integrated Rule Set (GitHub)")]
        public SigmaAnalysisStats SigmaIntegratedRuleSetGitHub { get; set; }

        [JsonProperty("SOC Prime Threat Detection Marketplace")]
        public SigmaAnalysisStats SocPrimeThreatDetectionMarketplace { get; set; }
    }

    public partial class TotalVotes
    {
        [JsonProperty("harmless")]
        public long Harmless { get; set; }

        [JsonProperty("malicious")]
        public long Malicious { get; set; }
    }

    public partial class Trid
    {
        [JsonProperty("file_type")]
        public string FileType { get; set; }

        [JsonProperty("probability")]
        public double Probability { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }
    }


    public enum Method { Blacklist };

    public enum Filetype { Ico, Unknown };

    public enum Lang { EnglishUk, Neutral };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                MethodConverter.Singleton,
                FiletypeConverter.Singleton,
                LangConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
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

    internal class FiletypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Filetype) || t == typeof(Filetype?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ICO":
                    return Filetype.Ico;
                case "unknown":
                    return Filetype.Unknown;
            }
            throw new Exception("Cannot unmarshal type Filetype");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Filetype)untypedValue;
            switch (value)
            {
                case Filetype.Ico:
                    serializer.Serialize(writer, "ICO");
                    return;
                case Filetype.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type Filetype");
        }

        public static readonly FiletypeConverter Singleton = new FiletypeConverter();
    }

    internal class LangConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Lang) || t == typeof(Lang?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ENGLISH UK":
                    return Lang.EnglishUk;
                case "NEUTRAL":
                    return Lang.Neutral;
            }
            throw new Exception("Cannot unmarshal type Lang");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Lang)untypedValue;
            switch (value)
            {
                case Lang.EnglishUk:
                    serializer.Serialize(writer, "ENGLISH UK");
                    return;
                case Lang.Neutral:
                    serializer.Serialize(writer, "NEUTRAL");
                    return;
            }
            throw new Exception("Cannot marshal type Lang");
        }

        public static readonly LangConverter Singleton = new LangConverter();
    }
}
