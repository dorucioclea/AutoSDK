﻿//HintName: G.Models.WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments
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
    public static class WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments.Read => "read",
                WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments.Read,
                "write" => WebhookIssuesDemilestonedIssuePerformedViaGithubAppPermissionsDeployments.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}