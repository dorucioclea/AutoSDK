﻿//HintName: G.Models.ListTokensResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListTokensResponse contains a list of API tokens.
    /// </summary>
    public sealed partial class ListTokensResponse
    {
        /// <summary>
        /// A list of API token resources.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public global::System.Collections.Generic.IList<global::G.ApiToken>? Tokens { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of API token resources.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTokensResponse" /> class.
        /// </summary>
        /// <param name="tokens">
        /// A list of API token resources.
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.
        /// </param>
        /// <param name="totalSize">
        /// Total number of API token resources.
        /// </param>
        public ListTokensResponse(
            global::System.Collections.Generic.IList<global::G.ApiToken>? tokens,
            string? nextPageToken,
            int? totalSize)
        {
            this.Tokens = tokens;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTokensResponse" /> class.
        /// </summary>
        public ListTokensResponse()
        {
        }
    }
}