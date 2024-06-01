﻿//HintName: G.Models.SearchReposOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchReposOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchReposOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchReposOrder value)
        {
            return value switch
            {
                SearchReposOrder.Desc => "desc",
                SearchReposOrder.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchReposOrder ToEnum(string value)
        {
            return value switch
            {
                "desc" => SearchReposOrder.Desc,
                "asc" => SearchReposOrder.Asc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}