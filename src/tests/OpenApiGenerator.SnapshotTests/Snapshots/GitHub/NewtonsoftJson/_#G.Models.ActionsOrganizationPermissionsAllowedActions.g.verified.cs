﻿//HintName: G.Models.ActionsOrganizationPermissionsAllowedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsOrganizationPermissionsAllowedActions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local_only")]
        LocalOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsOrganizationPermissionsAllowedActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsOrganizationPermissionsAllowedActions value)
        {
            return value switch
            {
                ActionsOrganizationPermissionsAllowedActions.All => "all",
                ActionsOrganizationPermissionsAllowedActions.LocalOnly => "local_only",
                ActionsOrganizationPermissionsAllowedActions.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsOrganizationPermissionsAllowedActions ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsOrganizationPermissionsAllowedActions.All,
                "local_only" => ActionsOrganizationPermissionsAllowedActions.LocalOnly,
                "selected" => ActionsOrganizationPermissionsAllowedActions.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}