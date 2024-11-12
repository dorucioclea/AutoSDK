﻿//HintName: G.Models.WebhookStatusCommitCommit.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommitCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.WebhookStatusCommitCommitAuthorVariant1, global::G.WebhookStatusCommitCommitAuthorVariant2> Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CommentCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.WebhookStatusCommitCommitCommitterVariant1, global::G.WebhookStatusCommitCommitCommitterVariant2> Committer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookStatusCommitCommitTree Tree { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookStatusCommitCommitVerification Verification { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="commentCount"></param>
        /// <param name="committer"></param>
        /// <param name="message"></param>
        /// <param name="tree"></param>
        /// <param name="url"></param>
        /// <param name="verification"></param>
        public WebhookStatusCommitCommit(
            global::G.AllOf<global::G.WebhookStatusCommitCommitAuthorVariant1, global::G.WebhookStatusCommitCommitAuthorVariant2> author,
            int commentCount,
            global::G.AllOf<global::G.WebhookStatusCommitCommitCommitterVariant1, global::G.WebhookStatusCommitCommitCommitterVariant2> committer,
            string message,
            global::G.WebhookStatusCommitCommitTree tree,
            string url,
            global::G.WebhookStatusCommitCommitVerification verification)
        {
            this.Author = author;
            this.CommentCount = commentCount;
            this.Committer = committer;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Verification = verification ?? throw new global::System.ArgumentNullException(nameof(verification));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        public WebhookStatusCommitCommit()
        {
        }
    }
}