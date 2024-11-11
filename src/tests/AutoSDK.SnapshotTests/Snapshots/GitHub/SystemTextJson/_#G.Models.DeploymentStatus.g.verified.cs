﻿//HintName: G.Models.DeploymentStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of a deployment.
    /// </summary>
    public sealed partial class DeploymentStatus
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example/deployments/42/statuses/1
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example/deployments/42/statuses/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDE2OkRlcGxveW1lbnRTdGF0dXMx
        /// </summary>
        /// <example>MDE2OkRlcGxveW1lbnRTdGF0dXMx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The state of the status.<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeploymentStatusStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeploymentStatusState State { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Creator { get; set; }

        /// <summary>
        /// A short description of the status.<br/>
        /// Example: Deployment finished successfully.
        /// </summary>
        /// <example>Deployment finished successfully.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The environment of the deployment that the status is for.<br/>
        /// Example: production
        /// </summary>
        /// <example>production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Deprecated: the URL to associate with this status.<br/>
        /// Example: https://example.com/deployment/42/output
        /// </summary>
        /// <example>https://example.com/deployment/42/output</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example/deployments/42
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example/deployments/42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/octocat/example
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/example</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoryUrl { get; set; }

        /// <summary>
        /// The URL for accessing your environment.<br/>
        /// Example: https://staging.example.com/
        /// </summary>
        /// <example>https://staging.example.com/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_url")]
        public string? EnvironmentUrl { get; set; }

        /// <summary>
        /// The URL to associate with this status.<br/>
        /// Example: https://example.com/deployment/42/output
        /// </summary>
        /// <example>https://example.com/deployment/42/output</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_url")]
        public string? LogUrl { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public global::G.NullableIntegration? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentStatus" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/example/deployments/42/statuses/1
        /// </param>
        /// <param name="id">
        /// Example: 1L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDE2OkRlcGxveW1lbnRTdGF0dXMx
        /// </param>
        /// <param name="state">
        /// The state of the status.<br/>
        /// Example: success
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="description">
        /// A short description of the status.<br/>
        /// Example: Deployment finished successfully.
        /// </param>
        /// <param name="environment">
        /// The environment of the deployment that the status is for.<br/>
        /// Example: production
        /// </param>
        /// <param name="targetUrl">
        /// Deprecated: the URL to associate with this status.<br/>
        /// Example: https://example.com/deployment/42/output
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="deploymentUrl">
        /// Example: https://api.github.com/repos/octocat/example/deployments/42
        /// </param>
        /// <param name="repositoryUrl">
        /// Example: https://api.github.com/repos/octocat/example
        /// </param>
        /// <param name="environmentUrl">
        /// The URL for accessing your environment.<br/>
        /// Example: https://staging.example.com/
        /// </param>
        /// <param name="logUrl">
        /// The URL to associate with this status.<br/>
        /// Example: https://example.com/deployment/42/output
        /// </param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeploymentStatus(
            string url,
            long id,
            string nodeId,
            global::G.DeploymentStatusState state,
            global::G.NullableSimpleUser? creator,
            string description,
            string targetUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string deploymentUrl,
            string repositoryUrl,
            string? environment,
            string? environmentUrl,
            string? logUrl,
            global::G.NullableIntegration? performedViaGithubApp)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.State = state;
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.TargetUrl = targetUrl ?? throw new global::System.ArgumentNullException(nameof(targetUrl));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeploymentUrl = deploymentUrl ?? throw new global::System.ArgumentNullException(nameof(deploymentUrl));
            this.RepositoryUrl = repositoryUrl ?? throw new global::System.ArgumentNullException(nameof(repositoryUrl));
            this.Environment = environment;
            this.EnvironmentUrl = environmentUrl;
            this.LogUrl = logUrl;
            this.PerformedViaGithubApp = performedViaGithubApp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentStatus" /> class.
        /// </summary>
        public DeploymentStatus()
        {
        }


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
#if NET8_0_OR_GREATER
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
        public static global::G.DeploymentStatus? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DeploymentStatus),
                jsonSerializerContext) as global::G.DeploymentStatus;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DeploymentStatus? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DeploymentStatus>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DeploymentStatus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DeploymentStatus),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DeploymentStatus;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DeploymentStatus?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DeploymentStatus?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}