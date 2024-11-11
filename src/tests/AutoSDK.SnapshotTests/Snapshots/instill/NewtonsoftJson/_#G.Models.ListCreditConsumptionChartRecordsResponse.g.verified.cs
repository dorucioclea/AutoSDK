﻿//HintName: G.Models.ListCreditConsumptionChartRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListCreditConsumptionChartRecordsResponse contains a list of credit consumption<br/>
    /// chart records.
    /// </summary>
    public sealed partial class ListCreditConsumptionChartRecordsResponse
    {
        /// <summary>
        /// Credit consumption timelines, aggregated by source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditConsumptionChartRecords")]
        public global::System.Collections.Generic.IList<global::G.CreditConsumptionChartRecord>? CreditConsumptionChartRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCreditConsumptionChartRecordsResponse" /> class.
        /// </summary>
        /// <param name="creditConsumptionChartRecords">
        /// Credit consumption timelines, aggregated by source.
        /// </param>
        public ListCreditConsumptionChartRecordsResponse(
            global::System.Collections.Generic.IList<global::G.CreditConsumptionChartRecord>? creditConsumptionChartRecords)
        {
            this.CreditConsumptionChartRecords = creditConsumptionChartRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCreditConsumptionChartRecordsResponse" /> class.
        /// </summary>
        public ListCreditConsumptionChartRecordsResponse()
        {
        }
    }
}