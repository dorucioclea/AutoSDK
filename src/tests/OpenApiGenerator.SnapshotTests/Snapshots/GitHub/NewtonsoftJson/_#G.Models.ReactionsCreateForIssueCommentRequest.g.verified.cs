﻿//HintName: G.Models.ReactionsCreateForIssueCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReactionsCreateForIssueCommentRequest
    {
        /// <summary>
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public ReactionsCreateForIssueCommentRequestContent Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}