﻿//HintName: G.Models.BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost
    {
        /// <summary>
        /// The name of the chapter, used for identification only.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// An optional URL from which we will extract content to initialize the project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_url")]
        public string? FromUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the chapter, used for identification only.
        /// </param>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        public BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost(
            string name,
            string? fromUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FromUrl = fromUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost" /> class.
        /// </summary>
        public BodyAddChapterToAProjectV1ProjectsProjectIdChaptersAddPost()
        {
        }
    }
}