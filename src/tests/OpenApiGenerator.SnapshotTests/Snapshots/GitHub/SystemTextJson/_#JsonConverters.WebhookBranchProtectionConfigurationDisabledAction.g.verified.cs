﻿//HintName: JsonConverters.WebhookBranchProtectionConfigurationDisabledAction.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookBranchProtectionConfigurationDisabledActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookBranchProtectionConfigurationDisabledAction>
    {
        /// <inheritdoc />
        public override global::G.WebhookBranchProtectionConfigurationDisabledAction Read(
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
                        return global::G.WebhookBranchProtectionConfigurationDisabledActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookBranchProtectionConfigurationDisabledAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookBranchProtectionConfigurationDisabledAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookBranchProtectionConfigurationDisabledActionExtensions.ToValueString(value));
        }
    }
}
