﻿//HintName: G.Models.WebhooksPullRequest5LinksHtml.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhooksPullRequest5LinksHtml
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
        /// Initializes a new instance of the <see cref="WebhooksPullRequest5LinksHtml" /> class.
        /// </summary>
        /// <param name="href"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksPullRequest5LinksHtml(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPullRequest5LinksHtml" /> class.
        /// </summary>
        public WebhooksPullRequest5LinksHtml()
        {
        }
    }
}