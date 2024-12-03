﻿//HintName: G.Models.WebhookPackagePublishedPackagePackageVersionNugetMetadataItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersionNugetMetadataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.OneOf<int?, string>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::G.OneOf<bool?, string, int?, global::G.WebhookPackagePublishedPackagePackageVersionNugetMetadataItemValue>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionNugetMetadataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public WebhookPackagePublishedPackagePackageVersionNugetMetadataItem(
            global::G.OneOf<int?, string>? id,
            string? name,
            global::G.OneOf<bool?, string, int?, global::G.WebhookPackagePublishedPackagePackageVersionNugetMetadataItemValue>? value)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionNugetMetadataItem" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersionNugetMetadataItem()
        {
        }
    }
}