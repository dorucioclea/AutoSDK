﻿//HintName: G.Models.ReposCreateOrUpdateFileContentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateFileContentsRequest
    {
        /// <summary>
        /// The commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The new file content, using Base64 encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// **Required if you are updating a file**. The blob SHA of the file being replaced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The branch name. Default: the repository’s default branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// The person that committed the file. Default: the authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        public ReposCreateOrUpdateFileContentsRequestCommitter? Committer { get; set; }

        /// <summary>
        /// The author of the file. Default: The `committer` or the authenticated user if you omit `committer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public ReposCreateOrUpdateFileContentsRequestAuthor? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}