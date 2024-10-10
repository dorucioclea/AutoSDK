﻿//HintName: G.Models.SpeechHistoryItemResponseModelState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpeechHistoryItemResponseModelState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted")]
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechHistoryItemResponseModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechHistoryItemResponseModelState value)
        {
            return value switch
            {
                SpeechHistoryItemResponseModelState.Created => "created",
                SpeechHistoryItemResponseModelState.Deleted => "deleted",
                SpeechHistoryItemResponseModelState.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechHistoryItemResponseModelState? ToEnum(string value)
        {
            return value switch
            {
                "created" => SpeechHistoryItemResponseModelState.Created,
                "deleted" => SpeechHistoryItemResponseModelState.Deleted,
                "processing" => SpeechHistoryItemResponseModelState.Processing,
                _ => null,
            };
        }
    }
}