﻿//HintName: G.Models.FileObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="size"></param>
        public FileObject(
            string? filename,
            string? id,
            string? @object,
            int? size)
        {
            this.Filename = filename;
            this.Id = id;
            this.Object = @object;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        public FileObject()
        {
        }
    }
}