﻿//HintName: G.Models.CommitComparison.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commit Comparison
    /// </summary>
    public sealed partial class CommitComparison
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/compare/master...topic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/octocat:bbcd538c8e72b8c175046e27cc8f907076331401...octocat:0328041d1152db8ae77652d1618a02e57f745f17
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PermalinkUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.diff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiffUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat/Hello-World/compare/master...topic.patch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PatchUrl { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Commit BaseCommit { get; set; }

        /// <summary>
        /// Commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_base_commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Commit MergeBaseCommit { get; set; }

        /// <summary>
        /// Example: ahead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CommitComparisonStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CommitComparisonStatus Status { get; set; }

        /// <summary>
        /// Example: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ahead_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AheadBy { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behind_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BehindBy { get; set; }

        /// <summary>
        /// Example: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCommits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Commit> Commits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::G.DiffEntry>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.CommitComparison? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CommitComparison),
                jsonSerializerContext) as global::G.CommitComparison;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CommitComparison? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CommitComparison>(
                json,
                jsonSerializerOptions);
        }

    }
}