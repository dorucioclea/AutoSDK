﻿//HintName: G.Models.ExtensionBitsProductCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of currency. Possible values are:  <br/>
    ///   <br/>
    /// * bits
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtensionBitsProductCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bits")]
        Bits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtensionBitsProductCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtensionBitsProductCostType value)
        {
            return value switch
            {
                ExtensionBitsProductCostType.Bits => "bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtensionBitsProductCostType? ToEnum(string value)
        {
            return value switch
            {
                "bits" => ExtensionBitsProductCostType.Bits,
                _ => null,
            };
        }
    }
}