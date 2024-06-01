﻿//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}