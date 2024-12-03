﻿//HintName: G.Models.CopilotAddCopilotSeatsForUsersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotAddCopilotSeatsForUsersRequest
    {
        /// <summary>
        /// The usernames of the organization members to be granted access to GitHub Copilot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("selected_usernames", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SelectedUsernames { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForUsersRequest" /> class.
        /// </summary>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members to be granted access to GitHub Copilot.
        /// </param>
        public CopilotAddCopilotSeatsForUsersRequest(
            global::System.Collections.Generic.IList<string> selectedUsernames)
        {
            this.SelectedUsernames = selectedUsernames ?? throw new global::System.ArgumentNullException(nameof(selectedUsernames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForUsersRequest" /> class.
        /// </summary>
        public CopilotAddCopilotSeatsForUsersRequest()
        {
        }
    }
}