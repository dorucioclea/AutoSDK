﻿//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks.Read => "read",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks.Read,
                "write" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks.Write,
                _ => null,
            };
        }
    }
}