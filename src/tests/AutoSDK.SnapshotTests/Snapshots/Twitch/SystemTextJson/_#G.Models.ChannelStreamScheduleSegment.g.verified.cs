﻿//HintName: G.Models.ChannelStreamScheduleSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelStreamScheduleSegment
    {
        /// <summary>
        /// An ID that identifies this broadcast segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcast starts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the broadcast ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// The broadcast segment’s title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Indicates whether the broadcaster canceled this segment of a recurring broadcast. If the broadcaster canceled this segment, this field is set to the same value that’s in the `end_time` field; otherwise, it’s set to **null**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled_until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CanceledUntil { get; set; }

        /// <summary>
        /// The type of content that the broadcaster plans to stream or **null** if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChannelStreamScheduleSegmentCategory Category { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcast is part of a recurring series that streams at the same time each week or is a one-time broadcast. Is **true** if the broadcast is part of a recurring series.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_recurring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRecurring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStreamScheduleSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that identifies this broadcast segment.
        /// </param>
        /// <param name="startTime">
        /// The UTC date and time (in RFC3339 format) of when the broadcast starts.
        /// </param>
        /// <param name="endTime">
        /// The UTC date and time (in RFC3339 format) of when the broadcast ends.
        /// </param>
        /// <param name="title">
        /// The broadcast segment’s title.
        /// </param>
        /// <param name="canceledUntil">
        /// Indicates whether the broadcaster canceled this segment of a recurring broadcast. If the broadcaster canceled this segment, this field is set to the same value that’s in the `end_time` field; otherwise, it’s set to **null**.
        /// </param>
        /// <param name="category">
        /// The type of content that the broadcaster plans to stream or **null** if not specified.
        /// </param>
        /// <param name="isRecurring">
        /// A Boolean value that determines whether the broadcast is part of a recurring series that streams at the same time each week or is a one-time broadcast. Is **true** if the broadcast is part of a recurring series.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChannelStreamScheduleSegment(
            string id,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string title,
            string? canceledUntil,
            global::G.ChannelStreamScheduleSegmentCategory category,
            bool isRecurring)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.CanceledUntil = canceledUntil ?? throw new global::System.ArgumentNullException(nameof(canceledUntil));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.IsRecurring = isRecurring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelStreamScheduleSegment" /> class.
        /// </summary>
        public ChannelStreamScheduleSegment()
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
        public static global::G.ChannelStreamScheduleSegment? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ChannelStreamScheduleSegment),
                jsonSerializerContext) as global::G.ChannelStreamScheduleSegment;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ChannelStreamScheduleSegment? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChannelStreamScheduleSegment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ChannelStreamScheduleSegment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ChannelStreamScheduleSegment),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ChannelStreamScheduleSegment;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ChannelStreamScheduleSegment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ChannelStreamScheduleSegment?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}