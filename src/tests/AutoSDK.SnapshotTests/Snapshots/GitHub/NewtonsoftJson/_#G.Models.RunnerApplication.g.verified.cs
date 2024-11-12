﻿//HintName: G.Models.RunnerApplication.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Runner Application
    /// </summary>
    public sealed partial class RunnerApplication
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("os", Required = global::Newtonsoft.Json.Required.Always)]
        public string Os { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("architecture", Required = global::Newtonsoft.Json.Required.Always)]
        public string Architecture { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// A short lived bearer token used to download the runner, if needed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temp_download_token")]
        public string? TempDownloadToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha256_checksum")]
        public string? Sha256Checksum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerApplication" /> class.
        /// </summary>
        /// <param name="os"></param>
        /// <param name="architecture"></param>
        /// <param name="downloadUrl"></param>
        /// <param name="filename"></param>
        /// <param name="tempDownloadToken">
        /// A short lived bearer token used to download the runner, if needed.
        /// </param>
        /// <param name="sha256Checksum"></param>
        public RunnerApplication(
            string os,
            string architecture,
            string downloadUrl,
            string filename,
            string? tempDownloadToken,
            string? sha256Checksum)
        {
            this.Os = os ?? throw new global::System.ArgumentNullException(nameof(os));
            this.Architecture = architecture ?? throw new global::System.ArgumentNullException(nameof(architecture));
            this.DownloadUrl = downloadUrl ?? throw new global::System.ArgumentNullException(nameof(downloadUrl));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.TempDownloadToken = tempDownloadToken;
            this.Sha256Checksum = sha256Checksum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerApplication" /> class.
        /// </summary>
        public RunnerApplication()
        {
        }
    }
}