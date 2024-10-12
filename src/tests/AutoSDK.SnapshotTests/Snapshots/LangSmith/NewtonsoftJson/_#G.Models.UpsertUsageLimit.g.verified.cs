﻿//HintName: G.Models.UpsertUsageLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for creating or updating a usage limit.
    /// </summary>
    public sealed partial class UpsertUsageLimit
    {
        /// <summary>
        /// Type of usage limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsageLimitType LimitType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_value", Required = global::Newtonsoft.Json.Required.Always)]
        public int LimitValue { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}