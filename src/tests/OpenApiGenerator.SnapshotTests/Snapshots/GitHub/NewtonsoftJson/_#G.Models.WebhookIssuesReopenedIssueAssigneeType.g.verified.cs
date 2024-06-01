﻿//HintName: G.Models.WebhookIssuesReopenedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssueAssigneeType
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
    public static class WebhookIssuesReopenedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesReopenedIssueAssigneeType.User => "User",
                WebhookIssuesReopenedIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueAssigneeType.Bot,
                "User" => WebhookIssuesReopenedIssueAssigneeType.User,
                "Organization" => WebhookIssuesReopenedIssueAssigneeType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}