﻿//HintName: G.Models.ConnectorLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorLog
    {
        /// <summary>
        /// Unique identifier for the connector log
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectorId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// Time of connector log creation in RFC3339 format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// HTTP status code of the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Duration of the request in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_millis", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMillis { get; set; } = default!;

        /// <summary>
        /// Error message of the request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorLog" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the connector log
        /// </param>
        /// <param name="connectorId">
        /// Unique identifier for the connector
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="userId">
        /// Unique identifier for the user
        /// </param>
        /// <param name="organizationId">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="createdAt">
        /// Time of connector log creation in RFC3339 format
        /// </param>
        /// <param name="statusCode">
        /// HTTP status code of the request
        /// </param>
        /// <param name="durationMillis">
        /// Duration of the request in milliseconds
        /// </param>
        /// <param name="errorMessage">
        /// Error message of the request
        /// </param>
        public ConnectorLog(
            string id,
            string connectorId,
            string requestId,
            string userId,
            string organizationId,
            global::System.DateTime createdAt,
            int statusCode,
            int durationMillis,
            string? errorMessage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CreatedAt = createdAt;
            this.StatusCode = statusCode;
            this.DurationMillis = durationMillis;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorLog" /> class.
        /// </summary>
        public ConnectorLog()
        {
        }


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
        public static global::G.ConnectorLog? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ConnectorLog>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ConnectorLog?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ConnectorLog?>(serializer.Deserialize<global::G.ConnectorLog>(jsonReader));
        }

    }
}