﻿//HintName: G.Models.WebhooksAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The security alert of the vulnerable dependency.
    /// </summary>
    public sealed partial class WebhooksAlert
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affected_package_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AffectedPackageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affected_range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AffectedRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismiss_reason")]
        public string? DismissReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_at")]
        public string? DismissedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismisser")]
        public global::G.WebhooksAlertDismisser? Dismisser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_reference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ExternalReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix_reason")]
        public string? FixReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_at")]
        public global::System.DateTime? FixedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_in")]
        public string? FixedIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghsa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GhsaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhooksAlertStateJsonConverter))]
        public global::G.WebhooksAlertState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksAlert" /> class.
        /// </summary>
        /// <param name="affectedPackageName"></param>
        /// <param name="affectedRange"></param>
        /// <param name="createdAt"></param>
        /// <param name="dismissReason"></param>
        /// <param name="dismissedAt"></param>
        /// <param name="dismisser"></param>
        /// <param name="externalIdentifier"></param>
        /// <param name="externalReference"></param>
        /// <param name="fixReason"></param>
        /// <param name="fixedAt"></param>
        /// <param name="fixedIn"></param>
        /// <param name="ghsaId"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="severity"></param>
        /// <param name="state"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhooksAlert(
            string affectedPackageName,
            string affectedRange,
            string createdAt,
            string externalIdentifier,
            string? externalReference,
            string ghsaId,
            int id,
            string nodeId,
            int number,
            string severity,
            string? dismissReason,
            string? dismissedAt,
            global::G.WebhooksAlertDismisser? dismisser,
            string? fixReason,
            global::System.DateTime? fixedAt,
            string? fixedIn,
            global::G.WebhooksAlertState state)
        {
            this.AffectedPackageName = affectedPackageName ?? throw new global::System.ArgumentNullException(nameof(affectedPackageName));
            this.AffectedRange = affectedRange ?? throw new global::System.ArgumentNullException(nameof(affectedRange));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ExternalIdentifier = externalIdentifier ?? throw new global::System.ArgumentNullException(nameof(externalIdentifier));
            this.ExternalReference = externalReference ?? throw new global::System.ArgumentNullException(nameof(externalReference));
            this.GhsaId = ghsaId ?? throw new global::System.ArgumentNullException(nameof(ghsaId));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.Severity = severity ?? throw new global::System.ArgumentNullException(nameof(severity));
            this.DismissReason = dismissReason;
            this.DismissedAt = dismissedAt;
            this.Dismisser = dismisser;
            this.FixReason = fixReason;
            this.FixedAt = fixedAt;
            this.FixedIn = fixedIn;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksAlert" /> class.
        /// </summary>
        public WebhooksAlert()
        {
        }
    }
}