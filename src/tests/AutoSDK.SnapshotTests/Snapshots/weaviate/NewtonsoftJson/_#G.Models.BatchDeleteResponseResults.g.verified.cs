﻿//HintName: G.Models.BatchDeleteResponseResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchDeleteResponseResults
    {
        /// <summary>
        /// How many objects were matched by the filter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("matches")]
        public double? Matches { get; set; }

        /// <summary>
        /// The most amount of objects that can be deleted in a single query, equals QUERY_MAXIMUM_RESULTS.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// How many objects were successfully deleted in this round.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successful")]
        public double? Successful { get; set; }

        /// <summary>
        /// How many objects should have been deleted but could not be deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// With output set to "minimal" only objects with error occurred will the be described. Successfully deleted objects would be omitted. Output set to "verbose" will list all of the objets with their respective statuses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objects")]
        public global::System.Collections.Generic.IList<global::G.BatchDeleteResponseResultsObject>? Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}