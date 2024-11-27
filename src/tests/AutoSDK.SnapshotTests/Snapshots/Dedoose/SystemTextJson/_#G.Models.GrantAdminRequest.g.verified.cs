﻿//HintName: G.Models.GrantAdminRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GrantAdminRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantAdminRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GrantAdminRequest(
            global::System.Guid accountId,
            global::System.Guid userId)
        {
            this.AccountId = accountId;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantAdminRequest" /> class.
        /// </summary>
        public GrantAdminRequest()
        {
        }
    }
}