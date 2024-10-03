﻿//HintName: G.Models.BackupConfigCompressionLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Compression level used by compression algorithm<br/>
    /// Default Value: DefaultCompression
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BackupConfigCompressionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DefaultCompression")]
        DefaultCompression,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BestSpeed")]
        BestSpeed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BestCompression")]
        BestCompression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupConfigCompressionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupConfigCompressionLevel value)
        {
            return value switch
            {
                BackupConfigCompressionLevel.DefaultCompression => "DefaultCompression",
                BackupConfigCompressionLevel.BestSpeed => "BestSpeed",
                BackupConfigCompressionLevel.BestCompression => "BestCompression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupConfigCompressionLevel? ToEnum(string value)
        {
            return value switch
            {
                "DefaultCompression" => BackupConfigCompressionLevel.DefaultCompression,
                "BestSpeed" => BackupConfigCompressionLevel.BestSpeed,
                "BestCompression" => BackupConfigCompressionLevel.BestCompression,
                _ => null,
            };
        }
    }
}