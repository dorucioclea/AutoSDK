﻿//HintName: G.Models.ReviewCustomGatesStateRequired.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewCustomGatesStateRequired
    {
        /// <summary>
        /// The name of the environment to approve or reject.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string EnvironmentName { get; set; } = default!;

        /// <summary>
        /// Whether to approve or reject deployment to the specified environments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReviewCustomGatesStateRequiredState State { get; set; } = default!;

        /// <summary>
        /// Optional comment to include with the review.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewCustomGatesStateRequired" /> class.
        /// </summary>
        /// <param name="environmentName">
        /// The name of the environment to approve or reject.
        /// </param>
        /// <param name="state">
        /// Whether to approve or reject deployment to the specified environments.
        /// </param>
        /// <param name="comment">
        /// Optional comment to include with the review.
        /// </param>
        public ReviewCustomGatesStateRequired(
            string environmentName,
            global::G.ReviewCustomGatesStateRequiredState state,
            string? comment)
        {
            this.EnvironmentName = environmentName ?? throw new global::System.ArgumentNullException(nameof(environmentName));
            this.State = state;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewCustomGatesStateRequired" /> class.
        /// </summary>
        public ReviewCustomGatesStateRequired()
        {
        }
    }
}