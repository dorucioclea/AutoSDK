﻿//HintName: G.Models.WebhooksIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssueMilestoneCreatorType
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
    public static class WebhooksIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhooksIssueMilestoneCreatorType.Bot => "Bot",
                WebhooksIssueMilestoneCreatorType.User => "User",
                WebhooksIssueMilestoneCreatorType.Organization => "Organization",
                WebhooksIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueMilestoneCreatorType.Bot,
                "User" => WebhooksIssueMilestoneCreatorType.User,
                "Organization" => WebhooksIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhooksIssueMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}