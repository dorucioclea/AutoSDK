﻿//HintName: G.Models.ProcessModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that is currently loaded.
    /// </summary>
    public sealed partial class ProcessModel
    {
        /// <summary>
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Size of the model on disk.<br/>
        /// Example: 7323310500L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public long? Size { get; set; }

        /// <summary>
        /// The model's digest.<br/>
        /// Example: sha256:bc07c81de745696fdf5afca05e065818a8149fb0c77266fb584d9b2cba3711a
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// Details about a model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.ModelDetails? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Size of the model on disk.<br/>
        /// Example: 7323310500L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_vram")]
        public long? SizeVram { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}