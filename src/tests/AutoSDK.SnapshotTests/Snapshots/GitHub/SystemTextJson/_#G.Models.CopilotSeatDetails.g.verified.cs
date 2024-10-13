﻿//HintName: G.Models.CopilotSeatDetails.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Information about a Copilot Business seat assignment for a user, team, or organization.
    /// </summary>
    public sealed partial class CopilotSeatDetails
    {
        /// <summary>
        /// The assignee that has been granted access to GitHub Copilot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverterFactory3))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.SimpleUser, global::G.Team, global::G.Organization> Assignee { get; set; }

        /// <summary>
        /// The team that granted access to GitHub Copilot to the assignee. This will be null if the user was assigned a seat individually.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigning_team")]
        public global::G.Team? AssigningTeam { get; set; }

        /// <summary>
        /// The pending cancellation date for the seat, in `YYYY-MM-DD` format. This will be null unless the assignee's Copilot access has been canceled during the current billing cycle. If the seat has been cancelled, this corresponds to the start of the organization's next billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_cancellation_date")]
        public global::System.DateTime? PendingCancellationDate { get; set; }

        /// <summary>
        /// Timestamp of user's last GitHub Copilot activity, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activity_at")]
        public global::System.DateTime? LastActivityAt { get; set; }

        /// <summary>
        /// Last editor that was used by the user for a GitHub Copilot completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_activity_editor")]
        public string? LastActivityEditor { get; set; }

        /// <summary>
        /// Timestamp of when the assignee was last granted access to GitHub Copilot, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the assignee's GitHub Copilot access was last updated, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
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

        public static global::G.CopilotSeatDetails? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CopilotSeatDetails),
                jsonSerializerContext) as global::G.CopilotSeatDetails;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CopilotSeatDetails? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CopilotSeatDetails>(
                json,
                jsonSerializerOptions);
        }

    }
}