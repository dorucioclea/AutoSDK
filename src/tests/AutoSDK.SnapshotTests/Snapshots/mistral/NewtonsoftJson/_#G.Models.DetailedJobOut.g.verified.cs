﻿//HintName: G.Models.DetailedJobOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedJobOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_start", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutoStart { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checkpoints")]
        public global::System.Collections.Generic.IList<global::G.CheckpointOut>? Checkpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<global::G.EventOut>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuned_model")]
        public string? FineTunedModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TrainingParameters Hyperparameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrations")]
        public global::System.Collections.Generic.IList<global::G.IntegrationsItem>? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The name of the model to fine-tune.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuneableModel Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modified_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int ModifiedAt { get; set; } = default!;

        /// <summary>
        /// Default Value: job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.DetailedJobOutObject? Object { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<global::G.RepositoriesItem>? Repositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DetailedJobOutStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> TrainingFiles { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_files")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ValidationFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedJobOut" /> class.
        /// </summary>
        /// <param name="autoStart"></param>
        /// <param name="checkpoints">
        /// Default Value: []
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="events">
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="fineTunedModel"></param>
        /// <param name="hyperparameters"></param>
        /// <param name="id"></param>
        /// <param name="integrations"></param>
        /// <param name="jobType"></param>
        /// <param name="metadata"></param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="modifiedAt"></param>
        /// <param name="object">
        /// Default Value: job
        /// </param>
        /// <param name="repositories">
        /// Default Value: []
        /// </param>
        /// <param name="status"></param>
        /// <param name="suffix"></param>
        /// <param name="trainedTokens"></param>
        /// <param name="trainingFiles"></param>
        /// <param name="validationFiles">
        /// Default Value: []
        /// </param>
        public DetailedJobOut(
            bool autoStart,
            int createdAt,
            global::G.TrainingParameters hyperparameters,
            global::System.Guid id,
            string jobType,
            global::G.FineTuneableModel model,
            int modifiedAt,
            global::G.DetailedJobOutStatus status,
            global::System.Collections.Generic.IList<global::System.Guid> trainingFiles,
            global::System.Collections.Generic.IList<global::G.CheckpointOut>? checkpoints,
            global::System.Collections.Generic.IList<global::G.EventOut>? events,
            string? fineTunedModel,
            global::System.Collections.Generic.IList<global::G.IntegrationsItem>? integrations,
            object? metadata,
            global::G.DetailedJobOutObject? @object,
            global::System.Collections.Generic.IList<global::G.RepositoriesItem>? repositories,
            string? suffix,
            int? trainedTokens,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles)
        {
            this.AutoStart = autoStart;
            this.CreatedAt = createdAt;
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.Id = id;
            this.JobType = jobType ?? throw new global::System.ArgumentNullException(nameof(jobType));
            this.Model = model;
            this.ModifiedAt = modifiedAt;
            this.Status = status;
            this.TrainingFiles = trainingFiles ?? throw new global::System.ArgumentNullException(nameof(trainingFiles));
            this.Checkpoints = checkpoints;
            this.Events = events;
            this.FineTunedModel = fineTunedModel;
            this.Integrations = integrations;
            this.Metadata = metadata;
            this.Object = @object;
            this.Repositories = repositories;
            this.Suffix = suffix;
            this.TrainedTokens = trainedTokens;
            this.ValidationFiles = validationFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedJobOut" /> class.
        /// </summary>
        public DetailedJobOut()
        {
        }
    }
}