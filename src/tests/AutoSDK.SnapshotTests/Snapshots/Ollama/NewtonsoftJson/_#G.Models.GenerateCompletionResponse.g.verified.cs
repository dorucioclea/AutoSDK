﻿//HintName: G.Models.GenerateCompletionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response class for the generate endpoint.
    /// </summary>
    public sealed partial class GenerateCompletionResponse
    {
        /// <summary>
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Date on which a model was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The response for a given prompt with a provided model.<br/>
        /// Example: The sky appears blue because of a phenomenon called Rayleigh scattering.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public string? Response { get; set; }

        /// <summary>
        /// Whether the response has completed.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("done")]
        public bool? Done { get; set; }

        /// <summary>
        /// An encoding of the conversation used in this response, this can be sent in the next request to keep a conversational memory.<br/>
        /// Example: [1L, 2L, 3L]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public global::System.Collections.Generic.IList<long>? Context { get; set; }

        /// <summary>
        /// Time spent generating the response.<br/>
        /// Example: 5589157167L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_duration")]
        public long? TotalDuration { get; set; }

        /// <summary>
        /// Time spent in nanoseconds loading the model.<br/>
        /// Example: 3013701500L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("load_duration")]
        public long? LoadDuration { get; set; }

        /// <summary>
        /// Number of tokens in the prompt.<br/>
        /// Example: 46
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_eval_count")]
        public int? PromptEvalCount { get; set; }

        /// <summary>
        /// Time spent in nanoseconds evaluating the prompt.<br/>
        /// Example: 1160282000L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_eval_duration")]
        public long? PromptEvalDuration { get; set; }

        /// <summary>
        /// Number of tokens the response.<br/>
        /// Example: 113
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_count")]
        public int? EvalCount { get; set; }

        /// <summary>
        /// Time in nanoseconds spent generating the response.<br/>
        /// Example: 1325948000L
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("eval_duration")]
        public long? EvalDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateCompletionResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model name. <br/>
        /// Model names follow a `model:tag` format. Some examples are `orca-mini:3b-q4_1` and `llama3:70b`. The tag is optional and, if not provided, will default to `latest`. The tag is used to identify a specific version.<br/>
        /// Example: llama3.2
        /// </param>
        /// <param name="createdAt">
        /// Date on which a model was created.
        /// </param>
        /// <param name="response">
        /// The response for a given prompt with a provided model.<br/>
        /// Example: The sky appears blue because of a phenomenon called Rayleigh scattering.
        /// </param>
        /// <param name="done">
        /// Whether the response has completed.<br/>
        /// Example: true
        /// </param>
        /// <param name="context">
        /// An encoding of the conversation used in this response, this can be sent in the next request to keep a conversational memory.<br/>
        /// Example: [1L, 2L, 3L]
        /// </param>
        /// <param name="totalDuration">
        /// Time spent generating the response.<br/>
        /// Example: 5589157167L
        /// </param>
        /// <param name="loadDuration">
        /// Time spent in nanoseconds loading the model.<br/>
        /// Example: 3013701500L
        /// </param>
        /// <param name="promptEvalCount">
        /// Number of tokens in the prompt.<br/>
        /// Example: 46
        /// </param>
        /// <param name="promptEvalDuration">
        /// Time spent in nanoseconds evaluating the prompt.<br/>
        /// Example: 1160282000L
        /// </param>
        /// <param name="evalCount">
        /// Number of tokens the response.<br/>
        /// Example: 113
        /// </param>
        /// <param name="evalDuration">
        /// Time in nanoseconds spent generating the response.<br/>
        /// Example: 1325948000L
        /// </param>
        public GenerateCompletionResponse(
            string? model,
            global::System.DateTime? createdAt,
            string? response,
            bool? done,
            global::System.Collections.Generic.IList<long>? context,
            long? totalDuration,
            long? loadDuration,
            int? promptEvalCount,
            long? promptEvalDuration,
            int? evalCount,
            long? evalDuration)
        {
            this.Model = model;
            this.CreatedAt = createdAt;
            this.Response = response;
            this.Done = done;
            this.Context = context;
            this.TotalDuration = totalDuration;
            this.LoadDuration = loadDuration;
            this.PromptEvalCount = promptEvalCount;
            this.PromptEvalDuration = promptEvalDuration;
            this.EvalCount = evalCount;
            this.EvalDuration = evalDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateCompletionResponse" /> class.
        /// </summary>
        public GenerateCompletionResponse()
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
        public static global::G.GenerateCompletionResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GenerateCompletionResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.GenerateCompletionResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.GenerateCompletionResponse?>(serializer.Deserialize<global::G.GenerateCompletionResponse>(jsonReader));
        }

    }
}