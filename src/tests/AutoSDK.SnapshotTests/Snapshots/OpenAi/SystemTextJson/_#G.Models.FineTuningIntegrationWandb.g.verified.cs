﻿//HintName: G.Models.FineTuningIntegrationWandb.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
    /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
    /// to your run, and set a default entity (team, username, etc) to be associated with your run.
    /// </summary>
    public sealed partial class FineTuningIntegrationWandb
    {
        /// <summary>
        /// The name of the project that the new run will be created under.<br/>
        /// Example: my-wandb-project
        /// </summary>
        /// <example>my-wandb-project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// A display name to set for the run. If not set, we will use the Job ID as the name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The entity to use for the run. This allows you to set the team or username of the WandB user that you would<br/>
        /// like associated with the run. If not set, the default entity for the registered WandB API key is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public string? Entity { get; set; }

        /// <summary>
        /// A list of tags to be attached to the newly created run. These tags are passed through directly to WandB. Some<br/>
        /// default tags are generated by OpenAI: "openai/finetune", "openai/{base-model}", "openai/{ftjob-abcdef}".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningIntegrationWandb" /> class.
        /// </summary>
        /// <param name="project">
        /// The name of the project that the new run will be created under.<br/>
        /// Example: my-wandb-project
        /// </param>
        /// <param name="name">
        /// A display name to set for the run. If not set, we will use the Job ID as the name.
        /// </param>
        /// <param name="entity">
        /// The entity to use for the run. This allows you to set the team or username of the WandB user that you would<br/>
        /// like associated with the run. If not set, the default entity for the registered WandB API key is used.
        /// </param>
        /// <param name="tags">
        /// A list of tags to be attached to the newly created run. These tags are passed through directly to WandB. Some<br/>
        /// default tags are generated by OpenAI: "openai/finetune", "openai/{base-model}", "openai/{ftjob-abcdef}".
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuningIntegrationWandb(
            string project,
            string? name,
            string? entity,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Name = name;
            this.Entity = entity;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningIntegrationWandb" /> class.
        /// </summary>
        public FineTuningIntegrationWandb()
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
        public static global::G.FineTuningIntegrationWandb? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.FineTuningIntegrationWandb),
                jsonSerializerContext) as global::G.FineTuningIntegrationWandb;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.FineTuningIntegrationWandb? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.FineTuningIntegrationWandb>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.FineTuningIntegrationWandb?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.FineTuningIntegrationWandb),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.FineTuningIntegrationWandb;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.FineTuningIntegrationWandb?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.FineTuningIntegrationWandb?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}