﻿//HintName: G.Models.AppPermissionsMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for organization teams and members.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsMembers
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
    public static class AppPermissionsMembersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsMembers value)
        {
            return value switch
            {
                AppPermissionsMembers.Read => "read",
                AppPermissionsMembers.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsMembers ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsMembers.Read,
                "write" => AppPermissionsMembers.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}