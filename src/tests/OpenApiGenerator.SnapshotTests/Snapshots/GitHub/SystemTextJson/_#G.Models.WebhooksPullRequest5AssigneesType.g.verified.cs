﻿//HintName: G.Models.WebhooksPullRequest5AssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5AssigneesType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPullRequest5AssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5AssigneesType value)
        {
            return value switch
            {
                WebhooksPullRequest5AssigneesType.Bot => "Bot",
                WebhooksPullRequest5AssigneesType.User => "User",
                WebhooksPullRequest5AssigneesType.Organization => "Organization",
                WebhooksPullRequest5AssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5AssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5AssigneesType.Bot,
                "User" => WebhooksPullRequest5AssigneesType.User,
                "Organization" => WebhooksPullRequest5AssigneesType.Organization,
                "Mannequin" => WebhooksPullRequest5AssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}