﻿//HintName: G.Models.TrainingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingRequest
    {
        /// <summary>
        /// A string representing the desired model to push to in the format `{destination_model_owner}/{destination_model_name}`. This should be an existing model owned by the user or organization making the API request. If the destination is invalid, the server will return an appropriate 4XX response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination", Required = global::Newtonsoft.Json.Required.Always)]
        public string Destination { get; set; } = default!;

        /// <summary>
        /// An object containing inputs to the Cog model's `train()` function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// An HTTPS URL for receiving a webhook when the training completes. The webhook will be a POST request where the request body is the same as the response body of the [get training](#trainings.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once. Replicate will not follow redirects when sending webhook requests to your service, so be sure to specify a URL that will resolve without redirecting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public string? Webhook { get; set; }

        /// <summary>
        /// By default, we will send requests to your webhook URL whenever there are new outputs or the training has finished. You can change which events trigger webhook requests by specifying `webhook_events_filter` in the training request:<br/>
        /// - `start`: immediately on training start<br/>
        /// - `output`: each time a training generates an output (note that trainings can generate multiple outputs)<br/>
        /// - `logs`: each time log output is generated by a training<br/>
        /// - `completed`: when the training reaches a terminal state (succeeded/canceled/failed)<br/>
        /// For example, if you only wanted requests to be sent at the start and end of the training, you would provide:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "destination": "my-organization/my-model",<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "webhook": "https://example.com/my-webhook",<br/>
        ///   "webhook_events_filter": ["start", "completed"]<br/>
        /// }<br/>
        /// ```<br/>
        /// Requests for event types `output` and `logs` will be sent at most once every 500ms. If you request `start` and `completed` webhooks, then they'll always be sent regardless of throttling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_events_filter")]
        public global::System.Collections.Generic.IList<global::G.TrainingRequestWebhookEventsFilterItem>? WebhookEventsFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingRequest" /> class.
        /// </summary>
        /// <param name="destination">
        /// A string representing the desired model to push to in the format `{destination_model_owner}/{destination_model_name}`. This should be an existing model owned by the user or organization making the API request. If the destination is invalid, the server will return an appropriate 4XX response.
        /// </param>
        /// <param name="input">
        /// An object containing inputs to the Cog model's `train()` function.
        /// </param>
        /// <param name="webhook">
        /// An HTTPS URL for receiving a webhook when the training completes. The webhook will be a POST request where the request body is the same as the response body of the [get training](#trainings.get) operation. If there are network problems, we will retry the webhook a few times, so make sure it can be safely called more than once. Replicate will not follow redirects when sending webhook requests to your service, so be sure to specify a URL that will resolve without redirecting.
        /// </param>
        /// <param name="webhookEventsFilter">
        /// By default, we will send requests to your webhook URL whenever there are new outputs or the training has finished. You can change which events trigger webhook requests by specifying `webhook_events_filter` in the training request:<br/>
        /// - `start`: immediately on training start<br/>
        /// - `output`: each time a training generates an output (note that trainings can generate multiple outputs)<br/>
        /// - `logs`: each time log output is generated by a training<br/>
        /// - `completed`: when the training reaches a terminal state (succeeded/canceled/failed)<br/>
        /// For example, if you only wanted requests to be sent at the start and end of the training, you would provide:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "destination": "my-organization/my-model",<br/>
        ///   "input": {<br/>
        ///     "text": "Alice"<br/>
        ///   },<br/>
        ///   "webhook": "https://example.com/my-webhook",<br/>
        ///   "webhook_events_filter": ["start", "completed"]<br/>
        /// }<br/>
        /// ```<br/>
        /// Requests for event types `output` and `logs` will be sent at most once every 500ms. If you request `start` and `completed` webhooks, then they'll always be sent regardless of throttling.
        /// </param>
        public TrainingRequest(
            string destination,
            object input,
            string? webhook,
            global::System.Collections.Generic.IList<global::G.TrainingRequestWebhookEventsFilterItem>? webhookEventsFilter)
        {
            this.Destination = destination ?? throw new global::System.ArgumentNullException(nameof(destination));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Webhook = webhook;
            this.WebhookEventsFilter = webhookEventsFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingRequest" /> class.
        /// </summary>
        public TrainingRequest()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.TrainingRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TrainingRequest>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.TrainingRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.TrainingRequest?>(serializer.Deserialize<global::G.TrainingRequest>(jsonReader));
        }

    }
}