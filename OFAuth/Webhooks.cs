using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFAuth.Webhooks
{
    // ========================================================================
    // Errors
    // ========================================================================

    /// <summary>
    /// Thrown when webhook signature verification fails.
    /// </summary>
    public class WebhookVerificationException : Exception
    {
        public string Code { get; }

        public WebhookVerificationException(string message, string code) : base(message)
        {
            Code = code;
        }
    }

    // ========================================================================
    // Types
    // ========================================================================

    /// <summary>
    /// Extracted Svix webhook headers.
    /// </summary>
    public record WebhookHeaders(string SvixId, string SvixTimestamp, string SvixSignature);

    /// <summary>
    /// User data from OnlyFans.
    /// </summary>
    public class WebhookUserData
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; } = "";

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("username")]
        public string Username { get; set; } = "";

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = "";
    }

    /// <summary>
    /// Connection object in webhook events.
    /// </summary>
    public class WebhookConnection
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = "";

        [JsonPropertyName("platformUserId")]
        public string PlatformUserId { get; set; } = "";

        [JsonPropertyName("status")]
        public string Status { get; set; } = "";

        [JsonPropertyName("userData")]
        public WebhookUserData? UserData { get; set; }

        [JsonPropertyName("permissions")]
        public List<string>? Permissions { get; set; }
    }

    /// <summary>
    /// Dynamic rules configuration.
    /// </summary>
    public class WebhookDynamicRules
    {
        [JsonPropertyName("static_param")]
        public string StaticParam { get; set; } = "";

        [JsonPropertyName("format")]
        public string Format { get; set; } = "";

        [JsonPropertyName("start")]
        public string Start { get; set; } = "";

        [JsonPropertyName("end")]
        public string End { get; set; } = "";

        [JsonPropertyName("prefix")]
        public string Prefix { get; set; } = "";

        [JsonPropertyName("suffix")]
        public string Suffix { get; set; } = "";

        [JsonPropertyName("checksum_constant")]
        public int ChecksumConstant { get; set; }

        [JsonPropertyName("checksum_indexes")]
        public List<int> ChecksumIndexes { get; set; } = new();

        [JsonPropertyName("app_token")]
        public string AppToken { get; set; } = "";

        [JsonPropertyName("revision")]
        public string Revision { get; set; } = "";
    }

    /// <summary>
    /// Raw webhook event with unparsed data.
    /// </summary>
    public class WebhookEvent
    {
        [JsonPropertyName("eventType")]
        public string EventType { get; set; } = "";

        [JsonPropertyName("live")]
        public bool Live { get; set; }

        [JsonPropertyName("data")]
        public JsonElement Data { get; set; }
    }

    /// <summary>
    /// Data payload for connection.created events.
    /// </summary>
    public class ConnectionCreatedEventData
    {
        [JsonPropertyName("connection")]
        public WebhookConnection Connection { get; set; } = new();

        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    }

    /// <summary>
    /// Data payload for connection.updated events.
    /// </summary>
    public class ConnectionUpdatedEventData
    {
        [JsonPropertyName("connection")]
        public WebhookConnection Connection { get; set; } = new();

        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    }

    /// <summary>
    /// Data payload for connection.expired events.
    /// </summary>
    public class ConnectionExpiredEventData
    {
        [JsonPropertyName("connection")]
        public WebhookConnection Connection { get; set; } = new();

        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    }

    /// <summary>
    /// Data payload for rules.updated events.
    /// </summary>
    public class RulesUpdatedEventData
    {
        [JsonPropertyName("rules")]
        public WebhookDynamicRules Rules { get; set; } = new();

        [JsonPropertyName("revision")]
        public string Revision { get; set; } = "";
    }

    // ========================================================================
    // Verification
    // ========================================================================

    /// <summary>
    /// Provides methods for Svix webhook signature verification.
    /// </summary>
    public static class WebhookVerifier
    {
        /// <summary>
        /// Extract and validate Svix headers from a dictionary.
        /// </summary>
        public static WebhookHeaders ExtractHeaders(IDictionary<string, string> headers)
        {
            string? Get(string name)
            {
                if (headers.TryGetValue(name, out var val)) return val;
                if (headers.TryGetValue(name.ToLowerInvariant(), out val)) return val;
                return null;
            }

            var svixId = Get("svix-id");
            var svixTimestamp = Get("svix-timestamp");
            var svixSignature = Get("svix-signature");

            if (string.IsNullOrEmpty(svixId) || string.IsNullOrEmpty(svixTimestamp) || string.IsNullOrEmpty(svixSignature))
            {
                throw new WebhookVerificationException(
                    "Missing required webhook headers (svix-id, svix-timestamp, svix-signature)",
                    "MISSING_HEADERS");
            }

            return new WebhookHeaders(svixId!, svixTimestamp!, svixSignature!);
        }

        /// <summary>
        /// Verify a webhook signature using the Svix HMAC-SHA256 protocol.
        /// </summary>
        /// <param name="payload">Raw JSON payload string.</param>
        /// <param name="headers">Extracted webhook headers.</param>
        /// <param name="secret">Webhook signing secret (with or without whsec_ prefix).</param>
        /// <param name="tolerance">Maximum allowed timestamp age in seconds (default: 300).</param>
        /// <returns>True if valid.</returns>
        public static bool VerifySignature(string payload, WebhookHeaders headers, string secret, int tolerance = 300)
        {
            // Timestamp check
            if (!long.TryParse(headers.SvixTimestamp, out var ts))
            {
                throw new WebhookVerificationException("Invalid timestamp format", "INVALID_TIMESTAMP");
            }
            var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            if (Math.Abs(now - ts) > tolerance)
            {
                throw new WebhookVerificationException("Webhook timestamp too old", "TIMESTAMP_TOO_OLD");
            }

            // Compute expected signature
            var cleanSecret = secret.StartsWith("whsec_") ? secret[6..] : secret;
            var key = Convert.FromBase64String(cleanSecret);
            var signed = $"{headers.SvixId}.{headers.SvixTimestamp}.{payload}";
            using var hmac = new HMACSHA256(key);
            var expectedBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(signed));
            var expected = Convert.ToBase64String(expectedBytes);

            // Parse provided signatures
            var sigs = headers.SvixSignature
                .Split(' ')
                .Select(s => s.Split(',', 2))
                .Where(parts => parts.Length == 2 && parts[0] == "v1")
                .Select(parts => parts[1])
                .ToList();

            if (sigs.Count == 0)
            {
                throw new WebhookVerificationException("No valid v1 signatures found", "NO_VALID_SIGNATURES");
            }

            // Constant-time comparison
            var expectedBytesForCompare = Encoding.UTF8.GetBytes(expected);
            foreach (var sig in sigs)
            {
                var sigBytes = Encoding.UTF8.GetBytes(sig);
                if (CryptographicOperations.FixedTimeEquals(expectedBytesForCompare, sigBytes))
                {
                    return true;
                }
            }

            throw new WebhookVerificationException("Signature verification failed", "SIGNATURE_MISMATCH");
        }

        /// <summary>
        /// Verify a webhook and return the parsed event.
        /// </summary>
        public static WebhookEvent VerifyPayload(string payload, IDictionary<string, string> headers, string secret, int tolerance = 300)
        {
            var wh = ExtractHeaders(headers);
            VerifySignature(payload, wh, secret, tolerance);

            try
            {
                return JsonSerializer.Deserialize<WebhookEvent>(payload)
                    ?? throw new WebhookVerificationException("Failed to parse webhook payload", "INVALID_JSON");
            }
            catch (JsonException)
            {
                throw new WebhookVerificationException("Failed to parse webhook payload as JSON", "INVALID_JSON");
            }
        }

        /// <summary>
        /// Parse the Data property of a WebhookEvent into a typed object.
        /// </summary>
        public static T ParseEventData<T>(WebhookEvent webhookEvent)
        {
            return JsonSerializer.Deserialize<T>(webhookEvent.Data.GetRawText())
                ?? throw new InvalidOperationException("Failed to deserialize event data");
        }

        /// <summary>
        /// Check if an exception is a WebhookVerificationException.
        /// </summary>
        public static bool IsVerificationError(Exception ex) => ex is WebhookVerificationException;
    }

    // ========================================================================
    // Router
    // ========================================================================

    /// <summary>
    /// Routes verified webhook events to registered handler functions.
    /// </summary>
    public class WebhookRouter
    {
        private readonly Dictionary<string, Func<WebhookEvent, Task>> _handlers = new();
        private Func<WebhookEvent, Task>? _defaultHandler;
        private Action<Exception, WebhookEvent?>? _errorHandler;
        private string _secret;
        private int _tolerance;

        public WebhookRouter(string secret, int tolerance = 300)
        {
            _secret = secret;
            _tolerance = tolerance;
        }

        /// <summary>
        /// Register a handler for a specific event type.
        /// </summary>
        public WebhookRouter On(string eventType, Func<WebhookEvent, Task> handler)
        {
            _handlers[eventType] = handler;
            return this;
        }

        /// <summary>
        /// Register a synchronous handler for a specific event type.
        /// </summary>
        public WebhookRouter On(string eventType, Action<WebhookEvent> handler)
        {
            _handlers[eventType] = (evt) => { handler(evt); return Task.CompletedTask; };
            return this;
        }

        /// <summary>
        /// Register a default handler for unmatched event types.
        /// </summary>
        public WebhookRouter OnDefault(Func<WebhookEvent, Task> handler)
        {
            _defaultHandler = handler;
            return this;
        }

        /// <summary>
        /// Register an error handler.
        /// </summary>
        public WebhookRouter OnError(Action<Exception, WebhookEvent?> handler)
        {
            _errorHandler = handler;
            return this;
        }

        /// <summary>
        /// Verify and route a webhook from a raw payload and headers.
        /// </summary>
        public async Task HandlePayloadAsync(string payload, IDictionary<string, string> headers)
        {
            try
            {
                var webhookEvent = WebhookVerifier.VerifyPayload(payload, headers, _secret, _tolerance);
                await ProcessEventAsync(webhookEvent);
            }
            catch (Exception ex)
            {
                if (_errorHandler != null)
                    _errorHandler(ex, null);
                else
                    throw;
            }
        }

        /// <summary>
        /// Verify and route a webhook from a Stream and headers (e.g., ASP.NET Core).
        /// </summary>
        public async Task HandleRequestAsync(Stream body, IDictionary<string, string> headers)
        {
            using var reader = new StreamReader(body, Encoding.UTF8);
            var payload = await reader.ReadToEndAsync();
            await HandlePayloadAsync(payload, headers);
        }

        /// <summary>
        /// Update the webhook secret at runtime.
        /// </summary>
        public void UpdateSecret(string secret) => _secret = secret;

        /// <summary>
        /// Update the timestamp tolerance at runtime.
        /// </summary>
        public void UpdateTolerance(int tolerance) => _tolerance = tolerance;

        private async Task ProcessEventAsync(WebhookEvent webhookEvent)
        {
            try
            {
                if (!_handlers.TryGetValue(webhookEvent.EventType, out var handler))
                {
                    handler = _defaultHandler;
                }

                if (handler == null) return;

                await handler(webhookEvent);
            }
            catch (Exception ex)
            {
                if (_errorHandler != null)
                    _errorHandler(ex, webhookEvent);
                else
                    throw;
            }
        }
    }
}
