﻿//HintName: G.Models.ActionsBillingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsBillingUsage
    {
        /// <summary>
        /// The sum of the free and paid GitHub Actions minutes used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_minutes_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalMinutesUsed { get; set; }

        /// <summary>
        /// The total paid GitHub Actions minutes used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_paid_minutes_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPaidMinutesUsed { get; set; }

        /// <summary>
        /// The amount of free GitHub Actions minutes available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IncludedMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes_used_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActionsBillingUsageMinutesUsedBreakdown MinutesUsedBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsBillingUsage" /> class.
        /// </summary>
        /// <param name="totalMinutesUsed">
        /// The sum of the free and paid GitHub Actions minutes used.
        /// </param>
        /// <param name="totalPaidMinutesUsed">
        /// The total paid GitHub Actions minutes used.
        /// </param>
        /// <param name="includedMinutes">
        /// The amount of free GitHub Actions minutes available.
        /// </param>
        /// <param name="minutesUsedBreakdown"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsBillingUsage(
            int totalMinutesUsed,
            int totalPaidMinutesUsed,
            int includedMinutes,
            global::G.ActionsBillingUsageMinutesUsedBreakdown minutesUsedBreakdown)
        {
            this.TotalMinutesUsed = totalMinutesUsed;
            this.TotalPaidMinutesUsed = totalPaidMinutesUsed;
            this.IncludedMinutes = includedMinutes;
            this.MinutesUsedBreakdown = minutesUsedBreakdown ?? throw new global::System.ArgumentNullException(nameof(minutesUsedBreakdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsBillingUsage" /> class.
        /// </summary>
        public ActionsBillingUsage()
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
        public static global::G.ActionsBillingUsage? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ActionsBillingUsage),
                jsonSerializerContext) as global::G.ActionsBillingUsage;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ActionsBillingUsage? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ActionsBillingUsage>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ActionsBillingUsage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ActionsBillingUsage),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ActionsBillingUsage;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ActionsBillingUsage?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ActionsBillingUsage?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}