﻿//HintName: G.Models.ChatCompletionStreamResponseDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A chat completion delta generated by streamed model responses.
    /// </summary>
    public sealed partial class ChatCompletionStreamResponseDelta
    {
        /// <summary>
        /// The contents of the chunk message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        public ChatCompletionStreamResponseDeltaFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<ChatCompletionMessageToolCallChunk?>? ToolCalls { get; set; }

        /// <summary>
        /// The role of the author of this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}