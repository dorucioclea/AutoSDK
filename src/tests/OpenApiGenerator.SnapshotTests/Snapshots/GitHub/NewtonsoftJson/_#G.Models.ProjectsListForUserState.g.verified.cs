﻿//HintName: G.Models.ProjectsListForUserState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: open
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectsListForUserState
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
    public static class ProjectsListForUserStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListForUserState value)
        {
            return value switch
            {
                ProjectsListForUserState.Open => "open",
                ProjectsListForUserState.Closed => "closed",
                ProjectsListForUserState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListForUserState ToEnum(string value)
        {
            return value switch
            {
                "open" => ProjectsListForUserState.Open,
                "closed" => ProjectsListForUserState.Closed,
                "all" => ProjectsListForUserState.All,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}