﻿//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewEditedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewEditedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestAssigneeType2.Organization,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}