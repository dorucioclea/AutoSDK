﻿//HintName: G.Models.Guest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Guest
    {
        /// <summary>
        /// ID representing this guest’s slot assignment.   <br/>
        ///   <br/>
        /// * Host is always in slot "0"<br/>
        /// * Guests are assigned the following consecutive IDs (e.g, "1", "2", "3", etc)<br/>
        /// * Screen Share is represented as a special guest with the ID "SCREENSHARE"<br/>
        /// * The identifier here matches the ID referenced in browser source links used in broadcasting software.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlotId { get; set; }

        /// <summary>
        /// Flag determining whether or not the guest is visible in the browser source in the host’s streaming software.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_live")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLive { get; set; }

        /// <summary>
        /// User ID of the guest assigned to this slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Display name of the guest assigned to this slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserDisplayName { get; set; }

        /// <summary>
        /// Login of the guest assigned to this slot.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// Value from 0 to 100 representing the host’s volume setting for this guest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Volume { get; set; }

        /// <summary>
        /// Timestamp when this guest was assigned a slot in the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AssignedAt { get; set; }

        /// <summary>
        /// Information about the guest’s audio settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuestAudioSettings AudioSettings { get; set; }

        /// <summary>
        /// Information about the guest’s video settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GuestVideoSettings VideoSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.Guest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Guest),
                jsonSerializerContext) as global::G.Guest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Guest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Guest>(
                json,
                jsonSerializerOptions);
        }

    }
}