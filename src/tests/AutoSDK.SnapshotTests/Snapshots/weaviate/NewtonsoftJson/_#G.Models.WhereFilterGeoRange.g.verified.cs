﻿//HintName: G.Models.WhereFilterGeoRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// filter within a distance of a georange
    /// </summary>
    public sealed partial class WhereFilterGeoRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geoCoordinates")]
        public global::G.GeoCoordinates? GeoCoordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance")]
        public global::G.WhereFilterGeoRangeDistance? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}