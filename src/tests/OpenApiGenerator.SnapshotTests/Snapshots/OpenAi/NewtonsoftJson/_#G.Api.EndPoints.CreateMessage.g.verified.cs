﻿//HintName: G.Api.EndPoints.CreateMessage.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a message.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<MessageObject> CreateMessageAsync(
            CreateMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/threads/{thread_id}/messages");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<MessageObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Create a message.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="attachments"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<MessageObject> CreateMessageAsync(
            CreateMessageRequestRole role,
            object content,
            global::System.Collections.Generic.IList<CreateMessageRequestAttachments?>? attachments,
            CreateMessageRequestMetadata? metadata,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateMessageRequest
            {
                Role = role,
                Content = content,
                Attachments = attachments,
                Metadata = metadata,
            };

            return await CreateMessageAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}