﻿//HintName: G.Models.WebhookPullRequestReviewThreadResolvedThreadCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedThreadCommentUserType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedThreadCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedThreadCommentUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedThreadCommentUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewThreadResolvedThreadCommentUserType.Mannequin,
                _ => null,
            };
        }
    }
}