﻿//HintName: G.Models.SearchCorpus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchCorpus
    {
        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// The filter string to narrow the search to according to metadata attributes. The query against this<br/>
        /// corpus will be confined to document parts that match the `metadata_filter`. Only metadata<br/>
        /// set as `filter_attributes` on the corpus can be filtered. Filter syntax is similiar to<br/>
        /// a SQL where clause. See [metadata filters documentation](https://docs.vectara.com/docs/learn/metadata-search-filtering/filter-overview)<br/>
        /// for more information.<br/>
        /// Example: doc.title = 'Charlotte''s Web'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_filter")]
        public string? MetadataFilter { get; set; }

        /// <summary>
        /// How much to weigh lexical scores compared to the embedding score. 0 means lexical search is not used at all, and 1 means only lexical search is used.<br/>
        /// Example: 0.025F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lexical_interpolation")]
        public float? LexicalInterpolation { get; set; }

        /// <summary>
        /// Indicates whether to consider a query against this corpus as a query or a response.<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("semantics")]
        public global::G.SearchSemantics? Semantics { get; set; } = global::G.SearchSemantics.Default;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}