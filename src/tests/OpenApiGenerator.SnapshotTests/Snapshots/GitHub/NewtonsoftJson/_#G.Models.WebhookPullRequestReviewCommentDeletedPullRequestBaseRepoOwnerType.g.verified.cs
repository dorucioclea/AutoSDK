﻿//HintName: G.Models.WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewCommentDeletedPullRequestBaseRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}