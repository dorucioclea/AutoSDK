﻿//HintName: JsonConverters.ChatCompletionMessageParam.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionMessageParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionMessageParam>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionMessageParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatCompletionSystemMessageParam? system = default;
            try
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionSystemMessageParam>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionUserMessageParam? user = default;
            try
            {
                user = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionUserMessageParam>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionAssistantMessageParam? assistant = default;
            try
            {
                assistant = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionAssistantMessageParam>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionToolMessageParam? tool = default;
            try
            {
                tool = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionToolMessageParam>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionFunctionMessageParam? function = default;
            try
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionFunctionMessageParam>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatCompletionMessageParam(
                system,
                user,
                assistant,
                tool,
                function
                );

            if (system != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionSystemMessageParam>(ref reader, options);
            }
            else if (user != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionUserMessageParam>(ref reader, options);
            }
            else if (assistant != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionAssistantMessageParam>(ref reader, options);
            }
            else if (tool != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionToolMessageParam>(ref reader, options);
            }
            else if (function != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionFunctionMessageParam>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionMessageParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::G.ChatCompletionSystemMessageParam), options);
            }
            else if (value.IsUser)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeof(global::G.ChatCompletionUserMessageParam), options);
            }
            else if (value.IsAssistant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeof(global::G.ChatCompletionAssistantMessageParam), options);
            }
            else if (value.IsTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeof(global::G.ChatCompletionToolMessageParam), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::G.ChatCompletionFunctionMessageParam), options);
            }
        }
    }
}