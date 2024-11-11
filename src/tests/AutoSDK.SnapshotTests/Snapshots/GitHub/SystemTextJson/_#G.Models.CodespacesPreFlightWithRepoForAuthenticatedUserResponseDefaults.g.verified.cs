﻿//HintName: G.Models.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devcontainer_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DevcontainerPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="devcontainerPath"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults(
            string location,
            string? devcontainerPath)
        {
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.DevcontainerPath = devcontainerPath ?? throw new global::System.ArgumentNullException(nameof(devcontainerPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults" /> class.
        /// </summary>
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults()
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
        public static global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults),
                jsonSerializerContext) as global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}