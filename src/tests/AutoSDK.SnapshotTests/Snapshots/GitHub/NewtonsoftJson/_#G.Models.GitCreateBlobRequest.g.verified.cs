﻿//HintName: G.Models.GitCreateBlobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitCreateBlobRequest
    {
        /// <summary>
        /// The new blob's content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The encoding used for `content`. Currently, `"utf-8"` and `"base64"` are supported.<br/>
        /// Default Value: utf-8
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding")]
        public string? Encoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateBlobRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The new blob's content.
        /// </param>
        /// <param name="encoding">
        /// The encoding used for `content`. Currently, `"utf-8"` and `"base64"` are supported.<br/>
        /// Default Value: utf-8
        /// </param>
        public GitCreateBlobRequest(
            string content,
            string? encoding)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Encoding = encoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateBlobRequest" /> class.
        /// </summary>
        public GitCreateBlobRequest()
        {
        }
    }
}