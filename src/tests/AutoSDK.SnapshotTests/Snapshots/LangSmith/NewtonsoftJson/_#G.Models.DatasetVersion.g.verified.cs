﻿//HintName: G.Models.DatasetVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset version schema.
    /// </summary>
    public sealed partial class DatasetVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("as_of", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime AsOf { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}