﻿//HintName: G.Models.CreatePollRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePollRequest
    {
        /// <summary>
        /// The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BroadcasterId { get; set; }

        /// <summary>
        /// The question that viewers will vote on. For example, _What game should I play next?_ The question may contain a maximum of 60 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A list of choices that viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 5 choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<CreatePollRequestChoices> Choices { get; set; }

        /// <summary>
        /// The length of time (in seconds) that the poll will run for. The minimum is 15 seconds and the maximum is 1800 seconds (30 minutes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. If **true**, the viewer may cast more than one vote but each additional vote costs the number of Channel Points specified in `channel_points_per_vote`. The default is **false** (viewers may cast only one vote). For information about Channel Points, see [Channel Points Guide](https://help.twitch.tv/s/article/channel-points-guide).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points_voting_enabled")]
        public bool ChannelPointsVotingEnabled { get; set; }

        /// <summary>
        /// The number of points that the viewer must spend to cast one additional vote. The minimum is 1 and the maximum is 1000000\. Set only if `ChannelPointsVotingEnabled` is **true**.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_points_per_vote")]
        public int ChannelPointsPerVote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}