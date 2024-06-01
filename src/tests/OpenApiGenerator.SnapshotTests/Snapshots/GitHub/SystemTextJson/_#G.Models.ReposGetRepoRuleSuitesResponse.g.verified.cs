﻿//HintName: G.Models.ReposGetRepoRuleSuitesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposGetRepoRuleSuitesResponse
    {
        /// <summary>
        /// The unique identifier of the rule insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The number that identifies the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        public int ActorId { get; set; }

        /// <summary>
        /// The handle for the GitHub user account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_name")]
        public string? ActorName { get; set; }

        /// <summary>
        /// The first commit sha before the push evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_sha")]
        public string? BeforeSha { get; set; }

        /// <summary>
        /// The last commit sha in the push evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_sha")]
        public string? AfterSha { get; set; }

        /// <summary>
        /// The ref name that the evaluation ran on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The ID of the repository associated with the rule evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        public int RepositoryId { get; set; }

        /// <summary>
        /// The name of the repository without the `.git` extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_name")]
        public string? RepositoryName { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        public global::System.DateTime PushedAt { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` enforcement status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposGetRepoRuleSuitesResponseResultJsonConverter))]
        public ReposGetRepoRuleSuitesResponseResult? Result { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposGetRepoRuleSuitesResponseEvaluationResultJsonConverter))]
        public ReposGetRepoRuleSuitesResponseEvaluationResult? EvaluationResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}