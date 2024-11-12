﻿//HintName: G.Models.WebhookDiscussionCommentEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDiscussionCommentEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookDiscussionCommentEditedChangesBody Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionCommentEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        public WebhookDiscussionCommentEditedChanges(
            global::G.WebhookDiscussionCommentEditedChangesBody body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionCommentEditedChanges" /> class.
        /// </summary>
        public WebhookDiscussionCommentEditedChanges()
        {
        }
    }
}