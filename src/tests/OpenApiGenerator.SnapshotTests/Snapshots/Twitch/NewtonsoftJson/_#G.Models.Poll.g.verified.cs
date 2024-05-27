﻿//HintName: G.Models.Poll.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Poll
    {
        /// <summary>
        /// An ID that identifies the poll.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the broadcaster that created the poll.
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
        /// The question that viewers are voting on. For example, _What game should I play next?_ The title may contain a maximum of 60 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A list of choices that viewers can choose from. The list will contain a minimum of two choices and up to a maximum of five choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<PollChoices> Choices { get; set; } = default!;

        /// <summary>
        /// Not used; will be set to **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bits_voting_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool BitsVotingEnabled { get; set; } = default!;

        /// <summary>
        /// Not used; will be set to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bits_per_vote", Required = global::Newtonsoft.Json.Required.Always)]
        public int BitsPerVote { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_voting_enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ChannelPointsVotingEnabled { get; set; } = default!;

        /// <summary>
        /// The number of points the viewer must spend to cast one additional vote.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel_points_per_vote", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChannelPointsPerVote { get; set; } = default!;

        /// <summary>
        /// The poll’s status. Valid values are:  
        ///   
        /// * ACTIVE — The poll is running.
        /// * COMPLETED — The poll ended on schedule (see the `duration` field).
        /// * TERMINATED — The poll was terminated before its scheduled end.
        /// * ARCHIVED — The poll has been archived and is no longer visible on the channel.
        /// * MODERATED — The poll was deleted.
        /// * INVALID — Something went wrong while determining the state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public PollStatus Status { get; set; } = default!;

        /// <summary>
        /// The length of time (in seconds) that the poll will run for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the poll began.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) of when the poll ended. If `status` is ACTIVE, this field is set to **null**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? EndedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}