﻿//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestHeadRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}