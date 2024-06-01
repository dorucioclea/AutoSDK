﻿//HintName: G.Models.IssuesListForOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssuesListForOrgState
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
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListForOrgStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForOrgState value)
        {
            return value switch
            {
                IssuesListForOrgState.Open => "open",
                IssuesListForOrgState.Closed => "closed",
                IssuesListForOrgState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForOrgState ToEnum(string value)
        {
            return value switch
            {
                "open" => IssuesListForOrgState.Open,
                "closed" => IssuesListForOrgState.Closed,
                "all" => IssuesListForOrgState.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}