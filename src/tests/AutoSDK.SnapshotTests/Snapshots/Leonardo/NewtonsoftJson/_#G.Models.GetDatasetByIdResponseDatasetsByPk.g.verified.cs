﻿//HintName: G.Models.GetDatasetByIdResponseDatasetsByPk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "datasets"
    /// </summary>
    public sealed partial class GetDatasetByIdResponseDatasetsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_images")]
        public global::System.Collections.Generic.IList<global::G.GetDatasetByIdResponseDatasetsByPkDatasetImage>? DatasetImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetByIdResponseDatasetsByPk" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="datasetImages"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="updatedAt"></param>
        public GetDatasetByIdResponseDatasetsByPk(
            string? createdAt,
            global::System.Collections.Generic.IList<global::G.GetDatasetByIdResponseDatasetsByPkDatasetImage>? datasetImages,
            string? description,
            string? id,
            string? name,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.DatasetImages = datasetImages;
            this.Description = description;
            this.Id = id;
            this.Name = name;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetByIdResponseDatasetsByPk" /> class.
        /// </summary>
        public GetDatasetByIdResponseDatasetsByPk()
        {
        }
    }
}