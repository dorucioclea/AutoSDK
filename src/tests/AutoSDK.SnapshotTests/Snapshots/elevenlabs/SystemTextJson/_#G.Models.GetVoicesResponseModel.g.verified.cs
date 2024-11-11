﻿//HintName: G.Models.GetVoicesResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VoiceResponseModel> Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseModel" /> class.
        /// </summary>
        /// <param name="voices"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetVoicesResponseModel(
            global::System.Collections.Generic.IList<global::G.VoiceResponseModel> voices)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponseModel" /> class.
        /// </summary>
        public GetVoicesResponseModel()
        {
        }
    }
}