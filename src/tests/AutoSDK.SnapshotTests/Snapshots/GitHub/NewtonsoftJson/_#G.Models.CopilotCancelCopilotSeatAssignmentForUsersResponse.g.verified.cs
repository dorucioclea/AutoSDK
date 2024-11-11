﻿//HintName: G.Models.CopilotCancelCopilotSeatAssignmentForUsersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The total number of seat assignments cancelled.
    /// </summary>
    public sealed partial class CopilotCancelCopilotSeatAssignmentForUsersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seats_cancelled", Required = global::Newtonsoft.Json.Required.Always)]
        public int SeatsCancelled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForUsersResponse" /> class.
        /// </summary>
        /// <param name="seatsCancelled"></param>
        public CopilotCancelCopilotSeatAssignmentForUsersResponse(
            int seatsCancelled)
        {
            this.SeatsCancelled = seatsCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForUsersResponse" /> class.
        /// </summary>
        public CopilotCancelCopilotSeatAssignmentForUsersResponse()
        {
        }
    }
}