﻿//HintName: G.Models.Dataset.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset schema.
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public global::G.AnyOf<string, object>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs_schema_definition")]
        public global::G.AnyOf<object, object>? InputsSchemaDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_schema_definition")]
        public global::G.AnyOf<object, object>? OutputsSchemaDefinition { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("externally_managed")]
        public global::G.AnyOf<bool?, object>? ExternallyManaged { get; set; } = false;

        /// <summary>
        /// Default Value: kv
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_type")]
        public global::G.AnyOf<global::G.DataType?, object>? DataType { get; set; } = global::G.DataType.Kv;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExampleCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int SessionCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ModifiedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_session_start_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? LastSessionStartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}