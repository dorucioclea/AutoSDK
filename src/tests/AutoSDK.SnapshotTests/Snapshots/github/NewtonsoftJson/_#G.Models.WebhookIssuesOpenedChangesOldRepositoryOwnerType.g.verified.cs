﻿//HintName: G.Models.WebhookIssuesOpenedChangesOldRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldRepositoryOwnerType
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
    public static class WebhookIssuesOpenedChangesOldRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldRepositoryOwnerType.Bot => "Bot",
                WebhookIssuesOpenedChangesOldRepositoryOwnerType.User => "User",
                WebhookIssuesOpenedChangesOldRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldRepositoryOwnerType.Bot,
                "User" => WebhookIssuesOpenedChangesOldRepositoryOwnerType.User,
                "Organization" => WebhookIssuesOpenedChangesOldRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}