﻿//HintName: G.Models.PullsUpdateReviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsUpdateReviewRequest
    {
        /// <summary>
        /// The body text of the pull request review.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body", Required = global::Newtonsoft.Json.Required.Always)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateReviewRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The body text of the pull request review.
        /// </param>
        public PullsUpdateReviewRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateReviewRequest" /> class.
        /// </summary>
        public PullsUpdateReviewRequest()
        {
        }
    }
}