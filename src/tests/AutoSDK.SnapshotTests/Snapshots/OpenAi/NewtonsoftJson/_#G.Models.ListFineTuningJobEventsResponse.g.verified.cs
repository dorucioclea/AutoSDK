﻿//HintName: G.Models.ListFineTuningJobEventsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFineTuningJobEventsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FineTuningJobEvent> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ListFineTuningJobEventsResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningJobEventsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        public ListFineTuningJobEventsResponse(
            global::System.Collections.Generic.IList<global::G.FineTuningJobEvent> data,
            global::G.ListFineTuningJobEventsResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningJobEventsResponse" /> class.
        /// </summary>
        public ListFineTuningJobEventsResponse()
        {
        }
    }
}