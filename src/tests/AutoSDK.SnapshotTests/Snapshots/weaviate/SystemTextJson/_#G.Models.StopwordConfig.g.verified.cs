﻿//HintName: G.Models.StopwordConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// fine-grained control over stopword list usage
    /// </summary>
    public sealed partial class StopwordConfig
    {
        /// <summary>
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StopwordConfigPresetJsonConverter))]
        public global::G.StopwordConfigPreset? Preset { get; set; }

        /// <summary>
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additions")]
        public global::System.Collections.Generic.IList<string>? Additions { get; set; }

        /// <summary>
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removals")]
        public global::System.Collections.Generic.IList<string>? Removals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        /// <param name="preset">
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </param>
        /// <param name="additions">
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </param>
        /// <param name="removals">
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StopwordConfig(
            global::G.StopwordConfigPreset? preset,
            global::System.Collections.Generic.IList<string>? additions,
            global::System.Collections.Generic.IList<string>? removals)
        {
            this.Preset = preset;
            this.Additions = additions;
            this.Removals = removals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordConfig" /> class.
        /// </summary>
        public StopwordConfig()
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
        public static global::G.StopwordConfig? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.StopwordConfig),
                jsonSerializerContext) as global::G.StopwordConfig;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.StopwordConfig? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.StopwordConfig>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.StopwordConfig?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.StopwordConfig),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.StopwordConfig;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.StopwordConfig?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.StopwordConfig?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}