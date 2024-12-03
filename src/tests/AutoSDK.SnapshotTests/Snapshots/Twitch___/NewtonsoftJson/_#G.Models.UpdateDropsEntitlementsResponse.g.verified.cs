﻿//HintName: G.Models.UpdateDropsEntitlementsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDropsEntitlementsResponse
    {
        /// <summary>
        /// A list that indicates which entitlements were successfully updated and those that weren’t.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DropsEntitlementUpdated> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDropsEntitlementsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that indicates which entitlements were successfully updated and those that weren’t.
        /// </param>
        public UpdateDropsEntitlementsResponse(
            global::System.Collections.Generic.IList<global::G.DropsEntitlementUpdated> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDropsEntitlementsResponse" /> class.
        /// </summary>
        public UpdateDropsEntitlementsResponse()
        {
        }
    }
}