﻿//HintName: G.Models.PullRequestReviewLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestReviewLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestReviewLinksHtml Html { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestReviewLinksPullRequest PullRequest { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewLinks" /> class.
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pullRequest"></param>
        public PullRequestReviewLinks(
            global::G.PullRequestReviewLinksHtml html,
            global::G.PullRequestReviewLinksPullRequest pullRequest)
        {
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewLinks" /> class.
        /// </summary>
        public PullRequestReviewLinks()
        {
        }
    }
}