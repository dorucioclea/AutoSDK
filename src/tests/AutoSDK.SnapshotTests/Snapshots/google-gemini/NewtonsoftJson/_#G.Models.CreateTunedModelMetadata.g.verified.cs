﻿//HintName: G.Models.CreateTunedModelMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about the state and progress of creating a tuned model returned from the long-running operation.
    /// </summary>
    public sealed partial class CreateTunedModelMetadata
    {
        /// <summary>
        /// The total number of tuning steps.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSteps")]
        public int? TotalSteps { get; set; }

        /// <summary>
        /// Name of the tuned model associated with the tuning operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tunedModel")]
        public string? TunedModel { get; set; }

        /// <summary>
        /// The number of steps completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completedSteps")]
        public int? CompletedSteps { get; set; }

        /// <summary>
        /// Metrics collected during tuning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snapshots")]
        public global::System.Collections.Generic.IList<global::G.TuningSnapshot>? Snapshots { get; set; }

        /// <summary>
        /// The completed percentage for the tuning operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completedPercent")]
        public float? CompletedPercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTunedModelMetadata" /> class.
        /// </summary>
        /// <param name="totalSteps">
        /// The total number of tuning steps.
        /// </param>
        /// <param name="tunedModel">
        /// Name of the tuned model associated with the tuning operation.
        /// </param>
        /// <param name="completedSteps">
        /// The number of steps completed.
        /// </param>
        /// <param name="snapshots">
        /// Metrics collected during tuning.
        /// </param>
        /// <param name="completedPercent">
        /// The completed percentage for the tuning operation.
        /// </param>
        public CreateTunedModelMetadata(
            int? totalSteps,
            string? tunedModel,
            int? completedSteps,
            global::System.Collections.Generic.IList<global::G.TuningSnapshot>? snapshots,
            float? completedPercent)
        {
            this.TotalSteps = totalSteps;
            this.TunedModel = tunedModel;
            this.CompletedSteps = completedSteps;
            this.Snapshots = snapshots;
            this.CompletedPercent = completedPercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTunedModelMetadata" /> class.
        /// </summary>
        public CreateTunedModelMetadata()
        {
        }
    }
}