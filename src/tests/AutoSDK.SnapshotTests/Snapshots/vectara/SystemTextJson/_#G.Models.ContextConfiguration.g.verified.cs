﻿//HintName: G.Models.ContextConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration on the presentation of each document part in the result set.
    /// </summary>
    public sealed partial class ContextConfiguration
    {
        /// <summary>
        /// The number of characters that are shown before the matching document part.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_before` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_before")]
        public int? CharactersBefore { get; set; }

        /// <summary>
        /// The number of characters that are shown after the matching document part. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_after` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters_after")]
        public int? CharactersAfter { get; set; }

        /// <summary>
        /// The number of sentences that are shown before the matching document part.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_before")]
        public int? SentencesBefore { get; set; }

        /// <summary>
        /// The number of sentences that are shown after the matching document part. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_after")]
        public int? SentencesAfter { get; set; }

        /// <summary>
        /// The tag that wraps the document part at the start. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_tag")]
        public string? StartTag { get; set; }

        /// <summary>
        /// The tag that wraps the document part at the end. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;/em&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_tag")]
        public string? EndTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextConfiguration" /> class.
        /// </summary>
        /// <param name="charactersBefore">
        /// The number of characters that are shown before the matching document part.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_before` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </param>
        /// <param name="charactersAfter">
        /// The number of characters that are shown after the matching document part. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Ignored if `sentences_after` is set.<br/>
        /// Vectara will capture the full sentence that contains the captured characters,<br/>
        /// to not lose the meaning caused by a truncated word or sentence.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </param>
        /// <param name="sentencesBefore">
        /// The number of sentences that are shown before the matching document part.<br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </param>
        /// <param name="sentencesAfter">
        /// The number of sentences that are shown after the matching document part. <br/>
        /// This is useful to show the context of the document part in the wider document.<br/>
        /// Default Value: 0<br/>
        /// Example: 3
        /// </param>
        /// <param name="startTag">
        /// The tag that wraps the document part at the start. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;em&gt;
        /// </param>
        /// <param name="endTag">
        /// The tag that wraps the document part at the end. This is often used to <br/>
        /// provide a start HTML/XML tag or some other delimiter you can use in an <br/>
        /// application to understand where to provide highlighting in your UI and <br/>
        /// understand where the context before ends and the document part begins.<br/>
        /// Example: &lt;/em&gt;
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ContextConfiguration(
            int? charactersBefore,
            int? charactersAfter,
            int? sentencesBefore,
            int? sentencesAfter,
            string? startTag,
            string? endTag)
        {
            this.CharactersBefore = charactersBefore;
            this.CharactersAfter = charactersAfter;
            this.SentencesBefore = sentencesBefore;
            this.SentencesAfter = sentencesAfter;
            this.StartTag = startTag;
            this.EndTag = endTag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextConfiguration" /> class.
        /// </summary>
        public ContextConfiguration()
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
        public static global::G.ContextConfiguration? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ContextConfiguration),
                jsonSerializerContext) as global::G.ContextConfiguration;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ContextConfiguration? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ContextConfiguration>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ContextConfiguration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ContextConfiguration),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ContextConfiguration;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ContextConfiguration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ContextConfiguration?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}