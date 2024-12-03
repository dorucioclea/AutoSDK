﻿//HintName: G.Models.WebhookIssuesMilestonedIssueActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesMilestonedIssueActiveLockReason
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
    public static class WebhookIssuesMilestonedIssueActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueActiveLockReason value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueActiveLockReason.Resolved => "resolved",
                WebhookIssuesMilestonedIssueActiveLockReason.OffTopic => "off-topic",
                WebhookIssuesMilestonedIssueActiveLockReason.TooHeated => "too heated",
                WebhookIssuesMilestonedIssueActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueActiveLockReason? ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookIssuesMilestonedIssueActiveLockReason.Resolved,
                "off-topic" => WebhookIssuesMilestonedIssueActiveLockReason.OffTopic,
                "too heated" => WebhookIssuesMilestonedIssueActiveLockReason.TooHeated,
                "spam" => WebhookIssuesMilestonedIssueActiveLockReason.Spam,
                _ => null,
            };
        }
    }
}