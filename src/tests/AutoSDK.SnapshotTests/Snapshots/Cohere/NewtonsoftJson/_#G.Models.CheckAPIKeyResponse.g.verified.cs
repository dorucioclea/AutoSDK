﻿//HintName: G.Models.CheckAPIKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAPIKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("valid", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Valid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CheckAPIKeyResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CheckAPIKeyResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}