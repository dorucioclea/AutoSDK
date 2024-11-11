﻿//HintName: G.Models.GetVariationByIdResponseGeneratedImageVariationGenericItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generated_image_variation_generic"
    /// </summary>
    public sealed partial class GetVariationByIdResponseGeneratedImageVariationGenericItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStatusJsonConverter))]
        public global::G.JobStatus? Status { get; set; }

        /// <summary>
        /// The type of variation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transformType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VARIATIONTYPEJsonConverter))]
        public global::G.VARIATIONTYPE? TransformType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariationByIdResponseGeneratedImageVariationGenericItem" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        /// <param name="transformType">
        /// The type of variation.
        /// </param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetVariationByIdResponseGeneratedImageVariationGenericItem(
            string? createdAt,
            string? id,
            global::G.JobStatus? status,
            global::G.VARIATIONTYPE? transformType,
            string? url)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Status = status;
            this.TransformType = transformType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVariationByIdResponseGeneratedImageVariationGenericItem" /> class.
        /// </summary>
        public GetVariationByIdResponseGeneratedImageVariationGenericItem()
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
        public static global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem),
                jsonSerializerContext) as global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.GetVariationByIdResponseGeneratedImageVariationGenericItem?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}