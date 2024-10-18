﻿//HintName: G.Models.ChunkingStrategyRequestParamDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChunkingStrategyRequestParamDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkingStrategyRequestParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkingStrategyRequestParamDiscriminatorType value)
        {
            return value switch
            {
                ChunkingStrategyRequestParamDiscriminatorType.Auto => "auto",
                ChunkingStrategyRequestParamDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkingStrategyRequestParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChunkingStrategyRequestParamDiscriminatorType.Auto,
                "static" => ChunkingStrategyRequestParamDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}