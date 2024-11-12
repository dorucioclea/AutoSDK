﻿//HintName: G.Models.MessageContentTextAnnotationsFilePathObjectFilePath.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentTextAnnotationsFilePathObjectFilePath
    {
        /// <summary>
        /// The ID of the file that was generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFilePathObjectFilePath" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file that was generated.
        /// </param>
        public MessageContentTextAnnotationsFilePathObjectFilePath(
            string fileId)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFilePathObjectFilePath" /> class.
        /// </summary>
        public MessageContentTextAnnotationsFilePathObjectFilePath()
        {
        }
    }
}