﻿//HintName: G.Models.ActionsWorkflowAccessToRepositoryAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the
    /// repository.
    /// `none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsWorkflowAccessToRepositoryAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsWorkflowAccessToRepositoryAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsWorkflowAccessToRepositoryAccessLevel value)
        {
            return value switch
            {
                ActionsWorkflowAccessToRepositoryAccessLevel.None => "none",
                ActionsWorkflowAccessToRepositoryAccessLevel.User => "user",
                ActionsWorkflowAccessToRepositoryAccessLevel.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsWorkflowAccessToRepositoryAccessLevel ToEnum(string value)
        {
            return value switch
            {
                "none" => ActionsWorkflowAccessToRepositoryAccessLevel.None,
                "user" => ActionsWorkflowAccessToRepositoryAccessLevel.User,
                "organization" => ActionsWorkflowAccessToRepositoryAccessLevel.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}