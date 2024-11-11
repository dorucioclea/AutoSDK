﻿//HintName: G.Models.CodeScanningAlertLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe a region within a file for the alert.
    /// </summary>
    public sealed partial class CodeScanningAlertLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_column")]
        public int? StartColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_column")]
        public int? EndColumn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertLocation" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="startLine"></param>
        /// <param name="endLine"></param>
        /// <param name="startColumn"></param>
        /// <param name="endColumn"></param>
        public CodeScanningAlertLocation(
            string? path,
            int? startLine,
            int? endLine,
            int? startColumn,
            int? endColumn)
        {
            this.Path = path;
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertLocation" /> class.
        /// </summary>
        public CodeScanningAlertLocation()
        {
        }
    }
}