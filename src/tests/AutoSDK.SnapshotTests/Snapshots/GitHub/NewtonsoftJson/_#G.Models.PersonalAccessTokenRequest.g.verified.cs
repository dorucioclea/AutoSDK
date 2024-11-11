﻿//HintName: G.Models.PersonalAccessTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of a Personal Access Token Request.
    /// </summary>
    public sealed partial class PersonalAccessTokenRequest
    {
        /// <summary>
        /// Unique identifier of the request for access via fine-grained personal access token. Used as the `pat_request_id` parameter in the list and review API calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Owner { get; set; } = default!;

        /// <summary>
        /// New requested permissions, categorized by type of permission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions_added", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PersonalAccessTokenRequestPermissionsAdded PermissionsAdded { get; set; } = default!;

        /// <summary>
        /// Requested permissions that elevate access for a previously approved request for access, categorized by type of permission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions_upgraded", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PersonalAccessTokenRequestPermissionsUpgraded PermissionsUpgraded { get; set; } = default!;

        /// <summary>
        /// Permissions requested, categorized by type of permission. This field incorporates `permissions_added` and `permissions_upgraded`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions_result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PersonalAccessTokenRequestPermissionsResult PermissionsResult { get; set; } = default!;

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_selection", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PersonalAccessTokenRequestRepositorySelection RepositorySelection { get; set; } = default!;

        /// <summary>
        /// The number of repositories the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RepositoryCount { get; set; } = default!;

        /// <summary>
        /// An array of repository objects the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PersonalAccessTokenRequestRepositorie>? Repositories { get; set; } = default!;

        /// <summary>
        /// Date and time when the request for access was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Whether the associated fine-grained personal access token has expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_expired", Required = global::Newtonsoft.Json.Required.Always)]
        public bool TokenExpired { get; set; } = default!;

        /// <summary>
        /// Date and time when the associated fine-grained personal access token expires.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TokenExpiresAt { get; set; } = default!;

        /// <summary>
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_last_used_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TokenLastUsedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAccessTokenRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the request for access via fine-grained personal access token. Used as the `pat_request_id` parameter in the list and review API calls.
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="permissionsAdded">
        /// New requested permissions, categorized by type of permission.
        /// </param>
        /// <param name="permissionsUpgraded">
        /// Requested permissions that elevate access for a previously approved request for access, categorized by type of permission.
        /// </param>
        /// <param name="permissionsResult">
        /// Permissions requested, categorized by type of permission. This field incorporates `permissions_added` and `permissions_upgraded`.
        /// </param>
        /// <param name="repositorySelection">
        /// Type of repository selection requested.
        /// </param>
        /// <param name="repositoryCount">
        /// The number of repositories the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </param>
        /// <param name="repositories">
        /// An array of repository objects the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </param>
        /// <param name="createdAt">
        /// Date and time when the request for access was created.
        /// </param>
        /// <param name="tokenExpired">
        /// Whether the associated fine-grained personal access token has expired.
        /// </param>
        /// <param name="tokenExpiresAt">
        /// Date and time when the associated fine-grained personal access token expires.
        /// </param>
        /// <param name="tokenLastUsedAt">
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </param>
        public PersonalAccessTokenRequest(
            int id,
            global::G.SimpleUser owner,
            global::G.PersonalAccessTokenRequestPermissionsAdded permissionsAdded,
            global::G.PersonalAccessTokenRequestPermissionsUpgraded permissionsUpgraded,
            global::G.PersonalAccessTokenRequestPermissionsResult permissionsResult,
            global::G.PersonalAccessTokenRequestRepositorySelection repositorySelection,
            int? repositoryCount,
            global::System.Collections.Generic.IList<global::G.PersonalAccessTokenRequestRepositorie>? repositories,
            string createdAt,
            bool tokenExpired,
            string? tokenExpiresAt,
            string? tokenLastUsedAt)
        {
            this.Id = id;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.PermissionsAdded = permissionsAdded ?? throw new global::System.ArgumentNullException(nameof(permissionsAdded));
            this.PermissionsUpgraded = permissionsUpgraded ?? throw new global::System.ArgumentNullException(nameof(permissionsUpgraded));
            this.PermissionsResult = permissionsResult ?? throw new global::System.ArgumentNullException(nameof(permissionsResult));
            this.RepositorySelection = repositorySelection;
            this.RepositoryCount = repositoryCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.TokenExpired = tokenExpired;
            this.TokenExpiresAt = tokenExpiresAt ?? throw new global::System.ArgumentNullException(nameof(tokenExpiresAt));
            this.TokenLastUsedAt = tokenLastUsedAt ?? throw new global::System.ArgumentNullException(nameof(tokenLastUsedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAccessTokenRequest" /> class.
        /// </summary>
        public PersonalAccessTokenRequest()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PersonalAccessTokenRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PersonalAccessTokenRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PersonalAccessTokenRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PersonalAccessTokenRequest?>(serializer.Deserialize<global::G.PersonalAccessTokenRequest>(jsonReader));
        }

    }
}