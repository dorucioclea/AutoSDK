﻿//HintName: G.Models.WebhookPullRequestSynchronizePullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestSynchronizePullRequestAssigneesType
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
    public static class WebhookPullRequestSynchronizePullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestSynchronizePullRequestAssigneesType.User => "User",
                WebhookPullRequestSynchronizePullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestSynchronizePullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestSynchronizePullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestSynchronizePullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestSynchronizePullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestSynchronizePullRequestAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}