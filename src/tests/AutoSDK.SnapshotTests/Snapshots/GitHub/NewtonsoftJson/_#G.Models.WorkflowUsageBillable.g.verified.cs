﻿//HintName: G.Models.WorkflowUsageBillable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowUsageBillable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("UBUNTU")]
        public global::G.WorkflowUsageBillableUBUNTU? UBUNTU { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MACOS")]
        public global::G.WorkflowUsageBillableMACOS? MACOS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("WINDOWS")]
        public global::G.WorkflowUsageBillableWINDOWS? WINDOWS { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillable" /> class.
        /// </summary>
        /// <param name="uBUNTU"></param>
        /// <param name="mACOS"></param>
        /// <param name="wINDOWS"></param>
        public WorkflowUsageBillable(
            global::G.WorkflowUsageBillableUBUNTU? uBUNTU,
            global::G.WorkflowUsageBillableMACOS? mACOS,
            global::G.WorkflowUsageBillableWINDOWS? wINDOWS)
        {
            this.UBUNTU = uBUNTU;
            this.MACOS = mACOS;
            this.WINDOWS = wINDOWS;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUsageBillable" /> class.
        /// </summary>
        public WorkflowUsageBillable()
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
        public static global::G.WorkflowUsageBillable? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WorkflowUsageBillable>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WorkflowUsageBillable?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WorkflowUsageBillable?>(serializer.Deserialize<global::G.WorkflowUsageBillable>(jsonReader));
        }

    }
}