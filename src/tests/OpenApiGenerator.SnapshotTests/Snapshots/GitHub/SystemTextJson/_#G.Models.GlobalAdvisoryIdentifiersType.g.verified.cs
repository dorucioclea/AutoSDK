﻿//HintName: G.Models.GlobalAdvisoryIdentifiersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of identifier.
    /// </summary>
    public enum GlobalAdvisoryIdentifiersType
    {
        /// <summary>
        /// 
        /// </summary>
        CVE,
        /// <summary>
        /// 
        /// </summary>
        GHSA,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlobalAdvisoryIdentifiersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalAdvisoryIdentifiersType value)
        {
            return value switch
            {
                GlobalAdvisoryIdentifiersType.CVE => "CVE",
                GlobalAdvisoryIdentifiersType.GHSA => "GHSA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalAdvisoryIdentifiersType ToEnum(string value)
        {
            return value switch
            {
                "CVE" => GlobalAdvisoryIdentifiersType.CVE,
                "GHSA" => GlobalAdvisoryIdentifiersType.GHSA,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}