﻿//HintName: G.Models.ReposCreatePagesDeploymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object used to create GitHub Pages deployment
    /// </summary>
    public sealed partial class ReposCreatePagesDeploymentRequest
    {
        /// <summary>
        /// The ID of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        public double? ArtifactId { get; set; }

        /// <summary>
        /// The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_url")]
        public string? ArtifactUrl { get; set; }

        /// <summary>
        /// The target environment for this GitHub Pages deployment.<br/>
        /// Default Value: github-pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// A unique string that represents the version of the build for this deployment.<br/>
        /// Default Value: GITHUB_SHA
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_build_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PagesBuildVersion { get; set; } = "GITHUB_SHA";

        /// <summary>
        /// The OIDC token issued by GitHub Actions certifying the origin of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oidc_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OidcToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesDeploymentRequest" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// The ID of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </param>
        /// <param name="artifactUrl">
        /// The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository. Either `artifact_id` or `artifact_url` are required.
        /// </param>
        /// <param name="environment">
        /// The target environment for this GitHub Pages deployment.<br/>
        /// Default Value: github-pages
        /// </param>
        /// <param name="pagesBuildVersion">
        /// A unique string that represents the version of the build for this deployment.<br/>
        /// Default Value: GITHUB_SHA
        /// </param>
        /// <param name="oidcToken">
        /// The OIDC token issued by GitHub Actions certifying the origin of the deployment.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposCreatePagesDeploymentRequest(
            string pagesBuildVersion,
            string oidcToken,
            double? artifactId,
            string? artifactUrl,
            string? environment)
        {
            this.PagesBuildVersion = pagesBuildVersion ?? throw new global::System.ArgumentNullException(nameof(pagesBuildVersion));
            this.OidcToken = oidcToken ?? throw new global::System.ArgumentNullException(nameof(oidcToken));
            this.ArtifactId = artifactId;
            this.ArtifactUrl = artifactUrl;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreatePagesDeploymentRequest" /> class.
        /// </summary>
        public ReposCreatePagesDeploymentRequest()
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
        public static global::G.ReposCreatePagesDeploymentRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ReposCreatePagesDeploymentRequest),
                jsonSerializerContext) as global::G.ReposCreatePagesDeploymentRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ReposCreatePagesDeploymentRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReposCreatePagesDeploymentRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ReposCreatePagesDeploymentRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ReposCreatePagesDeploymentRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ReposCreatePagesDeploymentRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ReposCreatePagesDeploymentRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ReposCreatePagesDeploymentRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}