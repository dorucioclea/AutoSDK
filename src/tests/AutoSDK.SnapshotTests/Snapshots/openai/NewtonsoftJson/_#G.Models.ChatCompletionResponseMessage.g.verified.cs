﻿//HintName: G.Models.ChatCompletionResponseMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A chat completion message generated by the model.
    /// </summary>
    public sealed partial class ChatCompletionResponseMessage
    {
        /// <summary>
        /// The contents of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Content { get; set; } = default!;

        /// <summary>
        /// The refusal message generated by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Refusal { get; set; } = default!;

        /// <summary>
        /// The tool calls generated by the model, such as function calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// The role of the author of this message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionResponseMessageRole Role { get; set; }

        /// <summary>
        /// Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionResponseMessageFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// If the audio output modality is requested, this object contains data<br/>
        /// about the audio response from the model. [Learn more](/docs/guides/audio).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.ChatCompletionResponseMessageAudio? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the message.
        /// </param>
        /// <param name="refusal">
        /// The refusal message generated by the model.
        /// </param>
        /// <param name="toolCalls">
        /// The tool calls generated by the model, such as function calls.
        /// </param>
        /// <param name="role">
        /// The role of the author of this message.
        /// </param>
        /// <param name="audio">
        /// If the audio output modality is requested, this object contains data<br/>
        /// about the audio response from the model. [Learn more](/docs/guides/audio).
        /// </param>
        public ChatCompletionResponseMessage(
            string? content,
            string? refusal,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? toolCalls,
            global::G.ChatCompletionResponseMessageRole role,
            global::G.ChatCompletionResponseMessageAudio? audio)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.ToolCalls = toolCalls;
            this.Role = role;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseMessage" /> class.
        /// </summary>
        public ChatCompletionResponseMessage()
        {
        }
    }
}