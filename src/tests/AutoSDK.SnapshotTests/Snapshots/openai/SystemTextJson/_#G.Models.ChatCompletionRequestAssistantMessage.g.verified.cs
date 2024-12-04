﻿//HintName: G.Models.ChatCompletionRequestAssistantMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestAssistantMessage
    {
        /// <summary>
        /// The contents of the assistant message. Required unless `tool_calls` or `function_call` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestAssistantMessageContentPart>>))]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestAssistantMessageContentPart>>? Content { get; set; }

        /// <summary>
        /// The refusal message by the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// The role of the messages author, in this case `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionRequestAssistantMessageRoleJsonConverter))]
        public global::G.ChatCompletionRequestAssistantMessageRole Role { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Data about a previous audio response from the model. <br/>
        /// [Learn more](/docs/guides/audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.ChatCompletionRequestAssistantMessageAudio? Audio { get; set; }

        /// <summary>
        /// The tool calls generated by the model, such as function calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ChatCompletionRequestAssistantMessageFunctionCall? FunctionCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the assistant message. Required unless `tool_calls` or `function_call` is specified.
        /// </param>
        /// <param name="refusal">
        /// The refusal message by the assistant.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `assistant`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        /// <param name="audio">
        /// Data about a previous audio response from the model. <br/>
        /// [Learn more](/docs/guides/audio).
        /// </param>
        /// <param name="toolCalls">
        /// The tool calls generated by the model, such as function calls.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatCompletionRequestAssistantMessage(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestAssistantMessageContentPart>>? content,
            string? refusal,
            global::G.ChatCompletionRequestAssistantMessageRole role,
            string? name,
            global::G.ChatCompletionRequestAssistantMessageAudio? audio,
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageToolCall>? toolCalls)
        {
            this.Content = content;
            this.Refusal = refusal;
            this.Role = role;
            this.Name = name;
            this.Audio = audio;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestAssistantMessage" /> class.
        /// </summary>
        public ChatCompletionRequestAssistantMessage()
        {
        }
    }
}