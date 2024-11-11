﻿//HintName: G.Models.WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage" /> class.
        /// </summary>
        /// <param name="text"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage" /> class.
        /// </summary>
        public WebhookCodeScanningAlertCreatedAlertMostRecentInstanceMessage()
        {
        }
    }
}