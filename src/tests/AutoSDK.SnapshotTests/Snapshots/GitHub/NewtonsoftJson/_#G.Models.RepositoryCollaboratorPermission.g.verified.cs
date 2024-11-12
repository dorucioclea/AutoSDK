﻿//HintName: G.Models.RepositoryCollaboratorPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Repository Collaborator Permission
    /// </summary>
    public sealed partial class RepositoryCollaboratorPermission
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission", Required = global::Newtonsoft.Json.Required.Always)]
        public string Permission { get; set; } = default!;

        /// <summary>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::Newtonsoft.Json.JsonProperty("role_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoleName { get; set; } = default!;

        /// <summary>
        /// Collaborator
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableCollaborator? User { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryCollaboratorPermission" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="roleName">
        /// Example: admin
        /// </param>
        /// <param name="user">
        /// Collaborator
        /// </param>
        public RepositoryCollaboratorPermission(
            string permission,
            string roleName,
            global::G.NullableCollaborator? user)
        {
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryCollaboratorPermission" /> class.
        /// </summary>
        public RepositoryCollaboratorPermission()
        {
        }
    }
}