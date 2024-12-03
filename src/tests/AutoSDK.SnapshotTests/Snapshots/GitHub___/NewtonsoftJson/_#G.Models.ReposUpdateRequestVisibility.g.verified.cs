﻿//HintName: G.Models.ReposUpdateRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposUpdateRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposUpdateRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposUpdateRequestVisibility value)
        {
            return value switch
            {
                ReposUpdateRequestVisibility.Public => "public",
                ReposUpdateRequestVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposUpdateRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => ReposUpdateRequestVisibility.Public,
                "private" => ReposUpdateRequestVisibility.Private,
                _ => null,
            };
        }
    }
}