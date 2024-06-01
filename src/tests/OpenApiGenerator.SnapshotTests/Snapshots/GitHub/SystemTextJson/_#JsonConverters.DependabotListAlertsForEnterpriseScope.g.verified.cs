﻿//HintName: JsonConverters.DependabotListAlertsForEnterpriseScope.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class DependabotListAlertsForEnterpriseScopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DependabotListAlertsForEnterpriseScope>
    {
        /// <inheritdoc />
        public override global::G.DependabotListAlertsForEnterpriseScope Read(
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
                        return global::G.DependabotListAlertsForEnterpriseScopeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.DependabotListAlertsForEnterpriseScope)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DependabotListAlertsForEnterpriseScope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.DependabotListAlertsForEnterpriseScopeExtensions.ToValueString(value));
        }
    }
}
