﻿//HintName: G.Models.CodeScanningAlertRuleSeverity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The severity of the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertRuleSeverity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="note")]
        Note,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="warning")]
        Warning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }
}