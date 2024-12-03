﻿//HintName: G.Models.IssuesListDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListDirection value)
        {
            return value switch
            {
                IssuesListDirection.Asc => "asc",
                IssuesListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => IssuesListDirection.Asc,
                "desc" => IssuesListDirection.Desc,
                _ => null,
            };
        }
    }
}