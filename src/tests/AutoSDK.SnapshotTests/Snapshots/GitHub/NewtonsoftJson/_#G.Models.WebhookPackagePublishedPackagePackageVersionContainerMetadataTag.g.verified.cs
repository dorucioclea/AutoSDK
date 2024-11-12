﻿//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionContainerMetadataTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersionContainerMetadataTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest")]
        public string? Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionContainerMetadataTag" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="name"></param>
        public WebhookPackagePublishedPackagePackageVersionContainerMetadataTag(
            string? digest,
            string? name)
        {
            this.Digest = digest;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionContainerMetadataTag" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersionContainerMetadataTag()
        {
        }
    }
}