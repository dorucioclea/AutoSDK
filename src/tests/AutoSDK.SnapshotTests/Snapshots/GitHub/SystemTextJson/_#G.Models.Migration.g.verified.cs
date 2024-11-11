﻿//HintName: G.Models.Migration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A migration.
    /// </summary>
    public sealed partial class Migration
    {
        /// <summary>
        /// Example: 79L
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Owner { get; set; }

        /// <summary>
        /// Example: 0b989ba4-242f-11e5-81e1-c7b6966d2516
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Guid { get; set; }

        /// <summary>
        /// Example: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool LockRepositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_git_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeGitData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_releases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeReleases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_owner_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExcludeOwnerProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_metadata_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OrgMetadataOnly { get; set; }

        /// <summary>
        /// The repositories included in the migration. Only returned for export migrations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Repository> Repositories { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/octo-org/migrations/79
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_url")]
        public string? ArchiveUrl { get; set; }

        /// <summary>
        /// Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `"repositories"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Migration" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 79L
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="guid">
        /// Example: 0b989ba4-242f-11e5-81e1-c7b6966d2516
        /// </param>
        /// <param name="state">
        /// Example: pending
        /// </param>
        /// <param name="lockRepositories">
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata"></param>
        /// <param name="excludeGitData"></param>
        /// <param name="excludeAttachments"></param>
        /// <param name="excludeReleases"></param>
        /// <param name="excludeOwnerProjects"></param>
        /// <param name="orgMetadataOnly"></param>
        /// <param name="repositories">
        /// The repositories included in the migration. Only returned for export migrations.
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/octo-org/migrations/79
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="nodeId"></param>
        /// <param name="archiveUrl"></param>
        /// <param name="exclude">
        /// Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `"repositories"`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Migration(
            long id,
            global::G.NullableSimpleUser? owner,
            string guid,
            string state,
            bool lockRepositories,
            bool excludeMetadata,
            bool excludeGitData,
            bool excludeAttachments,
            bool excludeReleases,
            bool excludeOwnerProjects,
            bool orgMetadataOnly,
            global::System.Collections.Generic.IList<global::G.Repository> repositories,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string nodeId,
            string? archiveUrl,
            global::System.Collections.Generic.IList<string>? exclude)
        {
            this.Id = id;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Guid = guid ?? throw new global::System.ArgumentNullException(nameof(guid));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.LockRepositories = lockRepositories;
            this.ExcludeMetadata = excludeMetadata;
            this.ExcludeGitData = excludeGitData;
            this.ExcludeAttachments = excludeAttachments;
            this.ExcludeReleases = excludeReleases;
            this.ExcludeOwnerProjects = excludeOwnerProjects;
            this.OrgMetadataOnly = orgMetadataOnly;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ArchiveUrl = archiveUrl;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Migration" /> class.
        /// </summary>
        public Migration()
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
        public static global::G.Migration? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Migration),
                jsonSerializerContext) as global::G.Migration;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Migration? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Migration>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Migration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Migration),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Migration;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Migration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Migration?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}