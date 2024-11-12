﻿//HintName: G.Models.PackageVersionMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PackageVersionMetadata
    {
        /// <summary>
        /// Example: docker
        /// </summary>
        /// <example>docker</example>
        [global::Newtonsoft.Json.JsonProperty("package_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PackageVersionMetadataPackageType PackageType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        public global::G.PackageVersionMetadataContainer? Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docker")]
        public global::G.PackageVersionMetadataDocker? Docker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadata" /> class.
        /// </summary>
        /// <param name="packageType">
        /// Example: docker
        /// </param>
        /// <param name="container"></param>
        /// <param name="docker"></param>
        public PackageVersionMetadata(
            global::G.PackageVersionMetadataPackageType packageType,
            global::G.PackageVersionMetadataContainer? container,
            global::G.PackageVersionMetadataDocker? docker)
        {
            this.PackageType = packageType;
            this.Container = container;
            this.Docker = docker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PackageVersionMetadata" /> class.
        /// </summary>
        public PackageVersionMetadata()
        {
        }
    }
}