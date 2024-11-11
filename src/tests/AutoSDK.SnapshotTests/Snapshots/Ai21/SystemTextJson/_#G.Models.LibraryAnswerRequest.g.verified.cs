﻿//HintName: G.Models.LibraryAnswerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class LibraryAnswerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("question")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Question { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxSegments")]
        public int? MaxSegments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.QueryFilterJsonConverter))]
        public global::G.QueryFilter? LabelsFilter { get; set; }

        /// <summary>
        /// Default Value: AND
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_filter_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LibraryAnswerRequestLabelsFilterModeJsonConverter))]
        public global::G.LibraryAnswerRequestLabelsFilterMode? LabelsFilterMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? FileIds { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answerLength")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnswerLengthJsonConverter))]
        public global::G.AnswerLength? AnswerLength { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModeJsonConverter))]
        public global::G.Mode? Mode { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalStrategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RetrievalStrategyJsonConverter))]
        public global::G.RetrievalStrategy? RetrievalStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalSimilarityThreshold")]
        public double? RetrievalSimilarityThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hybridSearchAlpha")]
        public double? HybridSearchAlpha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerRequest" /> class.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="maxSegments"></param>
        /// <param name="path"></param>
        /// <param name="labels"></param>
        /// <param name="labelsFilter"></param>
        /// <param name="labelsFilterMode">
        /// Default Value: AND
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="retrievalStrategy">
        /// Default Value: default
        /// </param>
        /// <param name="retrievalSimilarityThreshold"></param>
        /// <param name="hybridSearchAlpha"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LibraryAnswerRequest(
            string question,
            int? maxSegments,
            string? path,
            global::System.Collections.Generic.IList<string>? labels,
            global::G.QueryFilter? labelsFilter,
            global::G.LibraryAnswerRequestLabelsFilterMode? labelsFilterMode,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds,
            global::G.AnswerLength? answerLength,
            global::G.Mode? mode,
            global::G.RetrievalStrategy? retrievalStrategy,
            double? retrievalSimilarityThreshold,
            double? hybridSearchAlpha)
        {
            this.Question = question ?? throw new global::System.ArgumentNullException(nameof(question));
            this.MaxSegments = maxSegments;
            this.Path = path;
            this.Labels = labels;
            this.LabelsFilter = labelsFilter;
            this.LabelsFilterMode = labelsFilterMode;
            this.FileIds = fileIds;
            this.AnswerLength = answerLength;
            this.Mode = mode;
            this.RetrievalStrategy = retrievalStrategy;
            this.RetrievalSimilarityThreshold = retrievalSimilarityThreshold;
            this.HybridSearchAlpha = hybridSearchAlpha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryAnswerRequest" /> class.
        /// </summary>
        public LibraryAnswerRequest()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.LibraryAnswerRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.LibraryAnswerRequest),
                jsonSerializerContext) as global::G.LibraryAnswerRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.LibraryAnswerRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.LibraryAnswerRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.LibraryAnswerRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.LibraryAnswerRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.LibraryAnswerRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.LibraryAnswerRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.LibraryAnswerRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}