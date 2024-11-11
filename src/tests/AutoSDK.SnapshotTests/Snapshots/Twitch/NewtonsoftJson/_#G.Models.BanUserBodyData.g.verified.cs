﻿//HintName: G.Models.BanUserBodyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifies the user and type of ban.
    /// </summary>
    public sealed partial class BanUserBodyData
    {
        /// <summary>
        /// The ID of the user to ban or put in a timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// To ban a user indefinitely, don’t include this field.  <br/>
        ///   <br/>
        /// To put a user in a timeout, include this field and specify the timeout period, in seconds. The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).  <br/>
        ///   <br/>
        /// To end a user’s timeout early, set this field to 1, or use the [Unban user](https://dev.twitch.tv/docs/api/reference#unban-user) endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// The reason the you’re banning the user or putting them in a timeout. The text is user defined and is limited to a maximum of 500 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserBodyData" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user to ban or put in a timeout.
        /// </param>
        /// <param name="duration">
        /// To ban a user indefinitely, don’t include this field.  <br/>
        ///   <br/>
        /// To put a user in a timeout, include this field and specify the timeout period, in seconds. The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).  <br/>
        ///   <br/>
        /// To end a user’s timeout early, set this field to 1, or use the [Unban user](https://dev.twitch.tv/docs/api/reference#unban-user) endpoint.
        /// </param>
        /// <param name="reason">
        /// The reason the you’re banning the user or putting them in a timeout. The text is user defined and is limited to a maximum of 500 characters.
        /// </param>
        public BanUserBodyData(
            string userId,
            int? duration,
            string? reason)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Duration = duration;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserBodyData" /> class.
        /// </summary>
        public BanUserBodyData()
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
        public static global::G.BanUserBodyData? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.BanUserBodyData>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.BanUserBodyData?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.BanUserBodyData?>(serializer.Deserialize<global::G.BanUserBodyData>(jsonReader));
        }

    }
}