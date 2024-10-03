﻿//HintName: G.Models.Tenant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// attributes representing a single tenant within weaviate
    /// </summary>
    public sealed partial class Tenant
    {
        /// <summary>
        /// name of the tenant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// activity status of the tenant's shard. Optional for creating tenant (implicit `ACTIVE`) and required for updating tenant. For creation, allowed values are `ACTIVE` - tenant is fully active and `INACTIVE` - tenant is inactive; no actions can be performed on tenant, tenant's files are stored locally. For updating, `ACTIVE`, `INACTIVE` and also `OFFLOADED` - as INACTIVE, but files are stored on cloud storage. The following values are read-only and are set by the server for internal use: `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activityStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TenantActivityStatusJsonConverter))]
        public global::G.TenantActivityStatus? ActivityStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}