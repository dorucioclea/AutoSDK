﻿//HintName: G.Models.UpdateAutoModSettingsBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAutoModSettingsBody
    {
        /// <summary>
        /// The Automod level for hostility involving aggression.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aggression")]
        public int? Aggression { get; set; }

        /// <summary>
        /// The Automod level for hostility involving name calling or insults.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bullying")]
        public int? Bullying { get; set; }

        /// <summary>
        /// The Automod level for discrimination against disability.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disability")]
        public int? Disability { get; set; }

        /// <summary>
        /// The Automod level for discrimination against women.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("misogyny")]
        public int? Misogyny { get; set; }

        /// <summary>
        /// The default AutoMod level for the broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_level")]
        public int? OverallLevel { get; set; }

        /// <summary>
        /// The Automod level for racial discrimination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("race_ethnicity_or_religion")]
        public int? RaceEthnicityOrReligion { get; set; }

        /// <summary>
        /// The Automod level for sexual content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sex_based_terms")]
        public int? SexBasedTerms { get; set; }

        /// <summary>
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sexuality_sex_or_gender")]
        public int? SexualitySexOrGender { get; set; }

        /// <summary>
        /// The Automod level for profanity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("swearing")]
        public int? Swearing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoModSettingsBody" /> class.
        /// </summary>
        /// <param name="aggression">
        /// The Automod level for hostility involving aggression.
        /// </param>
        /// <param name="bullying">
        /// The Automod level for hostility involving name calling or insults.
        /// </param>
        /// <param name="disability">
        /// The Automod level for discrimination against disability.
        /// </param>
        /// <param name="misogyny">
        /// The Automod level for discrimination against women.
        /// </param>
        /// <param name="overallLevel">
        /// The default AutoMod level for the broadcaster.
        /// </param>
        /// <param name="raceEthnicityOrReligion">
        /// The Automod level for racial discrimination.
        /// </param>
        /// <param name="sexBasedTerms">
        /// The Automod level for sexual content.
        /// </param>
        /// <param name="sexualitySexOrGender">
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </param>
        /// <param name="swearing">
        /// The Automod level for profanity.
        /// </param>
        public UpdateAutoModSettingsBody(
            int? aggression,
            int? bullying,
            int? disability,
            int? misogyny,
            int? overallLevel,
            int? raceEthnicityOrReligion,
            int? sexBasedTerms,
            int? sexualitySexOrGender,
            int? swearing)
        {
            this.Aggression = aggression;
            this.Bullying = bullying;
            this.Disability = disability;
            this.Misogyny = misogyny;
            this.OverallLevel = overallLevel;
            this.RaceEthnicityOrReligion = raceEthnicityOrReligion;
            this.SexBasedTerms = sexBasedTerms;
            this.SexualitySexOrGender = sexualitySexOrGender;
            this.Swearing = swearing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoModSettingsBody" /> class.
        /// </summary>
        public UpdateAutoModSettingsBody()
        {
        }
    }
}