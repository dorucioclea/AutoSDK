﻿//HintName: G.Models.ListAuditLogsEffectiveAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAuditLogsEffectiveAt
    {
        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is greater than this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gt")]
        public int? Gt { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is greater than or equal to this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gte")]
        public int? Gte { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is less than this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lt")]
        public int? Lt { get; set; }

        /// <summary>
        /// Return only events whose `effective_at` (Unix seconds) is less than or equal to this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lte")]
        public int? Lte { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsEffectiveAt" /> class.
        /// </summary>
        /// <param name="gt">
        /// Return only events whose `effective_at` (Unix seconds) is greater than this value.
        /// </param>
        /// <param name="gte">
        /// Return only events whose `effective_at` (Unix seconds) is greater than or equal to this value.
        /// </param>
        /// <param name="lt">
        /// Return only events whose `effective_at` (Unix seconds) is less than this value.
        /// </param>
        /// <param name="lte">
        /// Return only events whose `effective_at` (Unix seconds) is less than or equal to this value.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListAuditLogsEffectiveAt(
            int? gt,
            int? gte,
            int? lt,
            int? lte)
        {
            this.Gt = gt;
            this.Gte = gte;
            this.Lt = lt;
            this.Lte = lte;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuditLogsEffectiveAt" /> class.
        /// </summary>
        public ListAuditLogsEffectiveAt()
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
        public static global::G.ListAuditLogsEffectiveAt? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ListAuditLogsEffectiveAt),
                jsonSerializerContext) as global::G.ListAuditLogsEffectiveAt;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ListAuditLogsEffectiveAt? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListAuditLogsEffectiveAt>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ListAuditLogsEffectiveAt?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ListAuditLogsEffectiveAt),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ListAuditLogsEffectiveAt;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ListAuditLogsEffectiveAt?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ListAuditLogsEffectiveAt?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}