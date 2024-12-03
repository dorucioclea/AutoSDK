﻿//HintName: G.Models.CustomChartPreviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartPreviewRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomChartsRequestBase BucketInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chart", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomChartCreatePreview Chart { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartPreviewRequest" /> class.
        /// </summary>
        /// <param name="bucketInfo"></param>
        /// <param name="chart"></param>
        public CustomChartPreviewRequest(
            global::G.CustomChartsRequestBase bucketInfo,
            global::G.CustomChartCreatePreview chart)
        {
            this.BucketInfo = bucketInfo ?? throw new global::System.ArgumentNullException(nameof(bucketInfo));
            this.Chart = chart ?? throw new global::System.ArgumentNullException(nameof(chart));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartPreviewRequest" /> class.
        /// </summary>
        public CustomChartPreviewRequest()
        {
        }
    }
}