﻿//HintName: G.Models.MigrationsStartForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MigrationsStartForOrgRequest
    {
        /// <summary>
        /// A list of arrays indicating which repositories should be migrated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Repositories { get; set; }

        /// <summary>
        /// Indicates whether repositories should be locked (to prevent manipulation) while migrating data.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_repositories")]
        public bool? LockRepositories { get; set; }

        /// <summary>
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_metadata")]
        public bool? ExcludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_git_data")]
        public bool? ExcludeGitData { get; set; }

        /// <summary>
        /// Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_attachments")]
        public bool? ExcludeAttachments { get; set; }

        /// <summary>
        /// Indicates whether releases should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_releases")]
        public bool? ExcludeReleases { get; set; }

        /// <summary>
        /// Indicates whether projects owned by the organization or users should be excluded. from the migration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_owner_projects")]
        public bool? ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_metadata_only")]
        public bool? OrgMetadataOnly { get; set; }

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsStartForOrgRequest" /> class.
        /// </summary>
        /// <param name="repositories">
        /// A list of arrays indicating which repositories should be migrated.
        /// </param>
        /// <param name="lockRepositories">
        /// Indicates whether repositories should be locked (to prevent manipulation) while migrating data.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata">
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeGitData">
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeAttachments">
        /// Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeReleases">
        /// Indicates whether releases should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeOwnerProjects">
        /// Indicates whether projects owned by the organization or users should be excluded. from the migration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="orgMetadataOnly">
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// Exclude related items from being returned in the response in order to improve performance of the request.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MigrationsStartForOrgRequest(
            global::System.Collections.Generic.IList<string> repositories,
            bool? lockRepositories,
            bool? excludeMetadata,
            bool? excludeGitData,
            bool? excludeAttachments,
            bool? excludeReleases,
            bool? excludeOwnerProjects,
            bool? orgMetadataOnly,
            global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>? exclude)
        {
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.LockRepositories = lockRepositories;
            this.ExcludeMetadata = excludeMetadata;
            this.ExcludeGitData = excludeGitData;
            this.ExcludeAttachments = excludeAttachments;
            this.ExcludeReleases = excludeReleases;
            this.ExcludeOwnerProjects = excludeOwnerProjects;
            this.OrgMetadataOnly = orgMetadataOnly;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsStartForOrgRequest" /> class.
        /// </summary>
        public MigrationsStartForOrgRequest()
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
        public static global::G.MigrationsStartForOrgRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.MigrationsStartForOrgRequest),
                jsonSerializerContext) as global::G.MigrationsStartForOrgRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MigrationsStartForOrgRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.MigrationsStartForOrgRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.MigrationsStartForOrgRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.MigrationsStartForOrgRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.MigrationsStartForOrgRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.MigrationsStartForOrgRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.MigrationsStartForOrgRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}