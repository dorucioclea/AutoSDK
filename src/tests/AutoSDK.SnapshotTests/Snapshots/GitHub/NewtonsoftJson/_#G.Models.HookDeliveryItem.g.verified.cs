﻿//HintName: G.Models.HookDeliveryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delivery made by a webhook, without request and response information.
    /// </summary>
    public sealed partial class HookDeliveryItem
    {
        /// <summary>
        /// Unique identifier of the webhook delivery.<br/>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event).<br/>
        /// Example: 58474f00-b361-11eb-836d-0e4f3503ccbe
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Guid { get; set; } = default!;

        /// <summary>
        /// Time when the webhook delivery occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delivered_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime DeliveredAt { get; set; } = default!;

        /// <summary>
        /// Whether the webhook delivery is a redelivery.<br/>
        /// Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redelivery", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Redelivery { get; set; } = default!;

        /// <summary>
        /// Time spent delivering.<br/>
        /// Example: 0.03
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Describes the response returned after attempting the delivery.<br/>
        /// Example: failed to connect
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Status code received when delivery was made.<br/>
        /// Example: 502
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// The event that triggered the delivery.<br/>
        /// Example: issues
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// The type of activity for the event that triggered the delivery.<br/>
        /// Example: opened
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Action { get; set; } = default!;

        /// <summary>
        /// The id of the GitHub App installation associated with this event.<br/>
        /// Example: 123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("installation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? InstallationId { get; set; } = default!;

        /// <summary>
        /// The id of the repository associated with this event.<br/>
        /// Example: 123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? RepositoryId { get; set; } = default!;

        /// <summary>
        /// Time when the webhook delivery was throttled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("throttled_at")]
        public global::System.DateTime? ThrottledAt { get; set; }

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
        public static global::G.HookDeliveryItem? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.HookDeliveryItem>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.HookDeliveryItem?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.HookDeliveryItem?>(serializer.Deserialize<global::G.HookDeliveryItem>(jsonReader));
        }

    }
}