﻿//HintName: G.Models.GenerateCompletionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request class for the generate endpoint.
    /// </summary>
    public sealed partial class GenerateCompletionRequest
    {
        /// <summary>
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The prompt to generate a response.<br/>
        /// Example: Why is the sky blue?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The text that comes after the inserted text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// (optional) a list of Base64-encoded images to include in the message (for multimodal models such as llava)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// The system prompt to (overrides what is defined in the Modelfile).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system")]
        public string? System { get; set; }

        /// <summary>
        /// The full prompt or prompt template (overrides what is defined in the Modelfile).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public string? Template { get; set; }

        /// <summary>
        /// The context parameter returned from a previous request to [generateCompletion], this can be used to keep a short conversational memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::System.Collections.Generic.IList<long>? Context { get; set; }

        /// <summary>
        /// Additional model parameters listed in the documentation for the Modelfile such as `temperature`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.RequestOptions? Options { get; set; }

        /// <summary>
        /// The format to return a response in. Currently the only accepted value is json.<br/>
        /// Enable JSON mode by setting the format parameter to json. This will structure the response as valid JSON.<br/>
        /// Note: it's important to instruct the model to use JSON in the prompt. Otherwise, the model may generate large amounts whitespace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.ResponseFormat? Format { get; set; }

        /// <summary>
        /// If `true` no formatting will be applied to the prompt and no context will be returned. <br/>
        /// You may choose to use the `raw` parameter if you are specifying a full templated prompt in your request to the API, and are managing history yourself.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw")]
        public bool? Raw { get; set; }

        /// <summary>
        /// If `false` the response will be returned as a single response object, otherwise the response will be streamed as a series of objects.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; } = true;

        /// <summary>
        /// How long (in minutes) to keep the model loaded in memory.<br/>
        /// - If set to a positive duration (e.g. 20), the model will stay loaded for the provided duration.<br/>
        /// - If set to a negative duration (e.g. -1), the model will stay loaded indefinitely.<br/>
        /// - If set to 0, the model will be unloaded immediately once finished.<br/>
        /// - If not set, the model will stay loaded for 5 minutes by default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keep_alive")]
        public int? KeepAlive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GenerateCompletionRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GenerateCompletionRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}