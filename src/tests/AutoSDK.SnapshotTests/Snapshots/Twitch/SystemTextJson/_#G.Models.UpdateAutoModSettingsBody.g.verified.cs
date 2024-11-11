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
        [global::System.Text.Json.Serialization.JsonPropertyName("aggression")]
        public int? Aggression { get; set; }

        /// <summary>
        /// The Automod level for hostility involving name calling or insults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bullying")]
        public int? Bullying { get; set; }

        /// <summary>
        /// The Automod level for discrimination against disability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disability")]
        public int? Disability { get; set; }

        /// <summary>
        /// The Automod level for discrimination against women.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("misogyny")]
        public int? Misogyny { get; set; }

        /// <summary>
        /// The default AutoMod level for the broadcaster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_level")]
        public int? OverallLevel { get; set; }

        /// <summary>
        /// The Automod level for racial discrimination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("race_ethnicity_or_religion")]
        public int? RaceEthnicityOrReligion { get; set; }

        /// <summary>
        /// The Automod level for sexual content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sex_based_terms")]
        public int? SexBasedTerms { get; set; }

        /// <summary>
        /// The AutoMod level for discrimination based on sexuality, sex, or gender.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexuality_sex_or_gender")]
        public int? SexualitySexOrGender { get; set; }

        /// <summary>
        /// The Automod level for profanity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swearing")]
        public int? Swearing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.UpdateAutoModSettingsBody? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.UpdateAutoModSettingsBody),
                jsonSerializerContext) as global::G.UpdateAutoModSettingsBody;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.UpdateAutoModSettingsBody? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateAutoModSettingsBody>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.UpdateAutoModSettingsBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.UpdateAutoModSettingsBody),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.UpdateAutoModSettingsBody;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.UpdateAutoModSettingsBody?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.UpdateAutoModSettingsBody?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}