﻿//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy.Open => "open",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy.Open,
                "closed" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}