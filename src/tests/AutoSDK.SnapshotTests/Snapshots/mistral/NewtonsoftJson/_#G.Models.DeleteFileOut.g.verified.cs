﻿//HintName: G.Models.DeleteFileOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFileOut
    {
        /// <summary>
        /// The deletion status.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// The ID of the deleted file.<br/>
        /// Example: 497f6eca-6276-4993-bfeb-53cbbbba6f09
        /// </summary>
        /// <example>497f6eca-6276-4993-bfeb-53cbbbba6f09</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The object type that was deleted<br/>
        /// Example: file
        /// </summary>
        /// <example>file</example>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileOut" /> class.
        /// </summary>
        /// <param name="deleted">
        /// The deletion status.<br/>
        /// Example: false
        /// </param>
        /// <param name="id">
        /// The ID of the deleted file.<br/>
        /// Example: 497f6eca-6276-4993-bfeb-53cbbbba6f09
        /// </param>
        /// <param name="object">
        /// The object type that was deleted<br/>
        /// Example: file
        /// </param>
        public DeleteFileOut(
            bool deleted,
            global::System.Guid id,
            string @object)
        {
            this.Deleted = deleted;
            this.Id = id;
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileOut" /> class.
        /// </summary>
        public DeleteFileOut()
        {
        }
    }
}