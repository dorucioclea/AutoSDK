﻿//HintName: G.Models.CreateModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelRequest
    {
        /// <summary>
        /// The name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The ID of the dataset to train the model on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// The instance prompt to use during training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstancePrompt { get; set; }

        /// <summary>
        /// The category the most accurately reflects the model.<br/>
        /// Default Value: GENERAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomModelTypeJsonConverter))]
        public global::G.CustomModelType? ModelType { get; set; }

        /// <summary>
        /// Whether or not the model is NSFW.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw")]
        public bool? Nsfw { get; set; }

        /// <summary>
        /// The resolution for training. Must be 512 or 768.<br/>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public int? Resolution { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd_Version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdVersionsJsonConverter))]
        public global::G.SdVersions? SdVersion { get; set; }

        /// <summary>
        /// When training using the PIXEL_ART model type, this influences the training strength.<br/>
        /// Default Value: MEDIUM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StrengthJsonConverter))]
        public global::G.Strength? Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the model.
        /// </param>
        /// <param name="description">
        /// The description of the model.
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset to train the model on.
        /// </param>
        /// <param name="instancePrompt">
        /// The instance prompt to use during training.
        /// </param>
        /// <param name="modelType">
        /// The category the most accurately reflects the model.<br/>
        /// Default Value: GENERAL
        /// </param>
        /// <param name="nsfw">
        /// Whether or not the model is NSFW.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resolution">
        /// The resolution for training. Must be 512 or 768.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="sdVersion">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="strength">
        /// When training using the PIXEL_ART model type, this influences the training strength.<br/>
        /// Default Value: MEDIUM
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateModelRequest(
            string name,
            string datasetId,
            string instancePrompt,
            string? description,
            global::G.CustomModelType? modelType,
            bool? nsfw,
            int? resolution,
            global::G.SdVersions? sdVersion,
            global::G.Strength? strength)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.InstancePrompt = instancePrompt ?? throw new global::System.ArgumentNullException(nameof(instancePrompt));
            this.Description = description;
            this.ModelType = modelType;
            this.Nsfw = nsfw;
            this.Resolution = resolution;
            this.SdVersion = sdVersion;
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        public CreateModelRequest()
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
        public static global::G.CreateModelRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CreateModelRequest),
                jsonSerializerContext) as global::G.CreateModelRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateModelRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateModelRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CreateModelRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CreateModelRequest),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CreateModelRequest;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CreateModelRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CreateModelRequest?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}