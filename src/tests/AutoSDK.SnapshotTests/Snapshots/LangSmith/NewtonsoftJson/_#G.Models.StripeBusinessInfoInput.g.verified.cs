﻿//HintName: G.Models.StripeBusinessInfoInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeBusinessInfoInput
    {
        /// <summary>
        /// Stripe customer billing information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company_info")]
        public global::G.StripeBusinessBillingInfo? CompanyInfo { get; set; }

        /// <summary>
        /// Stripe tax ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tax_id")]
        public global::G.StripeTaxId? TaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invoice_email")]
        public string? InvoiceEmail { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_business")]
        public bool? IsBusiness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessInfoInput" /> class.
        /// </summary>
        /// <param name="companyInfo">
        /// Stripe customer billing information.
        /// </param>
        /// <param name="taxId">
        /// Stripe tax ID.
        /// </param>
        /// <param name="invoiceEmail"></param>
        /// <param name="isBusiness">
        /// Default Value: false
        /// </param>
        public StripeBusinessInfoInput(
            global::G.StripeBusinessBillingInfo? companyInfo,
            global::G.StripeTaxId? taxId,
            string? invoiceEmail,
            bool? isBusiness)
        {
            this.CompanyInfo = companyInfo;
            this.TaxId = taxId;
            this.InvoiceEmail = invoiceEmail;
            this.IsBusiness = isBusiness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessInfoInput" /> class.
        /// </summary>
        public StripeBusinessInfoInput()
        {
        }
    }
}