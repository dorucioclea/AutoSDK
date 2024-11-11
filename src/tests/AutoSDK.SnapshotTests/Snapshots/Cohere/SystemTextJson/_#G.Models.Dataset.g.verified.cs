﻿//HintName: G.Models.Dataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// The dataset ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The creation date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The type of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DatasetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetType DatasetType { get; set; }

        /// <summary>
        /// The validation status of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DatasetValidationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Errors found during validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_error")]
        public string? ValidationError { get; set; }

        /// <summary>
        /// the avro schema of the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public string? Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_fields")]
        public global::System.Collections.Generic.IList<string>? RequiredFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_fields")]
        public global::System.Collections.Generic.IList<string>? PreserveFields { get; set; }

        /// <summary>
        /// the underlying files that make up the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_parts")]
        public global::System.Collections.Generic.IList<global::G.DatasetPart>? DatasetParts { get; set; }

        /// <summary>
        /// warnings found during validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_warnings")]
        public global::System.Collections.Generic.IList<string>? ValidationWarnings { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_info")]
        public global::G.ParseInfo? ParseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::G.Metrics? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="id">
        /// The dataset ID
        /// </param>
        /// <param name="name">
        /// The name of the dataset
        /// </param>
        /// <param name="createdAt">
        /// The creation date
        /// </param>
        /// <param name="updatedAt">
        /// The last update date
        /// </param>
        /// <param name="datasetType">
        /// The type of the dataset
        /// </param>
        /// <param name="validationStatus">
        /// The validation status of the dataset
        /// </param>
        /// <param name="validationError">
        /// Errors found during validation
        /// </param>
        /// <param name="schema">
        /// the avro schema of the dataset
        /// </param>
        /// <param name="requiredFields"></param>
        /// <param name="preserveFields"></param>
        /// <param name="datasetParts">
        /// the underlying files that make up the dataset
        /// </param>
        /// <param name="validationWarnings">
        /// warnings found during validation
        /// </param>
        /// <param name="parseInfo">
        /// Included only in requests
        /// </param>
        /// <param name="metrics"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Dataset(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.DatasetType datasetType,
            global::G.DatasetValidationStatus validationStatus,
            string? validationError,
            string? schema,
            global::System.Collections.Generic.IList<string>? requiredFields,
            global::System.Collections.Generic.IList<string>? preserveFields,
            global::System.Collections.Generic.IList<global::G.DatasetPart>? datasetParts,
            global::System.Collections.Generic.IList<string>? validationWarnings,
            global::G.ParseInfo? parseInfo,
            global::G.Metrics? metrics)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DatasetType = datasetType;
            this.ValidationStatus = validationStatus;
            this.ValidationError = validationError;
            this.Schema = schema;
            this.RequiredFields = requiredFields;
            this.PreserveFields = preserveFields;
            this.DatasetParts = datasetParts;
            this.ValidationWarnings = validationWarnings;
            this.ParseInfo = parseInfo;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
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
        public static global::G.Dataset? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Dataset),
                jsonSerializerContext) as global::G.Dataset;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Dataset? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Dataset>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.Dataset?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.Dataset),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.Dataset;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Dataset?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.Dataset?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}