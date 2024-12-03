﻿//HintName: G.Models.PullRequestReviewCommentLinksPullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestReviewCommentLinksPullRequest
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/pulls/1</example>
        [global::Newtonsoft.Json.JsonProperty("href", Required = global::Newtonsoft.Json.Required.Always)]
        public string Href { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinksPullRequest" /> class.
        /// </summary>
        /// <param name="href">
        /// Example: https://api.github.com/repos/octocat/Hello-World/pulls/1
        /// </param>
        public PullRequestReviewCommentLinksPullRequest(
            string href)
        {
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewCommentLinksPullRequest" /> class.
        /// </summary>
        public PullRequestReviewCommentLinksPullRequest()
        {
        }
    }
}