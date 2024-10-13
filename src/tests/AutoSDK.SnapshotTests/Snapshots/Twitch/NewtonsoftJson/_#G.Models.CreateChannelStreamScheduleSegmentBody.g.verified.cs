﻿//HintName: G.Models.CreateChannelStreamScheduleSegmentBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChannelStreamScheduleSegmentBody
    {
        /// <summary>
        /// The date and time that the broadcast segment starts. Specify the date and time in RFC3339 format (for example, 2021-07-01T18:00:00Z).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// The time zone where the broadcast takes place. Specify the time zone using [IANA time zone database](https://www.iana.org/time-zones) format (for example, America/New\_York).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timezone { get; set; } = default!;

        /// <summary>
        /// The length of time, in minutes, that the broadcast is scheduled to run. The duration must be in the range 30 through 1380 (23 hours).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public string Duration { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the broadcast recurs weekly. Is **true** if the broadcast recurs weekly. Only partners and affiliates may add non-recurring broadcasts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_recurring")]
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// The ID of the category that best represents the broadcast’s content. To get the category ID, use the [Search Categories](https://dev.twitch.tv/docs/api/reference#search-categories) endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category_id")]
        public string? CategoryId { get; set; }

        /// <summary>
        /// The broadcast’s title. The title may contain a maximum of 140 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateChannelStreamScheduleSegmentBody? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateChannelStreamScheduleSegmentBody>(
                json,
                jsonSerializerOptions);
        }

    }
}