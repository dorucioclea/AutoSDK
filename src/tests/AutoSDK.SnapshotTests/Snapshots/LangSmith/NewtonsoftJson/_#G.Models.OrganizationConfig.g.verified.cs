﻿//HintName: G.Models.OrganizationConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Organization level configuration. May include any field that exists in tenant config and additional fields.
    /// </summary>
    public sealed partial class OrganizationConfig
    {
        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_identities")]
        public int? MaxIdentities { get; set; } = 5;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_workspaces")]
        public int? MaxWorkspaces { get; set; } = 1;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_rbac")]
        public bool? CanUseRbac { get; set; } = false;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_add_seats")]
        public bool? CanAddSeats { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startup_plan_approval_date")]
        public global::G.AnyOf<string, object>? StartupPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partner_plan_approval_date")]
        public global::G.AnyOf<string, object>? PartnerPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("premier_plan_approval_date")]
        public global::G.AnyOf<string, object>? PremierPlanApprovalDate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_serve_datasets")]
        public bool? CanServeDatasets { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_langgraph_cloud")]
        public bool? CanUseLanggraphCloud { get; set; } = false;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_langgraph_cloud_deployments")]
        public int? MaxLanggraphCloudDeployments { get; set; } = 1;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_saml_sso")]
        public bool? CanUseSamlSso { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_bulk_export")]
        public bool? CanUseBulkExport { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_python_playground_service")]
        public bool? UsePythonPlaygroundService { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flags")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Flags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}