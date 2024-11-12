﻿//HintName: G.Models.CreateChannelStreamScheduleSegmentResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The broadcaster’s streaming scheduled.
    /// </summary>
    public sealed partial class CreateChannelStreamScheduleSegmentResponseData
    {
        /// <summary>
        /// A list that contains the single broadcast segment that you added.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChannelStreamScheduleSegment> Segments { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster that owns the broadcast schedule.
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
        /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vacation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateChannelStreamScheduleSegmentResponseDataVacation Vacation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentResponseData" /> class.
        /// </summary>
        /// <param name="segments">
        /// A list that contains the single broadcast segment that you added.
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that owns the broadcast schedule.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="vacation">
        /// The dates when the broadcaster is on vacation and not streaming. Is set to **null** if vacation mode is not enabled.
        /// </param>
        public CreateChannelStreamScheduleSegmentResponseData(
            global::System.Collections.Generic.IList<global::G.ChannelStreamScheduleSegment> segments,
            string broadcasterId,
            string broadcasterName,
            string broadcasterLogin,
            global::G.CreateChannelStreamScheduleSegmentResponseDataVacation vacation)
        {
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.Vacation = vacation ?? throw new global::System.ArgumentNullException(nameof(vacation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChannelStreamScheduleSegmentResponseData" /> class.
        /// </summary>
        public CreateChannelStreamScheduleSegmentResponseData()
        {
        }
    }
}