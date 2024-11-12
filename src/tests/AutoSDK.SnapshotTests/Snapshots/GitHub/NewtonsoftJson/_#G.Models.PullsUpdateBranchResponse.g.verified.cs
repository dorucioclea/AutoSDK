﻿//HintName: G.Models.PullsUpdateBranchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsUpdateBranchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateBranchResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="url"></param>
        public PullsUpdateBranchResponse(
            string? message,
            string? url)
        {
            this.Message = message;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateBranchResponse" /> class.
        /// </summary>
        public PullsUpdateBranchResponse()
        {
        }
    }
}