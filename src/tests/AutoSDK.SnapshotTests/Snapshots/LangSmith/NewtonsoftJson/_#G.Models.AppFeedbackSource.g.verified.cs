﻿//HintName: G.Models.AppFeedbackSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feedback from the LangChainPlus App.
    /// </summary>
    public sealed partial class AppFeedbackSource
    {
        /// <summary>
        /// Default Value: app
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppFeedbackSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: app
        /// </param>
        /// <param name="metadata"></param>
        public AppFeedbackSource(
            string? type,
            object? metadata)
        {
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppFeedbackSource" /> class.
        /// </summary>
        public AppFeedbackSource()
        {
        }
    }
}