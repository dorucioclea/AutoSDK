﻿//HintName: G.Models.PageDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the transcript page. Transcripts are sorted from newest to oldest. The previous URL always points to a page with older transcripts.
    /// </summary>
    public sealed partial class PageDetails
    {
        /// <summary>
        /// The number of results this page is limited to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// The actual number of results in the page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ResultCount { get; set; } = default!;

        /// <summary>
        /// The URL used to retrieve the current page of transcripts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CurrentUrl { get; set; } = default!;

        /// <summary>
        /// The URL to the next page of transcripts. The previous URL always points to a page with older transcripts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prev_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PrevUrl { get; set; } = default!;

        /// <summary>
        /// The URL to the next page of transcripts. The next URL always points to a page with newer transcripts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string NextUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageDetails" /> class.
        /// </summary>
        /// <param name="limit">
        /// The number of results this page is limited to
        /// </param>
        /// <param name="resultCount">
        /// The actual number of results in the page
        /// </param>
        /// <param name="currentUrl">
        /// The URL used to retrieve the current page of transcripts
        /// </param>
        /// <param name="prevUrl">
        /// The URL to the next page of transcripts. The previous URL always points to a page with older transcripts.
        /// </param>
        /// <param name="nextUrl">
        /// The URL to the next page of transcripts. The next URL always points to a page with newer transcripts.
        /// </param>
        public PageDetails(
            int limit,
            int resultCount,
            string currentUrl,
            string prevUrl,
            string nextUrl)
        {
            this.Limit = limit;
            this.ResultCount = resultCount;
            this.CurrentUrl = currentUrl ?? throw new global::System.ArgumentNullException(nameof(currentUrl));
            this.PrevUrl = prevUrl ?? throw new global::System.ArgumentNullException(nameof(prevUrl));
            this.NextUrl = nextUrl ?? throw new global::System.ArgumentNullException(nameof(nextUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageDetails" /> class.
        /// </summary>
        public PageDetails()
        {
        }
    }
}