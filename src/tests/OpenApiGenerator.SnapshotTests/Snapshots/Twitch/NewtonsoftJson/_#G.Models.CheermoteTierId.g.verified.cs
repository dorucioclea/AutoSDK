﻿//HintName: G.Models.CheermoteTierId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tier level. Possible tiers are:  <br/>
    ///   <br/>
    /// * 1<br/>
    /// * 100<br/>
    /// * 500<br/>
    /// * 1000<br/>
    /// * 5000<br/>
    /// * 10000<br/>
    /// * 100000
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CheermoteTierId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1")]
        x1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="100")]
        x100,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="500")]
        x500,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1000")]
        x1000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="5000")]
        x5000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="10000")]
        x10000,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="100000")]
        x100000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CheermoteTierIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CheermoteTierId value)
        {
            return value switch
            {
                CheermoteTierId.x1 => "1",
                CheermoteTierId.x100 => "100",
                CheermoteTierId.x500 => "500",
                CheermoteTierId.x1000 => "1000",
                CheermoteTierId.x5000 => "5000",
                CheermoteTierId.x10000 => "10000",
                CheermoteTierId.x100000 => "100000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CheermoteTierId? ToEnum(string value)
        {
            return value switch
            {
                "1" => CheermoteTierId.x1,
                "100" => CheermoteTierId.x100,
                "500" => CheermoteTierId.x500,
                "1000" => CheermoteTierId.x1000,
                "5000" => CheermoteTierId.x5000,
                "10000" => CheermoteTierId.x10000,
                "100000" => CheermoteTierId.x100000,
                _ => null,
            };
        }
    }
}