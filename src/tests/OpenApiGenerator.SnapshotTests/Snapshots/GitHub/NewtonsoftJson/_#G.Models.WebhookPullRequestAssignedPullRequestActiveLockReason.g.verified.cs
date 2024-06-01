﻿//HintName: G.Models.WebhookPullRequestAssignedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAssignedPullRequestActiveLockReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off-topic")]
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="too heated")]
        TooHeated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spam")]
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAssignedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestAssignedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestAssignedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestAssignedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestAssignedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestAssignedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestAssignedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestAssignedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}