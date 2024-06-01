﻿//HintName: G.Models.CodeScanningListAlertsForOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningListAlertsForOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningListAlertsForOrgStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningListAlertsForOrgState value)
        {
            return value switch
            {
                CodeScanningListAlertsForOrgState.Open => "open",
                CodeScanningListAlertsForOrgState.Closed => "closed",
                CodeScanningListAlertsForOrgState.Dismissed => "dismissed",
                CodeScanningListAlertsForOrgState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningListAlertsForOrgState ToEnum(string value)
        {
            return value switch
            {
                "open" => CodeScanningListAlertsForOrgState.Open,
                "closed" => CodeScanningListAlertsForOrgState.Closed,
                "dismissed" => CodeScanningListAlertsForOrgState.Dismissed,
                "fixed" => CodeScanningListAlertsForOrgState.Fixed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}