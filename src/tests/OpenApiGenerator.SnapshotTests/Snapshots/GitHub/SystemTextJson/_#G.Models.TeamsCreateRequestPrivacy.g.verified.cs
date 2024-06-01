﻿//HintName: G.Models.TeamsCreateRequestPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of privacy this team should have. The options are:  
    /// **For a non-nested team:**  
    ///  * `secret` - only visible to organization owners and members of this team.  
    ///  * `closed` - visible to all members of this organization.  
    /// Default: `secret`  
    /// **For a parent or child team:**  
    ///  * `closed` - visible to all members of this organization.  
    /// Default for child team: `closed`
    /// </summary>
    public enum TeamsCreateRequestPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Secret,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsCreateRequestPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsCreateRequestPrivacy value)
        {
            return value switch
            {
                TeamsCreateRequestPrivacy.Secret => "secret",
                TeamsCreateRequestPrivacy.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsCreateRequestPrivacy ToEnum(string value)
        {
            return value switch
            {
                "secret" => TeamsCreateRequestPrivacy.Secret,
                "closed" => TeamsCreateRequestPrivacy.Closed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}