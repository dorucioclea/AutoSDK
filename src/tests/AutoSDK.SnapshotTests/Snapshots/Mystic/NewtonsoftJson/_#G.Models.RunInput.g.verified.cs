﻿//HintName: G.Models.RunInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class RunInput
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunIOType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_path")]
        public string? FilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunInput" /> class.
        /// </summary>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="value"></param>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <param name="fileUrl"></param>
        public RunInput(
            global::G.RunIOType type,
            object? value,
            string? fileName,
            string? filePath,
            string? fileUrl)
        {
            this.Type = type;
            this.Value = value;
            this.FileName = fileName;
            this.FilePath = filePath;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunInput" /> class.
        /// </summary>
        public RunInput()
        {
        }
    }
}