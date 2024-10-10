﻿//HintName: G.Models.ProjectExtendedResponseModelQualityPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelQualityPreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="highest")]
        Highest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ultra")]
        Ultra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ultra_lossless")]
        UltraLossless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelQualityPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelQualityPreset value)
        {
            return value switch
            {
                ProjectExtendedResponseModelQualityPreset.Standard => "standard",
                ProjectExtendedResponseModelQualityPreset.High => "high",
                ProjectExtendedResponseModelQualityPreset.Highest => "highest",
                ProjectExtendedResponseModelQualityPreset.Ultra => "ultra",
                ProjectExtendedResponseModelQualityPreset.UltraLossless => "ultra_lossless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelQualityPreset? ToEnum(string value)
        {
            return value switch
            {
                "standard" => ProjectExtendedResponseModelQualityPreset.Standard,
                "high" => ProjectExtendedResponseModelQualityPreset.High,
                "highest" => ProjectExtendedResponseModelQualityPreset.Highest,
                "ultra" => ProjectExtendedResponseModelQualityPreset.Ultra,
                "ultra_lossless" => ProjectExtendedResponseModelQualityPreset.UltraLossless,
                _ => null,
            };
        }
    }
}