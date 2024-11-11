﻿//HintName: G.Models.CreateChatCompletionFunctionResponseChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionFunctionResponseChoice
    {
        /// <summary>
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, `content_filter` if content was omitted due to a flag from our content filters, or `function_call` if the model called a function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChatCompletionFunctionResponseChoiceFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// The index of the choice in the list of choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// A chat completion message generated by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionResponseMessage Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionFunctionResponseChoice" /> class.
        /// </summary>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, `content_filter` if content was omitted due to a flag from our content filters, or `function_call` if the model called a function.
        /// </param>
        /// <param name="index">
        /// The index of the choice in the list of choices.
        /// </param>
        /// <param name="message">
        /// A chat completion message generated by the model.
        /// </param>
        public CreateChatCompletionFunctionResponseChoice(
            global::G.CreateChatCompletionFunctionResponseChoiceFinishReason finishReason,
            int index,
            global::G.ChatCompletionResponseMessage message)
        {
            this.FinishReason = finishReason;
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionFunctionResponseChoice" /> class.
        /// </summary>
        public CreateChatCompletionFunctionResponseChoice()
        {
        }
    }
}