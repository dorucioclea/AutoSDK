﻿//HintName: G.Models.RankingOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output of the embedding service
    /// </summary>
    public sealed partial class RankingOutput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-embedding-t-en-v1`,	14m,	312<br/>
        /// - `jina-embedding-s-en-v1`,	35m,	512 (default)<br/>
        /// - `jina-embedding-b-en-v1`,	110m,	768<br/>
        /// - `jina-embedding-l-en-v1`,	330,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// An ordered list of ranked documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Results { get; set; } = default!;

        /// <summary>
        /// Total usage of the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiSchemasRankUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}