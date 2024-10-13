﻿//HintName: G.Models.BaseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The base model used for fine-tuning.
    /// </summary>
    public sealed partial class BaseModel
    {
        /// <summary>
        /// The name of the base model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// read-only. The version of the base model.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The possible types of fine-tuned models.<br/>
        ///  - BASE_TYPE_UNSPECIFIED: Unspecified model.<br/>
        ///  - BASE_TYPE_GENERATIVE: Deprecated: Generative model.<br/>
        ///  - BASE_TYPE_CLASSIFICATION: Classification model.<br/>
        ///  - BASE_TYPE_RERANK: Rerank model.<br/>
        ///  - BASE_TYPE_CHAT: Chat model.<br/>
        /// Default Value: BASE_TYPE_UNSPECIFIED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BaseType BaseType { get; set; } = default!;

        /// <summary>
        /// The possible strategy used to serve a fine-tuned models.<br/>
        ///  - STRATEGY_UNSPECIFIED: Unspecified strategy.<br/>
        ///  - STRATEGY_VANILLA: Deprecated: Serve the fine-tuned model on a dedicated GPU.<br/>
        ///  - STRATEGY_TFEW: Serve the fine-tuned model on a shared GPU.<br/>
        /// Default Value: STRATEGY_UNSPECIFIED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy")]
        public global::G.Strategy? Strategy { get; set; } = global::G.Strategy.UNSPECIFIED;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
    #if NET6_0_OR_GREATER
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
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.BaseModel? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BaseModel>(
                json,
                jsonSerializerOptions);
        }

    }
}