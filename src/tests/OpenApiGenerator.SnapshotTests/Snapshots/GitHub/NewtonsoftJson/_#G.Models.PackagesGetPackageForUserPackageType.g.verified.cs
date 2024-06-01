﻿//HintName: G.Models.PackagesGetPackageForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetPackageForUserPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docker")]
        Docker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container")]
        Container,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesGetPackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageForUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageForUserPackageType.Npm => "npm",
                PackagesGetPackageForUserPackageType.Maven => "maven",
                PackagesGetPackageForUserPackageType.Rubygems => "rubygems",
                PackagesGetPackageForUserPackageType.Docker => "docker",
                PackagesGetPackageForUserPackageType.Nuget => "nuget",
                PackagesGetPackageForUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageForUserPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetPackageForUserPackageType.Npm,
                "maven" => PackagesGetPackageForUserPackageType.Maven,
                "rubygems" => PackagesGetPackageForUserPackageType.Rubygems,
                "docker" => PackagesGetPackageForUserPackageType.Docker,
                "nuget" => PackagesGetPackageForUserPackageType.Nuget,
                "container" => PackagesGetPackageForUserPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}