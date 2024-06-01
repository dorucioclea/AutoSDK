﻿//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Resolved => "resolved",
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.OffTopic => "off-topic",
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.TooHeated => "too heated",
                WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Spam => "spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason ToEnum(string value)
        {
            return value switch
            {
                "resolved" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Resolved,
                "off-topic" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.OffTopic,
                "too heated" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.TooHeated,
                "spam" => WebhookPullRequestReviewThreadResolvedPullRequestActiveLockReason.Spam,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}