﻿//HintName: G.Models.FunctionName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// this restriction of `Function` is used to select a specific function to call
    /// </summary>
    public sealed partial class FunctionName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionName" /> class.
        /// </summary>
        /// <param name="name"></param>
        public FunctionName(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionName" /> class.
        /// </summary>
        public FunctionName()
        {
        }
    }
}