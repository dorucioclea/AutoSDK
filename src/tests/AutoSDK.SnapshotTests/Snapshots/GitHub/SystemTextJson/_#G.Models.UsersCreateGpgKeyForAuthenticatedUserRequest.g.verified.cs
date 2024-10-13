﻿//HintName: G.Models.UsersCreateGpgKeyForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersCreateGpgKeyForAuthenticatedUserRequest
    {
        /// <summary>
        /// A descriptive name for the new key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A GPG key in ASCII-armored format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("armored_public_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArmoredPublicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

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

        public static global::G.UsersCreateGpgKeyForAuthenticatedUserRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.UsersCreateGpgKeyForAuthenticatedUserRequest),
                jsonSerializerContext) as global::G.UsersCreateGpgKeyForAuthenticatedUserRequest;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UsersCreateGpgKeyForAuthenticatedUserRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.UsersCreateGpgKeyForAuthenticatedUserRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}