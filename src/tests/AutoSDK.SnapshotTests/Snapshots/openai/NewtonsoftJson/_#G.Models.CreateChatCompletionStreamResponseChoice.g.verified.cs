﻿//HintName: G.Models.CreateChatCompletionStreamResponseChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionStreamResponseChoice
    {
        /// <summary>
        /// A chat completion delta generated by streamed model responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionStreamResponseDelta Delta { get; set; } = default!;

        /// <summary>
        /// Log probability information for the choice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::G.CreateChatCompletionStreamResponseChoiceLogprobs? Logprobs { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// `content_filter` if content was omitted due to a flag from our content filters,<br/>
        /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChatCompletionStreamResponseChoiceFinishReason? FinishReason { get; set; } = default!;

        /// <summary>
        /// The index of the choice in the list of choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        /// <param name="delta">
        /// A chat completion delta generated by streamed model responses.
        /// </param>
        /// <param name="logprobs">
        /// Log probability information for the choice.
        /// </param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,<br/>
        /// `length` if the maximum number of tokens specified in the request was reached,<br/>
        /// `content_filter` if content was omitted due to a flag from our content filters,<br/>
        /// `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
        /// </param>
        /// <param name="index">
        /// The index of the choice in the list of choices.
        /// </param>
        public CreateChatCompletionStreamResponseChoice(
            global::G.ChatCompletionStreamResponseDelta delta,
            global::G.CreateChatCompletionStreamResponseChoiceFinishReason? finishReason,
            int index,
            global::G.CreateChatCompletionStreamResponseChoiceLogprobs? logprobs)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
            this.Index = index;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionStreamResponseChoice" /> class.
        /// </summary>
        public CreateChatCompletionStreamResponseChoice()
        {
        }
    }
}