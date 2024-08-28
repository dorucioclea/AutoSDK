﻿//HintName: G.Models.ToolMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of an individual message.<br/>
    /// - `user`:  Input provided by the user. Any instructions given here that conflict<br/>
    ///   with instructions given in the `system` prompt take precedence over the `system`<br/>
    ///   prompt instructions.<br/>
    /// - `assistant`:  Response generated by the model.<br/>
    /// - `system`:  Initial instructions provided to the system to provide general guidance<br/>
    ///   on the tone and voice of the generated message. An initial system message is<br/>
    ///   optional but recommended to provide guidance on the tone of the chat. For<br/>
    ///   example, "You are a helpful chatbot with a background in earth sciences and a<br/>
    ///   charming French accent."<br/>
    /// Default Value: tool
    /// </summary>
    public enum ToolMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageRole value)
        {
            return value switch
            {
                ToolMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ToolMessageRole.Tool,
                _ => null,
            };
        }
    }
}