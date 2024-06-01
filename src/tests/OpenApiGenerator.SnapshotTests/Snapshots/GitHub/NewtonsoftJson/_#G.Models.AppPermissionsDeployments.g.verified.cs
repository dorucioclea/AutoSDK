﻿//HintName: G.Models.AppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for deployments and deployment statuses.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsDeployments
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
    public static class AppPermissionsDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsDeployments value)
        {
            return value switch
            {
                AppPermissionsDeployments.Read => "read",
                AppPermissionsDeployments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsDeployments ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsDeployments.Read,
                "write" => AppPermissionsDeployments.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}