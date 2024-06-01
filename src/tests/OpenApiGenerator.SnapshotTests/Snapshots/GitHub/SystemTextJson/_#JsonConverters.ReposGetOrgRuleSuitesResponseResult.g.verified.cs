﻿//HintName: JsonConverters.ReposGetOrgRuleSuitesResponseResult.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposGetOrgRuleSuitesResponseResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposGetOrgRuleSuitesResponseResult>
    {
        /// <inheritdoc />
        public override global::G.ReposGetOrgRuleSuitesResponseResult Read(
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
                        return global::G.ReposGetOrgRuleSuitesResponseResultExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposGetOrgRuleSuitesResponseResult)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposGetOrgRuleSuitesResponseResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ReposGetOrgRuleSuitesResponseResultExtensions.ToValueString(value));
        }
    }
}
