﻿//HintName: G.Models.UpdateDeploymentsResponseCurrentReleaseCreatedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type of the creator. Can be a user or an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateDeploymentsResponseCurrentReleaseCreatedByType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateDeploymentsResponseCurrentReleaseCreatedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDeploymentsResponseCurrentReleaseCreatedByType value)
        {
            return value switch
            {
                UpdateDeploymentsResponseCurrentReleaseCreatedByType.Organization => "organization",
                UpdateDeploymentsResponseCurrentReleaseCreatedByType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDeploymentsResponseCurrentReleaseCreatedByType ToEnum(string value)
        {
            return value switch
            {
                "organization" => UpdateDeploymentsResponseCurrentReleaseCreatedByType.Organization,
                "user" => UpdateDeploymentsResponseCurrentReleaseCreatedByType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}