﻿//HintName: G.Models.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments
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
    public static class WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments value)
        {
            return value switch
            {
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments.Read => "read",
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments.Read,
                "write" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}