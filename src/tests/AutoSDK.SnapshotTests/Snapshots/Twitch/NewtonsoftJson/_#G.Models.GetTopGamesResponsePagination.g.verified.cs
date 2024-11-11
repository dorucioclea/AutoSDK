﻿//HintName: G.Models.GetTopGamesResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
    /// </summary>
    public sealed partial class GetTopGamesResponsePagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Use the cursor to set the request’s _after_ or _before_ query parameter to get the next or previous page of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTopGamesResponsePagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor used to get the next page of results. Use the cursor to set the request’s _after_ or _before_ query parameter to get the next or previous page of results.
        /// </param>
        public GetTopGamesResponsePagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTopGamesResponsePagination" /> class.
        /// </summary>
        public GetTopGamesResponsePagination()
        {
        }
    }
}