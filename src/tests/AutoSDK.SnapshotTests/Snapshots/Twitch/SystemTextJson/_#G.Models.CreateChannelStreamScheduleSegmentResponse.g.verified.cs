﻿//HintName: G.Models.CreateChannelStreamScheduleSegmentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChannelStreamScheduleSegmentResponse
    {
        /// <summary>
        /// The broadcaster’s streaming scheduled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateChannelStreamScheduleSegmentResponseData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The broadcaster’s streaming scheduled.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateChannelStreamScheduleSegmentResponse(
            global::G.CreateChannelStreamScheduleSegmentResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentResponse" /> class.
        /// </summary>
        public CreateChannelStreamScheduleSegmentResponse()
        {
        }
    }
}