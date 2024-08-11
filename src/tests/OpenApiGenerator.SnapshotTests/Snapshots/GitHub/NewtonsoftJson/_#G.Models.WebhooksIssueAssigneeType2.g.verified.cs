﻿//HintName: G.Models.WebhooksIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksIssueAssigneeType2
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
    public static class WebhooksIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhooksIssueAssigneeType2.Bot => "Bot",
                WebhooksIssueAssigneeType2.User => "User",
                WebhooksIssueAssigneeType2.Organization => "Organization",
                WebhooksIssueAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueAssigneeType2.Bot,
                "User" => WebhooksIssueAssigneeType2.User,
                "Organization" => WebhooksIssueAssigneeType2.Organization,
                "Mannequin" => WebhooksIssueAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}