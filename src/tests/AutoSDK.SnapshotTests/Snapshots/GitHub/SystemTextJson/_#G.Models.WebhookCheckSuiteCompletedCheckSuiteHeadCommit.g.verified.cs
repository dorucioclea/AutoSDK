﻿//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteHeadCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCheckSuiteCompletedCheckSuiteHeadCommit
    {
        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCheckSuiteCompletedCheckSuiteHeadCommitAuthor Author { get; set; }

        /// <summary>
        /// Metaproperties for Git author/committer information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookCheckSuiteCompletedCheckSuiteHeadCommitCommitter Committer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TreeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuiteHeadCommit" /> class.
        /// </summary>
        /// <param name="author">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="committer">
        /// Metaproperties for Git author/committer information.
        /// </param>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        /// <param name="treeId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCheckSuiteCompletedCheckSuiteHeadCommit(
            global::G.WebhookCheckSuiteCompletedCheckSuiteHeadCommitAuthor author,
            global::G.WebhookCheckSuiteCompletedCheckSuiteHeadCommitCommitter committer,
            string id,
            string message,
            string timestamp,
            string treeId)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Committer = committer ?? throw new global::System.ArgumentNullException(nameof(committer));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.TreeId = treeId ?? throw new global::System.ArgumentNullException(nameof(treeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuiteHeadCommit" /> class.
        /// </summary>
        public WebhookCheckSuiteCompletedCheckSuiteHeadCommit()
        {
        }
    }
}