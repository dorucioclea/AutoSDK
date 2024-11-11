﻿//HintName: G.Models.ServiceMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServiceMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public global::System.DateTime? Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMessage" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="description"></param>
        public ServiceMessage(
            string? title,
            global::System.DateTime? start,
            global::System.DateTime? end,
            string? description)
        {
            this.Title = title;
            this.Start = start;
            this.End = end;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceMessage" /> class.
        /// </summary>
        public ServiceMessage()
        {
        }
    }
}