﻿//HintName: G.Models.UploadDatasetImageFromGenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetImageFromGenResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadDatasetImageFromGen")]
        public global::G.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? UploadDatasetImageFromGen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageFromGenResponse" /> class.
        /// </summary>
        /// <param name="uploadDatasetImageFromGen"></param>
        public UploadDatasetImageFromGenResponse(
            global::G.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? uploadDatasetImageFromGen)
        {
            this.UploadDatasetImageFromGen = uploadDatasetImageFromGen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageFromGenResponse" /> class.
        /// </summary>
        public UploadDatasetImageFromGenResponse()
        {
        }
    }
}