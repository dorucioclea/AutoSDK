﻿//HintName: G.Models.ChatCompletionResponseDeltaChoice.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseDeltaChoice
    {
        /// <summary>
        /// Always zero in streamed responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// - **The first message** in the stream will be an object set to `{"role":"assistant"}`.<br/>
        /// - **Subsequent messages** will have an object `{"content": __token__}` with the generated token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ChatStreamingFirstDelta, global::G.ChatStreamingContentDelta> Delta { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::G.Logprobs? Logprobs { get; set; }

        /// <summary>
        /// One of the following string values:<br/>
        ///   - `null`: All messages but the last will return null for `finish_reason`.<br/>
        ///   - `stop`: The response ended naturally as a complete answer (due to<br/>
        ///     [end-of-sequence token](https://huggingface.co/docs/transformers/v4.32.1/en/llm_tutorial#generate-text))<br/>
        ///      or because the model generated a stop sequence provided in the request.<br/>
        ///   - `length`:  The response ended by reaching `max_tokens`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseDeltaChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// Always zero in streamed responses.
        /// </param>
        /// <param name="delta">
        /// - **The first message** in the stream will be an object set to `{"role":"assistant"}`.<br/>
        /// - **Subsequent messages** will have an object `{"content": __token__}` with the generated token.
        /// </param>
        /// <param name="logprobs"></param>
        /// <param name="finishReason">
        /// One of the following string values:<br/>
        ///   - `null`: All messages but the last will return null for `finish_reason`.<br/>
        ///   - `stop`: The response ended naturally as a complete answer (due to<br/>
        ///     [end-of-sequence token](https://huggingface.co/docs/transformers/v4.32.1/en/llm_tutorial#generate-text))<br/>
        ///      or because the model generated a stop sequence provided in the request.<br/>
        ///   - `length`:  The response ended by reaching `max_tokens`.
        /// </param>
        public ChatCompletionResponseDeltaChoice(
            int index,
            global::G.AnyOf<global::G.ChatStreamingFirstDelta, global::G.ChatStreamingContentDelta> delta,
            global::G.Logprobs? logprobs,
            string? finishReason)
        {
            this.Index = index;
            this.Delta = delta;
            this.Logprobs = logprobs;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseDeltaChoice" /> class.
        /// </summary>
        public ChatCompletionResponseDeltaChoice()
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
        public static global::G.ChatCompletionResponseDeltaChoice? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ChatCompletionResponseDeltaChoice>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ChatCompletionResponseDeltaChoice?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ChatCompletionResponseDeltaChoice?>(serializer.Deserialize<global::G.ChatCompletionResponseDeltaChoice>(jsonReader));
        }

    }
}