﻿//HintName: G.Models.CustomChartSeriesUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartSeriesUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::G.CustomChartSeriesFilters? Filters { get; set; }

        /// <summary>
        /// Metrics you can chart.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomChartMetric Metric { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_key")]
        public string? FeedbackKey { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filters"></param>
        /// <param name="metric">
        /// Metrics you can chart.
        /// </param>
        /// <param name="feedbackKey"></param>
        /// <param name="id"></param>
        public CustomChartSeriesUpdate(
            string name,
            global::G.CustomChartMetric metric,
            global::G.CustomChartSeriesFilters? filters,
            string? feedbackKey,
            global::System.Guid? id)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metric = metric;
            this.Filters = filters;
            this.FeedbackKey = feedbackKey;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesUpdate" /> class.
        /// </summary>
        public CustomChartSeriesUpdate()
        {
        }
    }
}