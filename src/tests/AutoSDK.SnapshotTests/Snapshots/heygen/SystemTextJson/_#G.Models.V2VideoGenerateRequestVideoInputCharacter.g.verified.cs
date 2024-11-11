﻿//HintName: G.Models.V2VideoGenerateRequestVideoInputCharacter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestVideoInputCharacter
    {
        /// <summary>
        /// Example: Kristin_public_3_20240108
        /// </summary>
        /// <example>Kristin_public_3_20240108</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        public string? AvatarId { get; set; }

        /// <summary>
        /// Example: normal
        /// </summary>
        /// <example>normal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_style")]
        public string? AvatarStyle { get; set; }

        /// <summary>
        /// Example: avatar
        /// </summary>
        /// <example>avatar</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInputCharacter" /> class.
        /// </summary>
        /// <param name="avatarId">
        /// Example: Kristin_public_3_20240108
        /// </param>
        /// <param name="avatarStyle">
        /// Example: normal
        /// </param>
        /// <param name="type">
        /// Example: avatar
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public V2VideoGenerateRequestVideoInputCharacter(
            string? avatarId,
            string? avatarStyle,
            string? type)
        {
            this.AvatarId = avatarId;
            this.AvatarStyle = avatarStyle;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInputCharacter" /> class.
        /// </summary>
        public V2VideoGenerateRequestVideoInputCharacter()
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
        public static global::G.V2VideoGenerateRequestVideoInputCharacter? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.V2VideoGenerateRequestVideoInputCharacter),
                jsonSerializerContext) as global::G.V2VideoGenerateRequestVideoInputCharacter;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.V2VideoGenerateRequestVideoInputCharacter? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.V2VideoGenerateRequestVideoInputCharacter>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.V2VideoGenerateRequestVideoInputCharacter?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.V2VideoGenerateRequestVideoInputCharacter),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.V2VideoGenerateRequestVideoInputCharacter;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.V2VideoGenerateRequestVideoInputCharacter?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.V2VideoGenerateRequestVideoInputCharacter?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}