﻿//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedThread.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewThreadUnresolvedThread
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment> Comments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedThread" /> class.
        /// </summary>
        /// <param name="comments"></param>
        /// <param name="nodeId"></param>
        public WebhookPullRequestReviewThreadUnresolvedThread(
            global::System.Collections.Generic.IList<global::G.WebhookPullRequestReviewThreadUnresolvedThreadComment> comments,
            string nodeId)
        {
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestReviewThreadUnresolvedThread" /> class.
        /// </summary>
        public WebhookPullRequestReviewThreadUnresolvedThread()
        {
        }
    }
}