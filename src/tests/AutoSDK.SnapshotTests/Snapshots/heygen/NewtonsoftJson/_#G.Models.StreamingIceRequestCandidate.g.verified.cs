﻿//HintName: G.Models.StreamingIceRequestCandidate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingIceRequestCandidate
    {
        /// <summary>
        /// Example: &lt;CANDIDATE&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("candidate")]
        public string? Candidate { get; set; }

        /// <summary>
        /// Example: &lt;SDP_MLINE_INDEX&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdpMLineIndex")]
        public string? SdpMLineIndex { get; set; }

        /// <summary>
        /// Example: &lt;SDP_MID&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdpMid")]
        public string? SdpMid { get; set; }

        /// <summary>
        /// Example: &lt;USERNAME_FRAGMENT&gt;
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usernameFragment")]
        public string? UsernameFragment { get; set; }

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
        public static global::G.StreamingIceRequestCandidate? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.StreamingIceRequestCandidate>(
                json,
                jsonSerializerOptions);
        }

    }
}