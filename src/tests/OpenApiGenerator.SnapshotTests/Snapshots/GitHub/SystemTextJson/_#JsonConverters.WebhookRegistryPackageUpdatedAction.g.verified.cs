﻿//HintName: JsonConverters.WebhookRegistryPackageUpdatedAction.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookRegistryPackageUpdatedActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookRegistryPackageUpdatedAction>
    {
        /// <inheritdoc />
        public override global::G.WebhookRegistryPackageUpdatedAction Read(
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
                        return global::G.WebhookRegistryPackageUpdatedActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookRegistryPackageUpdatedAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookRegistryPackageUpdatedAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookRegistryPackageUpdatedActionExtensions.ToValueString(value));
        }
    }
}
