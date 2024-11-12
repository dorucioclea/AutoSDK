﻿//HintName: G.Models.PerformInpaintingLCMResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformInpaintingLCMResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lcmGenerationJob")]
        public global::G.PerformInpaintingLCMResponseLcmGenerationJob? LcmGenerationJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInpaintingLCMResponse" /> class.
        /// </summary>
        /// <param name="lcmGenerationJob"></param>
        public PerformInpaintingLCMResponse(
            global::G.PerformInpaintingLCMResponseLcmGenerationJob? lcmGenerationJob)
        {
            this.LcmGenerationJob = lcmGenerationJob;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformInpaintingLCMResponse" /> class.
        /// </summary>
        public PerformInpaintingLCMResponse()
        {
        }
    }
}