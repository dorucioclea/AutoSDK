﻿//HintName: G.Models.CustomRewardGlobalCooldownSetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.
    /// </summary>
    public sealed partial class CustomRewardGlobalCooldownSetting
    {
        /// <summary>
        /// A Boolean value that determines whether to apply a cooldown period. Is **true** if a cooldown period is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsEnabled { get; set; } = default!;

        /// <summary>
        /// The cooldown period, in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("global_cooldown_seconds", Required = global::Newtonsoft.Json.Required.Always)]
        public long GlobalCooldownSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardGlobalCooldownSetting" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// A Boolean value that determines whether to apply a cooldown period. Is **true** if a cooldown period is enabled.
        /// </param>
        /// <param name="globalCooldownSeconds">
        /// The cooldown period, in seconds.
        /// </param>
        public CustomRewardGlobalCooldownSetting(
            bool isEnabled,
            long globalCooldownSeconds)
        {
            this.IsEnabled = isEnabled;
            this.GlobalCooldownSeconds = globalCooldownSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRewardGlobalCooldownSetting" /> class.
        /// </summary>
        public CustomRewardGlobalCooldownSetting()
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
        public static global::G.CustomRewardGlobalCooldownSetting? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CustomRewardGlobalCooldownSetting>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CustomRewardGlobalCooldownSetting?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CustomRewardGlobalCooldownSetting?>(serializer.Deserialize<global::G.CustomRewardGlobalCooldownSetting>(jsonReader));
        }

    }
}