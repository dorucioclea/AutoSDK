﻿//HintName: G.Models.CreateModerationRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModerationRequest
    {
        /// <summary>
        /// The input text to classify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// Two content moderations models are available: `text-moderation-stable` and `text-moderation-latest`.<br/>
        /// The default is `text-moderation-latest` which will be automatically upgraded over time. This ensures you are always using our most accurate model. If you use `text-moderation-stable`, we will provide advanced notice before updating the model. Accuracy of `text-moderation-stable` may be slightly lower than for `text-moderation-latest`.<br/>
        /// Default Value: text-moderation-latest<br/>
        /// Example: text-moderation-stable
        /// </summary>
        /// <example>text-moderation-stable</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::G.CreateModerationRequestModel?>))]
        public global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The input text to classify
        /// </param>
        /// <param name="model">
        /// Two content moderations models are available: `text-moderation-stable` and `text-moderation-latest`.<br/>
        /// The default is `text-moderation-latest` which will be automatically upgraded over time. This ensures you are always using our most accurate model. If you use `text-moderation-stable`, we will provide advanced notice before updating the model. Accuracy of `text-moderation-stable` may be slightly lower than for `text-moderation-latest`.<br/>
        /// Default Value: text-moderation-latest<br/>
        /// Example: text-moderation-stable
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateModerationRequest(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? model)
        {
            this.Input = input;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequest" /> class.
        /// </summary>
        public CreateModerationRequest()
        {
        }
    }
}