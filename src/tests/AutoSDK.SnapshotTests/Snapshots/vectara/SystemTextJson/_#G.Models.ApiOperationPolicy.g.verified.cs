﻿//HintName: G.Models.ApiOperationPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy to allow operations if only using the specified resource.
    /// </summary>
    public sealed partial class ApiOperationPolicy
    {
        /// <summary>
        /// If any resource is allowed for the operation.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_any_resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowAnyResource { get; set; }

        /// <summary>
        /// Object with keys of resource paths to a list of allowed resources.<br/>
        /// A resource path starts with either body, path, or implicit.<br/>
        /// A body or path resource is within the operation body, and an implicit<br/>
        /// resource is a resource implied by the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_resources")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? AllowedResources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::G.ApiOperationPolicy? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ApiOperationPolicy),
                jsonSerializerContext) as global::G.ApiOperationPolicy;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ApiOperationPolicy? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ApiOperationPolicy>(
                json,
                jsonSerializerOptions);
        }

    }
}