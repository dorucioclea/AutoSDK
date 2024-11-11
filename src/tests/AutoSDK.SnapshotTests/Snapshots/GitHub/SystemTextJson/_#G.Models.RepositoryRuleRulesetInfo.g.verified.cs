﻿//HintName: G.Models.RepositoryRuleRulesetInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
    /// </summary>
    public sealed partial class RepositoryRuleRulesetInfo
    {
        /// <summary>
        /// The type of source for the ruleset that includes this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleset_source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleRulesetInfoRulesetSourceTypeJsonConverter))]
        public global::G.RepositoryRuleRulesetInfoRulesetSourceType? RulesetSourceType { get; set; }

        /// <summary>
        /// The name of the source of the ruleset that includes this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleset_source")]
        public string? RulesetSource { get; set; }

        /// <summary>
        /// The ID of the ruleset that includes this rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleset_id")]
        public int? RulesetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRulesetInfo" /> class.
        /// </summary>
        /// <param name="rulesetSourceType">
        /// The type of source for the ruleset that includes this rule.
        /// </param>
        /// <param name="rulesetSource">
        /// The name of the source of the ruleset that includes this rule.
        /// </param>
        /// <param name="rulesetId">
        /// The ID of the ruleset that includes this rule.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleRulesetInfo(
            global::G.RepositoryRuleRulesetInfoRulesetSourceType? rulesetSourceType,
            string? rulesetSource,
            int? rulesetId)
        {
            this.RulesetSourceType = rulesetSourceType;
            this.RulesetSource = rulesetSource;
            this.RulesetId = rulesetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRulesetInfo" /> class.
        /// </summary>
        public RepositoryRuleRulesetInfo()
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
        public static global::G.RepositoryRuleRulesetInfo? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RepositoryRuleRulesetInfo),
                jsonSerializerContext) as global::G.RepositoryRuleRulesetInfo;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoryRuleRulesetInfo? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryRuleRulesetInfo>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.RepositoryRuleRulesetInfo?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.RepositoryRuleRulesetInfo),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.RepositoryRuleRulesetInfo;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryRuleRulesetInfo?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.RepositoryRuleRulesetInfo?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}