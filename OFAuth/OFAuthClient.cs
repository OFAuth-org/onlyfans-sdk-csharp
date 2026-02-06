using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace OFAuth
{
    /// <summary>
    /// OFAuth API error
    /// </summary>
    public class OFAuthException : Exception
    {
        public int Status { get; }
        public string? Code { get; }
        public object? Details { get; }

        public OFAuthException(int status, string message, string? code = null, object? details = null)
            : base(message)
        {
            Status = status;
            Code = code;
            Details = details;
        }
    }

    /// <summary>
    /// OFAuth API Client
    /// </summary>
    public class OFAuthClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseUrl;
        private readonly JsonSerializerOptions _jsonOptions;
        private string? _connectionId;
        private bool _disposed;

        public const string DefaultBaseUrl = "https://api-next.ofauth.com";

        public OFAuthClient(string apiKey, string? baseUrl = null, HttpClient? httpClient = null)
        {
            _apiKey = apiKey;
            _baseUrl = (baseUrl ?? DefaultBaseUrl).TrimEnd('/');
            _httpClient = httpClient ?? new HttpClient();
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
        }

        public OFAuthClient WithConnectionId(string connectionId)
        {
            _connectionId = connectionId;
            return this;
        }

        public async Task<T> RequestAsync<T>(
            HttpMethod method,
            string path,
            Dictionary<string, string?>? query = null,
            object? body = null,
            string? connectionId = null,
            CancellationToken cancellationToken = default)
        {
            var url = _baseUrl + path;
            
            if (query != null && query.Count > 0)
            {
                var queryString = HttpUtility.ParseQueryString(string.Empty);
                foreach (var (key, value) in query)
                {
                    if (value != null)
                        queryString[key] = value;
                }
                url += "?" + queryString;
            }

            using var request = new HttpRequestMessage(method, url);
            request.Headers.Add("apiKey", _apiKey);
            
            var connId = connectionId ?? _connectionId;
            if (!string.IsNullOrEmpty(connId))
                request.Headers.Add("x-connection-id", connId);

            if (body != null)
            {
                request.Content = new StringContent(
                    JsonSerializer.Serialize(body, _jsonOptions),
                    Encoding.UTF8,
                    "application/json");
            }

            var response = await _httpClient.SendAsync(request, cancellationToken);
            var content = await response.Content.ReadAsStringAsync(cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                try
                {
                    var error = JsonSerializer.Deserialize<ErrorResponse>(content, _jsonOptions);
                    throw new OFAuthException(
                        (int)response.StatusCode,
                        error?.Message ?? $"HTTP {response.StatusCode}",
                        error?.Code,
                        error?.Details);
                }
                catch (JsonException)
                {
                    throw new OFAuthException((int)response.StatusCode, content);
                }
            }

            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                return default!;

            return JsonSerializer.Deserialize<T>(content, _jsonOptions)!;
        }

        public Task<T> GetAsync<T>(string path, Dictionary<string, string?>? query = null, string? connectionId = null, CancellationToken cancellationToken = default)
            => RequestAsync<T>(HttpMethod.Get, path, query, null, connectionId, cancellationToken);

        public Task<T> PostAsync<T>(string path, object? body = null, string? connectionId = null, CancellationToken cancellationToken = default)
            => RequestAsync<T>(HttpMethod.Post, path, null, body, connectionId, cancellationToken);

        public Task<T> PutAsync<T>(string path, object? body = null, string? connectionId = null, CancellationToken cancellationToken = default)
            => RequestAsync<T>(HttpMethod.Put, path, null, body, connectionId, cancellationToken);

        public Task<T> PatchAsync<T>(string path, object? body = null, string? connectionId = null, CancellationToken cancellationToken = default)
            => RequestAsync<T>(HttpMethod.Patch, path, null, body, connectionId, cancellationToken);

        public Task<T> DeleteAsync<T>(string path, string? connectionId = null, CancellationToken cancellationToken = default)
            => RequestAsync<T>(HttpMethod.Delete, path, null, null, connectionId, cancellationToken);

        public void Dispose()
        {
            if (!_disposed)
            {
                _httpClient.Dispose();
                _disposed = true;
            }
            GC.SuppressFinalize(this);
        }

        private class ErrorResponse
        {
            public string? Message { get; set; }
            public string? Code { get; set; }
            public object? Details { get; set; }
        }
    }
}
