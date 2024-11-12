﻿//HintName: G.Models.ProjectsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateRequest
    {
        /// <summary>
        /// Name of the project<br/>
        /// Example: Week One Sprint
        /// </summary>
        /// <example>Week One Sprint</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Body of the project<br/>
        /// Example: This project represents the sprint of the first week in January
        /// </summary>
        /// <example>This project represents the sprint of the first week in January</example>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// State of the project; either 'open' or 'closed'<br/>
        /// Example: open
        /// </summary>
        /// <example>open</example>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public string? State { get; set; }

        /// <summary>
        /// The baseline permission that all organization members have on this project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_permission")]
        public global::G.ProjectsUpdateRequestOrganizationPermission? OrganizationPermission { get; set; }

        /// <summary>
        /// Whether or not this project can be seen by everyone.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project<br/>
        /// Example: Week One Sprint
        /// </param>
        /// <param name="body">
        /// Body of the project<br/>
        /// Example: This project represents the sprint of the first week in January
        /// </param>
        /// <param name="state">
        /// State of the project; either 'open' or 'closed'<br/>
        /// Example: open
        /// </param>
        /// <param name="organizationPermission">
        /// The baseline permission that all organization members have on this project
        /// </param>
        /// <param name="private">
        /// Whether or not this project can be seen by everyone.
        /// </param>
        public ProjectsUpdateRequest(
            string? name,
            string? body,
            string? state,
            global::G.ProjectsUpdateRequestOrganizationPermission? organizationPermission,
            bool? @private)
        {
            this.Name = name;
            this.Body = body;
            this.State = state;
            this.OrganizationPermission = organizationPermission;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateRequest" /> class.
        /// </summary>
        public ProjectsUpdateRequest()
        {
        }
    }
}