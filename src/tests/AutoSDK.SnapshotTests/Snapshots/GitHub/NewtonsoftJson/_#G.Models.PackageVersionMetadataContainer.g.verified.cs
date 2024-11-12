﻿//HintName: G.Models.PackageVersionMetadataContainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PackageVersionMetadataContainer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadataContainer" /> class.
        /// </summary>
        /// <param name="tags"></param>
        public PackageVersionMetadataContainer(
            global::System.Collections.Generic.IList<string> tags)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadataContainer" /> class.
        /// </summary>
        public PackageVersionMetadataContainer()
        {
        }
    }
}