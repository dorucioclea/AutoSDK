﻿//HintName: G.Models.WebhooksPullRequest5MergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5MergedByType
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
    public static class WebhooksPullRequest5MergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5MergedByType value)
        {
            return value switch
            {
                WebhooksPullRequest5MergedByType.Bot => "Bot",
                WebhooksPullRequest5MergedByType.User => "User",
                WebhooksPullRequest5MergedByType.Organization => "Organization",
                WebhooksPullRequest5MergedByType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5MergedByType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5MergedByType.Bot,
                "User" => WebhooksPullRequest5MergedByType.User,
                "Organization" => WebhooksPullRequest5MergedByType.Organization,
                "Mannequin" => WebhooksPullRequest5MergedByType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}