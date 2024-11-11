﻿//HintName: G.Models.WebhooksReviewLinksPullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksReviewLinksPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksReviewLinksPullRequest" /> class.
        /// </summary>
        /// <param name="href"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksReviewLinksPullRequest(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksReviewLinksPullRequest" /> class.
        /// </summary>
        public WebhooksReviewLinksPullRequest()
        {
        }
    }
}