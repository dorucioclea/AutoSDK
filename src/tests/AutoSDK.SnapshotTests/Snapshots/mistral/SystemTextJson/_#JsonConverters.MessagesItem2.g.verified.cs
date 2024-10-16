﻿//HintName: JsonConverters.MessagesItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class MessagesItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MessagesItem2>
    {
        /// <inheritdoc />
        public override global::G.MessagesItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            global::G.ChatCompletionRequestMessageDiscriminator? discriminator = default;
            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChatCompletionRequestMessageDiscriminator)}");
            discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SystemMessage? systemMessage = default;
            if (discriminator?.Role == global::G.ChatCompletionRequestMessageDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SystemMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UserMessage? userMessage = default;
            if (discriminator?.Role == global::G.ChatCompletionRequestMessageDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UserMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.AssistantMessage? assistantMessage = default;
            if (discriminator?.Role == global::G.ChatCompletionRequestMessageDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.AssistantMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ToolMessage? toolMessage = default;
            if (discriminator?.Role == global::G.ChatCompletionRequestMessageDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ToolMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.MessagesItem2(
                systemMessage,
                userMessage,
                assistantMessage,
                toolMessage
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MessagesItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeInfo);
            }
            else if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeInfo);
            }
            else if (value.IsToolMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolMessage, typeInfo);
            }
        }
    }
}