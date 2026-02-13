using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OFAuth;
using OFAuth.Models;

namespace OFAuth.Examples
{
    class SandboxComprehensive
    {
        private static readonly string ApiKey = Environment.GetEnvironmentVariable("OFAUTH_API_KEY") ?? "";
        private static readonly string ConnectionId = Environment.GetEnvironmentVariable("OFAUTH_CONNECTION_ID") ?? "";
        private static readonly string BaseUrl = Environment.GetEnvironmentVariable("OFAUTH_BASE_URL") ?? "https://api.ofauth.com";

        private static int passed = 0;
        private static int failed = 0;
        private static List<(string test, string error)> errors = new();

        static void Success(string name, object? data = null)
        {
            passed++;
            Console.WriteLine($"  ✓ {name}");
        }

        static void Fail(string name, Exception ex)
        {
            failed++;
            var message = ex is OFAuthException ofe 
                ? $"HTTP {ofe.Status}: {ofe.Message}" 
                : ex.Message;
            errors.Add((name, message));
            Console.WriteLine($"  ✗ {name}: {message}");
        }

        static async Task TestAccountAPI(OFAuthClient client)
        {
            Console.WriteLine("\n📋 Account API");
            Console.WriteLine("----------------------------------------");

            // Whoami
            try
            {
                var data = await client.GetAsync<GetV2AccountWhoamiResponse>("/v2/account/whoami");
                Success("Whoami");
                Console.WriteLine($"    → id: {data.Id}");
                Console.WriteLine($"    → name: {data.Name}");
            }
            catch (Exception ex)
            {
                Fail("Whoami", ex);
            }

            // List Connections
            try
            {
                var data = await client.GetAsync<GetV2AccountConnectionsResponse>("/v2/account/connections");
                Success("ListConnections");
                Console.WriteLine($"    → list: [{data.List.Count} items]");
                Console.WriteLine($"    → hasMore: {data.HasMore}");
            }
            catch (Exception ex)
            {
                Fail("ListConnections", ex);
            }

            // Get Connection Settings
            try
            {
                var data = await client.GetAsync<Dictionary<string, object>>($"/v2/account/connections/{ConnectionId}/settings");
                Success("GetConnectionSettings");
            }
            catch (Exception ex)
            {
                Fail("GetConnectionSettings", ex);
            }

            // Get Account Settings
            try
            {
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/account/settings");
                Success("GetAccountSettings");
            }
            catch (Exception ex)
            {
                Fail("GetAccountSettings", ex);
            }
        }

        static async Task TestSelfAPI(OFAuthClient client)
        {
            Console.WriteLine("\n👤 Self API");
            Console.WriteLine("----------------------------------------");

            // Get Self
            try
            {
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/self");
                Success("GetSelf");
                if (data.TryGetValue("id", out var id))
                    Console.WriteLine($"    → id: {id}");
                if (data.TryGetValue("username", out var username))
                    Console.WriteLine($"    → username: {username}");
            }
            catch (Exception ex)
            {
                Fail("GetSelf", ex);
            }

            // List Notifications
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/self/notifications", query);
                Success("ListNotifications");
            }
            catch (Exception ex)
            {
                Fail("ListNotifications", ex);
            }

            // List Release Forms
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/self/release-forms", query);
                Success("ListReleaseForms");
            }
            catch (Exception ex)
            {
                Fail("ListReleaseForms", ex);
            }

