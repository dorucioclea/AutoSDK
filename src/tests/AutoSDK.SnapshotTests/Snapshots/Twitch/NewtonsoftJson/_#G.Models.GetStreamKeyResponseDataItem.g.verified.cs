﻿//HintName: G.Models.GetStreamKeyResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStreamKeyResponseDataItem
    {
        /// <summary>
        /// The channel’s stream key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string StreamKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponseDataItem" /> class.
        /// </summary>
        /// <param name="streamKey">
        /// The channel’s stream key.
        /// </param>
        public GetStreamKeyResponseDataItem(
            string streamKey)
        {
            this.StreamKey = streamKey ?? throw new global::System.ArgumentNullException(nameof(streamKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamKeyResponseDataItem" /> class.
        /// </summary>
        public GetStreamKeyResponseDataItem()
        {
        }
    }
}