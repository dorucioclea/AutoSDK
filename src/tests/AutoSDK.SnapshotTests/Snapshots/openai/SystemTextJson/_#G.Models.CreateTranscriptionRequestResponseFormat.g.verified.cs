﻿//HintName: G.Models.CreateTranscriptionRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the transcript output, in one of these options: `json`, `text`, `srt`, `verbose_json`, or `vtt`.<br/>
    /// Default Value: json
    /// </summary>
    public enum CreateTranscriptionRequestResponseFormat
    {
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Json,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Text,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Srt,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        VerboseJson,
        /// <summary>
        /// `json`, `text`, `srt`, `verbose_json`, or `vtt`.
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionRequestResponseFormat value)
        {
            return value switch
            {
                CreateTranscriptionRequestResponseFormat.Json => "json",
                CreateTranscriptionRequestResponseFormat.Text => "text",
                CreateTranscriptionRequestResponseFormat.Srt => "srt",
                CreateTranscriptionRequestResponseFormat.VerboseJson => "verbose_json",
                CreateTranscriptionRequestResponseFormat.Vtt => "vtt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => CreateTranscriptionRequestResponseFormat.Json,
                "text" => CreateTranscriptionRequestResponseFormat.Text,
                "srt" => CreateTranscriptionRequestResponseFormat.Srt,
                "verbose_json" => CreateTranscriptionRequestResponseFormat.VerboseJson,
                "vtt" => CreateTranscriptionRequestResponseFormat.Vtt,
                _ => null,
            };
        }
    }
}