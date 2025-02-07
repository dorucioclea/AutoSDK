﻿//HintName: G.Models.SearchCategoriesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchCategoriesResponse
    {
        /// <summary>
        /// The list of games or categories that match the query. The list is empty if there are no matches.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Category> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCategoriesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of games or categories that match the query. The list is empty if there are no matches.
        /// </param>
        public SearchCategoriesResponse(
            global::System.Collections.Generic.IList<global::G.Category> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCategoriesResponse" /> class.
        /// </summary>
        public SearchCategoriesResponse()
        {
        }
    }
}