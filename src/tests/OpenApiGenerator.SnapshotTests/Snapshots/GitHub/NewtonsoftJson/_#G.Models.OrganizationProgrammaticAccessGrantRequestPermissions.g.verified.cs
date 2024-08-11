﻿//HintName: G.Models.OrganizationProgrammaticAccessGrantRequestPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permissions requested, categorized by type of permission.
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrantRequestPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.OrganizationProgrammaticAccessGrantRequestPermissionsOrganization? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public global::G.OrganizationProgrammaticAccessGrantRequestPermissionsRepository? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other")]
        public global::G.OrganizationProgrammaticAccessGrantRequestPermissionsOther? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}