﻿//HintName: G.Models.CheckNamespaceByUIDAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CheckNamespaceByUIDAdminResponse contains the availability of a namespace or the type<br/>
    /// of resource that's using it.
    /// </summary>
    public sealed partial class CheckNamespaceByUIDAdminResponse
    {
        /// <summary>
        /// Namespace type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CheckNamespaceByUIDAdminResponseNamespace? Type { get; set; }

        /// <summary>
        /// Namespace ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user")]
        public global::G.User? User { get; set; }

        /// <summary>
        /// Organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceByUIDAdminResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Namespace type.
        /// </param>
        /// <param name="id">
        /// Namespace ID.
        /// </param>
        /// <param name="user">
        /// User.
        /// </param>
        /// <param name="organization">
        /// Organization.
        /// </param>
        public CheckNamespaceByUIDAdminResponse(
            global::G.CheckNamespaceByUIDAdminResponseNamespace? type,
            string? id,
            global::G.User? user,
            global::G.Organization? organization)
        {
            this.Type = type;
            this.Id = id;
            this.User = user;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceByUIDAdminResponse" /> class.
        /// </summary>
        public CheckNamespaceByUIDAdminResponse()
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
        public static global::G.CheckNamespaceByUIDAdminResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CheckNamespaceByUIDAdminResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CheckNamespaceByUIDAdminResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CheckNamespaceByUIDAdminResponse?>(serializer.Deserialize<global::G.CheckNamespaceByUIDAdminResponse>(jsonReader));
        }

    }
}