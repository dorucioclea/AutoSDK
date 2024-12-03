﻿//HintName: G.Models.SnoozeNextAdResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnoozeNextAdResponseDataItem
    {
        /// <summary>
        /// The number of snoozes available for the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snooze_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int SnoozeCount { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp when the broadcaster will gain an additional snooze, in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snooze_refresh_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime SnoozeRefreshAt { get; set; } = default!;

        /// <summary>
        /// The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_ad_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime NextAdAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeNextAdResponseDataItem" /> class.
        /// </summary>
        /// <param name="snoozeCount">
        /// The number of snoozes available for the broadcaster.
        /// </param>
        /// <param name="snoozeRefreshAt">
        /// The UTC timestamp when the broadcaster will gain an additional snooze, in RFC3339 format.
        /// </param>
        /// <param name="nextAdAt">
        /// The UTC timestamp of the broadcaster’s next scheduled ad, in RFC3339 format.
        /// </param>
        public SnoozeNextAdResponseDataItem(
            int snoozeCount,
            global::System.DateTime snoozeRefreshAt,
            global::System.DateTime nextAdAt)
        {
            this.SnoozeCount = snoozeCount;
            this.SnoozeRefreshAt = snoozeRefreshAt;
            this.NextAdAt = nextAdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnoozeNextAdResponseDataItem" /> class.
        /// </summary>
        public SnoozeNextAdResponseDataItem()
        {
        }
    }
}