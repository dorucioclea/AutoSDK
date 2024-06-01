﻿//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestState.Open => "open",
                WebhookPullRequestReviewThreadUnresolvedPullRequestState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadUnresolvedPullRequestState.Open,
                "closed" => WebhookPullRequestReviewThreadUnresolvedPullRequestState.Closed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}