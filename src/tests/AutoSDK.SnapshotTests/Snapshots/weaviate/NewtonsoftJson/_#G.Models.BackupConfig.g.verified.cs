﻿//HintName: G.Models.BackupConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Backup custom configuration
    /// </summary>
    public sealed partial class BackupConfig
    {
        /// <summary>
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("CPUPercentage")]
        public int? CPUPercentage { get; set; }

        /// <summary>
        /// Aimed chunk size, with a minimum of 2MB, default of 128MB, and a maximum of 512MB. The actual chunk size may vary.<br/>
        /// Default Value: 128
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ChunkSize")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Compression level used by compression algorithm<br/>
        /// Default Value: DefaultCompression
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("CompressionLevel")]
        public global::G.BackupConfigCompressionLevel? CompressionLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupConfig" /> class.
        /// </summary>
        /// <param name="cPUPercentage">
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="chunkSize">
        /// Aimed chunk size, with a minimum of 2MB, default of 128MB, and a maximum of 512MB. The actual chunk size may vary.<br/>
        /// Default Value: 128
        /// </param>
        /// <param name="compressionLevel">
        /// Compression level used by compression algorithm<br/>
        /// Default Value: DefaultCompression
        /// </param>
        public BackupConfig(
            int? cPUPercentage,
            int? chunkSize,
            global::G.BackupConfigCompressionLevel? compressionLevel)
        {
            this.CPUPercentage = cPUPercentage;
            this.ChunkSize = chunkSize;
            this.CompressionLevel = compressionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupConfig" /> class.
        /// </summary>
        public BackupConfig()
        {
        }
    }
}