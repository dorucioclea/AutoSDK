﻿//HintName: G.Models.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        /// <param name="newName">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost" /> class.
        /// </summary>
        public BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost()
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
        public static global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost),
                jsonSerializerContext) as global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.BodyAddSharingVoiceV1VoicesAddPublicUserIdVoiceIdPost?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}