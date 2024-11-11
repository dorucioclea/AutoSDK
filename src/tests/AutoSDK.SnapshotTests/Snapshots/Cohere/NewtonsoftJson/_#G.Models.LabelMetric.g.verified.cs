﻿//HintName: G.Models.LabelMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabelMetric
    {
        /// <summary>
        /// Total number of examples for this label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_examples")]
        public double? TotalExamples { get; set; }

        /// <summary>
        /// value of the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// samples for this label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("samples")]
        public global::System.Collections.Generic.IList<string>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelMetric" /> class.
        /// </summary>
        /// <param name="totalExamples">
        /// Total number of examples for this label
        /// </param>
        /// <param name="label">
        /// value of the label
        /// </param>
        /// <param name="samples">
        /// samples for this label
        /// </param>
        public LabelMetric(
            double? totalExamples,
            string? label,
            global::System.Collections.Generic.IList<string>? samples)
        {
            this.TotalExamples = totalExamples;
            this.Label = label;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelMetric" /> class.
        /// </summary>
        public LabelMetric()
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
        public static global::G.LabelMetric? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LabelMetric>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.LabelMetric?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LabelMetric?>(serializer.Deserialize<global::G.LabelMetric>(jsonReader));
        }

    }
}