﻿//HintName: G.Models.Upload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Upload object can accept byte chunks in the form of Parts.
    /// </summary>
    public sealed partial class Upload
    {
        /// <summary>
        /// The Upload unique identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the file to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The intended number of bytes to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The intended purpose of the file. [Please refer here](/docs/api-reference/files/object#files/object-purpose) for acceptable values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose", Required = global::Newtonsoft.Json.Required.Always)]
        public string Purpose { get; set; } = default!;

        /// <summary>
        /// The status of the Upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UploadStatus Status { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "upload".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UploadObject? Object { get; set; }

        /// <summary>
        /// The `File` object represents a document that has been uploaded to OpenAI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public global::G.OpenAIFile? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}