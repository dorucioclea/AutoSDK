﻿//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking
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
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking.Read => "read",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking.Read,
                "write" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking.Write,
                _ => null,
            };
        }
    }
}