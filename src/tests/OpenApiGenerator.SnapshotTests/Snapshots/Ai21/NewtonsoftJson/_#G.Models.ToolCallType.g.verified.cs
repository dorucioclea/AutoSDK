﻿//HintName: G.Models.ToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: function
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallType value)
        {
            return value switch
            {
                ToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolCallType.Function,
                _ => null,
            };
        }
    }
}