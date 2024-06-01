﻿//HintName: JsonConverters.WebhookBranchProtectionRuleDeletedAction.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookBranchProtectionRuleDeletedActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookBranchProtectionRuleDeletedAction>
    {
        /// <inheritdoc />
        public override global::G.WebhookBranchProtectionRuleDeletedAction Read(
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
                        return global::G.WebhookBranchProtectionRuleDeletedActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookBranchProtectionRuleDeletedAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookBranchProtectionRuleDeletedAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookBranchProtectionRuleDeletedActionExtensions.ToValueString(value));
        }
    }
}
