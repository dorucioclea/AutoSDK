﻿//HintName: G.Models.GetTaskDetailXRunwayVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTaskDetailXRunwayVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2024-09-13")]
        x20240913,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTaskDetailXRunwayVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTaskDetailXRunwayVersion value)
        {
            return value switch
            {
                GetTaskDetailXRunwayVersion.x20240913 => "2024-09-13",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTaskDetailXRunwayVersion? ToEnum(string value)
        {
            return value switch
            {
                "2024-09-13" => GetTaskDetailXRunwayVersion.x20240913,
                _ => null,
            };
        }
    }
}