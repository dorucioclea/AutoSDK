﻿//HintName: G.Models.GetGenerationsByUserIdResponseGenerationGenerationElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This table captures the elements that are applied to a Generations, also the order and weightings used when applied.
    /// </summary>
    public sealed partial class GetGenerationsByUserIdResponseGenerationGenerationElement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Element used for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora")]
        public global::G.GetGenerationsByUserIdResponseGenerationGenerationElementLora? Lora { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weightApplied")]
        public double? WeightApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGenerationElement" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lora">
        /// Element used for the generation.
        /// </param>
        /// <param name="weightApplied"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetGenerationsByUserIdResponseGenerationGenerationElement(
            int? id,
            global::G.GetGenerationsByUserIdResponseGenerationGenerationElementLora? lora,
            double? weightApplied)
        {
            this.Id = id;
            this.Lora = lora;
            this.WeightApplied = weightApplied;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGenerationGenerationElement" /> class.
        /// </summary>
        public GetGenerationsByUserIdResponseGenerationGenerationElement()
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
        public static global::G.GetGenerationsByUserIdResponseGenerationGenerationElement? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GetGenerationsByUserIdResponseGenerationGenerationElement),
                jsonSerializerContext) as global::G.GetGenerationsByUserIdResponseGenerationGenerationElement;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetGenerationsByUserIdResponseGenerationGenerationElement? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetGenerationsByUserIdResponseGenerationGenerationElement>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.GetGenerationsByUserIdResponseGenerationGenerationElement?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.GetGenerationsByUserIdResponseGenerationGenerationElement),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.GetGenerationsByUserIdResponseGenerationGenerationElement;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GetGenerationsByUserIdResponseGenerationGenerationElement?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.GetGenerationsByUserIdResponseGenerationGenerationElement?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}