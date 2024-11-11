﻿//HintName: G.Models.AuditLogActorServiceAccount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The service account that performed the audit logged action.
    /// </summary>
    public sealed partial class AuditLogActorServiceAccount
    {
        /// <summary>
        /// The service account id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorServiceAccount" /> class.
        /// </summary>
        /// <param name="id">
        /// The service account id.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogActorServiceAccount(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorServiceAccount" /> class.
        /// </summary>
        public AuditLogActorServiceAccount()
        {
        }
    }
}