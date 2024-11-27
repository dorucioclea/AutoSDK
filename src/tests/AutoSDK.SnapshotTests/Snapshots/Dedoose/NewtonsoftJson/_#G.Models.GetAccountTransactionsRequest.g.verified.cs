﻿//HintName: G.Models.GetAccountTransactionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAccountTransactionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountTransactionsRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        public GetAccountTransactionsRequest(
            global::System.Guid accountId)
        {
            this.AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountTransactionsRequest" /> class.
        /// </summary>
        public GetAccountTransactionsRequest()
        {
        }
    }
}