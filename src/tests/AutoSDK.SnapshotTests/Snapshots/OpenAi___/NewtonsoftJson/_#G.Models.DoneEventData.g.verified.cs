﻿//HintName: G.Models.DoneEventData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DoneEventData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="[DONE]")]
        DONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DoneEventDataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DoneEventData value)
        {
            return value switch
            {
                DoneEventData.DONE => "[DONE]",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DoneEventData? ToEnum(string value)
        {
            return value switch
            {
                "[DONE]" => DoneEventData.DONE,
                _ => null,
            };
        }
    }
}