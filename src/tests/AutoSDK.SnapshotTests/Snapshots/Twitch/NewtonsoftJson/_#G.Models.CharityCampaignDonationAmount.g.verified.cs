﻿//HintName: G.Models.CharityCampaignDonationAmount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the amount of money that the user donated.
    /// </summary>
    public sealed partial class CharityCampaignDonationAmount
    {
        /// <summary>
        /// The monetary amount. The amount is specified in the currency’s minor unit. For example, the minor units for USD is cents, so if the amount is $5.50 USD, `value` is set to 550.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public int Value { get; set; } = default!;

        /// <summary>
        /// The number of decimal places used by the currency. For example, USD uses two decimal places. Use this number to translate `value` from minor units to major units by using the formula:  <br/>
        ///   <br/>
        /// `value / 10^decimal_places`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("decimal_places", Required = global::Newtonsoft.Json.Required.Always)]
        public int DecimalPlaces { get; set; } = default!;

        /// <summary>
        /// The ISO-4217 three-letter currency code that identifies the type of currency in `value`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currency", Required = global::Newtonsoft.Json.Required.Always)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharityCampaignDonationAmount" /> class.
        /// </summary>
        /// <param name="value">
        /// The monetary amount. The amount is specified in the currency’s minor unit. For example, the minor units for USD is cents, so if the amount is $5.50 USD, `value` is set to 550.
        /// </param>
        /// <param name="decimalPlaces">
        /// The number of decimal places used by the currency. For example, USD uses two decimal places. Use this number to translate `value` from minor units to major units by using the formula:  <br/>
        ///   <br/>
        /// `value / 10^decimal_places`
        /// </param>
        /// <param name="currency">
        /// The ISO-4217 three-letter currency code that identifies the type of currency in `value`.
        /// </param>
        public CharityCampaignDonationAmount(
            int value,
            int decimalPlaces,
            string currency)
        {
            this.Value = value;
            this.DecimalPlaces = decimalPlaces;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharityCampaignDonationAmount" /> class.
        /// </summary>
        public CharityCampaignDonationAmount()
        {
        }
    }
}