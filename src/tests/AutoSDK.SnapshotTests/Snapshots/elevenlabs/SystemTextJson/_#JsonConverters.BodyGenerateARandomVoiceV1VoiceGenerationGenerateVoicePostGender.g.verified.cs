﻿//HintName: JsonConverters.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender>
    {
        /// <inheritdoc />
        public override global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGenderExtensions.ToValueString(value));
        }
    }
}