            // List Tagged Friend Users
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/self/tagged-friend-users", query);
                Success("ListTaggedFriendUsers");
            }
            catch (Exception ex)
            {
                Fail("ListTaggedFriendUsers", ex);
            }
        }

        static async Task TestPostsAPI(OFAuthClient client)
        {
            Console.WriteLine("\n📝 Posts API");
            Console.WriteLine("----------------------------------------");

            // List Posts
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<GetV2AccessPostsResponse>("/v2/access/posts", query);
                Success("ListPosts");
                Console.WriteLine($"    → list: [{data.List.Count} items]");
                Console.WriteLine($"    → hasMore: {data.HasMore}");

                // Get single post if available
                if (data.List.Count > 0)
                {
                    var postId = data.List[0].Id;
                    try
                    {
                        var post = await client.GetAsync<Dictionary<string, object>>($"/v2/access/posts/{postId}");
                        Success($"GetPost (id={postId})");
                    }
                    catch (Exception ex)
                    {
                        Fail($"GetPost (id={postId})", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Fail("ListPosts", ex);
            }
        }

        static async Task TestMessagesAPI(OFAuthClient client)
        {
            Console.WriteLine("\n💬 Messages API");
            Console.WriteLine("----------------------------------------");

            // List Chats
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/chats", query);
                Success("ListChats");
            }
            catch (Exception ex)
            {
                Fail("ListChats", ex);
            }

            // List Sent Mass Messages
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/analytics/mass-messages/sent", query);
                Success("ListSentMassMessages");
            }
            catch (Exception ex)
            {
                Fail("ListMassMessages", ex);
            }
        }

        static async Task TestSubscribersAPI(OFAuthClient client)
        {
            Console.WriteLine("\n👥 Subscribers API");
            Console.WriteLine("----------------------------------------");

            // List Subscribers (all)
            try
            {
                var query = new Dictionary<string, string?> { { "type", "all" }, { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/subscribers", query);
                Success("ListSubscribers (all)");
            }
            catch (Exception ex)
            {
                Fail("ListSubscribers (all)", ex);
            }

            // List Subscribers (active)
            try
            {
                var query = new Dictionary<string, string?> { { "type", "active" }, { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/subscribers", query);
                Success("ListSubscribers (active)");
            }
            catch (Exception ex)
            {
                Fail("ListSubscribers (active)", ex);
            }
        }

        static async Task TestSubscriptionsAPI(OFAuthClient client)
        {
            Console.WriteLine("\n📊 Subscriptions API");
            Console.WriteLine("----------------------------------------");

            // Get Subscriptions Count
            try
            {
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/subscriptions/count");
                Success("GetSubscriptionsCount");
            }
            catch (Exception ex)
            {
                Fail("GetSubscriptionsCount", ex);
            }

            // List Subscriptions
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/subscriptions", query);
                Success("ListSubscriptions");
            }
            catch (Exception ex)
            {
                Fail("ListSubscriptions", ex);
            }
        }

        static async Task TestUsersAPI(OFAuthClient client)
        {
            Console.WriteLine("\n🔍 Users API");
            Console.WriteLine("----------------------------------------");

            // Get Blocked Users
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/users/blocked", query);
                Success("GetBlockedUsers");
            }
            catch (Exception ex)
            {
                Fail("GetBlockedUsers", ex);
            }

            // Get Restricted Users
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/users/restrict", query);
                Success("GetRestrictedUsers");
            }
            catch (Exception ex)
            {
                Fail("GetRestrictedUsers", ex);
            }

            try
            {
                var query = new Dictionary<string, string?> { { "query", "test" }, { "limit", "10" } };
                var data = await client.GetAsync<List<object>>("/v2/access/users/search", query);
                Success("SearchUsers");
            }
            catch (Exception ex)
            {
                Fail("SearchUsers", ex);
            }
        }

        static async Task TestUserListsAPI(OFAuthClient client)
        {
            Console.WriteLine("\n📁 User Lists API");
            Console.WriteLine("----------------------------------------");

            // List User Lists
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/users/lists", query);
                Success("ListUserLists");
            }
            catch (Exception ex)
            {
                Fail("ListUserLists", ex);
            }
        }

        static async Task TestVaultAPI(OFAuthClient client)
        {
            Console.WriteLine("\n🗄️ Vault API");
            Console.WriteLine("----------------------------------------");

            // List Vault Media
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<GetV2AccessVaultMediaResponse>("/v2/access/vault/media", query);
                Success("ListVaultMedia");
                Console.WriteLine($"    → list: [{data.List.Count} items]");
            }
            catch (Exception ex)
            {
                Fail("ListVaultMedia", ex);
            }

            // List Vault Lists
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<GetV2AccessVaultListsResponse>("/v2/access/vault/lists", query);
                Success("ListVaultLists");
                Console.WriteLine($"    → list: [{data.List.Count} items]");
            }
            catch (Exception ex)
            {
                Fail("ListVaultLists", ex);
            }
        }

        static async Task TestEarningsAPI(OFAuthClient client)
        {
            Console.WriteLine("\n💰 Earnings API");
            Console.WriteLine("----------------------------------------");

            var now = DateTime.Now;
            var thirtyDaysAgo = now.AddDays(-30);
            var startDate = thirtyDaysAgo.ToString("yyyy-MM-dd");
            var endDate = now.ToString("yyyy-MM-dd");

            // Get Earnings Chart
            try
            {
                var query = new Dictionary<string, string?> { { "startDate", startDate }, { "endDate", endDate } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/earnings/chart", query);
                Success("GetEarningsChart");
            }
            catch (Exception ex)
            {
                Fail("GetEarningsChart", ex);
            }

            // List Transactions
            try
            {
                var query = new Dictionary<string, string?> { { "startDate", startDate }, { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/earnings/transactions", query);
                Success("ListTransactions");
            }
            catch (Exception ex)
            {
                Fail("ListTransactions", ex);
            }

            // List Chargebacks
            try
            {
                var query = new Dictionary<string, string?> { { "startDate", startDate }, { "endDate", endDate }, { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/earnings/chargebacks", query);
                Success("ListChargebacks");
            }
            catch (Exception ex)
            {
                Fail("ListChargebacks", ex);
            }
        }

        static async Task TestAnalyticsAPI(OFAuthClient client)
        {
            Console.WriteLine("\n📈 Analytics API");
            Console.WriteLine("----------------------------------------");

            var now = DateTime.Now;
            var thirtyDaysAgo = now.AddDays(-30);
            var startDate = thirtyDaysAgo.ToString("yyyy-MM-dd");
            var endDate = now.ToString("yyyy-MM-dd");

            // Get Posts Chart
            try
            {
                var query = new Dictionary<string, string?> { { "startDate", startDate }, { "endDate", endDate } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/analytics/posts/chart", query);
                Success("GetPostsChart");
            }
            catch (Exception ex)
            {
                Fail("GetPostsChart", ex);
            }

            // Get Posts Top
            try
            {
                var query = new Dictionary<string, string?> { { "startDate", startDate }, { "endDate", endDate }, { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/analytics/posts/top", query);
                Success("GetPostsTop");
            }
            catch (Exception ex)
            {
                Fail("GetPostsTop", ex);
            }

            // Get Stories Chart
            try
            {
                var query = new Dictionary<string, string?> { { "startDate", startDate }, { "endDate", endDate } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/analytics/stories/chart", query);
                Success("GetStoriesChart");
            }
            catch (Exception ex)
            {
                Fail("GetStoriesChart", ex);
            }
        }

        static async Task TestPromotionsAPI(OFAuthClient client)
        {
            Console.WriteLine("\n🎁 Promotions API");
            Console.WriteLine("----------------------------------------");

            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<List<object>>("/v2/access/promotions", query);
                Success("ListPromotions");
            }
            catch (Exception ex)
            {
                Fail("ListPromotions", ex);
            }

            // List Tracking Links
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/promotions/tracking-links", query);
                Success("ListTrackingLinks");
            }
            catch (Exception ex)
            {
                Fail("ListTrackingLinks", ex);
            }

            // List Trial Links
            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<Dictionary<string, object>>("/v2/access/promotions/trial-links", query);
                Success("ListTrialLinks");
            }
            catch (Exception ex)
            {
                Fail("ListTrialLinks", ex);
            }

            try
            {
                var query = new Dictionary<string, string?> { { "limit", "10" } };
                var data = await client.GetAsync<List<object>>("/v2/access/promotions/bundles", query);
                Success("ListBundles");
            }
            catch (Exception ex)
            {
                Fail("ListBundles", ex);
            }
        }

        static async Task Main(string[] args)
        {
            if (string.IsNullOrEmpty(ApiKey) || string.IsNullOrEmpty(ConnectionId))
            {
                Console.WriteLine("Missing required environment variables:");
                Console.WriteLine("  OFAUTH_API_KEY - Your OFAuth API key");
                Console.WriteLine("  OFAUTH_CONNECTION_ID - Your connection ID");
                Console.WriteLine("  OFAUTH_BASE_URL - (optional) API base URL");
                Environment.Exit(1);
            }

            Console.WriteLine("============================================================");
            Console.WriteLine("OFAuth C# SDK - Comprehensive Sandbox Test");
            Console.WriteLine("============================================================");
            Console.WriteLine($"\nBase URL: {BaseUrl}");
            Console.WriteLine($"Connection ID: {ConnectionId}");
            Console.WriteLine($"API Key: {ApiKey.Substring(0, Math.Min(20, ApiKey.Length))}...");

            using var client = new OFAuthClient(ApiKey, BaseUrl).WithConnectionId(ConnectionId);

            await TestAccountAPI(client);
            await TestSelfAPI(client);
            await TestPostsAPI(client);
            await TestMessagesAPI(client);
            await TestSubscribersAPI(client);
            await TestSubscriptionsAPI(client);
            await TestUsersAPI(client);
            await TestUserListsAPI(client);
            await TestVaultAPI(client);
            await TestEarningsAPI(client);
            await TestAnalyticsAPI(client);
            await TestPromotionsAPI(client);

            var total = passed + failed;
            Console.WriteLine("\n============================================================");
            Console.WriteLine($"Results: {passed}/{total} passed");

            if (failed > 0)
            {
                Console.WriteLine("\nFailed tests:");
                foreach (var (test, error) in errors)
                {
                    Console.WriteLine($"  - {test}: {error}");
                }
                Environment.Exit(1);
            }
        }
    }
}
