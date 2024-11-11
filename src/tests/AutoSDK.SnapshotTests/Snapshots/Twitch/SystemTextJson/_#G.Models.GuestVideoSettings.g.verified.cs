﻿//HintName: G.Models.GuestVideoSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the guest’s video settings
    /// </summary>
    public sealed partial class GuestVideoSettings
    {
        /// <summary>
        /// Flag determining whether the host is allowing the guest’s video to be seen or heard within the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_host_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHostEnabled { get; set; }

        /// <summary>
        /// Flag determining whether the guest is allowing their video to be transmitted to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_guest_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsGuestEnabled { get; set; }

        /// <summary>
        /// Flag determining whether the guest has an appropriate video device available to be transmitted to the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAvailable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestVideoSettings" /> class.
        /// </summary>
        /// <param name="isHostEnabled">
        /// Flag determining whether the host is allowing the guest’s video to be seen or heard within the session.
        /// </param>
        /// <param name="isGuestEnabled">
        /// Flag determining whether the guest is allowing their video to be transmitted to the session.
        /// </param>
        /// <param name="isAvailable">
        /// Flag determining whether the guest has an appropriate video device available to be transmitted to the session.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GuestVideoSettings(
            bool isHostEnabled,
            bool isGuestEnabled,
            bool isAvailable)
        {
            this.IsHostEnabled = isHostEnabled;
            this.IsGuestEnabled = isGuestEnabled;
            this.IsAvailable = isAvailable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuestVideoSettings" /> class.
        /// </summary>
        public GuestVideoSettings()
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
        public static global::G.GuestVideoSettings? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GuestVideoSettings),
                jsonSerializerContext) as global::G.GuestVideoSettings;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GuestVideoSettings? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GuestVideoSettings>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.GuestVideoSettings?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.GuestVideoSettings),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.GuestVideoSettings;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GuestVideoSettings?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.GuestVideoSettings?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}