﻿//HintName: G.Models.SecretScanningLocationDiscussionTitle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'discussion_title' secret scanning location type. This location type shows that a secret was detected in the title of a discussion.
    /// </summary>
    public sealed partial class SecretScanningLocationDiscussionTitle
    {
        /// <summary>
        /// The URL to the discussion where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082
        /// </summary>
        /// <example>https://github.com/community/community/discussions/39082</example>
        [global::Newtonsoft.Json.JsonProperty("discussion_title_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiscussionTitleUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionTitle" /> class.
        /// </summary>
        /// <param name="discussionTitleUrl">
        /// The URL to the discussion where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082
        /// </param>
        public SecretScanningLocationDiscussionTitle(
            string discussionTitleUrl)
        {
            this.DiscussionTitleUrl = discussionTitleUrl ?? throw new global::System.ArgumentNullException(nameof(discussionTitleUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionTitle" /> class.
        /// </summary>
        public SecretScanningLocationDiscussionTitle()
        {
        }
    }
}