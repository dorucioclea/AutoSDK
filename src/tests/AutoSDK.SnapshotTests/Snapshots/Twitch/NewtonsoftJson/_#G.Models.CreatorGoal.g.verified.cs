﻿//HintName: G.Models.CreatorGoal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatorGoal
    {
        /// <summary>
        /// An ID that identifies this goal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the broadcaster that created the goal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The type of goal. Possible values are:   <br/>
        ///   <br/>
        /// * follower — The goal is to increase followers.<br/>
        /// * subscription — The goal is to increase subscriptions. This type shows the net increase or decrease in tier points associated with the subscriptions.<br/>
        /// * subscription\_count — The goal is to increase subscriptions. This type shows the net increase or decrease in the number of subscriptions.<br/>
        /// * new\_subscription — The goal is to increase subscriptions. This type shows only the net increase in tier points associated with the subscriptions (it does not account for users that unsubscribed since the goal started).<br/>
        /// * new\_subscription\_count — The goal is to increase subscriptions. This type shows only the net increase in the number of subscriptions (it does not account for users that unsubscribed since the goal started).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreatorGoalType Type { get; set; } = default!;

        /// <summary>
        /// A description of the goal. Is an empty string if not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The goal’s current value.  <br/>
        ///   <br/>
        /// The goal’s `type` determines how this value is increased or decreased.   <br/>
        ///   <br/>
        /// * If `type` is follower, this field is set to the broadcaster's current number of followers. This number increases with new followers and decreases when users unfollow the broadcaster.<br/>
        /// * If `type` is subscription, this field is increased and decreased by the points value associated with the subscription tier. For example, if a tier-two subscription is worth 2 points, this field is increased or decreased by 2, not 1.<br/>
        /// * If `type` is subscription\_count, this field is increased by 1 for each new subscription and decreased by 1 for each user that unsubscribes.<br/>
        /// * If `type` is new\_subscription, this field is increased by the points value associated with the subscription tier. For example, if a tier-two subscription is worth 2 points, this field is increased by 2, not 1.<br/>
        /// * If `type` is new\_subscription\_count, this field is increased by 1 for each new subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int CurrentAmount { get; set; } = default!;

        /// <summary>
        /// The goal’s target value. For example, if the broadcaster has 200 followers before creating the goal, and their goal is to double that number, this field is set to 400.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_amount", Required = global::Newtonsoft.Json.Required.Always)]
        public int TargetAmount { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the broadcaster created the goal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

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
        public static global::G.CreatorGoal? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreatorGoal>(
                json,
                jsonSerializerOptions);
        }

    }
}