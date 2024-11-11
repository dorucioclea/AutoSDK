﻿//HintName: G.Models.ModelDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about a model.
    /// </summary>
    public sealed partial class ModelDetails
    {
        /// <summary>
        /// The parent model of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_model")]
        public string? ParentModel { get; set; }

        /// <summary>
        /// The format of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// The family of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("family")]
        public string? Family { get; set; }

        /// <summary>
        /// The families of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("families")]
        public global::System.Collections.Generic.IList<string>? Families { get; set; }

        /// <summary>
        /// The size of the model's parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_size")]
        public string? ParameterSize { get; set; }

        /// <summary>
        /// The quantization level of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization_level")]
        public string? QuantizationLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDetails" /> class.
        /// </summary>
        /// <param name="parentModel">
        /// The parent model of the model.
        /// </param>
        /// <param name="format">
        /// The format of the model.
        /// </param>
        /// <param name="family">
        /// The family of the model.
        /// </param>
        /// <param name="families">
        /// The families of the model.
        /// </param>
        /// <param name="parameterSize">
        /// The size of the model's parameters.
        /// </param>
        /// <param name="quantizationLevel">
        /// The quantization level of the model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModelDetails(
            string? parentModel,
            string? format,
            string? family,
            global::System.Collections.Generic.IList<string>? families,
            string? parameterSize,
            string? quantizationLevel)
        {
            this.ParentModel = parentModel;
            this.Format = format;
            this.Family = family;
            this.Families = families;
            this.ParameterSize = parameterSize;
            this.QuantizationLevel = quantizationLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDetails" /> class.
        /// </summary>
        public ModelDetails()
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
        public static global::G.ModelDetails? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ModelDetails),
                jsonSerializerContext) as global::G.ModelDetails;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ModelDetails? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ModelDetails>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ModelDetails?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ModelDetails),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ModelDetails;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ModelDetails?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ModelDetails?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}