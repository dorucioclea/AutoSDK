﻿//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestBaseRepoOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}