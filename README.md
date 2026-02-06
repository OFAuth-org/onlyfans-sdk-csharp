# OnlyFans API - C# SDK

[![NuGet](https://img.shields.io/nuget/v/OnlyFans.SDK)](https://www.nuget.org/packages/OnlyFans.SDK/)
[![License](https://img.shields.io/badge/license-Apache--2.0-blue)](LICENSE)

The official **OnlyFans API C# SDK** by [OFAuth](https://ofauth.com). A type-safe .NET client for integrating with the OnlyFans API using HttpClient and System.Text.Json. Build OnlyFans tools, dashboards, analytics, and automations in C# / .NET.

> **What is this?** This is an SDK for the [OnlyFans API](https://ofauth.com) via OFAuth — the only authorized way to programmatically access OnlyFans data. Use it to build OnlyFans integrations, manage creator accounts, access earnings data, automate messaging, and more.

## Installation

```bash
dotnet add package OnlyFans.SDK
```

Or via NuGet Package Manager:
```powershell
Install-Package OnlyFans.SDK
```

## Quick Start

```csharp
using OFAuth;

var client = new OFAuthClient("your-api-key");

var account = await client.GetAsync<WhoamiResponse>("/v2/account/whoami");
Console.WriteLine($"Account ID: {account.Id}");
Console.WriteLine($"Permissions: {string.Join(", ", account.Permissions)}");
```

## Features

- Full type safety with generated model classes (473 types)
- Async/await throughout
- IDisposable for proper resource cleanup
- Fluent configuration
- CancellationToken support
- Webhook verification and routing (Svix-compatible)
- .NET 8.0+ support

## Configuration

```csharp
using OFAuth;

// Basic configuration
var client = new OFAuthClient("your-api-key");

// With default connection ID (for access API calls)
var client = new OFAuthClient("your-api-key")
    .WithConnectionId("conn_xxx");

// Full configuration
var client = new OFAuthClient(
    apiKey: "your-api-key",
    baseUrl: "https://api-next.ofauth.com",  // Optional
    httpClient: customHttpClient              // Optional, for custom settings
);

// Using statement for automatic disposal
using var client = new OFAuthClient("your-api-key");
```

## Usage Examples

### Account Operations

```csharp
using OFAuth;

var client = new OFAuthClient("your-api-key");

// Get account info
var account = await client.GetAsync<WhoamiResponse>("/v2/account/whoami");
Console.WriteLine($"Account ID: {account.Id}");

// List all connections
var connections = await client.GetAsync<ConnectionsListResponse>("/v2/account/connections");
foreach (var conn in connections.List)
{
    Console.WriteLine($"{conn.Id}: {conn.UserData.Username} ({conn.Status})");
}

// List with filters
var activeConnections = await client.GetAsync<ConnectionsListResponse>(
    "/v2/account/connections",
    query: new Dictionary<string, string?>
    {
        ["status"] = "active",
        ["limit"] = "10"
    }
);

// Get connection settings
var settings = await client.GetAsync<ConnectionSettingsResponse>(
    $"/v2/account/connections/{connectionId}/settings"
);
```

### Access API (OnlyFans Data)

Access endpoints require a connection ID:

```csharp
// Set connection ID on client
var client = new OFAuthClient("your-api-key")
    .WithConnectionId("conn_xxx");

// Get creator profile
var profile = await client.GetAsync<SelfResponse>("/v2/access/self");
Console.WriteLine($"Username: {profile.Username}");
Console.WriteLine($"Subscribers: {profile.SubscribersCount}");

// Or pass connection ID per-request
var profile = await client.GetAsync<SelfResponse>(
    "/v2/access/self",
    connectionId: "conn_xxx"
);

// Get earnings data
var earnings = await client.GetAsync<EarningsChartResponse>(
    "/v2/access/earnings/chart",
    query: new Dictionary<string, string?>
    {
        ["startDate"] = "2024-01-01",
        ["endDate"] = "2024-01-31"
    }
);

// List posts
var posts = await client.GetAsync<PostsListResponse>(
    "/v2/access/posts",
    query: new Dictionary<string, string?> { ["limit"] = "20" }
);
foreach (var post in posts.List)
{
    Console.WriteLine($"Post {post.Id}: {post.Text?.Substring(0, Math.Min(50, post.Text.Length))}");
}
```

### Proxy Requests

Call any OnlyFans API endpoint directly:

```csharp
var client = new OFAuthClient("your-api-key")
    .WithConnectionId("conn_xxx");

// GET request
var user = await client.GetAsync<Dictionary<string, object>>("/v2/access/proxy/users/me");
Console.WriteLine($"User: {user["name"]}");

// POST request with body
var response = await client.PostAsync<MessageResponse>(
    "/v2/access/proxy/messages/queue",
    body: new
    {
        text = "Hello!",
        lockedText = false
    }
);

// With query parameters
var subscribers = await client.GetAsync<SubscribersResponse>(
    "/v2/access/proxy/subscriptions/subscribers",
    query: new Dictionary<string, string?> { ["limit"] = "10" }
);
```

## Error Handling

```csharp
using OFAuth;

var client = new OFAuthClient("your-api-key");

try
{
    var account = await client.GetAsync<WhoamiResponse>("/v2/account/whoami");
}
catch (OFAuthException ex)
{
    Console.WriteLine($"API Error {ex.Status}: {ex.Message}");
    Console.WriteLine($"Error code: {ex.Code}");
    Console.WriteLine($"Details: {ex.Details}");
}
```

## Webhooks

Svix-compatible HMAC-SHA256 webhook verification:

```csharp
using OFAuth.Webhooks;

// Verify a webhook
var headers = new Dictionary<string, string>
{
    { "svix-id", "..." },
    { "svix-timestamp", "..." },
    { "svix-signature", "..." }
};

var webhookEvent = WebhookVerifier.VerifyPayload(payload, headers, "whsec_...");
Console.WriteLine($"Event: {webhookEvent.EventType}");

// Route webhooks
var router = new WebhookRouter("whsec_...");
router.On("connection.created", evt =>
{
    var data = WebhookVerifier.ParseEventData<ConnectionCreatedEventData>(evt);
    Console.WriteLine($"New connection: {data.Connection.Id}");
});

await router.HandlePayloadAsync(payload, headers);
```

## Dependency Injection

```csharp
// In Startup.cs or Program.cs
services.AddSingleton<OFAuthClient>(sp => 
    new OFAuthClient(Configuration["OFAuth:ApiKey"]));

// Or with HttpClientFactory
services.AddHttpClient<OFAuthClient>((sp, client) =>
{
    client.BaseAddress = new Uri("https://api-next.ofauth.com");
});
```

## License

Apache-2.0
