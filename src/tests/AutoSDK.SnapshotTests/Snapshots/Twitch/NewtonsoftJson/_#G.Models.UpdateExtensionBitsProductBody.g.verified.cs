﻿//HintName: G.Models.UpdateExtensionBitsProductBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExtensionBitsProductBody
    {
        /// <summary>
        /// The product's SKU. The SKU must be unique within an extension. The product's SKU cannot be changed. The SKU may contain only alphanumeric characters, dashes (-), underscores (\_), and periods (.) and is limited to a maximum of 255 characters. No spaces.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sku", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sku { get; set; } = default!;

        /// <summary>
        /// An object that contains the product's cost information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UpdateExtensionBitsProductBodyCost Cost { get; set; } = default!;

        /// <summary>
        /// The product's name as displayed in the extension. The maximum length is 255 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether the product is in development. Set to **true** if the product is in development and not available for public use. The default is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("in_development")]
        public bool? InDevelopment { get; set; }

        /// <summary>
        /// The date and time, in RFC3339 format, when the product expires. If not set, the product does not expire. To disable the product, set the expiration date to a date in the past.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiration")]
        public global::System.DateTime? Expiration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of the extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. The default is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_broadcast")]
        public bool? IsBroadcast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtensionBitsProductBody" /> class.
        /// </summary>
        /// <param name="sku">
        /// The product's SKU. The SKU must be unique within an extension. The product's SKU cannot be changed. The SKU may contain only alphanumeric characters, dashes (-), underscores (\_), and periods (.) and is limited to a maximum of 255 characters. No spaces.
        /// </param>
        /// <param name="cost">
        /// An object that contains the product's cost information.
        /// </param>
        /// <param name="displayName">
        /// The product's name as displayed in the extension. The maximum length is 255 characters.
        /// </param>
        /// <param name="inDevelopment">
        /// A Boolean value that indicates whether the product is in development. Set to **true** if the product is in development and not available for public use. The default is **false**.
        /// </param>
        /// <param name="expiration">
        /// The date and time, in RFC3339 format, when the product expires. If not set, the product does not expire. To disable the product, set the expiration date to a date in the past.
        /// </param>
        /// <param name="isBroadcast">
        /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of the extension on a channel. The events are broadcast via the `onTransactionComplete` helper callback. The default is **false**.
        /// </param>
        public UpdateExtensionBitsProductBody(
            string sku,
            global::G.UpdateExtensionBitsProductBodyCost cost,
            string displayName,
            bool? inDevelopment,
            global::System.DateTime? expiration,
            bool? isBroadcast)
        {
            this.Sku = sku ?? throw new global::System.ArgumentNullException(nameof(sku));
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.InDevelopment = inDevelopment;
            this.Expiration = expiration;
            this.IsBroadcast = isBroadcast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExtensionBitsProductBody" /> class.
        /// </summary>
        public UpdateExtensionBitsProductBody()
        {
        }
    }
}