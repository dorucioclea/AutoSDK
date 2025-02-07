﻿//HintName: G.Models.SecretScanningLocationCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository.
    /// </summary>
    public sealed partial class SecretScanningLocationCommit
    {
        /// <summary>
        /// The file path in the repository<br/>
        /// Example: /example/secrets.txt
        /// </summary>
        /// <example>/example/secrets.txt</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Line number at which the secret starts in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartLine { get; set; } = default!;

        /// <summary>
        /// Line number at which the secret ends in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_line", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndLine { get; set; } = default!;

        /// <summary>
        /// The column at which the secret starts within the start line when the file is interpreted as 8BIT ASCII
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_column", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartColumn { get; set; } = default!;

        /// <summary>
        /// The column at which the secret ends within the end line when the file is interpreted as 8BIT ASCII
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_column", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndColumn { get; set; } = default!;

        /// <summary>
        /// SHA-1 hash ID of the associated blob<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </summary>
        /// <example>af5626b4a114abcb82d63db7c8082c3c4756e51b</example>
        [global::Newtonsoft.Json.JsonProperty("blob_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobSha { get; set; } = default!;

        /// <summary>
        /// The API URL to get the associated blob resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobUrl { get; set; } = default!;

        /// <summary>
        /// SHA-1 hash ID of the associated commit<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </summary>
        /// <example>af5626b4a114abcb82d63db7c8082c3c4756e51b</example>
        [global::Newtonsoft.Json.JsonProperty("commit_sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitSha { get; set; } = default!;

        /// <summary>
        /// The API URL to get the associated commit resource
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationCommit" /> class.
        /// </summary>
        /// <param name="path">
        /// The file path in the repository<br/>
        /// Example: /example/secrets.txt
        /// </param>
        /// <param name="startLine">
        /// Line number at which the secret starts in the file
        /// </param>
        /// <param name="endLine">
        /// Line number at which the secret ends in the file
        /// </param>
        /// <param name="startColumn">
        /// The column at which the secret starts within the start line when the file is interpreted as 8BIT ASCII
        /// </param>
        /// <param name="endColumn">
        /// The column at which the secret ends within the end line when the file is interpreted as 8BIT ASCII
        /// </param>
        /// <param name="blobSha">
        /// SHA-1 hash ID of the associated blob<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </param>
        /// <param name="blobUrl">
        /// The API URL to get the associated blob resource
        /// </param>
        /// <param name="commitSha">
        /// SHA-1 hash ID of the associated commit<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </param>
        /// <param name="commitUrl">
        /// The API URL to get the associated commit resource
        /// </param>
        public SecretScanningLocationCommit(
            string path,
            double startLine,
            double endLine,
            double startColumn,
            double endColumn,
            string blobSha,
            string blobUrl,
            string commitSha,
            string commitUrl)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
            this.BlobSha = blobSha ?? throw new global::System.ArgumentNullException(nameof(blobSha));
            this.BlobUrl = blobUrl ?? throw new global::System.ArgumentNullException(nameof(blobUrl));
            this.CommitSha = commitSha ?? throw new global::System.ArgumentNullException(nameof(commitSha));
            this.CommitUrl = commitUrl ?? throw new global::System.ArgumentNullException(nameof(commitUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationCommit" /> class.
        /// </summary>
        public SecretScanningLocationCommit()
        {
        }
    }
}