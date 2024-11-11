﻿//HintName: G.Models.ToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the model should use the provided tools. The model can use a specific tool, <br/>
    /// any available tool, or decide by itself.<br/>
    /// - `auto`: allows Claude to decide whether to call any provided tools or not. This is the default value.<br/>
    /// - `any`: tells Claude that it must use one of the provided tools, but doesn’t force a particular tool.<br/>
    /// - `tool`: allows us to force Claude to always use a particular tool specified in the `name` field.
    /// </summary>
    public sealed partial class ToolChoice
    {
        /// <summary>
        /// How the model should use the provided tools. The model can use a specific tool, <br/>
        /// any available tool, or decide by itself.<br/>
        /// - `auto`: allows Claude to decide whether to call any provided tools or not. This is the default value.<br/>
        /// - `any`: tells Claude that it must use one of the provided tools, but doesn't force a particular tool.<br/>
        /// - `tool`: allows us to force Claude to always use a particular tool specified in the `name` field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ToolChoiceType Type { get; set; } = default!;

        /// <summary>
        /// The name of the tool to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether to disable parallel tool use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_parallel_tool_use")]
        public bool? DisableParallelToolUse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice" /> class.
        /// </summary>
        /// <param name="type">
        /// How the model should use the provided tools. The model can use a specific tool, <br/>
        /// any available tool, or decide by itself.<br/>
        /// - `auto`: allows Claude to decide whether to call any provided tools or not. This is the default value.<br/>
        /// - `any`: tells Claude that it must use one of the provided tools, but doesn't force a particular tool.<br/>
        /// - `tool`: allows us to force Claude to always use a particular tool specified in the `name` field.
        /// </param>
        /// <param name="name">
        /// The name of the tool to use.
        /// </param>
        /// <param name="disableParallelToolUse">
        /// Whether to disable parallel tool use.
        /// </param>
        public ToolChoice(
            global::G.ToolChoiceType type,
            string? name,
            bool? disableParallelToolUse)
        {
            this.Type = type;
            this.Name = name;
            this.DisableParallelToolUse = disableParallelToolUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice" /> class.
        /// </summary>
        public ToolChoice()
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
        public static global::G.ToolChoice? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ToolChoice>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ToolChoice?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ToolChoice?>(serializer.Deserialize<global::G.ToolChoice>(jsonReader));
        }

    }
}