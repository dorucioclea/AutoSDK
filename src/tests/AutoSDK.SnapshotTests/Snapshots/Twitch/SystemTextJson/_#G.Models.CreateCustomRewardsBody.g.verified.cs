﻿//HintName: G.Models.CreateCustomRewardsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCustomRewardsBody
    {
        /// <summary>
        /// The custom reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The cost of the reward, in Channel Points. The minimum is 1 point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Cost { get; set; }

        /// <summary>
        /// The prompt shown to the viewer when they redeem the reward. Specify a prompt if `is_user_input_required` is **true**. The prompt is limited to a maximum of 200 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the reward is enabled. Viewers see only enabled rewards. The default is **true**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// The background color to use for the reward. Specify the color using Hex format (for example, #9147FF).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the user needs to enter information when redeeming the reward. See the `prompt` field. The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_user_input_required")]
        public bool? IsUserInputRequired { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the `max_per_stream` field). The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_max_per_stream_enabled")]
        public bool? IsMaxPerStreamEnabled { get; set; }

        /// <summary>
        /// The maximum number of redemptions allowed per live stream. Applied only if `is_max_per_stream_enabled` is **true**. The minimum value is 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_stream")]
        public int? MaxPerStream { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see the `max_per_user_per_stream` field). The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_max_per_user_per_stream_enabled")]
        public bool? IsMaxPerUserPerStreamEnabled { get; set; }

        /// <summary>
        /// The maximum number of redemptions allowed per user per stream. Applied only if `is_max_per_user_per_stream_enabled` is **true**. The minimum value is 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_per_user_per_stream")]
        public int? MaxPerUserPerStream { get; set; }

        /// <summary>
        /// A Boolean value that determines whether to apply a cooldown period between redemptions (see the `global_cooldown_seconds` field for the duration of the cooldown period). The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_global_cooldown_enabled")]
        public bool? IsGlobalCooldownEnabled { get; set; }

        /// <summary>
        /// The cooldown period, in seconds. Applied only if the `is_global_cooldown_enabled` field is **true**. The minimum value is 1; however, the minimum value is 60 for it to be shown in the Twitch UX.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_cooldown_seconds")]
        public int? GlobalCooldownSeconds { get; set; }

        /// <summary>
        /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process. The default is **false**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_redemptions_skip_request_queue")]
        public bool? ShouldRedemptionsSkipRequestQueue { get; set; }

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

        public static global::G.CreateCustomRewardsBody? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CreateCustomRewardsBody),
                jsonSerializerContext) as global::G.CreateCustomRewardsBody;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CreateCustomRewardsBody? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateCustomRewardsBody>(
                json,
                jsonSerializerOptions);
        }

    }
}