﻿//HintName: G.Models.ChecksListSuitesForRefResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksListSuitesForRefResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("check_suites", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CheckSuite> CheckSuites { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksListSuitesForRefResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="checkSuites"></param>
        public ChecksListSuitesForRefResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::G.CheckSuite> checkSuites)
        {
            this.TotalCount = totalCount;
            this.CheckSuites = checkSuites ?? throw new global::System.ArgumentNullException(nameof(checkSuites));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksListSuitesForRefResponse" /> class.
        /// </summary>
        public ChecksListSuitesForRefResponse()
        {
        }
    }
}