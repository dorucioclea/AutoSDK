﻿//HintName: G.Models.UserSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserSubscription
    {
        /// <summary>
        /// An ID that identifies the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterLogin { get; set; } = default!;

        /// <summary>
        /// The broadcaster’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterName { get; set; } = default!;

        /// <summary>
        /// The ID of the user that gifted the subscription. The object includes this field only if `is_gift` is **true**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_id")]
        public string? GifterId { get; set; }

        /// <summary>
        /// The gifter’s login name. The object includes this field only if `is_gift` is **true**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_login")]
        public string? GifterLogin { get; set; }

        /// <summary>
        /// The gifter’s display name. The object includes this field only if `is_gift` is **true**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gifter_name")]
        public string? GifterName { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_gift", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsGift { get; set; } = default!;

        /// <summary>
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UserSubscriptionTier Tier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// An ID that identifies the broadcaster.
        /// </param>
        /// <param name="broadcasterLogin">
        /// The broadcaster’s login name.
        /// </param>
        /// <param name="broadcasterName">
        /// The broadcaster’s display name.
        /// </param>
        /// <param name="gifterId">
        /// The ID of the user that gifted the subscription. The object includes this field only if `is_gift` is **true**.
        /// </param>
        /// <param name="gifterLogin">
        /// The gifter’s login name. The object includes this field only if `is_gift` is **true**.
        /// </param>
        /// <param name="gifterName">
        /// The gifter’s display name. The object includes this field only if `is_gift` is **true**.
        /// </param>
        /// <param name="isGift">
        /// A Boolean value that determines whether the subscription is a gift subscription. Is **true** if the subscription was gifted.
        /// </param>
        /// <param name="tier">
        /// The type of subscription. Possible values are:  <br/>
        ///   <br/>
        /// * 1000 — Tier 1<br/>
        /// * 2000 — Tier 2<br/>
        /// * 3000 — Tier 3
        /// </param>
        public UserSubscription(
            string broadcasterId,
            string broadcasterLogin,
            string broadcasterName,
            bool isGift,
            global::G.UserSubscriptionTier tier,
            string? gifterId,
            string? gifterLogin,
            string? gifterName)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.BroadcasterLogin = broadcasterLogin ?? throw new global::System.ArgumentNullException(nameof(broadcasterLogin));
            this.BroadcasterName = broadcasterName ?? throw new global::System.ArgumentNullException(nameof(broadcasterName));
            this.IsGift = isGift;
            this.Tier = tier;
            this.GifterId = gifterId;
            this.GifterLogin = gifterLogin;
            this.GifterName = gifterName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        public UserSubscription()
        {
        }
    }
}