﻿//HintName: G.Models.RunSchemaWithAnnotationQueueInfo.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Run schema with annotation queue info.
    /// </summary>
    public sealed partial class RunSchemaWithAnnotationQueueInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.AnyOf<object, object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs_preview")]
        public global::G.AnyOf<string, object>? InputsPreview { get; set; }

        /// <summary>
        /// Enum for run types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunTypeEnum RunType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra")]
        public global::G.AnyOf<object, object>? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.AnyOf<string, object>? Error { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_order")]
        public int? ExecutionOrder { get; set; } = 1;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serialized")]
        public global::G.AnyOf<object, object>? Serialized { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::G.AnyOf<object, object>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_preview")]
        public global::G.AnyOf<string, object>? OutputsPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run_id")]
        public global::G.AnyOf<global::System.Guid?, object>? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_id")]
        public global::G.AnyOf<global::System.Guid?, object>? ManifestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest_s3_id")]
        public global::G.AnyOf<global::System.Guid?, object>? ManifestS3Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<object>, object>? Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs_s3_urls")]
        public global::G.AnyOf<object, object>? InputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs_s3_urls")]
        public global::G.AnyOf<object, object>? OutputsS3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("s3_urls")]
        public global::G.AnyOf<object, object>? S3Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TraceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dotted_order", Required = global::Newtonsoft.Json.Required.Always)]
        public string DottedOrder { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("child_run_ids")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direct_child_run_ids")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? DirectChildRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_run_ids")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? ParentRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_stats")]
        public global::G.AnyOf<global::System.Collections.Generic.Dictionary<string, object>, object>? FeedbackStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_example_id")]
        public global::G.AnyOf<global::System.Guid?, object>? ReferenceExampleId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; } = 0;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost")]
        public global::G.AnyOf<string, object>? TotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_cost")]
        public global::G.AnyOf<string, object>? PromptCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_cost")]
        public global::G.AnyOf<string, object>? CompletionCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price_model_id")]
        public global::G.AnyOf<global::System.Guid?, object>? PriceModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_token_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? FirstTokenTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string AppPath { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_queued_at")]
        public global::G.AnyOf<global::System.DateTime?, object>? LastQueuedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_dataset")]
        public global::G.AnyOf<bool?, object>? InDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("share_token")]
        public global::G.AnyOf<global::System.Guid?, object>? ShareToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_tier")]
        public global::G.AnyOf<global::G.TraceTier3?, object>? TraceTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_first_received_at")]
        public global::G.AnyOf<global::System.DateTime?, object>? TraceFirstReceivedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ttl_seconds")]
        public global::G.AnyOf<int?, object>? TtlSeconds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_upgrade")]
        public bool? TraceUpgrade { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queue_run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid QueueRunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_reviewed_time")]
        public global::G.AnyOf<global::System.DateTime?, object>? LastReviewedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_at")]
        public global::G.AnyOf<global::System.DateTime?, object>? AddedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_added_at")]
        public global::G.AnyOf<global::System.DateTime?, object>? EffectiveAddedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}