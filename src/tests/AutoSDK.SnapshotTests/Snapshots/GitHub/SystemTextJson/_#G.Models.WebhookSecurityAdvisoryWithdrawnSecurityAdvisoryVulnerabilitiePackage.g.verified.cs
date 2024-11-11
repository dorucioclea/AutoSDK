﻿//HintName: G.Models.WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ecosystem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ecosystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage" /> class.
        /// </summary>
        /// <param name="ecosystem"></param>
        /// <param name="name"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage(
            string ecosystem,
            string name)
        {
            this.Ecosystem = ecosystem ?? throw new global::System.ArgumentNullException(nameof(ecosystem));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage" /> class.
        /// </summary>
        public WebhookSecurityAdvisoryWithdrawnSecurityAdvisoryVulnerabilitiePackage()
        {
        }
    }
}