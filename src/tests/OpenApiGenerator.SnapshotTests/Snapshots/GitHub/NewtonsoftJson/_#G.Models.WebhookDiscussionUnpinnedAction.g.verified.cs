﻿//HintName: G.Models.WebhookDiscussionUnpinnedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDiscussionUnpinnedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unpinned")]
        Unpinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionUnpinnedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionUnpinnedAction value)
        {
            return value switch
            {
                WebhookDiscussionUnpinnedAction.Unpinned => "unpinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionUnpinnedAction ToEnum(string value)
        {
            return value switch
            {
                "unpinned" => WebhookDiscussionUnpinnedAction.Unpinned,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}