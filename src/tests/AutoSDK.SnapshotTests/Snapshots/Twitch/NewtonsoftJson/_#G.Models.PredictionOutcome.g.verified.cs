﻿//HintName: G.Models.PredictionOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionOutcome
    {
        /// <summary>
        /// An ID that identifies this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The outcome’s text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The number of unique viewers that chose this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public int Users { get; set; } = default!;

        /// <summary>
        /// The number of Channel Points spent by viewers on this outcome.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPoints { get; set; } = default!;

        /// <summary>
        /// A list of viewers who were the top predictors; otherwise, **null** if none.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_predictors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PredictionOutcomeTopPredictor>? TopPredictors { get; set; } = default!;

        /// <summary>
        /// The color that visually identifies this outcome in the UX. Possible values are:  <br/>
        ///   <br/>
        /// * BLUE<br/>
        /// * PINK<br/>
        ///   <br/>
        /// If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PredictionOutcomeColor Color { get; set; } = default!;

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
        public static global::G.PredictionOutcome? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PredictionOutcome>(
                json,
                jsonSerializerOptions);
        }

    }
}