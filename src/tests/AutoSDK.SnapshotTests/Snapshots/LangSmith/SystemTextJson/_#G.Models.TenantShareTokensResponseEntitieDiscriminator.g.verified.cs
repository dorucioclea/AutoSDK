﻿//HintName: G.Models.TenantShareTokensResponseEntitieDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantShareTokensResponseEntitieDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter))]
        public global::G.TenantShareTokensResponseEntitieDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareTokensResponseEntitieDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TenantShareTokensResponseEntitieDiscriminator(
            global::G.TenantShareTokensResponseEntitieDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareTokensResponseEntitieDiscriminator" /> class.
        /// </summary>
        public TenantShareTokensResponseEntitieDiscriminator()
        {
        }
    }
}