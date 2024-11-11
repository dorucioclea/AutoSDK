﻿//HintName: G.Models.Encoder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Encoder
    {
        /// <summary>
        /// The Encoder ID.<br/>
        /// Example: enc_1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The encoder name.<br/>
        /// Example: boomerang
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When this encoder is used to create an embedding, it shows the count of dimensions for the output embedding.<br/>
        /// A high dimensionality will consume more storage space, but it allows for an increase in the quality of<br/>
        /// the embedding.<br/>
        /// Example: 768
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_dimensions")]
        public int? OutputDimensions { get; set; }

        /// <summary>
        /// The encoder description.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether the default encoder is used when creating a corpus.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default")]
        public bool? Default { get; set; }

        /// <summary>
        /// Indicates whether the encoder is enabled.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Encoder" /> class.
        /// </summary>
        /// <param name="id">
        /// The Encoder ID.<br/>
        /// Example: enc_1
        /// </param>
        /// <param name="name">
        /// The encoder name.<br/>
        /// Example: boomerang
        /// </param>
        /// <param name="outputDimensions">
        /// When this encoder is used to create an embedding, it shows the count of dimensions for the output embedding.<br/>
        /// A high dimensionality will consume more storage space, but it allows for an increase in the quality of<br/>
        /// the embedding.<br/>
        /// Example: 768
        /// </param>
        /// <param name="description">
        /// The encoder description.
        /// </param>
        /// <param name="default">
        /// Indicates whether the default encoder is used when creating a corpus.<br/>
        /// Example: true
        /// </param>
        /// <param name="enabled">
        /// Indicates whether the encoder is enabled.<br/>
        /// Example: true
        /// </param>
        public Encoder(
            string? id,
            string? name,
            int? outputDimensions,
            string? description,
            bool? @default,
            bool? enabled)
        {
            this.Id = id;
            this.Name = name;
            this.OutputDimensions = outputDimensions;
            this.Description = description;
            this.Default = @default;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Encoder" /> class.
        /// </summary>
        public Encoder()
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
        public static global::G.Encoder? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Encoder>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Encoder?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Encoder?>(serializer.Deserialize<global::G.Encoder>(jsonReader));
        }

    }
}