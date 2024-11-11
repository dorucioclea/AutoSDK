﻿//HintName: G.Models.GetCharityCampaignDonationsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
    /// </summary>
    public sealed partial class GetCharityCampaignDonationsResponsePagination
    {
        /// <summary>
        /// The cursor used to get the next page of results. Use the cursor to set the request’s _after_ query parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharityCampaignDonationsResponsePagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor used to get the next page of results. Use the cursor to set the request’s _after_ query parameter.
        /// </param>
        public GetCharityCampaignDonationsResponsePagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharityCampaignDonationsResponsePagination" /> class.
        /// </summary>
        public GetCharityCampaignDonationsResponsePagination()
        {
        }
    }
}