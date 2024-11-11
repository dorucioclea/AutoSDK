﻿//HintName: G.Models.ListOrganizationsAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListOrganizationsAdminResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizations")]
        public global::System.Collections.Generic.IList<global::G.Organization>? Organizations { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of organizations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationsAdminResponse" /> class.
        /// </summary>
        /// <param name="organizations"></param>
        /// <param name="nextPageToken">
        /// Next page token.
        /// </param>
        /// <param name="totalSize">
        /// Total number of organizations.
        /// </param>
        public ListOrganizationsAdminResponse(
            global::System.Collections.Generic.IList<global::G.Organization>? organizations,
            string? nextPageToken,
            int? totalSize)
        {
            this.Organizations = organizations;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationsAdminResponse" /> class.
        /// </summary>
        public ListOrganizationsAdminResponse()
        {
        }
    }
}