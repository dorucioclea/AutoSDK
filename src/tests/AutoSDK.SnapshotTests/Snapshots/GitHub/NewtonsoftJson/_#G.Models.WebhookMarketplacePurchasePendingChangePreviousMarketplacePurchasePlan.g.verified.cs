﻿//HintName: G.Models.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bullets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Bullets { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_free_trial", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasFreeTrial { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monthly_price_in_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int MonthlyPriceInCents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel PriceModel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? UnitName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("yearly_price_in_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int YearlyPriceInCents { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan" /> class.
        /// </summary>
        /// <param name="bullets"></param>
        /// <param name="description"></param>
        /// <param name="hasFreeTrial"></param>
        /// <param name="id"></param>
        /// <param name="monthlyPriceInCents"></param>
        /// <param name="name"></param>
        /// <param name="priceModel"></param>
        /// <param name="unitName"></param>
        /// <param name="yearlyPriceInCents"></param>
        public WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan(
            global::System.Collections.Generic.IList<string> bullets,
            string description,
            bool hasFreeTrial,
            int id,
            int monthlyPriceInCents,
            string name,
            global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlanPriceModel priceModel,
            string? unitName,
            int yearlyPriceInCents)
        {
            this.Bullets = bullets ?? throw new global::System.ArgumentNullException(nameof(bullets));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HasFreeTrial = hasFreeTrial;
            this.Id = id;
            this.MonthlyPriceInCents = monthlyPriceInCents;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PriceModel = priceModel;
            this.UnitName = unitName ?? throw new global::System.ArgumentNullException(nameof(unitName));
            this.YearlyPriceInCents = yearlyPriceInCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan" /> class.
        /// </summary>
        public WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan?>(serializer.Deserialize<global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan>(jsonReader));
        }

    }
}