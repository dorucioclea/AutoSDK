﻿//HintName: G.Models.SecretScanningListAlertsForEnterpriseSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningListAlertsForEnterpriseSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListAlertsForEnterpriseSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForEnterpriseSort value)
        {
            return value switch
            {
                SecretScanningListAlertsForEnterpriseSort.Created => "created",
                SecretScanningListAlertsForEnterpriseSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForEnterpriseSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => SecretScanningListAlertsForEnterpriseSort.Created,
                "updated" => SecretScanningListAlertsForEnterpriseSort.Updated,
                _ => null,
            };
        }
    }
}