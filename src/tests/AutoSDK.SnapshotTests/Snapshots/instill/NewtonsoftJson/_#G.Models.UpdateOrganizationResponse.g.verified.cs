﻿//HintName: G.Models.UpdateOrganizationResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// UpdateOrganizationResponse contains the updated organization.
    /// </summary>
    public sealed partial class UpdateOrganizationResponse
    {
        /// <summary>
        /// The organization resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.AllOf<global::G.Organization7>? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}