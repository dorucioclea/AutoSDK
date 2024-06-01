﻿//HintName: G.Models.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys.Read => "read",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys.Read,
                "write" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsKeys.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}