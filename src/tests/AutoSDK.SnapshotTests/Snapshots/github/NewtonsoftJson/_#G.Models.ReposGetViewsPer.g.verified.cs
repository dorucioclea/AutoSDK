﻿//HintName: G.Models.ReposGetViewsPer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: day
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposGetViewsPer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="day")]
        Day,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="week")]
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposGetViewsPerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposGetViewsPer value)
        {
            return value switch
            {
                ReposGetViewsPer.Day => "day",
                ReposGetViewsPer.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposGetViewsPer? ToEnum(string value)
        {
            return value switch
            {
                "day" => ReposGetViewsPer.Day,
                "week" => ReposGetViewsPer.Week,
                _ => null,
            };
        }
    }
}