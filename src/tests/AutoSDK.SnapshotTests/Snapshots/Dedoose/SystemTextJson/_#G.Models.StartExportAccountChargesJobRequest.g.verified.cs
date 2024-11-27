﻿//HintName: G.Models.StartExportAccountChargesJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportAccountChargesJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportAccountChargesJobRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartExportAccountChargesJobRequest(
            global::System.Guid accountId)
        {
            this.AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportAccountChargesJobRequest" /> class.
        /// </summary>
        public StartExportAccountChargesJobRequest()
        {
        }
    }
}