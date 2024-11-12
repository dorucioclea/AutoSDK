﻿//HintName: G.Models.SummarizeBySegmentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummarizeBySegmentResponse
    {
        /// <summary>
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SegmentSummary> Segments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeBySegmentResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique ID for the request (not the message). Repeated identical requests<br/>
        /// get different IDs. However, for a streaming response, the ID will be the same<br/>
        /// for all responses in the stream.
        /// </param>
        /// <param name="segments"></param>
        public SummarizeBySegmentResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.SegmentSummary> segments)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizeBySegmentResponse" /> class.
        /// </summary>
        public SummarizeBySegmentResponse()
        {
        }
    }
}