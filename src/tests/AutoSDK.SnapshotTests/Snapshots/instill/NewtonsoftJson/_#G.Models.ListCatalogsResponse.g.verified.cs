﻿//HintName: G.Models.ListCatalogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetCatalogsResponse represents a response for getting all catalogs from users.
    /// </summary>
    public sealed partial class ListCatalogsResponse
    {
        /// <summary>
        /// The catalogs container.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalogs")]
        public global::System.Collections.Generic.IList<global::G.Catalog>? Catalogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogsResponse" /> class.
        /// </summary>
        /// <param name="catalogs">
        /// The catalogs container.
        /// </param>
        public ListCatalogsResponse(
            global::System.Collections.Generic.IList<global::G.Catalog>? catalogs)
        {
            this.Catalogs = catalogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCatalogsResponse" /> class.
        /// </summary>
        public ListCatalogsResponse()
        {
        }
    }
}