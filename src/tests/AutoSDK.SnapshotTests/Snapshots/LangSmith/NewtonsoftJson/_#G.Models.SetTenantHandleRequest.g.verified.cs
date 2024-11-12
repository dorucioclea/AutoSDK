﻿//HintName: G.Models.SetTenantHandleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetTenantHandleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_handle", Required = global::Newtonsoft.Json.Required.Always)]
        public string TenantHandle { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTenantHandleRequest" /> class.
        /// </summary>
        /// <param name="tenantHandle"></param>
        public SetTenantHandleRequest(
            string tenantHandle)
        {
            this.TenantHandle = tenantHandle ?? throw new global::System.ArgumentNullException(nameof(tenantHandle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetTenantHandleRequest" /> class.
        /// </summary>
        public SetTenantHandleRequest()
        {
        }
    }
}