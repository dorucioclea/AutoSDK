﻿//HintName: G.Models.WebhookPullRequestUnassignedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestMergedByType
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
    public static class WebhookPullRequestUnassignedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestMergedByType.User => "User",
                WebhookPullRequestUnassignedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestMergedByType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestMergedByType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestMergedByType.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestMergedByType.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestMergedByType.Organization,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestMergedByType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}