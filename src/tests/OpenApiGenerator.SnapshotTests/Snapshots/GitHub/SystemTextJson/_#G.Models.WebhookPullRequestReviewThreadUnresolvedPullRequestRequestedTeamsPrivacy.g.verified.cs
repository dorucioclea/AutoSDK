﻿//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestReviewThreadUnresolvedPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}