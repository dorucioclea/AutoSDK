﻿//HintName: G.Models.GetOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetOrganizationResponse contains the requested organization.
    /// </summary>
    public sealed partial class GetOrganizationResponse
    {
        /// <summary>
        /// The organization resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}