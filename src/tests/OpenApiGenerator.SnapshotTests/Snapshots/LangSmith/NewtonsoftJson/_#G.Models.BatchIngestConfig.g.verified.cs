﻿//HintName: G.Models.BatchIngestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Batch ingest config.
    /// </summary>
    public sealed partial class BatchIngestConfig
    {
        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale_up_qsize_trigger")]
        public int ScaleUpQsizeTrigger { get; set; } = 1000;

        /// <summary>
        /// Default Value: 16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale_up_nthreads_limit")]
        public int ScaleUpNthreadsLimit { get; set; } = 16;

        /// <summary>
        /// Default Value: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale_down_nempty_trigger")]
        public int ScaleDownNemptyTrigger { get; set; } = 4;

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_limit")]
        public int SizeLimit { get; set; } = 100;

        /// <summary>
        /// Default Value: 20971520
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_limit_bytes")]
        public int SizeLimitBytes { get; set; } = 20971520;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}