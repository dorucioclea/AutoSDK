﻿//HintName: G.Models.OrgHook.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Org Hook
    /// </summary>
    public sealed partial class OrgHook
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat/hooks/1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat/hooks/1/pings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ping_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PingUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/octocat/hooks/1/deliveries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveries_url")]
        public string? DeliveriesUrl { get; set; }

        /// <summary>
        /// Example: web
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: [push, pull_request]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OrgHookConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgHook" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/octocat/hooks/1
        /// </param>
        /// <param name="pingUrl">
        /// Example: https://api.github.com/orgs/octocat/hooks/1/pings
        /// </param>
        /// <param name="deliveriesUrl">
        /// Example: https://api.github.com/orgs/octocat/hooks/1/deliveries
        /// </param>
        /// <param name="name">
        /// Example: web
        /// </param>
        /// <param name="events">
        /// Example: [push, pull_request]
        /// </param>
        /// <param name="active">
        /// Example: true
        /// </param>
        /// <param name="config"></param>
        /// <param name="updatedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrgHook(
            int id,
            string url,
            string pingUrl,
            string name,
            global::System.Collections.Generic.IList<string> events,
            bool active,
            global::G.OrgHookConfig config,
            global::System.DateTime updatedAt,
            global::System.DateTime createdAt,
            string type,
            string? deliveriesUrl)
        {
            this.Id = id;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PingUrl = pingUrl ?? throw new global::System.ArgumentNullException(nameof(pingUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Active = active;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.UpdatedAt = updatedAt;
            this.CreatedAt = createdAt;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DeliveriesUrl = deliveriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgHook" /> class.
        /// </summary>
        public OrgHook()
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
        public static global::G.OrgHook? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.OrgHook),
                jsonSerializerContext) as global::G.OrgHook;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OrgHook? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.OrgHook>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.OrgHook?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.OrgHook),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.OrgHook;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.OrgHook?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.OrgHook?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}