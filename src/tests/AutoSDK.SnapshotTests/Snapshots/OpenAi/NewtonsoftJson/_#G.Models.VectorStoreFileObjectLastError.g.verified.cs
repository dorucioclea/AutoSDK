﻿//HintName: G.Models.VectorStoreFileObjectLastError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The last error associated with this vector store file. Will be `null` if there are no errors.
    /// </summary>
    public sealed partial class VectorStoreFileObjectLastError
    {
        /// <summary>
        /// One of `server_error` or `rate_limit_exceeded`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStoreFileObjectLastErrorCode Code { get; set; } = default!;

        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileObjectLastError" /> class.
        /// </summary>
        /// <param name="code">
        /// One of `server_error` or `rate_limit_exceeded`.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error.
        /// </param>
        public VectorStoreFileObjectLastError(
            global::G.VectorStoreFileObjectLastErrorCode code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileObjectLastError" /> class.
        /// </summary>
        public VectorStoreFileObjectLastError()
        {
        }
    }
}