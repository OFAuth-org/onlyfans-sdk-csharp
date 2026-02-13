// Auto-generated from OpenAPI spec - do not edit directly
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OFAuth.Models
{
    public class GetV2AccountWhoamiResponse
    {
    
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    
    
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }
    }

    public enum GetV2AccountConnectionsResponseListItemStatusEnum
    {
        [JsonPropertyName("active")]
        Active,
        [JsonPropertyName("expired")]
        Expired,
        [JsonPropertyName("awaiting_2fa")]
        Awaiting2fa
    }

    public class GetV2AccountConnectionsResponseListItemUserData
    {
    
        /// <summary>The ID of the user.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        /// <summary>The name of the user.</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        /// <summary>The username of the user.</summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        /// <summary>The avatar of the user.</summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    }

    public class GetV2AccountConnectionsResponseListItem
    {
    
        /// <summary>The status of the connection.</summary>
        [JsonPropertyName("status")]
        public GetV2AccountConnectionsResponseListItemStatusEnum Status { get; set; }
    
    
        /// <summary>The ID of the connection.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        /// <summary>Data could be outdated if the connection is expired, but will be updated once the account has been reconnected.</summary>
        [JsonPropertyName("userData")]
        public GetV2AccountConnectionsResponseListItemUserData UserData { get; set; }
    
    
        /// <summary>The permissions of the connection.</summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }
    
    
        /// <summary>The expiration date of the connection.</summary>
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    
    
        /// <summary>The creation date of the connection.</summary>
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        /// <summary>The last update date of the connection.</summary>
        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }
    
    
        /// <summary>The client reference ID of the connection.</summary>
        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    
    
        /// <summary>Whether this is an imported (non-managed) connection.</summary>
        [JsonPropertyName("imported")]
        public bool Imported { get; set; }
    
    
        /// <summary>The last time the connection was checked or used.</summary>
        [JsonPropertyName("lastCheckedAt")]
        public string? LastCheckedAt { get; set; }
    }

    public class GetV2AccountConnectionsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccountConnectionsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public enum GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverridesImageQualitiesItemEnum
    {
        [JsonPropertyName("thumb")]
        Thumb,
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("full")]
        Full
    }

    public enum GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverridesVideoQualitiesItemEnum
    {
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("720p")]
        _720p,
        [JsonPropertyName("1080p")]
        _1080p,
        [JsonPropertyName("source")]
        Source
    }

    public enum GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverridesStorageLimitPurgeStrategyEnum
    {
        [JsonPropertyName("purge_oldest")]
        PurgeOldest,
        [JsonPropertyName("purge_largest")]
        PurgeLargest,
        [JsonPropertyName("purge_smallest")]
        PurgeSmallest,
        [JsonPropertyName("block_new")]
        BlockNew
    }

    public class GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverrides
    {
    
        [JsonPropertyName("autoCacheVault")]
        public bool? AutoCacheVault { get; set; }
    
    
        [JsonPropertyName("autoCacheMessages")]
        public bool? AutoCacheMessages { get; set; }
    
    
        [JsonPropertyName("autoCachePosts")]
        public bool? AutoCachePosts { get; set; }
    
    
        [JsonPropertyName("autoCacheStories")]
        public bool? AutoCacheStories { get; set; }
    
    
        [JsonPropertyName("minAccessCountVault")]
        public double? MinAccessCountVault { get; set; }
    
    
        [JsonPropertyName("minAccessCountMessages")]
        public double? MinAccessCountMessages { get; set; }
    
    
        [JsonPropertyName("minAccessCountPosts")]
        public double? MinAccessCountPosts { get; set; }
    
    
        [JsonPropertyName("minAccessCountStories")]
        public double? MinAccessCountStories { get; set; }
    
    
        [JsonPropertyName("cacheImages")]
        public bool? CacheImages { get; set; }
    
    
        [JsonPropertyName("cacheVideos")]
        public bool? CacheVideos { get; set; }
    
    
        [JsonPropertyName("cacheAudio")]
        public bool? CacheAudio { get; set; }
    
    
        [JsonPropertyName("imageQualities")]
        public List<GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverridesImageQualitiesItemEnum> ImageQualities { get; set; }
    
    
        [JsonPropertyName("videoQualities")]
        public List<GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverridesVideoQualitiesItemEnum> VideoQualities { get; set; }
    
    
        [JsonPropertyName("retentionDays")]
        public double? RetentionDays { get; set; }
    
    
        [JsonPropertyName("accessExpiryDays")]
        public double? AccessExpiryDays { get; set; }
    
    
        [JsonPropertyName("presignedUrlTtlSeconds")]
        public double? PresignedUrlTtlSeconds { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double? StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitPurgeStrategy")]
        public GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverridesStorageLimitPurgeStrategyEnum? StorageLimitPurgeStrategy { get; set; }
    }

    public class GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusStats
    {
    
        [JsonPropertyName("vaultPlusEnabled")]
        public bool VaultPlusEnabled { get; set; }
    
    
        [JsonPropertyName("totalStorageBytes")]
        public double TotalStorageBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("storedCount")]
        public double StoredCount { get; set; }
    
    
        [JsonPropertyName("storageUsagePercent")]
        public double StorageUsagePercent { get; set; }
    }

    public class GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlus
    {
    
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    
    
        [JsonPropertyName("settingsOverrides")]
        public GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusSettingsOverrides? SettingsOverrides { get; set; }
    
    
        [JsonPropertyName("stats")]
        public GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlusStats Stats { get; set; }
    }

    public class GetV2AccountConnectionsConnectionIdSettingsResponse
    {
    
        [JsonPropertyName("connectionId")]
        public string ConnectionId { get; set; }
    
    
        [JsonPropertyName("vaultPlus")]
        public GetV2AccountConnectionsConnectionIdSettingsResponseVaultPlus VaultPlus { get; set; }
    }

    public enum PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverridesImageQualitiesItemEnum
    {
        [JsonPropertyName("thumb")]
        Thumb,
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("full")]
        Full
    }

    public enum PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverridesVideoQualitiesItemEnum
    {
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("720p")]
        _720p,
        [JsonPropertyName("1080p")]
        _1080p,
        [JsonPropertyName("source")]
        Source
    }

    public enum PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverridesStorageLimitPurgeStrategyEnum
    {
        [JsonPropertyName("purge_oldest")]
        PurgeOldest,
        [JsonPropertyName("purge_largest")]
        PurgeLargest,
        [JsonPropertyName("purge_smallest")]
        PurgeSmallest,
        [JsonPropertyName("block_new")]
        BlockNew
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverrides
    {
    
        [JsonPropertyName("autoCacheVault")]
        public bool? AutoCacheVault { get; set; }
    
    
        [JsonPropertyName("autoCacheMessages")]
        public bool? AutoCacheMessages { get; set; }
    
    
        [JsonPropertyName("autoCachePosts")]
        public bool? AutoCachePosts { get; set; }
    
    
        [JsonPropertyName("autoCacheStories")]
        public bool? AutoCacheStories { get; set; }
    
    
        [JsonPropertyName("minAccessCountVault")]
        public double? MinAccessCountVault { get; set; }
    
    
        [JsonPropertyName("minAccessCountMessages")]
        public double? MinAccessCountMessages { get; set; }
    
    
        [JsonPropertyName("minAccessCountPosts")]
        public double? MinAccessCountPosts { get; set; }
    
    
        [JsonPropertyName("minAccessCountStories")]
        public double? MinAccessCountStories { get; set; }
    
    
        [JsonPropertyName("cacheImages")]
        public bool? CacheImages { get; set; }
    
    
        [JsonPropertyName("cacheVideos")]
        public bool? CacheVideos { get; set; }
    
    
        [JsonPropertyName("cacheAudio")]
        public bool? CacheAudio { get; set; }
    
    
        [JsonPropertyName("imageQualities")]
        public List<PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverridesImageQualitiesItemEnum> ImageQualities { get; set; }
    
    
        [JsonPropertyName("videoQualities")]
        public List<PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverridesVideoQualitiesItemEnum> VideoQualities { get; set; }
    
    
        [JsonPropertyName("retentionDays")]
        public double? RetentionDays { get; set; }
    
    
        [JsonPropertyName("accessExpiryDays")]
        public double? AccessExpiryDays { get; set; }
    
    
        [JsonPropertyName("presignedUrlTtlSeconds")]
        public double? PresignedUrlTtlSeconds { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double? StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitPurgeStrategy")]
        public PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverridesStorageLimitPurgeStrategyEnum? StorageLimitPurgeStrategy { get; set; }
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusStats
    {
    
        [JsonPropertyName("vaultPlusEnabled")]
        public bool VaultPlusEnabled { get; set; }
    
    
        [JsonPropertyName("totalStorageBytes")]
        public double TotalStorageBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("storedCount")]
        public double StoredCount { get; set; }
    
    
        [JsonPropertyName("storageUsagePercent")]
        public double StorageUsagePercent { get; set; }
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlus
    {
    
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    
    
        [JsonPropertyName("settingsOverrides")]
        public PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusSettingsOverrides? SettingsOverrides { get; set; }
    
    
        [JsonPropertyName("stats")]
        public PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlusStats Stats { get; set; }
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsResponseSettings
    {
    
        [JsonPropertyName("connectionId")]
        public string ConnectionId { get; set; }
    
    
        [JsonPropertyName("vaultPlus")]
        public PatchV2AccountConnectionsConnectionIdSettingsResponseSettingsVaultPlus VaultPlus { get; set; }
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsResponsePurgeResult
    {
    
        [JsonPropertyName("purgedCount")]
        public double PurgedCount { get; set; }
    
    
        [JsonPropertyName("freedBytes")]
        public double FreedBytes { get; set; }
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsResponse
    {
    
        [JsonPropertyName("settings")]
        public PatchV2AccountConnectionsConnectionIdSettingsResponseSettings Settings { get; set; }
    
    
        [JsonPropertyName("purgeResult")]
        public PatchV2AccountConnectionsConnectionIdSettingsResponsePurgeResult? PurgeResult { get; set; }
    }

    public enum PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettingsImageQualitiesItemEnum
    {
        [JsonPropertyName("thumb")]
        Thumb,
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("full")]
        Full
    }

    public enum PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettingsVideoQualitiesItemEnum
    {
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("720p")]
        _720p,
        [JsonPropertyName("1080p")]
        _1080p,
        [JsonPropertyName("source")]
        Source
    }

    public enum PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettingsStorageLimitPurgeStrategyEnum
    {
        [JsonPropertyName("purge_oldest")]
        PurgeOldest,
        [JsonPropertyName("purge_largest")]
        PurgeLargest,
        [JsonPropertyName("purge_smallest")]
        PurgeSmallest,
        [JsonPropertyName("block_new")]
        BlockNew
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettings
    {
    
        [JsonPropertyName("autoCacheVault")]
        public bool? AutoCacheVault { get; set; }
    
    
        [JsonPropertyName("autoCacheMessages")]
        public bool? AutoCacheMessages { get; set; }
    
    
        [JsonPropertyName("autoCachePosts")]
        public bool? AutoCachePosts { get; set; }
    
    
        [JsonPropertyName("autoCacheStories")]
        public bool? AutoCacheStories { get; set; }
    
    
        [JsonPropertyName("minAccessCountVault")]
        public double? MinAccessCountVault { get; set; }
    
    
        [JsonPropertyName("minAccessCountMessages")]
        public double? MinAccessCountMessages { get; set; }
    
    
        [JsonPropertyName("minAccessCountPosts")]
        public double? MinAccessCountPosts { get; set; }
    
    
        [JsonPropertyName("minAccessCountStories")]
        public double? MinAccessCountStories { get; set; }
    
    
        [JsonPropertyName("cacheImages")]
        public bool? CacheImages { get; set; }
    
    
        [JsonPropertyName("cacheVideos")]
        public bool? CacheVideos { get; set; }
    
    
        [JsonPropertyName("cacheAudio")]
        public bool? CacheAudio { get; set; }
    
    
        [JsonPropertyName("imageQualities")]
        public List<PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettingsImageQualitiesItemEnum> ImageQualities { get; set; }
    
    
        [JsonPropertyName("videoQualities")]
        public List<PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettingsVideoQualitiesItemEnum> VideoQualities { get; set; }
    
    
        [JsonPropertyName("retentionDays")]
        public double? RetentionDays { get; set; }
    
    
        [JsonPropertyName("accessExpiryDays")]
        public double? AccessExpiryDays { get; set; }
    
    
        [JsonPropertyName("presignedUrlTtlSeconds")]
        public double? PresignedUrlTtlSeconds { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double? StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitPurgeStrategy")]
        public PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettingsStorageLimitPurgeStrategyEnum? StorageLimitPurgeStrategy { get; set; }
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlus
    {
    
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    
    
        [JsonPropertyName("settings")]
        public PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlusSettings? Settings { get; set; }
    }

    public class PatchV2AccountConnectionsConnectionIdSettingsRequest
    {
    
        [JsonPropertyName("vaultPlus")]
        public PatchV2AccountConnectionsConnectionIdSettingsRequestVaultPlus? VaultPlus { get; set; }
    }

    public enum PostV2AccountConnectionsImportResponseStatusEnum
    {
        [JsonPropertyName("active")]
        Active,
        [JsonPropertyName("expired")]
        Expired,
        [JsonPropertyName("awaiting_2fa")]
        Awaiting2fa
    }

    public class PostV2AccountConnectionsImportResponseUserData
    {
    
        /// <summary>The ID of the user.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        /// <summary>The name of the user.</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        /// <summary>The username of the user.</summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        /// <summary>The avatar of the user.</summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    }

    public class PostV2AccountConnectionsImportResponse
    {
    
        /// <summary>The status of the connection.</summary>
        [JsonPropertyName("status")]
        public PostV2AccountConnectionsImportResponseStatusEnum Status { get; set; }
    
    
        /// <summary>The ID of the connection.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        /// <summary>Data could be outdated if the connection is expired, but will be updated once the account has been reconnected.</summary>
        [JsonPropertyName("userData")]
        public PostV2AccountConnectionsImportResponseUserData UserData { get; set; }
    
    
        /// <summary>The permissions of the connection.</summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }
    
    
        /// <summary>The expiration date of the connection.</summary>
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    
    
        /// <summary>The creation date of the connection.</summary>
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        /// <summary>The last update date of the connection.</summary>
        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }
    
    
        /// <summary>The client reference ID of the connection.</summary>
        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    
    
        /// <summary>Whether this is an imported (non-managed) connection.</summary>
        [JsonPropertyName("imported")]
        public bool Imported { get; set; }
    
    
        /// <summary>The last time the connection was checked or used.</summary>
        [JsonPropertyName("lastCheckedAt")]
        public string? LastCheckedAt { get; set; }
    }

    public class PostV2AccountConnectionsImportRequest
    {
    
        /// <summary>The OnlyFans session cookie string. Must contain `auth_id`, `sess`, and `fp` values.</summary>
        [JsonPropertyName("cookie")]
        public string Cookie { get; set; }
    
    
        /// <summary>The user agent string that was used to create this session.</summary>
        [JsonPropertyName("userAgent")]
        public string UserAgent { get; set; }
    
    
        /// <summary>Permissions to grant. Defaults to organization permissions.</summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }
    
    
        /// <summary>Optional client reference ID for tracking.</summary>
        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    }

    public enum PatchV2AccountConnectionsImportConnectionIdResponseStatusEnum
    {
        [JsonPropertyName("active")]
        Active,
        [JsonPropertyName("expired")]
        Expired,
        [JsonPropertyName("awaiting_2fa")]
        Awaiting2fa
    }

    public class PatchV2AccountConnectionsImportConnectionIdResponseUserData
    {
    
        /// <summary>The ID of the user.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        /// <summary>The name of the user.</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        /// <summary>The username of the user.</summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        /// <summary>The avatar of the user.</summary>
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    }

    public class PatchV2AccountConnectionsImportConnectionIdResponse
    {
    
        /// <summary>The status of the connection.</summary>
        [JsonPropertyName("status")]
        public PatchV2AccountConnectionsImportConnectionIdResponseStatusEnum Status { get; set; }
    
    
        /// <summary>The ID of the connection.</summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        /// <summary>Data could be outdated if the connection is expired, but will be updated once the account has been reconnected.</summary>
        [JsonPropertyName("userData")]
        public PatchV2AccountConnectionsImportConnectionIdResponseUserData UserData { get; set; }
    
    
        /// <summary>The permissions of the connection.</summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }
    
    
        /// <summary>The expiration date of the connection.</summary>
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    
    
        /// <summary>The creation date of the connection.</summary>
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        /// <summary>The last update date of the connection.</summary>
        [JsonPropertyName("updatedAt")]
        public string UpdatedAt { get; set; }
    
    
        /// <summary>The client reference ID of the connection.</summary>
        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    
    
        /// <summary>Whether this is an imported (non-managed) connection.</summary>
        [JsonPropertyName("imported")]
        public bool Imported { get; set; }
    
    
        /// <summary>The last time the connection was checked or used.</summary>
        [JsonPropertyName("lastCheckedAt")]
        public string? LastCheckedAt { get; set; }
    }

    public class PatchV2AccountConnectionsImportConnectionIdRequest
    {
    
        /// <summary>The OnlyFans session cookie string. Must contain `auth_id`, `sess`, and `fp` values.</summary>
        [JsonPropertyName("cookie")]
        public string Cookie { get; set; }
    
    
        /// <summary>The user agent string that was used to create this session.</summary>
        [JsonPropertyName("userAgent")]
        public string UserAgent { get; set; }
    }

    public class GetV2AccountSettingsResponseVaultPlusDefaultSettings
    {
    
        [JsonPropertyName("autoCacheVault")]
        public bool AutoCacheVault { get; set; }
    
    
        [JsonPropertyName("autoCacheMessages")]
        public bool AutoCacheMessages { get; set; }
    
    
        [JsonPropertyName("autoCachePosts")]
        public bool AutoCachePosts { get; set; }
    
    
        [JsonPropertyName("autoCacheStories")]
        public bool AutoCacheStories { get; set; }
    
    
        [JsonPropertyName("minAccessCountVault")]
        public double MinAccessCountVault { get; set; }
    
    
        [JsonPropertyName("minAccessCountMessages")]
        public double MinAccessCountMessages { get; set; }
    
    
        [JsonPropertyName("minAccessCountPosts")]
        public double MinAccessCountPosts { get; set; }
    
    
        [JsonPropertyName("minAccessCountStories")]
        public double MinAccessCountStories { get; set; }
    
    
        [JsonPropertyName("cacheImages")]
        public bool CacheImages { get; set; }
    
    
        [JsonPropertyName("cacheVideos")]
        public bool CacheVideos { get; set; }
    
    
        [JsonPropertyName("cacheAudio")]
        public bool CacheAudio { get; set; }
    
    
        [JsonPropertyName("imageQualities")]
        public List<string> ImageQualities { get; set; }
    
    
        [JsonPropertyName("videoQualities")]
        public List<string> VideoQualities { get; set; }
    
    
        [JsonPropertyName("retentionDays")]
        public double RetentionDays { get; set; }
    
    
        [JsonPropertyName("accessExpiryDays")]
        public double AccessExpiryDays { get; set; }
    
    
        [JsonPropertyName("presignedUrlTtlSeconds")]
        public double PresignedUrlTtlSeconds { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitPurgeStrategy")]
        public string StorageLimitPurgeStrategy { get; set; }
    }

    public class GetV2AccountSettingsResponseVaultPlus
    {
    
        [JsonPropertyName("autoEnableForNewConnections")]
        public bool AutoEnableForNewConnections { get; set; }
    
    
        [JsonPropertyName("defaultSettings")]
        public GetV2AccountSettingsResponseVaultPlusDefaultSettings DefaultSettings { get; set; }
    }

    public class GetV2AccountSettingsResponse
    {
    
        [JsonPropertyName("vaultPlus")]
        public GetV2AccountSettingsResponseVaultPlus VaultPlus { get; set; }
    }

    public class PatchV2AccountSettingsResponseSettingsVaultPlusDefaultSettings
    {
    
        [JsonPropertyName("autoCacheVault")]
        public bool AutoCacheVault { get; set; }
    
    
        [JsonPropertyName("autoCacheMessages")]
        public bool AutoCacheMessages { get; set; }
    
    
        [JsonPropertyName("autoCachePosts")]
        public bool AutoCachePosts { get; set; }
    
    
        [JsonPropertyName("autoCacheStories")]
        public bool AutoCacheStories { get; set; }
    
    
        [JsonPropertyName("minAccessCountVault")]
        public double MinAccessCountVault { get; set; }
    
    
        [JsonPropertyName("minAccessCountMessages")]
        public double MinAccessCountMessages { get; set; }
    
    
        [JsonPropertyName("minAccessCountPosts")]
        public double MinAccessCountPosts { get; set; }
    
    
        [JsonPropertyName("minAccessCountStories")]
        public double MinAccessCountStories { get; set; }
    
    
        [JsonPropertyName("cacheImages")]
        public bool CacheImages { get; set; }
    
    
        [JsonPropertyName("cacheVideos")]
        public bool CacheVideos { get; set; }
    
    
        [JsonPropertyName("cacheAudio")]
        public bool CacheAudio { get; set; }
    
    
        [JsonPropertyName("imageQualities")]
        public List<string> ImageQualities { get; set; }
    
    
        [JsonPropertyName("videoQualities")]
        public List<string> VideoQualities { get; set; }
    
    
        [JsonPropertyName("retentionDays")]
        public double RetentionDays { get; set; }
    
    
        [JsonPropertyName("accessExpiryDays")]
        public double AccessExpiryDays { get; set; }
    
    
        [JsonPropertyName("presignedUrlTtlSeconds")]
        public double PresignedUrlTtlSeconds { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitPurgeStrategy")]
        public string StorageLimitPurgeStrategy { get; set; }
    }

    public class PatchV2AccountSettingsResponseSettingsVaultPlus
    {
    
        [JsonPropertyName("autoEnableForNewConnections")]
        public bool AutoEnableForNewConnections { get; set; }
    
    
        [JsonPropertyName("defaultSettings")]
        public PatchV2AccountSettingsResponseSettingsVaultPlusDefaultSettings DefaultSettings { get; set; }
    }

    public class PatchV2AccountSettingsResponseSettings
    {
    
        [JsonPropertyName("vaultPlus")]
        public PatchV2AccountSettingsResponseSettingsVaultPlus VaultPlus { get; set; }
    }

    public class PatchV2AccountSettingsResponseBroadcastResultPurgeResultsItem
    {
    
        [JsonPropertyName("connectionId")]
        public string ConnectionId { get; set; }
    
    
        [JsonPropertyName("purgedCount")]
        public double PurgedCount { get; set; }
    
    
        [JsonPropertyName("freedBytes")]
        public double FreedBytes { get; set; }
    }

    public class PatchV2AccountSettingsResponseBroadcastResult
    {
    
        [JsonPropertyName("affectedConnections")]
        public double AffectedConnections { get; set; }
    
    
        [JsonPropertyName("purgeResults")]
        public List<PatchV2AccountSettingsResponseBroadcastResultPurgeResultsItem> PurgeResults { get; set; }
    }

    public class PatchV2AccountSettingsResponse
    {
    
        [JsonPropertyName("settings")]
        public PatchV2AccountSettingsResponseSettings Settings { get; set; }
    
    
        [JsonPropertyName("broadcastResult")]
        public PatchV2AccountSettingsResponseBroadcastResult? BroadcastResult { get; set; }
    }

    public enum PatchV2AccountSettingsRequestVaultPlusDefaultSettingsImageQualitiesItemEnum
    {
        [JsonPropertyName("thumb")]
        Thumb,
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("full")]
        Full
    }

    public enum PatchV2AccountSettingsRequestVaultPlusDefaultSettingsVideoQualitiesItemEnum
    {
        [JsonPropertyName("preview")]
        Preview,
        [JsonPropertyName("720p")]
        _720p,
        [JsonPropertyName("1080p")]
        _1080p,
        [JsonPropertyName("source")]
        Source
    }

    public enum PatchV2AccountSettingsRequestVaultPlusDefaultSettingsStorageLimitPurgeStrategyEnum
    {
        [JsonPropertyName("purge_oldest")]
        PurgeOldest,
        [JsonPropertyName("purge_largest")]
        PurgeLargest,
        [JsonPropertyName("purge_smallest")]
        PurgeSmallest,
        [JsonPropertyName("block_new")]
        BlockNew
    }

    public class PatchV2AccountSettingsRequestVaultPlusDefaultSettings
    {
    
        [JsonPropertyName("autoCacheVault")]
        public bool? AutoCacheVault { get; set; }
    
    
        [JsonPropertyName("autoCacheMessages")]
        public bool? AutoCacheMessages { get; set; }
    
    
        [JsonPropertyName("autoCachePosts")]
        public bool? AutoCachePosts { get; set; }
    
    
        [JsonPropertyName("autoCacheStories")]
        public bool? AutoCacheStories { get; set; }
    
    
        [JsonPropertyName("minAccessCountVault")]
        public double? MinAccessCountVault { get; set; }
    
    
        [JsonPropertyName("minAccessCountMessages")]
        public double? MinAccessCountMessages { get; set; }
    
    
        [JsonPropertyName("minAccessCountPosts")]
        public double? MinAccessCountPosts { get; set; }
    
    
        [JsonPropertyName("minAccessCountStories")]
        public double? MinAccessCountStories { get; set; }
    
    
        [JsonPropertyName("cacheImages")]
        public bool? CacheImages { get; set; }
    
    
        [JsonPropertyName("cacheVideos")]
        public bool? CacheVideos { get; set; }
    
    
        [JsonPropertyName("cacheAudio")]
        public bool? CacheAudio { get; set; }
    
    
        [JsonPropertyName("imageQualities")]
        public List<PatchV2AccountSettingsRequestVaultPlusDefaultSettingsImageQualitiesItemEnum> ImageQualities { get; set; }
    
    
        [JsonPropertyName("videoQualities")]
        public List<PatchV2AccountSettingsRequestVaultPlusDefaultSettingsVideoQualitiesItemEnum> VideoQualities { get; set; }
    
    
        [JsonPropertyName("retentionDays")]
        public double? RetentionDays { get; set; }
    
    
        [JsonPropertyName("accessExpiryDays")]
        public double? AccessExpiryDays { get; set; }
    
    
        [JsonPropertyName("presignedUrlTtlSeconds")]
        public double? PresignedUrlTtlSeconds { get; set; }
    
    
        [JsonPropertyName("storageLimitBytes")]
        public double? StorageLimitBytes { get; set; }
    
    
        [JsonPropertyName("storageLimitPurgeStrategy")]
        public PatchV2AccountSettingsRequestVaultPlusDefaultSettingsStorageLimitPurgeStrategyEnum? StorageLimitPurgeStrategy { get; set; }
    }

    public class PatchV2AccountSettingsRequestVaultPlus
    {
    
        [JsonPropertyName("autoEnableForNewConnections")]
        public bool? AutoEnableForNewConnections { get; set; }
    
    
        [JsonPropertyName("applyToExistingConnections")]
        public bool? ApplyToExistingConnections { get; set; }
    
    
        [JsonPropertyName("defaultSettings")]
        public PatchV2AccountSettingsRequestVaultPlusDefaultSettings? DefaultSettings { get; set; }
    }

    public class PatchV2AccountSettingsRequest
    {
    
        [JsonPropertyName("vaultPlus")]
        public PatchV2AccountSettingsRequestVaultPlus? VaultPlus { get; set; }
    }

    public class PatchV2AccessSelfResponseAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PatchV2AccessSelfResponseListsItem
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PatchV2AccessSelfResponseHeaderSize
    {
    
        [JsonPropertyName("width")]
        public double Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double Height { get; set; }
    }

    public class PatchV2AccessSelfResponseHeaderThumbs
    {
    
        [JsonPropertyName("w480")]
        public string W480 { get; set; }
    
    
        [JsonPropertyName("w760")]
        public string W760 { get; set; }
    }

    public class PatchV2AccessSelfResponseSubscribedByDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class PatchV2AccessSelfResponseSubscribedByData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("showPostsInFeed")]
        public bool ShowPostsInFeed { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<PatchV2AccessSelfResponseSubscribedByDataSubscribesItem> Subscribes { get; set; }
    }

    public class PatchV2AccessSelfResponseSubscribedOnDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class PatchV2AccessSelfResponseSubscribedOnData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<PatchV2AccessSelfResponseSubscribedOnDataSubscribesItem> Subscribes { get; set; }
    
    
        [JsonPropertyName("tipsSumm")]
        public double TipsSumm { get; set; }
    
    
        [JsonPropertyName("subscribesSumm")]
        public double SubscribesSumm { get; set; }
    
    
        [JsonPropertyName("messagesSumm")]
        public double MessagesSumm { get; set; }
    
    
        [JsonPropertyName("postsSumm")]
        public double PostsSumm { get; set; }
    
    
        [JsonPropertyName("streamsSumm")]
        public double StreamsSumm { get; set; }
    
    
        [JsonPropertyName("totalSumm")]
        public double TotalSumm { get; set; }
    }

    public class PatchV2AccessSelfResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PatchV2AccessSelfResponseAvatarThumbs? AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<PatchV2AccessSelfResponseListsItem> Lists { get; set; }
    
    
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
    
    
        [JsonPropertyName("notice")]
        public string? Notice { get; set; }
    
    
        [JsonPropertyName("about")]
        public string? About { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabledForAbout")]
        public bool? IsMarkdownDisabledForAbout { get; set; }
    
    
        [JsonPropertyName("website")]
        public string? Website { get; set; }
    
    
        [JsonPropertyName("wishlist")]
        public string? Wishlist { get; set; }
    
    
        [JsonPropertyName("location")]
        public string? Location { get; set; }
    
    
        [JsonPropertyName("header")]
        public string? Header { get; set; }
    
    
        [JsonPropertyName("headerSize")]
        public PatchV2AccessSelfResponseHeaderSize? HeaderSize { get; set; }
    
    
        [JsonPropertyName("headerThumbs")]
        public PatchV2AccessSelfResponseHeaderThumbs? HeaderThumbs { get; set; }
    
    
        [JsonPropertyName("subscribersCount")]
        public double? SubscribersCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double? PostsCount { get; set; }
    
    
        [JsonPropertyName("archivedPostsCount")]
        public double? ArchivedPostsCount { get; set; }
    
    
        [JsonPropertyName("privateArchivedPostsCount")]
        public double? PrivateArchivedPostsCount { get; set; }
    
    
        [JsonPropertyName("photosCount")]
        public double? PhotosCount { get; set; }
    
    
        [JsonPropertyName("videosCount")]
        public double? VideosCount { get; set; }
    
    
        [JsonPropertyName("audiosCount")]
        public double? AudiosCount { get; set; }
    
    
        [JsonPropertyName("mediasCount")]
        public double? MediasCount { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double? FavoritesCount { get; set; }
    
    
        [JsonPropertyName("favoritedCount")]
        public double? FavoritedCount { get; set; }
    
    
        [JsonPropertyName("joinDate")]
        public string? JoinDate { get; set; }
    
    
        [JsonPropertyName("lastSeen")]
        public string? LastSeen { get; set; }
    
    
        [JsonPropertyName("subscribedBy")]
        public bool? SubscribedBy { get; set; }
    
    
        [JsonPropertyName("subscribedByExpire")]
        public bool? SubscribedByExpire { get; set; }
    
    
        [JsonPropertyName("subscribedByExpireDate")]
        public string? SubscribedByExpireDate { get; set; }
    
    
        [JsonPropertyName("subscribedByAutoprolong")]
        public bool? SubscribedByAutoprolong { get; set; }
    
    
        [JsonPropertyName("subscribedIsExpiredNow")]
        public bool? SubscribedIsExpiredNow { get; set; }
    
    
        [JsonPropertyName("subscribedByData")]
        public PatchV2AccessSelfResponseSubscribedByData? SubscribedByData { get; set; }
    
    
        [JsonPropertyName("subscribedOn")]
        public bool? SubscribedOn { get; set; }
    
    
        [JsonPropertyName("subscribedOnExpiredNow")]
        public bool? SubscribedOnExpiredNow { get; set; }
    
    
        [JsonPropertyName("subscribedOnDuration")]
        public string? SubscribedOnDuration { get; set; }
    
    
        [JsonPropertyName("subscribedOnData")]
        public PatchV2AccessSelfResponseSubscribedOnData? SubscribedOnData { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double? SubscribePrice { get; set; }
    
    
        [JsonPropertyName("currentSubscribePrice")]
        public double? CurrentSubscribePrice { get; set; }
    
    
        [JsonPropertyName("canAddSubscriber")]
        public bool? CanAddSubscriber { get; set; }
    
    
        [JsonPropertyName("tipsEnabled")]
        public bool? TipsEnabled { get; set; }
    
    
        [JsonPropertyName("tipsTextEnabled")]
        public bool? TipsTextEnabled { get; set; }
    
    
        [JsonPropertyName("tipsMin")]
        public double? TipsMin { get; set; }
    
    
        [JsonPropertyName("tipsMinInternal")]
        public double? TipsMinInternal { get; set; }
    
    
        [JsonPropertyName("tipsMax")]
        public double? TipsMax { get; set; }
    
    
        [JsonPropertyName("canLookStory")]
        public bool? CanLookStory { get; set; }
    
    
        [JsonPropertyName("canCommentStory")]
        public bool? CanCommentStory { get; set; }
    
    
        [JsonPropertyName("hasNotViewedStory")]
        public bool? HasNotViewedStory { get; set; }
    
    
        [JsonPropertyName("hasStories")]
        public bool? HasStories { get; set; }
    
    
        [JsonPropertyName("isRestricted")]
        public bool? IsRestricted { get; set; }
    
    
        [JsonPropertyName("canRestrict")]
        public bool? CanRestrict { get; set; }
    
    
        [JsonPropertyName("isBlocked")]
        public bool? IsBlocked { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canUnsubscribe")]
        public bool? CanUnsubscribe { get; set; }
    
    
        [JsonPropertyName("isPendingAutoprolong")]
        public bool? IsPendingAutoprolong { get; set; }
    
    
        [JsonPropertyName("isPerformer")]
        public bool? IsPerformer { get; set; }
    
    
        [JsonPropertyName("isRealPerformer")]
        public bool? IsRealPerformer { get; set; }
    
    
        [JsonPropertyName("canReceiveChatMessage")]
        public bool? CanReceiveChatMessage { get; set; }
    
    
        [JsonPropertyName("canChat")]
        public bool? CanChat { get; set; }
    
    
        [JsonPropertyName("showPostsInFeed")]
        public bool? ShowPostsInFeed { get; set; }
    
    
        [JsonPropertyName("hasPinnedPosts")]
        public bool? HasPinnedPosts { get; set; }
    
    
        [JsonPropertyName("hasLabels")]
        public bool? HasLabels { get; set; }
    
    
        [JsonPropertyName("isPrivateRestriction")]
        public bool? IsPrivateRestriction { get; set; }
    
    
        [JsonPropertyName("showSubscribersCount")]
        public bool? ShowSubscribersCount { get; set; }
    
    
        [JsonPropertyName("showMediaCount")]
        public bool? ShowMediaCount { get; set; }
    
    
        [JsonPropertyName("isReferrerAllowed")]
        public bool? IsReferrerAllowed { get; set; }
    
    
        [JsonPropertyName("canCreatePromotion")]
        public bool? CanCreatePromotion { get; set; }
    
    
        [JsonPropertyName("canCreateTrial")]
        public bool? CanCreateTrial { get; set; }
    
    
        [JsonPropertyName("isAdultContent")]
        public bool? IsAdultContent { get; set; }
    
    
        [JsonPropertyName("canTrialSend")]
        public bool? CanTrialSend { get; set; }
    
    
        [JsonPropertyName("isFriend")]
        public bool? IsFriend { get; set; }
    
    
        [JsonPropertyName("hasScheduledStream")]
        public bool? HasScheduledStream { get; set; }
    
    
        [JsonPropertyName("hasStream")]
        public bool? HasStream { get; set; }
    
    
        [JsonPropertyName("canPayInternal")]
        public bool? CanPayInternal { get; set; }
    }

    public class PatchV2AccessSelfRequest
    {
    
        /// <summary>Display name</summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    
    
        /// <summary>Profile bio/description</summary>
        [JsonPropertyName("about")]
        public string? About { get; set; }
    }

    public class GetV2AccessSelfNotificationsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("subType")]
        public string? SubType { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isRead")]
        public bool IsRead { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("replacePairs")]
        public Dictionary<string, string> ReplacePairs { get; set; }
    
    
        [JsonPropertyName("canGoToProfile")]
        public bool CanGoToProfile { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double? UserId { get; set; }
    }

    public class GetV2AccessSelfNotificationsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessSelfNotificationsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessSelfReleaseFormsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerId")]
        public double? PartnerId { get; set; }
    
    
        [JsonPropertyName("code")]
        public string? Code { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("approvedAt")]
        public string? ApprovedAt { get; set; }
    
    
        [JsonPropertyName("lastChangedAt")]
        public string? LastChangedAt { get; set; }
    
    
        [JsonPropertyName("userName")]
        public string? UserName { get; set; }
    
    
        [JsonPropertyName("hasUser")]
        public bool HasUser { get; set; }
    
    
        [JsonPropertyName("isHidden")]
        public bool IsHidden { get; set; }
    }

    public class GetV2AccessSelfReleaseFormsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessSelfReleaseFormsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessSelfTaggedFriendUsersResponseListItemUser
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("isHidden")]
        public bool IsHidden { get; set; }
    }

    public class GetV2AccessSelfTaggedFriendUsersResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessSelfTaggedFriendUsersResponseListItemUser? User { get; set; }
    }

    public class GetV2AccessSelfTaggedFriendUsersResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessSelfTaggedFriendUsersResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessEarningsChartResponseChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessEarningsChartResponse
    {
    
        [JsonPropertyName("chart")]
        public List<GetV2AccessEarningsChartResponseChartItem> Chart { get; set; }
    
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("gross")]
        public double? Gross { get; set; }
    
    
        [JsonPropertyName("delta")]
        public double? Delta { get; set; }
    }

    public class GetV2AccessEarningsTransactionsResponseListItemAmounts
    {
    
        [JsonPropertyName("gross")]
        public double Gross { get; set; }
    
    
        [JsonPropertyName("net")]
        public double Net { get; set; }
    
    
        [JsonPropertyName("fee")]
        public double Fee { get; set; }
    
    
        [JsonPropertyName("vat")]
        public double Vat { get; set; }
    
    
        [JsonPropertyName("tax")]
        public double Tax { get; set; }
    }

    public class GetV2AccessEarningsTransactionsResponseListItemUser
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    }

    public class GetV2AccessEarningsTransactionsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("amounts")]
        public GetV2AccessEarningsTransactionsResponseListItemAmounts Amounts { get; set; }
    
    
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    
    
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("payoutPendingDays")]
        public double? PayoutPendingDays { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessEarningsTransactionsResponseListItemUser? User { get; set; }
    }

    public class GetV2AccessEarningsTransactionsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessEarningsTransactionsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("nextMarker")]
        public double? NextMarker { get; set; }
    }

    public class GetV2AccessEarningsChargebacksResponseListItemPaymentAmounts
    {
    
        [JsonPropertyName("gross")]
        public double Gross { get; set; }
    
    
        [JsonPropertyName("net")]
        public double Net { get; set; }
    
    
        [JsonPropertyName("fee")]
        public double Fee { get; set; }
    
    
        [JsonPropertyName("vat")]
        public double Vat { get; set; }
    
    
        [JsonPropertyName("tax")]
        public double Tax { get; set; }
    }

    public class GetV2AccessEarningsChargebacksResponseListItemPaymentUser
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    }

    public class GetV2AccessEarningsChargebacksResponseListItemPayment
    {
    
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("amounts")]
        public GetV2AccessEarningsChargebacksResponseListItemPaymentAmounts Amounts { get; set; }
    
    
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    
    
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessEarningsChargebacksResponseListItemPaymentUser? User { get; set; }
    }

    public class GetV2AccessEarningsChargebacksResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("paymentType")]
        public string? PaymentType { get; set; }
    
    
        [JsonPropertyName("payment")]
        public GetV2AccessEarningsChargebacksResponseListItemPayment? Payment { get; set; }
    }

    public class GetV2AccessEarningsChargebacksResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessEarningsChargebacksResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("nextMarker")]
        public double? NextMarker { get; set; }
    }

    public enum GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemAuthor
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemStatsUniqueLookChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemStatsLookChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemStatsLikeChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemStatsCommentChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemStatsTipChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemStats
    {
    
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
    
    
        [JsonPropertyName("hasStats")]
        public bool HasStats { get; set; }
    
    
        [JsonPropertyName("hasVideo")]
        public bool? HasVideo { get; set; }
    
    
        [JsonPropertyName("lookCount")]
        public double LookCount { get; set; }
    
    
        [JsonPropertyName("uniqueLookCount")]
        public double UniqueLookCount { get; set; }
    
    
        [JsonPropertyName("uniqueLookChart")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemStatsUniqueLookChartItem> UniqueLookChart { get; set; }
    
    
        [JsonPropertyName("lookChart")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemStatsLookChartItem> LookChart { get; set; }
    
    
        [JsonPropertyName("lookDuration")]
        public double LookDuration { get; set; }
    
    
        [JsonPropertyName("lookDurationAverage")]
        public double LookDurationAverage { get; set; }
    
    
        [JsonPropertyName("likeCount")]
        public double LikeCount { get; set; }
    
    
        [JsonPropertyName("likeChart")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemStatsLikeChartItem> LikeChart { get; set; }
    
    
        [JsonPropertyName("commentCount")]
        public double CommentCount { get; set; }
    
    
        [JsonPropertyName("commentChart")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemStatsCommentChartItem> CommentChart { get; set; }
    
    
        [JsonPropertyName("tipCount")]
        public double TipCount { get; set; }
    
    
        [JsonPropertyName("tipChart")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemStatsTipChartItem> TipChart { get; set; }
    
    
        [JsonPropertyName("tipSum")]
        public double TipSum { get; set; }
    
    
        [JsonPropertyName("purchasedCount")]
        public double PurchasedCount { get; set; }
    
    
        [JsonPropertyName("purchasedSumm")]
        public double PurchasedSumm { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemVotingOptionsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    
    
        [JsonPropertyName("count")]
        public double? Count { get; set; }
    
    
        [JsonPropertyName("percent")]
        public double? Percent { get; set; }
    
    
        [JsonPropertyName("isWinner")]
        public bool? IsWinner { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItemVoting
    {
    
        [JsonPropertyName("finishedAt")]
        public string FinishedAt { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemVotingOptionsItem> Options { get; set; }
    
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("canViewMedia")]
        public bool CanViewMedia { get; set; }
    
    
        [JsonPropertyName("author")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemAuthor? Author { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }
    
    
        [JsonPropertyName("postedAt")]
        public string PostedAt { get; set; }
    
    
        [JsonPropertyName("postedAtPrecise")]
        public string PostedAtPrecise { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool IsOpened { get; set; }
    
    
        [JsonPropertyName("canToggleFavorite")]
        public bool CanToggleFavorite { get; set; }
    
    
        [JsonPropertyName("tipsAmount")]
        public string TipsAmount { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }
    
    
        [JsonPropertyName("canComment")]
        public bool CanComment { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double FavoritesCount { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool IsMediaReady { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string RawText { get; set; }
    
    
        [JsonPropertyName("stats")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemStats? Stats { get; set; }
    
    
        [JsonPropertyName("hasVoting")]
        public bool? HasVoting { get; set; }
    
    
        [JsonPropertyName("votingType")]
        public double? VotingType { get; set; }
    
    
        [JsonPropertyName("voting")]
        public GetV2AccessAnalyticsPostsTopResponseItemsItemVoting? Voting { get; set; }
    }

    public class GetV2AccessAnalyticsPostsTopResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("items")]
        public List<GetV2AccessAnalyticsPostsTopResponseItemsItem> Items { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponseUniqueLookChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponseLookChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponseLikeChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponseCommentChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponseTipChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponseTipSumChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponsePurchasesChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsPostsPostIdResponse
    {
    
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
    
    
        [JsonPropertyName("hasStats")]
        public bool HasStats { get; set; }
    
    
        [JsonPropertyName("hasVideo")]
        public bool? HasVideo { get; set; }
    
    
        [JsonPropertyName("lookCount")]
        public double LookCount { get; set; }
    
    
        [JsonPropertyName("uniqueLookCount")]
        public double UniqueLookCount { get; set; }
    
    
        [JsonPropertyName("uniqueLookChart")]
        public List<GetV2AccessAnalyticsPostsPostIdResponseUniqueLookChartItem> UniqueLookChart { get; set; }
    
    
        [JsonPropertyName("lookChart")]
        public List<GetV2AccessAnalyticsPostsPostIdResponseLookChartItem> LookChart { get; set; }
    
    
        [JsonPropertyName("lookDuration")]
        public double LookDuration { get; set; }
    
    
        [JsonPropertyName("lookDurationAverage")]
        public double LookDurationAverage { get; set; }
    
    
        [JsonPropertyName("likeCount")]
        public double LikeCount { get; set; }
    
    
        [JsonPropertyName("likeChart")]
        public List<GetV2AccessAnalyticsPostsPostIdResponseLikeChartItem> LikeChart { get; set; }
    
    
        [JsonPropertyName("commentCount")]
        public double CommentCount { get; set; }
    
    
        [JsonPropertyName("commentChart")]
        public List<GetV2AccessAnalyticsPostsPostIdResponseCommentChartItem> CommentChart { get; set; }
    
    
        [JsonPropertyName("tipCount")]
        public double TipCount { get; set; }
    
    
        [JsonPropertyName("tipChart")]
        public List<GetV2AccessAnalyticsPostsPostIdResponseTipChartItem> TipChart { get; set; }
    
    
        [JsonPropertyName("tipSum")]
        public double TipSum { get; set; }
    
    
        [JsonPropertyName("purchasedCount")]
        public double PurchasedCount { get; set; }
    
    
        [JsonPropertyName("purchasedSumm")]
        public double PurchasedSumm { get; set; }
    
    
        [JsonPropertyName("tipSumChart")]
        public List<GetV2AccessAnalyticsPostsPostIdResponseTipSumChartItem> TipSumChart { get; set; }
    
    
        [JsonPropertyName("purchasesChart")]
        public List<GetV2AccessAnalyticsPostsPostIdResponsePurchasesChartItem> PurchasesChart { get; set; }
    }

    public enum GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemAuthor
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsUniqueLookChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsLookChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsLikeChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsCommentChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsTipChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItemStats
    {
    
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
    
    
        [JsonPropertyName("hasStats")]
        public bool HasStats { get; set; }
    
    
        [JsonPropertyName("hasVideo")]
        public bool? HasVideo { get; set; }
    
    
        [JsonPropertyName("lookCount")]
        public double LookCount { get; set; }
    
    
        [JsonPropertyName("uniqueLookCount")]
        public double UniqueLookCount { get; set; }
    
    
        [JsonPropertyName("uniqueLookChart")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsUniqueLookChartItem> UniqueLookChart { get; set; }
    
    
        [JsonPropertyName("lookChart")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsLookChartItem> LookChart { get; set; }
    
    
        [JsonPropertyName("lookDuration")]
        public double LookDuration { get; set; }
    
    
        [JsonPropertyName("lookDurationAverage")]
        public double LookDurationAverage { get; set; }
    
    
        [JsonPropertyName("likeCount")]
        public double LikeCount { get; set; }
    
    
        [JsonPropertyName("likeChart")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsLikeChartItem> LikeChart { get; set; }
    
    
        [JsonPropertyName("commentCount")]
        public double CommentCount { get; set; }
    
    
        [JsonPropertyName("commentChart")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsCommentChartItem> CommentChart { get; set; }
    
    
        [JsonPropertyName("tipCount")]
        public double TipCount { get; set; }
    
    
        [JsonPropertyName("tipChart")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemStatsTipChartItem> TipChart { get; set; }
    
    
        [JsonPropertyName("tipSum")]
        public double TipSum { get; set; }
    
    
        [JsonPropertyName("purchasedCount")]
        public double PurchasedCount { get; set; }
    
    
        [JsonPropertyName("purchasedSumm")]
        public double PurchasedSumm { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("canViewMedia")]
        public bool CanViewMedia { get; set; }
    
    
        [JsonPropertyName("author")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemAuthor? Author { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }
    
    
        [JsonPropertyName("postedAt")]
        public string PostedAt { get; set; }
    
    
        [JsonPropertyName("postedAtPrecise")]
        public string PostedAtPrecise { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool IsOpened { get; set; }
    
    
        [JsonPropertyName("canToggleFavorite")]
        public bool CanToggleFavorite { get; set; }
    
    
        [JsonPropertyName("tipsAmount")]
        public string TipsAmount { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }
    
    
        [JsonPropertyName("canComment")]
        public bool CanComment { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double FavoritesCount { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool IsMediaReady { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string RawText { get; set; }
    
    
        [JsonPropertyName("stats")]
        public GetV2AccessAnalyticsStreamsTopResponseItemsItemStats? Stats { get; set; }
    }

    public class GetV2AccessAnalyticsStreamsTopResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("items")]
        public List<GetV2AccessAnalyticsStreamsTopResponseItemsItem> Items { get; set; }
    }

    public enum GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemQuestionEntity
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemQuestionPositions
    {
    
        [JsonPropertyName("zIndex")]
        public double ZIndex { get; set; }
    
    
        [JsonPropertyName("x")]
        public double? X { get; set; }
    
    
        [JsonPropertyName("y")]
        public double? Y { get; set; }
    
    
        [JsonPropertyName("top")]
        public double Top { get; set; }
    
    
        [JsonPropertyName("left")]
        public double Left { get; set; }
    
    
        [JsonPropertyName("width")]
        public double Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double Height { get; set; }
    
    
        [JsonPropertyName("angle")]
        public double Angle { get; set; }
    
    
        [JsonPropertyName("color")]
        public string Color { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemQuestion
    {
    
        [JsonPropertyName("entity")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemQuestionEntity Entity { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("positions")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemQuestionPositions Positions { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemViewersItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemViewersItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemViewersItemAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("canLookStory")]
        public bool CanLookStory { get; set; }
    
    
        [JsonPropertyName("canCommentStory")]
        public bool CanCommentStory { get; set; }
    
    
        [JsonPropertyName("hasNotViewedStory")]
        public bool HasNotViewedStory { get; set; }
    
    
        [JsonPropertyName("isStoryLiked")]
        public bool IsStoryLiked { get; set; }
    
    
        [JsonPropertyName("isStoryBlockedUser")]
        public bool IsStoryBlockedUser { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemPostAuthor
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemPostCoordinateParams
    {
    
        [JsonPropertyName("top")]
        public double Top { get; set; }
    
    
        [JsonPropertyName("left")]
        public double Left { get; set; }
    
    
        [JsonPropertyName("angle")]
        public double Angle { get; set; }
    
    
        [JsonPropertyName("scale")]
        public double Scale { get; set; }
    
    
        [JsonPropertyName("width")]
        public double Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double Height { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemPost
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("author")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemPostAuthor? Author { get; set; }
    
    
        [JsonPropertyName("coordinateParams")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemPostCoordinateParams? CoordinateParams { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemTextsItemPosition
    {
    
        [JsonPropertyName("x")]
        public double X { get; set; }
    
    
        [JsonPropertyName("y")]
        public double Y { get; set; }
    
    
        [JsonPropertyName("width")]
        public double Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double Height { get; set; }
    
    
        [JsonPropertyName("angle")]
        public double Angle { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItemTextsItem
    {
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("position")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemTextsItemPosition Position { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("hasPost")]
        public bool HasPost { get; set; }
    
    
        [JsonPropertyName("isWatched")]
        public bool IsWatched { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("canvasHeight")]
        public double CanvasHeight { get; set; }
    
    
        [JsonPropertyName("canvasWidth")]
        public double CanvasWidth { get; set; }
    
    
        [JsonPropertyName("question")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemQuestion? Question { get; set; }
    
    
        [JsonPropertyName("viewersCount")]
        public double ViewersCount { get; set; }
    
    
        [JsonPropertyName("viewers")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItemViewersItem> Viewers { get; set; }
    
    
        [JsonPropertyName("commentsCount")]
        public double CommentsCount { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("isHighlightCover")]
        public bool IsHighlightCover { get; set; }
    
    
        [JsonPropertyName("isLastInHighlight")]
        public bool IsLastInHighlight { get; set; }
    
    
        [JsonPropertyName("tipsAmount")]
        public string TipsAmount { get; set; }
    
    
        [JsonPropertyName("tipsAmountRaw")]
        public double TipsAmountRaw { get; set; }
    
    
        [JsonPropertyName("tipsCount")]
        public double TipsCount { get; set; }
    
    
        [JsonPropertyName("likesCount")]
        public double LikesCount { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("post")]
        public GetV2AccessAnalyticsStoriesTopResponseItemsItemPost? Post { get; set; }
    
    
        [JsonPropertyName("texts")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItemTextsItem> Texts { get; set; }
    }

    public class GetV2AccessAnalyticsStoriesTopResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("items")]
        public List<GetV2AccessAnalyticsStoriesTopResponseItemsItem> Items { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseGroupMessagesChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseGroupMessages
    {
    
        [JsonPropertyName("chart")]
        public List<GetV2AccessAnalyticsMassMessagesChartResponseGroupMessagesChartItem> Chart { get; set; }
    
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("delta")]
        public double Delta { get; set; }
    
    
        [JsonPropertyName("gross")]
        public double? Gross { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseGroupMessagesPurchasesChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseGroupMessagesPurchases
    {
    
        [JsonPropertyName("chart")]
        public List<GetV2AccessAnalyticsMassMessagesChartResponseGroupMessagesPurchasesChartItem> Chart { get; set; }
    
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("delta")]
        public double Delta { get; set; }
    
    
        [JsonPropertyName("gross")]
        public double? Gross { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseDirectMessagesChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseDirectMessages
    {
    
        [JsonPropertyName("chart")]
        public List<GetV2AccessAnalyticsMassMessagesChartResponseDirectMessagesChartItem> Chart { get; set; }
    
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("delta")]
        public double Delta { get; set; }
    
    
        [JsonPropertyName("gross")]
        public double? Gross { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseDirectMessagesPurchasesChartItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponseDirectMessagesPurchases
    {
    
        [JsonPropertyName("chart")]
        public List<GetV2AccessAnalyticsMassMessagesChartResponseDirectMessagesPurchasesChartItem> Chart { get; set; }
    
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("delta")]
        public double Delta { get; set; }
    
    
        [JsonPropertyName("gross")]
        public double? Gross { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesChartResponse
    {
    
        [JsonPropertyName("group_messages")]
        public GetV2AccessAnalyticsMassMessagesChartResponseGroupMessages GroupMessages { get; set; }
    
    
        [JsonPropertyName("group_messages_purchases")]
        public GetV2AccessAnalyticsMassMessagesChartResponseGroupMessagesPurchases GroupMessagesPurchases { get; set; }
    
    
        [JsonPropertyName("direct_messages")]
        public GetV2AccessAnalyticsMassMessagesChartResponseDirectMessages DirectMessages { get; set; }
    
    
        [JsonPropertyName("direct_messages_purchases")]
        public GetV2AccessAnalyticsMassMessagesChartResponseDirectMessagesPurchases DirectMessagesPurchases { get; set; }
    }

    public enum GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItemFiles? Files { get; set; }
    }

    public enum GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItemFiles? Files { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsMassMessagesSentResponseItemsItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string? RawText { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemPreviewsItem> Previews { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("viewedCount")]
        public double? ViewedCount { get; set; }
    
    
        [JsonPropertyName("sentCount")]
        public double? SentCount { get; set; }
    
    
        [JsonPropertyName("isCanceled")]
        public bool? IsCanceled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("template")]
        public string? Template { get; set; }
    
    
        [JsonPropertyName("canUnsend")]
        public bool? CanUnsend { get; set; }
    
    
        [JsonPropertyName("unsendSeconds")]
        public double? UnsendSeconds { get; set; }
    
    
        [JsonPropertyName("price")]
        public string? Price { get; set; }
    
    
        [JsonPropertyName("purchasedCount")]
        public double? PurchasedCount { get; set; }
    
    
        [JsonPropertyName("canSendMessageToBuyers")]
        public bool? CanSendMessageToBuyers { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesSentResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("items")]
        public List<GetV2AccessAnalyticsMassMessagesSentResponseItemsItem> Items { get; set; }
    }

    public enum GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItemFiles? Files { get; set; }
    }

    public enum GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItemFiles? Files { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string? RawText { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemPreviewsItem> Previews { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("viewedCount")]
        public double? ViewedCount { get; set; }
    
    
        [JsonPropertyName("sentCount")]
        public double? SentCount { get; set; }
    
    
        [JsonPropertyName("isCanceled")]
        public bool? IsCanceled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("template")]
        public string? Template { get; set; }
    
    
        [JsonPropertyName("canUnsend")]
        public bool? CanUnsend { get; set; }
    
    
        [JsonPropertyName("unsendSeconds")]
        public double? UnsendSeconds { get; set; }
    
    
        [JsonPropertyName("price")]
        public string? Price { get; set; }
    
    
        [JsonPropertyName("purchasedCount")]
        public double? PurchasedCount { get; set; }
    
    
        [JsonPropertyName("canSendMessageToBuyers")]
        public bool? CanSendMessageToBuyers { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesPurchasedResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("items")]
        public List<GetV2AccessAnalyticsMassMessagesPurchasedResponseItemsItem> Items { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesMassMessageIdBuyersResponseListItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesMassMessageIdBuyersResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessAnalyticsMassMessagesMassMessageIdBuyersResponseListItemAvatarThumbs? AvatarThumbs { get; set; }
    }

    public class GetV2AccessAnalyticsMassMessagesMassMessageIdBuyersResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessAnalyticsMassMessagesMassMessageIdBuyersResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("nextMarker")]
        public double? NextMarker { get; set; }
    }

    public class GetV2AccessAnalyticsPromotionsTopResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
    
        [JsonPropertyName("rawMessage")]
        public string RawMessage { get; set; }
    
    
        [JsonPropertyName("hasRelatedPromo")]
        public bool HasRelatedPromo { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("canClaim")]
        public bool CanClaim { get; set; }
    
    
        [JsonPropertyName("claimsCount")]
        public double ClaimsCount { get; set; }
    
    
        [JsonPropertyName("subscribeCounts")]
        public double? SubscribeCounts { get; set; }
    
    
        [JsonPropertyName("subscribeDays")]
        public double SubscribeDays { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("finishedAt")]
        public string FinishedAt { get; set; }
    
    
        [JsonPropertyName("isFinished")]
        public bool IsFinished { get; set; }
    }

    public class GetV2AccessAnalyticsPromotionsTopResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("items")]
        public List<GetV2AccessAnalyticsPromotionsTopResponseItemsItem> Items { get; set; }
    }

    public class GetV2AccessAnalyticsTrialsTopResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("trialLinkName")]
        public string TrialLinkName { get; set; }
    
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("subscribeDays")]
        public double SubscribeDays { get; set; }
    
    
        [JsonPropertyName("subscribeCounts")]
        public double SubscribeCounts { get; set; }
    
    
        [JsonPropertyName("claimCounts")]
        public double ClaimCounts { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isFinished")]
        public bool IsFinished { get; set; }
    }

    public class GetV2AccessAnalyticsTrialsTopResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("items")]
        public List<GetV2AccessAnalyticsTrialsTopResponseItemsItem> Items { get; set; }
    }

    public class GetV2AccessAnalyticsCampaignsTopResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("countSubscribers")]
        public double CountSubscribers { get; set; }
    
    
        [JsonPropertyName("countTransitions")]
        public double CountTransitions { get; set; }
    
    
        [JsonPropertyName("campaignCode")]
        public double CampaignCode { get; set; }
    
    
        [JsonPropertyName("campaignName")]
        public string CampaignName { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("endDate")]
        public string EndDate { get; set; }
    }

    public class GetV2AccessAnalyticsCampaignsTopResponse
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("list")]
        public List<GetV2AccessAnalyticsCampaignsTopResponseListItem> List { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesChartResponseChartVisitorsItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesChartResponseChartDurationItem
    {
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("count")]
        public double Count { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesChartResponseChart
    {
    
        [JsonPropertyName("visitors")]
        public List<GetV2AccessAnalyticsVisitorCountriesChartResponseChartVisitorsItem> Visitors { get; set; }
    
    
        [JsonPropertyName("duration")]
        public List<GetV2AccessAnalyticsVisitorCountriesChartResponseChartDurationItem> Duration { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesChartResponseTotal
    {
    
        [JsonPropertyName("current")]
        public string Current { get; set; }
    
    
        [JsonPropertyName("delta")]
        public double Delta { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesChartResponse
    {
    
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
    
    
        [JsonPropertyName("chart")]
        public GetV2AccessAnalyticsVisitorCountriesChartResponseChart Chart { get; set; }
    
    
        [JsonPropertyName("total")]
        public GetV2AccessAnalyticsVisitorCountriesChartResponseTotal Total { get; set; }
    
    
        [JsonPropertyName("hasStats")]
        public bool HasStats { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountriesTotals
    {
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("guests")]
        public string Guests { get; set; }
    
    
        [JsonPropertyName("users")]
        public string Users { get; set; }
    
    
        [JsonPropertyName("subscribers")]
        public double Subscribers { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountriesRowsItemViewsCount
    {
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("guests")]
        public double Guests { get; set; }
    
    
        [JsonPropertyName("users")]
        public double Users { get; set; }
    
    
        [JsonPropertyName("subscribers")]
        public double Subscribers { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountriesRowsItem
    {
    
        [JsonPropertyName("rank")]
        public double Rank { get; set; }
    
    
        [JsonPropertyName("countryName")]
        public string CountryName { get; set; }
    
    
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }
    
    
        [JsonPropertyName("viewsCount")]
        public GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountriesRowsItemViewsCount ViewsCount { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountries
    {
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("totals")]
        public GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountriesTotals Totals { get; set; }
    
    
        [JsonPropertyName("rows")]
        public List<GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountriesRowsItem> Rows { get; set; }
    }

    public class GetV2AccessAnalyticsVisitorCountriesTopResponse
    {
    
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
    
    
        [JsonPropertyName("hasStats")]
        public bool HasStats { get; set; }
    
    
        [JsonPropertyName("topCountries")]
        public GetV2AccessAnalyticsVisitorCountriesTopResponseTopCountries TopCountries { get; set; }
    }

    public enum GetV2AccessPostsResponseListItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessPostsResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessPostsResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessPostsResponseListItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessPostsResponseListItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessPostsResponseListItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessPostsResponseListItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessPostsResponseListItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessPostsResponseListItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessPostsResponseListItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessPostsResponseListItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessPostsResponseListItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessPostsResponseListItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessPostsResponseListItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessPostsResponseListItemMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessPostsResponseListItemAuthor
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public class GetV2AccessPostsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessPostsResponseListItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("canViewMedia")]
        public bool CanViewMedia { get; set; }
    
    
        [JsonPropertyName("author")]
        public GetV2AccessPostsResponseListItemAuthor? Author { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }
    
    
        [JsonPropertyName("postedAt")]
        public string PostedAt { get; set; }
    
    
        [JsonPropertyName("postedAtPrecise")]
        public string PostedAtPrecise { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool IsOpened { get; set; }
    
    
        [JsonPropertyName("canToggleFavorite")]
        public bool CanToggleFavorite { get; set; }
    
    
        [JsonPropertyName("tipsAmount")]
        public string TipsAmount { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }
    
    
        [JsonPropertyName("canComment")]
        public bool CanComment { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double FavoritesCount { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool IsMediaReady { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string RawText { get; set; }
    }

    public class GetV2AccessPostsResponseCounters
    {
    
        [JsonPropertyName("audiosCount")]
        public double AudiosCount { get; set; }
    
    
        [JsonPropertyName("photosCount")]
        public double PhotosCount { get; set; }
    
    
        [JsonPropertyName("videosCount")]
        public double VideosCount { get; set; }
    
    
        [JsonPropertyName("mediasCount")]
        public double MediasCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double PostsCount { get; set; }
    
    
        [JsonPropertyName("streamsCount")]
        public double StreamsCount { get; set; }
    
    
        [JsonPropertyName("archivedPostsCount")]
        public double ArchivedPostsCount { get; set; }
    
    
        [JsonPropertyName("privateArchivedPostsCount")]
        public double PrivateArchivedPostsCount { get; set; }
    }

    public class GetV2AccessPostsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessPostsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("headMarker")]
        public string HeadMarker { get; set; }
    
    
        [JsonPropertyName("tailMarker")]
        public string TailMarker { get; set; }
    
    
        [JsonPropertyName("counters")]
        public GetV2AccessPostsResponseCounters Counters { get; set; }
    }

    public enum PostV2AccessPostsResponseMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PostV2AccessPostsResponseMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PostV2AccessPostsResponseMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public PostV2AccessPostsResponseMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<PostV2AccessPostsResponseMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<PostV2AccessPostsResponseMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public PostV2AccessPostsResponseMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public PostV2AccessPostsResponseMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public PostV2AccessPostsResponseMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public PostV2AccessPostsResponseMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class PostV2AccessPostsResponseMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PostV2AccessPostsResponseMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<PostV2AccessPostsResponseMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public PostV2AccessPostsResponseMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public PostV2AccessPostsResponseMediaItemFiles? Files { get; set; }
    }

    public class PostV2AccessPostsResponseAuthor
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public class PostV2AccessPostsResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<PostV2AccessPostsResponseMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("canViewMedia")]
        public bool CanViewMedia { get; set; }
    
    
        [JsonPropertyName("author")]
        public PostV2AccessPostsResponseAuthor? Author { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }
    
    
        [JsonPropertyName("postedAt")]
        public string PostedAt { get; set; }
    
    
        [JsonPropertyName("postedAtPrecise")]
        public string PostedAtPrecise { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool IsOpened { get; set; }
    
    
        [JsonPropertyName("canToggleFavorite")]
        public bool CanToggleFavorite { get; set; }
    
    
        [JsonPropertyName("tipsAmount")]
        public string TipsAmount { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }
    
    
        [JsonPropertyName("canComment")]
        public bool CanComment { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double FavoritesCount { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool IsMediaReady { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string RawText { get; set; }
    }

    public class PostV2AccessPostsRequestReleaseForms
    {
    
        /// <summary>Users to add to release form</summary>
        [JsonPropertyName("users")]
        public List<int> Users { get; set; }
    
    
        /// <summary>Partners to add to release form</summary>
        [JsonPropertyName("partners")]
        public List<int> Partners { get; set; }
    
    
        /// <summary>Guests to add to release form</summary>
        [JsonPropertyName("guests")]
        public List<int> Guests { get; set; }
    }

    public class PostV2AccessPostsRequest
    {
    
        /// <summary>Text content. Supports markdown by default. See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    
    
        /// <summary>Media references to attach. Accepts vault media IDs, upload references (mediaUploadId), or http(s) URLs. See [mediaItems reference](/guides/media-items).</summary>
        [JsonPropertyName("mediaItems")]
        public List<object> MediaItems { get; set; }
    
    
        /// <summary>Whether text is locked behind paywall (defaults to false).</summary>
        [JsonPropertyName("isLockedText")]
        public bool? IsLockedText { get; set; }
    
    
        /// <summary>Price to unlock message content (0 for free)</summary>
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
    
        /// <summary>How many items in mediaItems should be previews. Uses the first N items from left to right.</summary>
        [JsonPropertyName("previewMediaCount")]
        public int? PreviewMediaCount { get; set; }
    
    
        /// <summary>Release form participants</summary>
        [JsonPropertyName("releaseForms")]
        public PostV2AccessPostsRequestReleaseForms? ReleaseForms { get; set; }
    
    
        /// <summary>Users to tag</summary>
        [JsonPropertyName("userTags")]
        public List<int> UserTags { get; set; }
    
    
        /// <summary>Whether to parse text as markdown (default: true). See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("isMarkdown")]
        public bool? IsMarkdown { get; set; }
    
    
        /// <summary>When to publish the post (omit for immediate)</summary>
        [JsonPropertyName("scheduledDate")]
        public string? ScheduledDate { get; set; }
    
    
        /// <summary>Target amount for fund raising post</summary>
        [JsonPropertyName("fundRaisingTargetAmount")]
        public double? FundRaisingTargetAmount { get; set; }
    
    
        /// <summary>Preset tip amounts for fund raising</summary>
        [JsonPropertyName("fundRaisingTipsPresets")]
        public List<double> FundRaisingTipsPresets { get; set; }
    
    
        /// <summary>Days until post expires (1-30)</summary>
        [JsonPropertyName("expireAfter")]
        public double? ExpireAfter { get; set; }
    }

    public enum PutV2AccessPostsPostIdResponseMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PutV2AccessPostsPostIdResponseMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PutV2AccessPostsPostIdResponseMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public PutV2AccessPostsPostIdResponseMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<PutV2AccessPostsPostIdResponseMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<PutV2AccessPostsPostIdResponseMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public PutV2AccessPostsPostIdResponseMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public PutV2AccessPostsPostIdResponseMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public PutV2AccessPostsPostIdResponseMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public PutV2AccessPostsPostIdResponseMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PutV2AccessPostsPostIdResponseMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<PutV2AccessPostsPostIdResponseMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public PutV2AccessPostsPostIdResponseMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public PutV2AccessPostsPostIdResponseMediaItemFiles? Files { get; set; }
    }

    public class PutV2AccessPostsPostIdResponseAuthor
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public class PutV2AccessPostsPostIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<PutV2AccessPostsPostIdResponseMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("canViewMedia")]
        public bool CanViewMedia { get; set; }
    
    
        [JsonPropertyName("author")]
        public PutV2AccessPostsPostIdResponseAuthor? Author { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }
    
    
        [JsonPropertyName("postedAt")]
        public string PostedAt { get; set; }
    
    
        [JsonPropertyName("postedAtPrecise")]
        public string PostedAtPrecise { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool IsOpened { get; set; }
    
    
        [JsonPropertyName("canToggleFavorite")]
        public bool CanToggleFavorite { get; set; }
    
    
        [JsonPropertyName("tipsAmount")]
        public string TipsAmount { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }
    
    
        [JsonPropertyName("canComment")]
        public bool CanComment { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double FavoritesCount { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool IsMediaReady { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string RawText { get; set; }
    }

    public class PutV2AccessPostsPostIdRequestReleaseForms
    {
    
        /// <summary>Users to add to release form</summary>
        [JsonPropertyName("users")]
        public List<int> Users { get; set; }
    
    
        /// <summary>Partners to add to release form</summary>
        [JsonPropertyName("partners")]
        public List<int> Partners { get; set; }
    
    
        /// <summary>Guests to add to release form</summary>
        [JsonPropertyName("guests")]
        public List<int> Guests { get; set; }
    }

    public class PutV2AccessPostsPostIdRequest
    {
    
        /// <summary>Text content. Supports markdown by default. See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    
    
        /// <summary>Media references to attach. Accepts vault media IDs, upload references (mediaUploadId), or http(s) URLs. See [mediaItems reference](/guides/media-items).</summary>
        [JsonPropertyName("mediaItems")]
        public List<object> MediaItems { get; set; }
    
    
        /// <summary>Whether text is locked behind paywall (defaults to false).</summary>
        [JsonPropertyName("isLockedText")]
        public bool? IsLockedText { get; set; }
    
    
        /// <summary>Price to unlock message content (0 for free)</summary>
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
    
        /// <summary>How many items in mediaItems should be previews. Uses the first N items from left to right.</summary>
        [JsonPropertyName("previewMediaCount")]
        public int? PreviewMediaCount { get; set; }
    
    
        /// <summary>Release form participants</summary>
        [JsonPropertyName("releaseForms")]
        public PutV2AccessPostsPostIdRequestReleaseForms? ReleaseForms { get; set; }
    
    
        /// <summary>Users to tag</summary>
        [JsonPropertyName("userTags")]
        public List<int> UserTags { get; set; }
    
    
        /// <summary>Whether to parse text as markdown (default: true). See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("isMarkdown")]
        public bool? IsMarkdown { get; set; }
    
    
        /// <summary>When to publish the post (omit for immediate)</summary>
        [JsonPropertyName("scheduledDate")]
        public string? ScheduledDate { get; set; }
    
    
        /// <summary>Target amount for fund raising post</summary>
        [JsonPropertyName("fundRaisingTargetAmount")]
        public double? FundRaisingTargetAmount { get; set; }
    
    
        /// <summary>Preset tip amounts for fund raising</summary>
        [JsonPropertyName("fundRaisingTipsPresets")]
        public List<double> FundRaisingTipsPresets { get; set; }
    
    
        /// <summary>Days until post expires (1-30)</summary>
        [JsonPropertyName("expireAfter")]
        public double? ExpireAfter { get; set; }
    }

    public enum GetV2AccessUsersUserIdPostsResponseListItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessUsersUserIdPostsResponseListItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessUsersUserIdPostsResponseListItemMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItemAuthor
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("canEdit")]
        public bool CanEdit { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double MediaCount { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessUsersUserIdPostsResponseListItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("canViewMedia")]
        public bool CanViewMedia { get; set; }
    
    
        [JsonPropertyName("author")]
        public GetV2AccessUsersUserIdPostsResponseListItemAuthor? Author { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string ResponseType { get; set; }
    
    
        [JsonPropertyName("postedAt")]
        public string PostedAt { get; set; }
    
    
        [JsonPropertyName("postedAtPrecise")]
        public string PostedAtPrecise { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool IsOpened { get; set; }
    
    
        [JsonPropertyName("canToggleFavorite")]
        public bool CanToggleFavorite { get; set; }
    
    
        [JsonPropertyName("tipsAmount")]
        public string TipsAmount { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }
    
    
        [JsonPropertyName("canComment")]
        public bool CanComment { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double FavoritesCount { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool IsMediaReady { get; set; }
    
    
        [JsonPropertyName("rawText")]
        public string RawText { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponseCounters
    {
    
        [JsonPropertyName("audiosCount")]
        public double AudiosCount { get; set; }
    
    
        [JsonPropertyName("photosCount")]
        public double PhotosCount { get; set; }
    
    
        [JsonPropertyName("videosCount")]
        public double VideosCount { get; set; }
    
    
        [JsonPropertyName("mediasCount")]
        public double MediasCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double PostsCount { get; set; }
    
    
        [JsonPropertyName("streamsCount")]
        public double StreamsCount { get; set; }
    
    
        [JsonPropertyName("archivedPostsCount")]
        public double ArchivedPostsCount { get; set; }
    
    
        [JsonPropertyName("privateArchivedPostsCount")]
        public double PrivateArchivedPostsCount { get; set; }
    }

    public class GetV2AccessUsersUserIdPostsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessUsersUserIdPostsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("headMarker")]
        public string HeadMarker { get; set; }
    
    
        [JsonPropertyName("tailMarker")]
        public string TailMarker { get; set; }
    
    
        [JsonPropertyName("counters")]
        public GetV2AccessUsersUserIdPostsResponseCounters Counters { get; set; }
    }

    public enum GetV2AccessChatsUserIdMessagesResponseListItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessChatsUserIdMessagesResponseListItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessChatsUserIdMessagesResponseListItemMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("fromUser")]
        public object FromUser { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessChatsUserIdMessagesResponseListItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<double> Previews { get; set; }
    
    
        [JsonPropertyName("lockedText")]
        public bool? LockedText { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    
    
        [JsonPropertyName("queueId")]
        public double? QueueId { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool? IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public object? ReleaseForms { get; set; }
    
    
        [JsonPropertyName("isFromQueue")]
        public bool? IsFromQueue { get; set; }
    
    
        [JsonPropertyName("canUnsendQueue")]
        public bool? CanUnsendQueue { get; set; }
    
    
        [JsonPropertyName("unsendSecondsQueue")]
        public double? UnsendSecondsQueue { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool? IsOpened { get; set; }
    
    
        [JsonPropertyName("isNew")]
        public bool? IsNew { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("changedAt")]
        public string? ChangedAt { get; set; }
    
    
        [JsonPropertyName("cancelSeconds")]
        public double? CancelSeconds { get; set; }
    
    
        [JsonPropertyName("isLiked")]
        public bool? IsLiked { get; set; }
    
    
        [JsonPropertyName("canPurchase")]
        public bool? CanPurchase { get; set; }
    
    
        [JsonPropertyName("canPurchaseReason")]
        public string? CanPurchaseReason { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canBePinned")]
        public bool? CanBePinned { get; set; }
    
    
        [JsonPropertyName("isPinned")]
        public bool? IsPinned { get; set; }
    }

    public class GetV2AccessChatsUserIdMessagesResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessChatsUserIdMessagesResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public enum PostV2AccessChatsUserIdMessagesResponseMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<PostV2AccessChatsUserIdMessagesResponseMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<PostV2AccessChatsUserIdMessagesResponseMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponseMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<PostV2AccessChatsUserIdMessagesResponseMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public PostV2AccessChatsUserIdMessagesResponseMediaItemFiles? Files { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("fromUser")]
        public object FromUser { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<PostV2AccessChatsUserIdMessagesResponseMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<double> Previews { get; set; }
    
    
        [JsonPropertyName("lockedText")]
        public bool? LockedText { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    
    
        [JsonPropertyName("queueId")]
        public double? QueueId { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool? IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public object? ReleaseForms { get; set; }
    
    
        [JsonPropertyName("isFromQueue")]
        public bool? IsFromQueue { get; set; }
    
    
        [JsonPropertyName("canUnsendQueue")]
        public bool? CanUnsendQueue { get; set; }
    
    
        [JsonPropertyName("unsendSecondsQueue")]
        public double? UnsendSecondsQueue { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool? IsOpened { get; set; }
    
    
        [JsonPropertyName("isNew")]
        public bool? IsNew { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("changedAt")]
        public string? ChangedAt { get; set; }
    
    
        [JsonPropertyName("cancelSeconds")]
        public double? CancelSeconds { get; set; }
    
    
        [JsonPropertyName("isLiked")]
        public bool? IsLiked { get; set; }
    
    
        [JsonPropertyName("canPurchase")]
        public bool? CanPurchase { get; set; }
    
    
        [JsonPropertyName("canPurchaseReason")]
        public string? CanPurchaseReason { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canBePinned")]
        public bool? CanBePinned { get; set; }
    
    
        [JsonPropertyName("isPinned")]
        public bool? IsPinned { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesRequestReleaseForms
    {
    
        /// <summary>Users to add to release form</summary>
        [JsonPropertyName("users")]
        public List<int> Users { get; set; }
    
    
        /// <summary>Partners to add to release form</summary>
        [JsonPropertyName("partners")]
        public List<int> Partners { get; set; }
    
    
        /// <summary>Guests to add to release form</summary>
        [JsonPropertyName("guests")]
        public List<int> Guests { get; set; }
    }

    public class PostV2AccessChatsUserIdMessagesRequest
    {
    
        /// <summary>Whether this is a forwarded message</summary>
        [JsonPropertyName("isForwardedMessage")]
        public bool? IsForwardedMessage { get; set; }
    
    
        /// <summary>Text content. Supports markdown by default. See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    
    
        /// <summary>Media references to attach. Accepts vault media IDs, upload references (mediaUploadId), or http(s) URLs. See [mediaItems reference](/guides/media-items).</summary>
        [JsonPropertyName("mediaItems")]
        public List<object> MediaItems { get; set; }
    
    
        /// <summary>Whether text is locked behind paywall (defaults to false).</summary>
        [JsonPropertyName("isLockedText")]
        public bool? IsLockedText { get; set; }
    
    
        /// <summary>Price to unlock message content (0 for free)</summary>
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
    
        /// <summary>How many items in mediaItems should be previews. Uses the first N items from left to right.</summary>
        [JsonPropertyName("previewMediaCount")]
        public int? PreviewMediaCount { get; set; }
    
    
        /// <summary>Release form participants</summary>
        [JsonPropertyName("releaseForms")]
        public PostV2AccessChatsUserIdMessagesRequestReleaseForms? ReleaseForms { get; set; }
    
    
        /// <summary>Users to tag</summary>
        [JsonPropertyName("userTags")]
        public List<int> UserTags { get; set; }
    
    
        /// <summary>Whether to parse text as markdown (default: true). See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("isMarkdown")]
        public bool? IsMarkdown { get; set; }
    }

    public enum DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItemFiles? Files { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaTypes
    {
    
        [JsonPropertyName("video")]
        public double? Video { get; set; }
    
    
        [JsonPropertyName("photo")]
        public double? Photo { get; set; }
    
    
        [JsonPropertyName("gif")]
        public double? Gif { get; set; }
    
    
        [JsonPropertyName("audio")]
        public double? Audio { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueue
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("fromUser")]
        public object FromUser { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<double> Previews { get; set; }
    
    
        [JsonPropertyName("lockedText")]
        public bool? LockedText { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    
    
        [JsonPropertyName("queueId")]
        public double? QueueId { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool? IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public object? ReleaseForms { get; set; }
    
    
        [JsonPropertyName("isFromQueue")]
        public bool? IsFromQueue { get; set; }
    
    
        [JsonPropertyName("canUnsendQueue")]
        public bool? CanUnsendQueue { get; set; }
    
    
        [JsonPropertyName("unsendSecondsQueue")]
        public double? UnsendSecondsQueue { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool? IsOpened { get; set; }
    
    
        [JsonPropertyName("isNew")]
        public bool? IsNew { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("changedAt")]
        public string? ChangedAt { get; set; }
    
    
        [JsonPropertyName("cancelSeconds")]
        public double? CancelSeconds { get; set; }
    
    
        [JsonPropertyName("isLiked")]
        public bool? IsLiked { get; set; }
    
    
        [JsonPropertyName("canPurchase")]
        public bool? CanPurchase { get; set; }
    
    
        [JsonPropertyName("canPurchaseReason")]
        public string? CanPurchaseReason { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canBePinned")]
        public bool? CanBePinned { get; set; }
    
    
        [JsonPropertyName("isPinned")]
        public bool? IsPinned { get; set; }
    
    
        [JsonPropertyName("date")]
        public string? Date { get; set; }
    
    
        [JsonPropertyName("textCropped")]
        public string? TextCropped { get; set; }
    
    
        [JsonPropertyName("sentCount")]
        public double? SentCount { get; set; }
    
    
        [JsonPropertyName("viewedCount")]
        public double? ViewedCount { get; set; }
    
    
        [JsonPropertyName("canUnsend")]
        public bool? CanUnsend { get; set; }
    
    
        [JsonPropertyName("unsendSeconds")]
        public double? UnsendSeconds { get; set; }
    
    
        [JsonPropertyName("isCanceled")]
        public bool? IsCanceled { get; set; }
    
    
        [JsonPropertyName("mediaTypes")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueueMediaTypes? MediaTypes { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool? HasError { get; set; }
    
    
        [JsonPropertyName("price")]
        public string? Price { get; set; }
    
    
        [JsonPropertyName("purchasedCount")]
        public double? PurchasedCount { get; set; }
    
    
        [JsonPropertyName("canSendMessageToBuyers")]
        public bool? CanSendMessageToBuyers { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    
    
        [JsonPropertyName("queue")]
        public DeleteV2AccessChatsUserIdMessagesMessageIdResponseQueue? Queue { get; set; }
    }

    public class DeleteV2AccessChatsUserIdMessagesMessageIdRequest
    {
    
        [JsonPropertyName("withUserId")]
        public object WithUserId { get; set; }
    }

    public class PostV2AccessMassMessagesResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool? IsReady { get; set; }
    
    
        [JsonPropertyName("isDone")]
        public bool? IsDone { get; set; }
    
    
        [JsonPropertyName("total")]
        public double? Total { get; set; }
    
    
        [JsonPropertyName("pending")]
        public double? Pending { get; set; }
    
    
        [JsonPropertyName("canUnsend")]
        public bool? CanUnsend { get; set; }
    
    
        [JsonPropertyName("unsendSeconds")]
        public double? UnsendSeconds { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool? HasError { get; set; }
    
    
        [JsonPropertyName("isCanceled")]
        public bool? IsCanceled { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    }

    public class PostV2AccessMassMessagesRequestReleaseForms
    {
    
        /// <summary>Users to add to release form</summary>
        [JsonPropertyName("users")]
        public List<int> Users { get; set; }
    
    
        /// <summary>Partners to add to release form</summary>
        [JsonPropertyName("partners")]
        public List<int> Partners { get; set; }
    
    
        /// <summary>Guests to add to release form</summary>
        [JsonPropertyName("guests")]
        public List<int> Guests { get; set; }
    }

    public class PostV2AccessMassMessagesRequest
    {
    
        /// <summary>Whether this is a forwarded message</summary>
        [JsonPropertyName("isForwardedMessage")]
        public bool? IsForwardedMessage { get; set; }
    
    
        /// <summary>Text content. Supports markdown by default. See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    
    
        /// <summary>Media references to attach. Accepts vault media IDs, upload references (mediaUploadId), or http(s) URLs. See [mediaItems reference](/guides/media-items).</summary>
        [JsonPropertyName("mediaItems")]
        public List<object> MediaItems { get; set; }
    
    
        /// <summary>Whether text is locked behind paywall (defaults to false).</summary>
        [JsonPropertyName("isLockedText")]
        public bool? IsLockedText { get; set; }
    
    
        /// <summary>Price to unlock message content (0 for free)</summary>
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
    
        /// <summary>How many items in mediaItems should be previews. Uses the first N items from left to right.</summary>
        [JsonPropertyName("previewMediaCount")]
        public int? PreviewMediaCount { get; set; }
    
    
        /// <summary>Release form participants</summary>
        [JsonPropertyName("releaseForms")]
        public PostV2AccessMassMessagesRequestReleaseForms? ReleaseForms { get; set; }
    
    
        /// <summary>Users to tag</summary>
        [JsonPropertyName("userTags")]
        public List<int> UserTags { get; set; }
    
    
        /// <summary>Whether to parse text as markdown (default: true). See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("isMarkdown")]
        public bool? IsMarkdown { get; set; }
    
    
        /// <summary>When to send the message (omit for immediate)</summary>
        [JsonPropertyName("scheduledDate")]
        public object? ScheduledDate { get; set; }
    
    
        /// <summary>Specific user IDs to send to</summary>
        [JsonPropertyName("userIds")]
        public List<object> UserIds { get; set; }
    
    
        /// <summary>User list IDs to send to</summary>
        [JsonPropertyName("userLists")]
        public List<object> UserLists { get; set; }
    
    
        /// <summary>Only send to users subscribed after this date</summary>
        [JsonPropertyName("subscribedAfterDate")]
        public object? SubscribedAfterDate { get; set; }
    
    
        /// <summary>User list IDs to exclude</summary>
        [JsonPropertyName("excludeUserLists")]
        public List<object> ExcludeUserLists { get; set; }
    }

    public enum GetV2AccessMassMessagesMassMessageIdResponseMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponseMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessMassMessagesMassMessageIdResponseMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessMassMessagesMassMessageIdResponseMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessMassMessagesMassMessageIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("fromUser")]
        public object FromUser { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessMassMessagesMassMessageIdResponseMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<double> Previews { get; set; }
    
    
        [JsonPropertyName("lockedText")]
        public bool? LockedText { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    
    
        [JsonPropertyName("queueId")]
        public double? QueueId { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool? IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public object? ReleaseForms { get; set; }
    
    
        [JsonPropertyName("isFromQueue")]
        public bool? IsFromQueue { get; set; }
    
    
        [JsonPropertyName("canUnsendQueue")]
        public bool? CanUnsendQueue { get; set; }
    
    
        [JsonPropertyName("unsendSecondsQueue")]
        public double? UnsendSecondsQueue { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool? IsOpened { get; set; }
    
    
        [JsonPropertyName("isNew")]
        public bool? IsNew { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("changedAt")]
        public string? ChangedAt { get; set; }
    
    
        [JsonPropertyName("cancelSeconds")]
        public double? CancelSeconds { get; set; }
    
    
        [JsonPropertyName("isLiked")]
        public bool? IsLiked { get; set; }
    
    
        [JsonPropertyName("canPurchase")]
        public bool? CanPurchase { get; set; }
    
    
        [JsonPropertyName("canPurchaseReason")]
        public string? CanPurchaseReason { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canBePinned")]
        public bool? CanBePinned { get; set; }
    
    
        [JsonPropertyName("isPinned")]
        public bool? IsPinned { get; set; }
    }

    public class PutV2AccessMassMessagesMassMessageIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool? IsReady { get; set; }
    
    
        [JsonPropertyName("isDone")]
        public bool? IsDone { get; set; }
    
    
        [JsonPropertyName("total")]
        public double? Total { get; set; }
    
    
        [JsonPropertyName("pending")]
        public double? Pending { get; set; }
    
    
        [JsonPropertyName("canUnsend")]
        public bool? CanUnsend { get; set; }
    
    
        [JsonPropertyName("unsendSeconds")]
        public double? UnsendSeconds { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool? HasError { get; set; }
    
    
        [JsonPropertyName("isCanceled")]
        public bool? IsCanceled { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    }

    public class PutV2AccessMassMessagesMassMessageIdRequestReleaseForms
    {
    
        /// <summary>Users to add to release form</summary>
        [JsonPropertyName("users")]
        public List<int> Users { get; set; }
    
    
        /// <summary>Partners to add to release form</summary>
        [JsonPropertyName("partners")]
        public List<int> Partners { get; set; }
    
    
        /// <summary>Guests to add to release form</summary>
        [JsonPropertyName("guests")]
        public List<int> Guests { get; set; }
    }

    public class PutV2AccessMassMessagesMassMessageIdRequest
    {
    
        /// <summary>Whether this is a forwarded message</summary>
        [JsonPropertyName("isForwardedMessage")]
        public bool? IsForwardedMessage { get; set; }
    
    
        /// <summary>Text content. Supports markdown by default. See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("text")]
        public string? Text { get; set; }
    
    
        /// <summary>Media references to attach. Accepts vault media IDs, upload references (mediaUploadId), or http(s) URLs. See [mediaItems reference](/guides/media-items).</summary>
        [JsonPropertyName("mediaItems")]
        public List<object> MediaItems { get; set; }
    
    
        /// <summary>Whether text is locked behind paywall (defaults to false).</summary>
        [JsonPropertyName("isLockedText")]
        public bool? IsLockedText { get; set; }
    
    
        /// <summary>Price to unlock message content (0 for free)</summary>
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
    
        /// <summary>How many items in mediaItems should be previews. Uses the first N items from left to right.</summary>
        [JsonPropertyName("previewMediaCount")]
        public int? PreviewMediaCount { get; set; }
    
    
        /// <summary>Release form participants</summary>
        [JsonPropertyName("releaseForms")]
        public PutV2AccessMassMessagesMassMessageIdRequestReleaseForms? ReleaseForms { get; set; }
    
    
        /// <summary>Users to tag</summary>
        [JsonPropertyName("userTags")]
        public List<int> UserTags { get; set; }
    
    
        /// <summary>Whether to parse text as markdown (default: true). See [Text Formatting Guide](/guides/how-to/text-formatting).</summary>
        [JsonPropertyName("isMarkdown")]
        public bool? IsMarkdown { get; set; }
    
    
        /// <summary>When to send the message (omit for immediate)</summary>
        [JsonPropertyName("scheduledDate")]
        public object? ScheduledDate { get; set; }
    
    
        /// <summary>Specific user IDs to send to</summary>
        [JsonPropertyName("userIds")]
        public List<object> UserIds { get; set; }
    
    
        /// <summary>User list IDs to send to</summary>
        [JsonPropertyName("userLists")]
        public List<object> UserLists { get; set; }
    
    
        /// <summary>Only send to users subscribed after this date</summary>
        [JsonPropertyName("subscribedAfterDate")]
        public object? SubscribedAfterDate { get; set; }
    
    
        /// <summary>User list IDs to exclude</summary>
        [JsonPropertyName("excludeUserLists")]
        public List<object> ExcludeUserLists { get; set; }
    }

    public enum DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItemFiles? Files { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaTypes
    {
    
        [JsonPropertyName("video")]
        public double? Video { get; set; }
    
    
        [JsonPropertyName("photo")]
        public double? Photo { get; set; }
    
    
        [JsonPropertyName("gif")]
        public double? Gif { get; set; }
    
    
        [JsonPropertyName("audio")]
        public double? Audio { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponseQueue
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("fromUser")]
        public object FromUser { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<double> Previews { get; set; }
    
    
        [JsonPropertyName("lockedText")]
        public bool? LockedText { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    
    
        [JsonPropertyName("queueId")]
        public double? QueueId { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool? IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public object? ReleaseForms { get; set; }
    
    
        [JsonPropertyName("isFromQueue")]
        public bool? IsFromQueue { get; set; }
    
    
        [JsonPropertyName("canUnsendQueue")]
        public bool? CanUnsendQueue { get; set; }
    
    
        [JsonPropertyName("unsendSecondsQueue")]
        public double? UnsendSecondsQueue { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool? IsOpened { get; set; }
    
    
        [JsonPropertyName("isNew")]
        public bool? IsNew { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("changedAt")]
        public string? ChangedAt { get; set; }
    
    
        [JsonPropertyName("cancelSeconds")]
        public double? CancelSeconds { get; set; }
    
    
        [JsonPropertyName("isLiked")]
        public bool? IsLiked { get; set; }
    
    
        [JsonPropertyName("canPurchase")]
        public bool? CanPurchase { get; set; }
    
    
        [JsonPropertyName("canPurchaseReason")]
        public string? CanPurchaseReason { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canBePinned")]
        public bool? CanBePinned { get; set; }
    
    
        [JsonPropertyName("isPinned")]
        public bool? IsPinned { get; set; }
    
    
        [JsonPropertyName("date")]
        public string? Date { get; set; }
    
    
        [JsonPropertyName("textCropped")]
        public string? TextCropped { get; set; }
    
    
        [JsonPropertyName("sentCount")]
        public double? SentCount { get; set; }
    
    
        [JsonPropertyName("viewedCount")]
        public double? ViewedCount { get; set; }
    
    
        [JsonPropertyName("canUnsend")]
        public bool? CanUnsend { get; set; }
    
    
        [JsonPropertyName("unsendSeconds")]
        public double? UnsendSeconds { get; set; }
    
    
        [JsonPropertyName("isCanceled")]
        public bool? IsCanceled { get; set; }
    
    
        [JsonPropertyName("mediaTypes")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueueMediaTypes? MediaTypes { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool? HasError { get; set; }
    
    
        [JsonPropertyName("price")]
        public string? Price { get; set; }
    
    
        [JsonPropertyName("purchasedCount")]
        public double? PurchasedCount { get; set; }
    
    
        [JsonPropertyName("canSendMessageToBuyers")]
        public bool? CanSendMessageToBuyers { get; set; }
    }

    public class DeleteV2AccessMassMessagesMassMessageIdResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    
    
        [JsonPropertyName("queue")]
        public DeleteV2AccessMassMessagesMassMessageIdResponseQueue? Queue { get; set; }
    }

    public class GetV2AccessChatsResponseListItemWithUser
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("_view")]
        public string View { get; set; }
    }

    public enum GetV2AccessChatsResponseListItemLastMessageMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessChatsResponseListItemLastMessageMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessChatsResponseListItemLastMessageMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessageMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessChatsResponseListItemLastMessageMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessChatsResponseListItemLastMessageMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessChatsResponseListItemLastMessage
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("fromUser")]
        public object FromUser { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessChatsResponseListItemLastMessageMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<double> Previews { get; set; }
    
    
        [JsonPropertyName("lockedText")]
        public bool? LockedText { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    
    
        [JsonPropertyName("queueId")]
        public double? QueueId { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool? IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public object? ReleaseForms { get; set; }
    
    
        [JsonPropertyName("isFromQueue")]
        public bool? IsFromQueue { get; set; }
    
    
        [JsonPropertyName("canUnsendQueue")]
        public bool? CanUnsendQueue { get; set; }
    
    
        [JsonPropertyName("unsendSecondsQueue")]
        public double? UnsendSecondsQueue { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool? IsOpened { get; set; }
    
    
        [JsonPropertyName("isNew")]
        public bool? IsNew { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("changedAt")]
        public string? ChangedAt { get; set; }
    
    
        [JsonPropertyName("cancelSeconds")]
        public double? CancelSeconds { get; set; }
    
    
        [JsonPropertyName("isLiked")]
        public bool? IsLiked { get; set; }
    
    
        [JsonPropertyName("canPurchase")]
        public bool? CanPurchase { get; set; }
    
    
        [JsonPropertyName("canPurchaseReason")]
        public string? CanPurchaseReason { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canBePinned")]
        public bool? CanBePinned { get; set; }
    
    
        [JsonPropertyName("isPinned")]
        public bool? IsPinned { get; set; }
    }

    public class GetV2AccessChatsResponseListItem
    {
    
        [JsonPropertyName("withUser")]
        public GetV2AccessChatsResponseListItemWithUser WithUser { get; set; }
    
    
        [JsonPropertyName("canNotSendReason")]
        public object? CanNotSendReason { get; set; }
    
    
        [JsonPropertyName("canSendMessage")]
        public bool? CanSendMessage { get; set; }
    
    
        [JsonPropertyName("canGoToProfile")]
        public bool? CanGoToProfile { get; set; }
    
    
        [JsonPropertyName("unreadMessagesCount")]
        public double? UnreadMessagesCount { get; set; }
    
    
        [JsonPropertyName("hasUnreadTips")]
        public bool? HasUnreadTips { get; set; }
    
    
        [JsonPropertyName("isMutedNotifications")]
        public bool? IsMutedNotifications { get; set; }
    
    
        [JsonPropertyName("lastMessage")]
        public GetV2AccessChatsResponseListItemLastMessage? LastMessage { get; set; }
    
    
        [JsonPropertyName("lastReadMessageId")]
        public double? LastReadMessageId { get; set; }
    
    
        [JsonPropertyName("hasPurchasedFeed")]
        public bool? HasPurchasedFeed { get; set; }
    
    
        [JsonPropertyName("countPinnedMessages")]
        public double? CountPinnedMessages { get; set; }
    }

    public class GetV2AccessChatsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessChatsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("nextOffset")]
        public double? NextOffset { get; set; }
    }

    public enum GetV2AccessChatsUserIdMediaResponseListItemMediaItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItemMediaItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessChatsUserIdMediaResponseListItemMediaItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessChatsUserIdMediaResponseListItemMediaItemFiles? Files { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("text")]
        public string Text { get; set; }
    
    
        [JsonPropertyName("fromUser")]
        public object FromUser { get; set; }
    
    
        [JsonPropertyName("media")]
        public List<GetV2AccessChatsUserIdMediaResponseListItemMediaItem> Media { get; set; }
    
    
        [JsonPropertyName("isMediaReady")]
        public bool? IsMediaReady { get; set; }
    
    
        [JsonPropertyName("mediaCount")]
        public double? MediaCount { get; set; }
    
    
        [JsonPropertyName("previews")]
        public List<double> Previews { get; set; }
    
    
        [JsonPropertyName("lockedText")]
        public bool? LockedText { get; set; }
    
    
        [JsonPropertyName("responseType")]
        public string? ResponseType { get; set; }
    
    
        [JsonPropertyName("giphyId")]
        public string? GiphyId { get; set; }
    
    
        [JsonPropertyName("isFree")]
        public bool? IsFree { get; set; }
    
    
        [JsonPropertyName("isTip")]
        public bool? IsTip { get; set; }
    
    
        [JsonPropertyName("isReportedByMe")]
        public bool? IsReportedByMe { get; set; }
    
    
        [JsonPropertyName("isCouplePeopleMedia")]
        public bool? IsCouplePeopleMedia { get; set; }
    
    
        [JsonPropertyName("queueId")]
        public double? QueueId { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabled")]
        public bool? IsMarkdownDisabled { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public object? ReleaseForms { get; set; }
    
    
        [JsonPropertyName("isFromQueue")]
        public bool? IsFromQueue { get; set; }
    
    
        [JsonPropertyName("canUnsendQueue")]
        public bool? CanUnsendQueue { get; set; }
    
    
        [JsonPropertyName("unsendSecondsQueue")]
        public double? UnsendSecondsQueue { get; set; }
    
    
        [JsonPropertyName("isOpened")]
        public bool? IsOpened { get; set; }
    
    
        [JsonPropertyName("isNew")]
        public bool? IsNew { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }
    
    
        [JsonPropertyName("changedAt")]
        public string? ChangedAt { get; set; }
    
    
        [JsonPropertyName("cancelSeconds")]
        public double? CancelSeconds { get; set; }
    
    
        [JsonPropertyName("isLiked")]
        public bool? IsLiked { get; set; }
    
    
        [JsonPropertyName("canPurchase")]
        public bool? CanPurchase { get; set; }
    
    
        [JsonPropertyName("canPurchaseReason")]
        public string? CanPurchaseReason { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canBePinned")]
        public bool? CanBePinned { get; set; }
    
    
        [JsonPropertyName("isPinned")]
        public bool? IsPinned { get; set; }
    }

    public class GetV2AccessChatsUserIdMediaResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessChatsUserIdMediaResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessSubscribersResponseListItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessSubscribersResponseListItemSubscriptionHistoryItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class GetV2AccessSubscribersResponseListItemSubscription
    {
    
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    
    
        [JsonPropertyName("isExpired")]
        public bool IsExpired { get; set; }
    
    
        [JsonPropertyName("subscribedAt")]
        public string? SubscribedAt { get; set; }
    
    
        [JsonPropertyName("expiresAt")]
        public string? ExpiresAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("price")]
        public double? Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double? RegularPrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double? DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double? DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("history")]
        public List<GetV2AccessSubscribersResponseListItemSubscriptionHistoryItem> History { get; set; }
    }

    public class GetV2AccessSubscribersResponseListItemSpending
    {
    
        [JsonPropertyName("total")]
        public double Total { get; set; }
    
    
        [JsonPropertyName("tips")]
        public double Tips { get; set; }
    
    
        [JsonPropertyName("subscriptions")]
        public double Subscriptions { get; set; }
    
    
        [JsonPropertyName("messages")]
        public double Messages { get; set; }
    
    
        [JsonPropertyName("posts")]
        public double Posts { get; set; }
    
    
        [JsonPropertyName("streams")]
        public double Streams { get; set; }
    }

    public class GetV2AccessSubscribersResponseListItemCapabilities
    {
    
        [JsonPropertyName("canRestrict")]
        public bool CanRestrict { get; set; }
    
    
        [JsonPropertyName("canBlock")]
        public bool CanBlock { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool CanReport { get; set; }
    
    
        [JsonPropertyName("canUnsubscribe")]
        public bool CanUnsubscribe { get; set; }
    
    
        [JsonPropertyName("canReceiveMessages")]
        public bool CanReceiveMessages { get; set; }
    
    
        [JsonPropertyName("canSendTrial")]
        public bool CanSendTrial { get; set; }
    }

    public class GetV2AccessSubscribersResponseListItemListsItem
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessSubscribersResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessSubscribersResponseListItemAvatarThumbs? AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("lastSeen")]
        public string? LastSeen { get; set; }
    
    
        [JsonPropertyName("subscription")]
        public GetV2AccessSubscribersResponseListItemSubscription Subscription { get; set; }
    
    
        [JsonPropertyName("spending")]
        public GetV2AccessSubscribersResponseListItemSpending Spending { get; set; }
    
    
        [JsonPropertyName("isRestricted")]
        public bool IsRestricted { get; set; }
    
    
        [JsonPropertyName("isBlocked")]
        public bool IsBlocked { get; set; }
    
    
        [JsonPropertyName("capabilities")]
        public GetV2AccessSubscribersResponseListItemCapabilities Capabilities { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<GetV2AccessSubscribersResponseListItemListsItem> Lists { get; set; }
    }

    public class GetV2AccessSubscribersResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessSubscribersResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class PutV2AccessSubscribersUserIdNoteRequest
    {
    
        /// <summary>Note about the subscriber</summary>
        [JsonPropertyName("notice")]
        public string Notice { get; set; }
    }

    public class PutV2AccessSubscribersUserIdDiscountRequest
    {
    
        /// <summary>Discount percentage (1-100)</summary>
        [JsonPropertyName("discount")]
        public int Discount { get; set; }
    
    
        /// <summary>Number of months to apply discount</summary>
        [JsonPropertyName("period")]
        public int Period { get; set; }
    }

    public class PutV2AccessSubscribersUserIdCustomNameRequest
    {
    
        /// <summary>Custom display name for subscriber</summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    }

    public class GetV2AccessSubscriptionsResponseListItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessSubscriptionsResponseListItemListsItem
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessSubscriptionsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessSubscriptionsResponseListItemAvatarThumbs? AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<GetV2AccessSubscriptionsResponseListItemListsItem> Lists { get; set; }
    
    
        [JsonPropertyName("subscribedAt")]
        public string SubscribedAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    
    
        [JsonPropertyName("subscriptionPrice")]
        public double SubscriptionPrice { get; set; }
    
    
        [JsonPropertyName("tipsSumm")]
        public double? TipsSumm { get; set; }
    
    
        [JsonPropertyName("subscribesSumm")]
        public double? SubscribesSumm { get; set; }
    
    
        [JsonPropertyName("messagesSumm")]
        public double? MessagesSumm { get; set; }
    
    
        [JsonPropertyName("postsSumm")]
        public double? PostsSumm { get; set; }
    
    
        [JsonPropertyName("streamsSumm")]
        public double? StreamsSumm { get; set; }
    
    
        [JsonPropertyName("totalSumm")]
        public double? TotalSumm { get; set; }
    }

    public class GetV2AccessSubscriptionsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessSubscriptionsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessSubscriptionsCountResponseSubscriptions
    {
    
        [JsonPropertyName("active")]
        public double Active { get; set; }
    
    
        [JsonPropertyName("muted")]
        public double Muted { get; set; }
    
    
        [JsonPropertyName("restricted")]
        public double Restricted { get; set; }
    
    
        [JsonPropertyName("expired")]
        public double Expired { get; set; }
    
    
        [JsonPropertyName("blocked")]
        public double Blocked { get; set; }
    
    
        [JsonPropertyName("attention")]
        public double Attention { get; set; }
    
    
        [JsonPropertyName("all")]
        public double All { get; set; }
    }

    public class GetV2AccessSubscriptionsCountResponseSubscribers
    {
    
        [JsonPropertyName("active")]
        public double Active { get; set; }
    
    
        [JsonPropertyName("muted")]
        public double Muted { get; set; }
    
    
        [JsonPropertyName("restricted")]
        public double Restricted { get; set; }
    
    
        [JsonPropertyName("expired")]
        public double Expired { get; set; }
    
    
        [JsonPropertyName("blocked")]
        public double Blocked { get; set; }
    
    
        [JsonPropertyName("all")]
        public double All { get; set; }
    
    
        [JsonPropertyName("activeOnline")]
        public double ActiveOnline { get; set; }
    }

    public class GetV2AccessSubscriptionsCountResponse
    {
    
        [JsonPropertyName("subscriptions")]
        public GetV2AccessSubscriptionsCountResponseSubscriptions Subscriptions { get; set; }
    
    
        [JsonPropertyName("subscribers")]
        public GetV2AccessSubscriptionsCountResponseSubscribers Subscribers { get; set; }
    
    
        [JsonPropertyName("bookmarks")]
        public double Bookmarks { get; set; }
    }

    public class GetV2AccessSubscriptionsSubscriptionIdHistoryResponseListItem
    {
    
        [JsonPropertyName("subscribeDate")]
        public string SubscribeDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    }

    public class GetV2AccessSubscriptionsSubscriptionIdHistoryResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessSubscriptionsSubscriptionIdHistoryResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessPromotionsTrackingLinksResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessPromotionsTrackingLinksResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessPromotionsTrackingLinksResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class PostV2AccessPromotionsTrackingLinksRequest
    {
    
        /// <summary>Name for the tracking link</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PostV2AccessPromotionsTrackingLinksShareAccessResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class PostV2AccessPromotionsTrackingLinksShareAccessRequest
    {
    
        /// <summary>Campaign ID to share</summary>
        [JsonPropertyName("campaignId")]
        public int CampaignId { get; set; }
    
    
        /// <summary>User ID to share with</summary>
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
    }

    public class DeleteV2AccessPromotionsTrackingLinksShareAccessResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class DeleteV2AccessPromotionsTrackingLinksShareAccessRequest
    {
    
        /// <summary>Campaign ID to share</summary>
        [JsonPropertyName("campaignId")]
        public int CampaignId { get; set; }
    
    
        /// <summary>User ID to share with</summary>
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
    }

    public class GetV2AccessPromotionsTrackingLinksTrackingLinkIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PutV2AccessPromotionsTrackingLinksTrackingLinkIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class PutV2AccessPromotionsTrackingLinksTrackingLinkIdRequest
    {
    
        /// <summary>Name for the tracking link</summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class DeleteV2AccessPromotionsTrackingLinksTrackingLinkIdResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class GetV2AccessPromotionsTrackingLinksTrackingLinkIdClaimersResponse
    {
    
        [JsonPropertyName("list")]
        public List<object> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool? HasMore { get; set; }
    }

    public class PostV2AccessPromotionsTrialLinksResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("trialLinkName")]
        public string TrialLinkName { get; set; }
    
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("subscribeDays")]
        public double SubscribeDays { get; set; }
    
    
        [JsonPropertyName("subscribeCounts")]
        public double SubscribeCounts { get; set; }
    
    
        [JsonPropertyName("claimCounts")]
        public double ClaimCounts { get; set; }
    
    
        [JsonPropertyName("clicksCounts")]
        public double ClicksCounts { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isFinished")]
        public bool IsFinished { get; set; }
    
    
        [JsonPropertyName("user")]
        public object? User { get; set; }
    
    
        [JsonPropertyName("sharedWith")]
        public string? SharedWith { get; set; }
    }

    public class PostV2AccessPromotionsTrialLinksRequest
    {
    
        /// <summary>Name for the trial link</summary>
        [JsonPropertyName("trialLinkName")]
        public string TrialLinkName { get; set; }
    
    
        /// <summary>Number of days for trial subscription</summary>
        [JsonPropertyName("subscribeDays")]
        public int SubscribeDays { get; set; }
    
    
        /// <summary>Maximum number of times trial can be claimed</summary>
        [JsonPropertyName("subscribeCounts")]
        public int? SubscribeCounts { get; set; }
    
    
        /// <summary>When the trial link expires</summary>
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    }

    public class PostV2AccessPromotionsTrialLinksShareAccessResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class PostV2AccessPromotionsTrialLinksShareAccessRequest
    {
    
        /// <summary>Trial ID to share</summary>
        [JsonPropertyName("trialId")]
        public int TrialId { get; set; }
    
    
        /// <summary>User ID to share with</summary>
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
    }

    public class DeleteV2AccessPromotionsTrialLinksShareAccessResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class DeleteV2AccessPromotionsTrialLinksShareAccessRequest
    {
    
        /// <summary>Trial ID to share</summary>
        [JsonPropertyName("trialId")]
        public int TrialId { get; set; }
    
    
        /// <summary>User ID to share with</summary>
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
    }

    public class GetV2AccessPromotionsTrialLinksTrialLinkIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("trialLinkName")]
        public string TrialLinkName { get; set; }
    
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("subscribeDays")]
        public double SubscribeDays { get; set; }
    
    
        [JsonPropertyName("subscribeCounts")]
        public double SubscribeCounts { get; set; }
    
    
        [JsonPropertyName("claimCounts")]
        public double ClaimCounts { get; set; }
    
    
        [JsonPropertyName("clicksCounts")]
        public double ClicksCounts { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isFinished")]
        public bool IsFinished { get; set; }
    
    
        [JsonPropertyName("user")]
        public object? User { get; set; }
    
    
        [JsonPropertyName("sharedWith")]
        public string? SharedWith { get; set; }
    }

    public class PutV2AccessPromotionsTrialLinksTrialLinkIdResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class PutV2AccessPromotionsTrialLinksTrialLinkIdRequest
    {
    
        /// <summary>New name for trial link</summary>
        [JsonPropertyName("trialLinkName")]
        public string? TrialLinkName { get; set; }
    
    
        /// <summary>New trial duration in days</summary>
        [JsonPropertyName("subscribeDays")]
        public int? SubscribeDays { get; set; }
    
    
        /// <summary>New maximum claim count</summary>
        [JsonPropertyName("subscribeCounts")]
        public int? SubscribeCounts { get; set; }
    
    
        /// <summary>New expiration date</summary>
        [JsonPropertyName("expiredAt")]
        public string? ExpiredAt { get; set; }
    }

    public class DeleteV2AccessPromotionsTrialLinksTrialLinkIdResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class PostV2AccessPromotionsBundlesResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("canBuy")]
        public bool CanBuy { get; set; }
    }

    public class PostV2AccessPromotionsBundlesRequest
    {
    
        /// <summary>Discount percentage for bundle</summary>
        [JsonPropertyName("discount")]
        public int Discount { get; set; }
    
    
        /// <summary>Bundle subscription duration in days</summary>
        [JsonPropertyName("duration")]
        public int Duration { get; set; }
    }

    public class GetV2AccessPromotionsBundlesBundleIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("canBuy")]
        public bool CanBuy { get; set; }
    }

    public class PutV2AccessPromotionsBundlesBundleIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("canBuy")]
        public bool CanBuy { get; set; }
    }

    public class PutV2AccessPromotionsBundlesBundleIdRequest
    {
    
        /// <summary>Discount percentage for bundle</summary>
        [JsonPropertyName("discount")]
        public int? Discount { get; set; }
    
    
        /// <summary>Bundle subscription duration in days</summary>
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }
    }

    public class DeleteV2AccessPromotionsBundlesBundleIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("canBuy")]
        public bool CanBuy { get; set; }
    }

    public class PostV2AccessPromotionsRequest
    {
    
        /// <summary>Discount percentage to offer</summary>
        [JsonPropertyName("discount")]
        public int Discount { get; set; }
    
    
        /// <summary>Promotion message</summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
    
        /// <summary>Days until promotion ends</summary>
        [JsonPropertyName("finishDays")]
        public int FinishDays { get; set; }
    
    
        /// <summary>Maximum subscribers</summary>
        [JsonPropertyName("subscribeCounts")]
        public int SubscribeCounts { get; set; }
    
    
        /// <summary>Subscription duration in days</summary>
        [JsonPropertyName("subscribeDays")]
        public int SubscribeDays { get; set; }
    
    
        /// <summary>Promotion types</summary>
        [JsonPropertyName("type")]
        public List<string> Type { get; set; }
    }

    public class PutV2AccessPromotionsPromotionIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
    
        [JsonPropertyName("rawMessage")]
        public string RawMessage { get; set; }
    
    
        [JsonPropertyName("hasRelatedPromo")]
        public bool HasRelatedPromo { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("canClaim")]
        public bool CanClaim { get; set; }
    
    
        [JsonPropertyName("claimsCount")]
        public double ClaimsCount { get; set; }
    
    
        [JsonPropertyName("subscribeCounts")]
        public double SubscribeCounts { get; set; }
    
    
        [JsonPropertyName("subscribeDays")]
        public double SubscribeDays { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("finishedAt")]
        public string FinishedAt { get; set; }
    
    
        [JsonPropertyName("isFinished")]
        public bool IsFinished { get; set; }
    }

    public class PutV2AccessPromotionsPromotionIdRequest
    {
    
        /// <summary>Discount percentage to offer</summary>
        [JsonPropertyName("discount")]
        public int? Discount { get; set; }
    
    
        /// <summary>Promotion message</summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    
    
        /// <summary>Days until promotion ends</summary>
        [JsonPropertyName("finishDays")]
        public int? FinishDays { get; set; }
    
    
        /// <summary>Maximum subscribers</summary>
        [JsonPropertyName("subscribeCounts")]
        public int? SubscribeCounts { get; set; }
    
    
        /// <summary>Subscription duration in days</summary>
        [JsonPropertyName("subscribeDays")]
        public int? SubscribeDays { get; set; }
    
    
        /// <summary>Promotion types</summary>
        [JsonPropertyName("type")]
        public List<string> Type { get; set; }
    }

    public class DeleteV2AccessPromotionsPromotionIdResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class PostV2AccessPromotionsPromotionIdStopResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class GetV2AccessUsersRestrictResponseListItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessUsersRestrictResponseListItemListsItem
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessUsersRestrictResponseListItemSubscribedByDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class GetV2AccessUsersRestrictResponseListItemSubscribedByData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("showPostsInFeed")]
        public bool ShowPostsInFeed { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<GetV2AccessUsersRestrictResponseListItemSubscribedByDataSubscribesItem> Subscribes { get; set; }
    }

    public class GetV2AccessUsersRestrictResponseListItemSubscribedOnDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class GetV2AccessUsersRestrictResponseListItemSubscribedOnData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<GetV2AccessUsersRestrictResponseListItemSubscribedOnDataSubscribesItem> Subscribes { get; set; }
    
    
        [JsonPropertyName("tipsSumm")]
        public double TipsSumm { get; set; }
    
    
        [JsonPropertyName("subscribesSumm")]
        public double SubscribesSumm { get; set; }
    
    
        [JsonPropertyName("messagesSumm")]
        public double MessagesSumm { get; set; }
    
    
        [JsonPropertyName("postsSumm")]
        public double PostsSumm { get; set; }
    
    
        [JsonPropertyName("streamsSumm")]
        public double StreamsSumm { get; set; }
    
    
        [JsonPropertyName("totalSumm")]
        public double TotalSumm { get; set; }
    }

    public class GetV2AccessUsersRestrictResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessUsersRestrictResponseListItemAvatarThumbs? AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<GetV2AccessUsersRestrictResponseListItemListsItem> Lists { get; set; }
    
    
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
    
    
        [JsonPropertyName("notice")]
        public string? Notice { get; set; }
    
    
        [JsonPropertyName("isRestricted")]
        public bool? IsRestricted { get; set; }
    
    
        [JsonPropertyName("canRestrict")]
        public bool? CanRestrict { get; set; }
    
    
        [JsonPropertyName("subscribedBy")]
        public bool? SubscribedBy { get; set; }
    
    
        [JsonPropertyName("subscribedByExpire")]
        public bool? SubscribedByExpire { get; set; }
    
    
        [JsonPropertyName("subscribedByExpireDate")]
        public string? SubscribedByExpireDate { get; set; }
    
    
        [JsonPropertyName("subscribedByAutoprolong")]
        public bool? SubscribedByAutoprolong { get; set; }
    
    
        [JsonPropertyName("subscribedIsExpiredNow")]
        public bool? SubscribedIsExpiredNow { get; set; }
    
    
        [JsonPropertyName("currentSubscribePrice")]
        public double? CurrentSubscribePrice { get; set; }
    
    
        [JsonPropertyName("subscribedOn")]
        public bool? SubscribedOn { get; set; }
    
    
        [JsonPropertyName("subscribedOnExpiredNow")]
        public bool? SubscribedOnExpiredNow { get; set; }
    
    
        [JsonPropertyName("subscribedOnDuration")]
        public string? SubscribedOnDuration { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canReceiveChatMessage")]
        public bool? CanReceiveChatMessage { get; set; }
    
    
        [JsonPropertyName("hideChat")]
        public bool? HideChat { get; set; }
    
    
        [JsonPropertyName("lastSeen")]
        public string? LastSeen { get; set; }
    
    
        [JsonPropertyName("isPerformer")]
        public bool? IsPerformer { get; set; }
    
    
        [JsonPropertyName("isRealPerformer")]
        public bool? IsRealPerformer { get; set; }
    
    
        [JsonPropertyName("subscribedByData")]
        public GetV2AccessUsersRestrictResponseListItemSubscribedByData? SubscribedByData { get; set; }
    
    
        [JsonPropertyName("subscribedOnData")]
        public GetV2AccessUsersRestrictResponseListItemSubscribedOnData? SubscribedOnData { get; set; }
    
    
        [JsonPropertyName("canTrialSend")]
        public bool? CanTrialSend { get; set; }
    
    
        [JsonPropertyName("isBlocked")]
        public bool? IsBlocked { get; set; }
    
    
        [JsonPropertyName("canUnsubscribe")]
        public bool? CanUnsubscribe { get; set; }
    
    
        [JsonPropertyName("isPendingAutoprolong")]
        public bool? IsPendingAutoprolong { get; set; }
    }

    public class GetV2AccessUsersRestrictResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessUsersRestrictResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessUsersBlockedResponseListItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessUsersBlockedResponseListItemListsItem
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessUsersBlockedResponseListItemSubscribedByDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class GetV2AccessUsersBlockedResponseListItemSubscribedByData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("showPostsInFeed")]
        public bool ShowPostsInFeed { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<GetV2AccessUsersBlockedResponseListItemSubscribedByDataSubscribesItem> Subscribes { get; set; }
    }

    public class GetV2AccessUsersBlockedResponseListItemSubscribedOnDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class GetV2AccessUsersBlockedResponseListItemSubscribedOnData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<GetV2AccessUsersBlockedResponseListItemSubscribedOnDataSubscribesItem> Subscribes { get; set; }
    
    
        [JsonPropertyName("tipsSumm")]
        public double TipsSumm { get; set; }
    
    
        [JsonPropertyName("subscribesSumm")]
        public double SubscribesSumm { get; set; }
    
    
        [JsonPropertyName("messagesSumm")]
        public double MessagesSumm { get; set; }
    
    
        [JsonPropertyName("postsSumm")]
        public double PostsSumm { get; set; }
    
    
        [JsonPropertyName("streamsSumm")]
        public double StreamsSumm { get; set; }
    
    
        [JsonPropertyName("totalSumm")]
        public double TotalSumm { get; set; }
    }

    public class GetV2AccessUsersBlockedResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessUsersBlockedResponseListItemAvatarThumbs? AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<GetV2AccessUsersBlockedResponseListItemListsItem> Lists { get; set; }
    
    
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
    
    
        [JsonPropertyName("notice")]
        public string? Notice { get; set; }
    
    
        [JsonPropertyName("isRestricted")]
        public bool? IsRestricted { get; set; }
    
    
        [JsonPropertyName("canRestrict")]
        public bool? CanRestrict { get; set; }
    
    
        [JsonPropertyName("subscribedBy")]
        public bool? SubscribedBy { get; set; }
    
    
        [JsonPropertyName("subscribedByExpire")]
        public bool? SubscribedByExpire { get; set; }
    
    
        [JsonPropertyName("subscribedByExpireDate")]
        public string? SubscribedByExpireDate { get; set; }
    
    
        [JsonPropertyName("subscribedByAutoprolong")]
        public bool? SubscribedByAutoprolong { get; set; }
    
    
        [JsonPropertyName("subscribedIsExpiredNow")]
        public bool? SubscribedIsExpiredNow { get; set; }
    
    
        [JsonPropertyName("currentSubscribePrice")]
        public double? CurrentSubscribePrice { get; set; }
    
    
        [JsonPropertyName("subscribedOn")]
        public bool? SubscribedOn { get; set; }
    
    
        [JsonPropertyName("subscribedOnExpiredNow")]
        public bool? SubscribedOnExpiredNow { get; set; }
    
    
        [JsonPropertyName("subscribedOnDuration")]
        public string? SubscribedOnDuration { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canReceiveChatMessage")]
        public bool? CanReceiveChatMessage { get; set; }
    
    
        [JsonPropertyName("hideChat")]
        public bool? HideChat { get; set; }
    
    
        [JsonPropertyName("lastSeen")]
        public string? LastSeen { get; set; }
    
    
        [JsonPropertyName("isPerformer")]
        public bool? IsPerformer { get; set; }
    
    
        [JsonPropertyName("isRealPerformer")]
        public bool? IsRealPerformer { get; set; }
    
    
        [JsonPropertyName("subscribedByData")]
        public GetV2AccessUsersBlockedResponseListItemSubscribedByData? SubscribedByData { get; set; }
    
    
        [JsonPropertyName("subscribedOnData")]
        public GetV2AccessUsersBlockedResponseListItemSubscribedOnData? SubscribedOnData { get; set; }
    
    
        [JsonPropertyName("canTrialSend")]
        public bool? CanTrialSend { get; set; }
    
    
        [JsonPropertyName("isBlocked")]
        public bool? IsBlocked { get; set; }
    
    
        [JsonPropertyName("canUnsubscribe")]
        public bool? CanUnsubscribe { get; set; }
    
    
        [JsonPropertyName("isPendingAutoprolong")]
        public bool? IsPendingAutoprolong { get; set; }
    }

    public class GetV2AccessUsersBlockedResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessUsersBlockedResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemListsItem
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemHeaderSize
    {
    
        [JsonPropertyName("width")]
        public double Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double Height { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemHeaderThumbs
    {
    
        [JsonPropertyName("w480")]
        public string W480 { get; set; }
    
    
        [JsonPropertyName("w760")]
        public string W760 { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemSubscribedByDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemSubscribedByData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("showPostsInFeed")]
        public bool ShowPostsInFeed { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<GetV2AccessUsersListResponseUsersItemSubscribedByDataSubscribesItem> Subscribes { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemSubscribedOnDataSubscribesItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("userId")]
        public double UserId { get; set; }
    
    
        [JsonPropertyName("subscriberId")]
        public double SubscriberId { get; set; }
    
    
        [JsonPropertyName("date")]
        public string Date { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    
    
        [JsonPropertyName("startDate")]
        public string StartDate { get; set; }
    
    
        [JsonPropertyName("expireDate")]
        public string ExpireDate { get; set; }
    
    
        [JsonPropertyName("cancelDate")]
        public string? CancelDate { get; set; }
    
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("discount")]
        public double Discount { get; set; }
    
    
        [JsonPropertyName("earningId")]
        public double EarningId { get; set; }
    
    
        [JsonPropertyName("action")]
        public string Action { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("offerStart")]
        public string? OfferStart { get; set; }
    
    
        [JsonPropertyName("offerEnd")]
        public string? OfferEnd { get; set; }
    
    
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItemSubscribedOnData
    {
    
        [JsonPropertyName("price")]
        public double Price { get; set; }
    
    
        [JsonPropertyName("newPrice")]
        public double NewPrice { get; set; }
    
    
        [JsonPropertyName("regularPrice")]
        public double RegularPrice { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double SubscribePrice { get; set; }
    
    
        [JsonPropertyName("discountPercent")]
        public double DiscountPercent { get; set; }
    
    
        [JsonPropertyName("discountPeriod")]
        public double DiscountPeriod { get; set; }
    
    
        [JsonPropertyName("subscribeAt")]
        public string SubscribeAt { get; set; }
    
    
        [JsonPropertyName("expiredAt")]
        public string ExpiredAt { get; set; }
    
    
        [JsonPropertyName("renewedAt")]
        public string? RenewedAt { get; set; }
    
    
        [JsonPropertyName("discountFinishedAt")]
        public string? DiscountFinishedAt { get; set; }
    
    
        [JsonPropertyName("discountStartedAt")]
        public string? DiscountStartedAt { get; set; }
    
    
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    
    
        [JsonPropertyName("isMuted")]
        public bool IsMuted { get; set; }
    
    
        [JsonPropertyName("unsubscribeReason")]
        public string UnsubscribeReason { get; set; }
    
    
        [JsonPropertyName("duration")]
        public string Duration { get; set; }
    
    
        [JsonPropertyName("hasActivePaidSubscriptions")]
        public bool HasActivePaidSubscriptions { get; set; }
    
    
        [JsonPropertyName("subscribes")]
        public List<GetV2AccessUsersListResponseUsersItemSubscribedOnDataSubscribesItem> Subscribes { get; set; }
    
    
        [JsonPropertyName("tipsSumm")]
        public double TipsSumm { get; set; }
    
    
        [JsonPropertyName("subscribesSumm")]
        public double SubscribesSumm { get; set; }
    
    
        [JsonPropertyName("messagesSumm")]
        public double MessagesSumm { get; set; }
    
    
        [JsonPropertyName("postsSumm")]
        public double PostsSumm { get; set; }
    
    
        [JsonPropertyName("streamsSumm")]
        public double StreamsSumm { get; set; }
    
    
        [JsonPropertyName("totalSumm")]
        public double TotalSumm { get; set; }
    }

    public class GetV2AccessUsersListResponseUsersItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessUsersListResponseUsersItemAvatarThumbs? AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<GetV2AccessUsersListResponseUsersItemListsItem> Lists { get; set; }
    
    
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
    
    
        [JsonPropertyName("notice")]
        public string? Notice { get; set; }
    
    
        [JsonPropertyName("about")]
        public string? About { get; set; }
    
    
        [JsonPropertyName("isMarkdownDisabledForAbout")]
        public bool? IsMarkdownDisabledForAbout { get; set; }
    
    
        [JsonPropertyName("website")]
        public string? Website { get; set; }
    
    
        [JsonPropertyName("wishlist")]
        public string? Wishlist { get; set; }
    
    
        [JsonPropertyName("location")]
        public string? Location { get; set; }
    
    
        [JsonPropertyName("header")]
        public string? Header { get; set; }
    
    
        [JsonPropertyName("headerSize")]
        public GetV2AccessUsersListResponseUsersItemHeaderSize? HeaderSize { get; set; }
    
    
        [JsonPropertyName("headerThumbs")]
        public GetV2AccessUsersListResponseUsersItemHeaderThumbs? HeaderThumbs { get; set; }
    
    
        [JsonPropertyName("subscribersCount")]
        public double? SubscribersCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double? PostsCount { get; set; }
    
    
        [JsonPropertyName("archivedPostsCount")]
        public double? ArchivedPostsCount { get; set; }
    
    
        [JsonPropertyName("privateArchivedPostsCount")]
        public double? PrivateArchivedPostsCount { get; set; }
    
    
        [JsonPropertyName("photosCount")]
        public double? PhotosCount { get; set; }
    
    
        [JsonPropertyName("videosCount")]
        public double? VideosCount { get; set; }
    
    
        [JsonPropertyName("audiosCount")]
        public double? AudiosCount { get; set; }
    
    
        [JsonPropertyName("mediasCount")]
        public double? MediasCount { get; set; }
    
    
        [JsonPropertyName("favoritesCount")]
        public double? FavoritesCount { get; set; }
    
    
        [JsonPropertyName("favoritedCount")]
        public double? FavoritedCount { get; set; }
    
    
        [JsonPropertyName("joinDate")]
        public string? JoinDate { get; set; }
    
    
        [JsonPropertyName("lastSeen")]
        public string? LastSeen { get; set; }
    
    
        [JsonPropertyName("subscribedBy")]
        public bool? SubscribedBy { get; set; }
    
    
        [JsonPropertyName("subscribedByExpire")]
        public bool? SubscribedByExpire { get; set; }
    
    
        [JsonPropertyName("subscribedByExpireDate")]
        public string? SubscribedByExpireDate { get; set; }
    
    
        [JsonPropertyName("subscribedByAutoprolong")]
        public bool? SubscribedByAutoprolong { get; set; }
    
    
        [JsonPropertyName("subscribedIsExpiredNow")]
        public bool? SubscribedIsExpiredNow { get; set; }
    
    
        [JsonPropertyName("subscribedByData")]
        public GetV2AccessUsersListResponseUsersItemSubscribedByData? SubscribedByData { get; set; }
    
    
        [JsonPropertyName("subscribedOn")]
        public bool? SubscribedOn { get; set; }
    
    
        [JsonPropertyName("subscribedOnExpiredNow")]
        public bool? SubscribedOnExpiredNow { get; set; }
    
    
        [JsonPropertyName("subscribedOnDuration")]
        public string? SubscribedOnDuration { get; set; }
    
    
        [JsonPropertyName("subscribedOnData")]
        public GetV2AccessUsersListResponseUsersItemSubscribedOnData? SubscribedOnData { get; set; }
    
    
        [JsonPropertyName("subscribePrice")]
        public double? SubscribePrice { get; set; }
    
    
        [JsonPropertyName("currentSubscribePrice")]
        public double? CurrentSubscribePrice { get; set; }
    
    
        [JsonPropertyName("canAddSubscriber")]
        public bool? CanAddSubscriber { get; set; }
    
    
        [JsonPropertyName("tipsEnabled")]
        public bool? TipsEnabled { get; set; }
    
    
        [JsonPropertyName("tipsTextEnabled")]
        public bool? TipsTextEnabled { get; set; }
    
    
        [JsonPropertyName("tipsMin")]
        public double? TipsMin { get; set; }
    
    
        [JsonPropertyName("tipsMinInternal")]
        public double? TipsMinInternal { get; set; }
    
    
        [JsonPropertyName("tipsMax")]
        public double? TipsMax { get; set; }
    
    
        [JsonPropertyName("canLookStory")]
        public bool? CanLookStory { get; set; }
    
    
        [JsonPropertyName("canCommentStory")]
        public bool? CanCommentStory { get; set; }
    
    
        [JsonPropertyName("hasNotViewedStory")]
        public bool? HasNotViewedStory { get; set; }
    
    
        [JsonPropertyName("hasStories")]
        public bool? HasStories { get; set; }
    
    
        [JsonPropertyName("isRestricted")]
        public bool? IsRestricted { get; set; }
    
    
        [JsonPropertyName("canRestrict")]
        public bool? CanRestrict { get; set; }
    
    
        [JsonPropertyName("isBlocked")]
        public bool? IsBlocked { get; set; }
    
    
        [JsonPropertyName("canReport")]
        public bool? CanReport { get; set; }
    
    
        [JsonPropertyName("canUnsubscribe")]
        public bool? CanUnsubscribe { get; set; }
    
    
        [JsonPropertyName("isPendingAutoprolong")]
        public bool? IsPendingAutoprolong { get; set; }
    
    
        [JsonPropertyName("isPerformer")]
        public bool? IsPerformer { get; set; }
    
    
        [JsonPropertyName("isRealPerformer")]
        public bool? IsRealPerformer { get; set; }
    
    
        [JsonPropertyName("canReceiveChatMessage")]
        public bool? CanReceiveChatMessage { get; set; }
    
    
        [JsonPropertyName("canChat")]
        public bool? CanChat { get; set; }
    
    
        [JsonPropertyName("showPostsInFeed")]
        public bool? ShowPostsInFeed { get; set; }
    
    
        [JsonPropertyName("hasPinnedPosts")]
        public bool? HasPinnedPosts { get; set; }
    
    
        [JsonPropertyName("hasLabels")]
        public bool? HasLabels { get; set; }
    
    
        [JsonPropertyName("isPrivateRestriction")]
        public bool? IsPrivateRestriction { get; set; }
    
    
        [JsonPropertyName("showSubscribersCount")]
        public bool? ShowSubscribersCount { get; set; }
    
    
        [JsonPropertyName("showMediaCount")]
        public bool? ShowMediaCount { get; set; }
    
    
        [JsonPropertyName("isReferrerAllowed")]
        public bool? IsReferrerAllowed { get; set; }
    
    
        [JsonPropertyName("canCreatePromotion")]
        public bool? CanCreatePromotion { get; set; }
    
    
        [JsonPropertyName("canCreateTrial")]
        public bool? CanCreateTrial { get; set; }
    
    
        [JsonPropertyName("isAdultContent")]
        public bool? IsAdultContent { get; set; }
    
    
        [JsonPropertyName("canTrialSend")]
        public bool? CanTrialSend { get; set; }
    
    
        [JsonPropertyName("isFriend")]
        public bool? IsFriend { get; set; }
    
    
        [JsonPropertyName("hasScheduledStream")]
        public bool? HasScheduledStream { get; set; }
    
    
        [JsonPropertyName("hasStream")]
        public bool? HasStream { get; set; }
    
    
        [JsonPropertyName("canPayInternal")]
        public bool? CanPayInternal { get; set; }
    }

    public class GetV2AccessUsersListResponse
    {
    
        [JsonPropertyName("users")]
        public List<GetV2AccessUsersListResponseUsersItem> Users { get; set; }
    }

    public class GetV2AccessUsersListsResponseListItemSortListItem
    {
    
        [JsonPropertyName("order")]
        public string Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string Direction { get; set; }
    }

    public class GetV2AccessUsersListsResponseListItemUsersItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessUsersListsResponseListItemUsersItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessUsersListsResponseListItemUsersItemAvatarThumbs? AvatarThumbs { get; set; }
    }

    public class GetV2AccessUsersListsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("usersCount")]
        public double? UsersCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double? PostsCount { get; set; }
    
    
        [JsonPropertyName("order")]
        public string? Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string? Direction { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool? CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool? CanDelete { get; set; }
    
    
        [JsonPropertyName("canManageUsers")]
        public bool? CanManageUsers { get; set; }
    
    
        [JsonPropertyName("canAddUsers")]
        public bool? CanAddUsers { get; set; }
    
    
        [JsonPropertyName("canPinnedToFeed")]
        public bool? CanPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("isPinnedToFeed")]
        public bool? IsPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("canPinnedToChat")]
        public bool? CanPinnedToChat { get; set; }
    
    
        [JsonPropertyName("isPinnedToChat")]
        public bool? IsPinnedToChat { get; set; }
    
    
        [JsonPropertyName("sortList")]
        public List<GetV2AccessUsersListsResponseListItemSortListItem> SortList { get; set; }
    
    
        [JsonPropertyName("users")]
        public List<GetV2AccessUsersListsResponseListItemUsersItem> Users { get; set; }
    }

    public class GetV2AccessUsersListsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessUsersListsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("order")]
        public string? Order { get; set; }
    
    
        [JsonPropertyName("sort")]
        public string? Sort { get; set; }
    }

    public class PostV2AccessUsersListsResponseSortListItem
    {
    
        [JsonPropertyName("order")]
        public string Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string Direction { get; set; }
    }

    public class PostV2AccessUsersListsResponseUsersItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PostV2AccessUsersListsResponseUsersItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PostV2AccessUsersListsResponseUsersItemAvatarThumbs? AvatarThumbs { get; set; }
    }

    public class PostV2AccessUsersListsResponse
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("usersCount")]
        public double? UsersCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double? PostsCount { get; set; }
    
    
        [JsonPropertyName("order")]
        public string? Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string? Direction { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool? CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool? CanDelete { get; set; }
    
    
        [JsonPropertyName("canManageUsers")]
        public bool? CanManageUsers { get; set; }
    
    
        [JsonPropertyName("canAddUsers")]
        public bool? CanAddUsers { get; set; }
    
    
        [JsonPropertyName("canPinnedToFeed")]
        public bool? CanPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("isPinnedToFeed")]
        public bool? IsPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("canPinnedToChat")]
        public bool? CanPinnedToChat { get; set; }
    
    
        [JsonPropertyName("isPinnedToChat")]
        public bool? IsPinnedToChat { get; set; }
    
    
        [JsonPropertyName("sortList")]
        public List<PostV2AccessUsersListsResponseSortListItem> SortList { get; set; }
    
    
        [JsonPropertyName("users")]
        public List<PostV2AccessUsersListsResponseUsersItem> Users { get; set; }
    }

    public class PostV2AccessUsersListsRequest
    {
    
        /// <summary>Name for the new user list</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessUsersListsListIdResponseSortListItem
    {
    
        [JsonPropertyName("order")]
        public string Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string Direction { get; set; }
    }

    public class GetV2AccessUsersListsListIdResponseUsersItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessUsersListsListIdResponseUsersItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessUsersListsListIdResponseUsersItemAvatarThumbs? AvatarThumbs { get; set; }
    }

    public class GetV2AccessUsersListsListIdResponse
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("usersCount")]
        public double? UsersCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double? PostsCount { get; set; }
    
    
        [JsonPropertyName("order")]
        public string? Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string? Direction { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool? CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool? CanDelete { get; set; }
    
    
        [JsonPropertyName("canManageUsers")]
        public bool? CanManageUsers { get; set; }
    
    
        [JsonPropertyName("canAddUsers")]
        public bool? CanAddUsers { get; set; }
    
    
        [JsonPropertyName("canPinnedToFeed")]
        public bool? CanPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("isPinnedToFeed")]
        public bool? IsPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("canPinnedToChat")]
        public bool? CanPinnedToChat { get; set; }
    
    
        [JsonPropertyName("isPinnedToChat")]
        public bool? IsPinnedToChat { get; set; }
    
    
        [JsonPropertyName("sortList")]
        public List<GetV2AccessUsersListsListIdResponseSortListItem> SortList { get; set; }
    
    
        [JsonPropertyName("users")]
        public List<GetV2AccessUsersListsListIdResponseUsersItem> Users { get; set; }
    }

    public class PatchV2AccessUsersListsListIdResponseSortListItem
    {
    
        [JsonPropertyName("order")]
        public string Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string Direction { get; set; }
    }

    public class PatchV2AccessUsersListsListIdResponseUsersItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PatchV2AccessUsersListsListIdResponseUsersItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PatchV2AccessUsersListsListIdResponseUsersItemAvatarThumbs? AvatarThumbs { get; set; }
    }

    public class PatchV2AccessUsersListsListIdResponse
    {
    
        [JsonPropertyName("id")]
        public object Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("usersCount")]
        public double? UsersCount { get; set; }
    
    
        [JsonPropertyName("postsCount")]
        public double? PostsCount { get; set; }
    
    
        [JsonPropertyName("order")]
        public string? Order { get; set; }
    
    
        [JsonPropertyName("direction")]
        public string? Direction { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool? CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool? CanDelete { get; set; }
    
    
        [JsonPropertyName("canManageUsers")]
        public bool? CanManageUsers { get; set; }
    
    
        [JsonPropertyName("canAddUsers")]
        public bool? CanAddUsers { get; set; }
    
    
        [JsonPropertyName("canPinnedToFeed")]
        public bool? CanPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("isPinnedToFeed")]
        public bool? IsPinnedToFeed { get; set; }
    
    
        [JsonPropertyName("canPinnedToChat")]
        public bool? CanPinnedToChat { get; set; }
    
    
        [JsonPropertyName("isPinnedToChat")]
        public bool? IsPinnedToChat { get; set; }
    
    
        [JsonPropertyName("sortList")]
        public List<PatchV2AccessUsersListsListIdResponseSortListItem> SortList { get; set; }
    
    
        [JsonPropertyName("users")]
        public List<PatchV2AccessUsersListsListIdResponseUsersItem> Users { get; set; }
    }

    public class PatchV2AccessUsersListsListIdRequest
    {
    
        /// <summary>New name for the user list</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessUsersListsListIdUsersResponseListItemAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessUsersListsListIdUsersResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessUsersListsListIdUsersResponseListItemAvatarThumbs? AvatarThumbs { get; set; }
    }

    public class GetV2AccessUsersListsListIdUsersResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessUsersListsListIdUsersResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("nextOffset")]
        public double? NextOffset { get; set; }
    }

    public class PostV2AccessUsersUserIdListsResponseSuccessItem
    {
    
        [JsonPropertyName("listId")]
        public double ListId { get; set; }
    
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }

    public class PostV2AccessUsersUserIdListsResponseErrorsItem
    {
    
        [JsonPropertyName("listId")]
        public double ListId { get; set; }
    
    
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }

    public class PostV2AccessUsersUserIdListsResponse
    {
    
        [JsonPropertyName("success")]
        public List<PostV2AccessUsersUserIdListsResponseSuccessItem> Success { get; set; }
    
    
        [JsonPropertyName("errors")]
        public List<PostV2AccessUsersUserIdListsResponseErrorsItem> Errors { get; set; }
    }

    public class PostV2AccessUsersUserIdListsRequest
    {
    
        /// <summary>List IDs to add the user to</summary>
        [JsonPropertyName("listIds")]
        public List<int> ListIds { get; set; }
    }

    public enum GetV2AccessVaultMediaResponseListItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessVaultMediaResponseListItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessVaultMediaResponseListItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessVaultMediaResponseListItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessVaultMediaResponseListItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessVaultMediaResponseListItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessVaultMediaResponseListItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessVaultMediaResponseListItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessVaultMediaResponseListItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessVaultMediaResponseListItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemCounters
    {
    
        [JsonPropertyName("likesCount")]
        public double LikesCount { get; set; }
    
    
        [JsonPropertyName("tipsSumm")]
        public double TipsSumm { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItemListsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessVaultMediaResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessVaultMediaResponseListItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessVaultMediaResponseListItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessVaultMediaResponseListItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessVaultMediaResponseListItemFiles? Files { get; set; }
    
    
        [JsonPropertyName("counters")]
        public GetV2AccessVaultMediaResponseListItemCounters Counters { get; set; }
    
    
        [JsonPropertyName("hasPosts")]
        public bool? HasPosts { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<GetV2AccessVaultMediaResponseListItemListsItem> Lists { get; set; }
    }

    public class GetV2AccessVaultMediaResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessVaultMediaResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public enum GetV2AccessVaultListsResponseListItemTypeEnum
    {
        [JsonPropertyName("custom")]
        Custom,
        [JsonPropertyName("messages")]
        Messages,
        [JsonPropertyName("posts")]
        Posts,
        [JsonPropertyName("stories")]
        Stories,
        [JsonPropertyName("streams")]
        Streams,
        [JsonPropertyName("media_stickers")]
        MediaStickers
    }

    public enum GetV2AccessVaultListsResponseListItemMediasItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessVaultListsResponseListItemMediasItem
    {
    
        [JsonPropertyName("type")]
        public GetV2AccessVaultListsResponseListItemMediasItemTypeEnum? Type { get; set; }
    
    
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class GetV2AccessVaultListsResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessVaultListsResponseListItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("hasMedia")]
        public bool HasMedia { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("medias")]
        public List<GetV2AccessVaultListsResponseListItemMediasItem> Medias { get; set; }
    }

    public class GetV2AccessVaultListsResponseAllMediasItem
    {
    
        [JsonPropertyName("type")]
        public object? Type { get; set; }
    }

    public class GetV2AccessVaultListsResponseAll
    {
    
        [JsonPropertyName("videosCount")]
        public double VideosCount { get; set; }
    
    
        [JsonPropertyName("photosCount")]
        public double PhotosCount { get; set; }
    
    
        [JsonPropertyName("gifsCount")]
        public double GifsCount { get; set; }
    
    
        [JsonPropertyName("audiosCount")]
        public double AudiosCount { get; set; }
    
    
        [JsonPropertyName("medias")]
        public List<GetV2AccessVaultListsResponseAllMediasItem> Medias { get; set; }
    }

    public class GetV2AccessVaultListsResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessVaultListsResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("all")]
        public GetV2AccessVaultListsResponseAll All { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    
    
        [JsonPropertyName("canCreateVaultLists")]
        public bool CanCreateVaultLists { get; set; }
    
    
        [JsonPropertyName("order")]
        public string Order { get; set; }
    
    
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }

    public enum PostV2AccessVaultListsResponseTypeEnum
    {
        [JsonPropertyName("custom")]
        Custom,
        [JsonPropertyName("messages")]
        Messages,
        [JsonPropertyName("posts")]
        Posts,
        [JsonPropertyName("stories")]
        Stories,
        [JsonPropertyName("streams")]
        Streams,
        [JsonPropertyName("media_stickers")]
        MediaStickers
    }

    public enum PostV2AccessVaultListsResponseMediasItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PostV2AccessVaultListsResponseMediasItem
    {
    
        [JsonPropertyName("type")]
        public PostV2AccessVaultListsResponseMediasItemTypeEnum? Type { get; set; }
    
    
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class PostV2AccessVaultListsResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PostV2AccessVaultListsResponseTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("hasMedia")]
        public bool HasMedia { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("medias")]
        public List<PostV2AccessVaultListsResponseMediasItem> Medias { get; set; }
    }

    public class PostV2AccessVaultListsRequest
    {
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public enum PatchV2AccessVaultListsListIdResponseTypeEnum
    {
        [JsonPropertyName("custom")]
        Custom,
        [JsonPropertyName("messages")]
        Messages,
        [JsonPropertyName("posts")]
        Posts,
        [JsonPropertyName("stories")]
        Stories,
        [JsonPropertyName("streams")]
        Streams,
        [JsonPropertyName("media_stickers")]
        MediaStickers
    }

    public enum PatchV2AccessVaultListsListIdResponseMediasItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PatchV2AccessVaultListsListIdResponseMediasItem
    {
    
        [JsonPropertyName("type")]
        public PatchV2AccessVaultListsListIdResponseMediasItemTypeEnum? Type { get; set; }
    
    
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class PatchV2AccessVaultListsListIdResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PatchV2AccessVaultListsListIdResponseTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("hasMedia")]
        public bool HasMedia { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("medias")]
        public List<PatchV2AccessVaultListsListIdResponseMediasItem> Medias { get; set; }
    }

    public class PatchV2AccessVaultListsListIdRequest
    {
    
        /// <summary>New name for the vault list</summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        /// <summary>Remove all media from the list</summary>
        [JsonPropertyName("clearMedia")]
        public bool? ClearMedia { get; set; }
    }

    public enum GetV2AccessVaultListsListIdMediaResponseListItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public GetV2AccessVaultListsListIdMediaResponseListItemReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public GetV2AccessVaultListsListIdMediaResponseListItemReleaseFormsItemUser? User { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<GetV2AccessVaultListsListIdMediaResponseListItemFilesFullSourcesItem> Sources { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<GetV2AccessVaultListsListIdMediaResponseListItemFilesPreviewOptionsItem> Options { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemFiles
    {
    
        [JsonPropertyName("full")]
        public GetV2AccessVaultListsListIdMediaResponseListItemFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public GetV2AccessVaultListsListIdMediaResponseListItemFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public GetV2AccessVaultListsListIdMediaResponseListItemFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public GetV2AccessVaultListsListIdMediaResponseListItemFilesSquarePreview? SquarePreview { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemCounters
    {
    
        [JsonPropertyName("likesCount")]
        public double LikesCount { get; set; }
    
    
        [JsonPropertyName("tipsSumm")]
        public double TipsSumm { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItemListsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponseListItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2AccessVaultListsListIdMediaResponseListItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<GetV2AccessVaultListsListIdMediaResponseListItemReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public GetV2AccessVaultListsListIdMediaResponseListItemVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public GetV2AccessVaultListsListIdMediaResponseListItemFiles? Files { get; set; }
    
    
        [JsonPropertyName("counters")]
        public GetV2AccessVaultListsListIdMediaResponseListItemCounters Counters { get; set; }
    
    
        [JsonPropertyName("hasPosts")]
        public bool? HasPosts { get; set; }
    
    
        [JsonPropertyName("lists")]
        public List<GetV2AccessVaultListsListIdMediaResponseListItemListsItem> Lists { get; set; }
    }

    public class GetV2AccessVaultListsListIdMediaResponse
    {
    
        [JsonPropertyName("list")]
        public List<GetV2AccessVaultListsListIdMediaResponseListItem> List { get; set; }
    
    
        [JsonPropertyName("hasMore")]
        public bool HasMore { get; set; }
    }

    public enum PostV2AccessVaultListsListIdMediaResponseTypeEnum
    {
        [JsonPropertyName("custom")]
        Custom,
        [JsonPropertyName("messages")]
        Messages,
        [JsonPropertyName("posts")]
        Posts,
        [JsonPropertyName("stories")]
        Stories,
        [JsonPropertyName("streams")]
        Streams,
        [JsonPropertyName("media_stickers")]
        MediaStickers
    }

    public enum PostV2AccessVaultListsListIdMediaResponseMediasItemTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PostV2AccessVaultListsListIdMediaResponseMediasItem
    {
    
        [JsonPropertyName("type")]
        public PostV2AccessVaultListsListIdMediaResponseMediasItemTypeEnum? Type { get; set; }
    
    
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }

    public class PostV2AccessVaultListsListIdMediaResponse
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PostV2AccessVaultListsListIdMediaResponseTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("hasMedia")]
        public bool HasMedia { get; set; }
    
    
        [JsonPropertyName("canUpdate")]
        public bool CanUpdate { get; set; }
    
    
        [JsonPropertyName("canDelete")]
        public bool CanDelete { get; set; }
    
    
        [JsonPropertyName("medias")]
        public List<PostV2AccessVaultListsListIdMediaResponseMediasItem> Medias { get; set; }
    }

    public class PostV2AccessVaultListsListIdMediaRequest
    {
    
        /// <summary>Media IDs to add to the list</summary>
        [JsonPropertyName("mediaIds")]
        public List<int> MediaIds { get; set; }
    }

    public enum PostV2AccessUploadsCheckResponseMediaTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PostV2AccessUploadsCheckResponseMediaReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PostV2AccessUploadsCheckResponseMediaReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public PostV2AccessUploadsCheckResponseMediaReleaseFormsItemUser? User { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<PostV2AccessUploadsCheckResponseMediaFilesFullSourcesItem> Sources { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<PostV2AccessUploadsCheckResponseMediaFilesPreviewOptionsItem> Options { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMediaFiles
    {
    
        [JsonPropertyName("full")]
        public PostV2AccessUploadsCheckResponseMediaFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public PostV2AccessUploadsCheckResponseMediaFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public PostV2AccessUploadsCheckResponseMediaFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public PostV2AccessUploadsCheckResponseMediaFilesSquarePreview? SquarePreview { get; set; }
    }

    public class PostV2AccessUploadsCheckResponseMedia
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PostV2AccessUploadsCheckResponseMediaTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<PostV2AccessUploadsCheckResponseMediaReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public PostV2AccessUploadsCheckResponseMediaVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public PostV2AccessUploadsCheckResponseMediaFiles? Files { get; set; }
    }

    public class PostV2AccessUploadsCheckResponse
    {
    
        [JsonPropertyName("exists")]
        public bool Exists { get; set; }
    
    
        [JsonPropertyName("media")]
        public PostV2AccessUploadsCheckResponseMedia? Media { get; set; }
    }

    public class PostV2AccessUploadsCheckRequest
    {
    
        /// <summary>ETag from the upload response</summary>
        [JsonPropertyName("etag")]
        public string Etag { get; set; }
    
    
        /// <summary>Uploaded file size in bytes</summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
    }

    public class PostV2AccessUploadsInitResponse
    {
    
        [JsonPropertyName("mediaUploadId")]
        public string MediaUploadId { get; set; }
    }

    public enum PostV2AccessUploadsInitRequestVaultUploadModeEnum
    {
        [JsonPropertyName("message")]
        Message
    }

    public class PostV2AccessUploadsInitRequestVaultUpload
    {
    
        /// <summary>Upload mode</summary>
        [JsonPropertyName("mode")]
        public PostV2AccessUploadsInitRequestVaultUploadModeEnum? Mode { get; set; }
    
    
        /// <summary>Target user ID for the upload</summary>
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
    }

    public class PostV2AccessUploadsInitRequest
    {
    
        /// <summary>Name of the file to upload</summary>
        [JsonPropertyName("filename")]
        public string Filename { get; set; }
    
    
        /// <summary>File size in bytes</summary>
        [JsonPropertyName("size")]
        public int Size { get; set; }
    
    
        /// <summary>MIME type of the file (e.g., image/jpeg, video/mp4)</summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    
    
        /// <summary>Options for vault upload (if uploading to vault)</summary>
        [JsonPropertyName("vaultUpload")]
        public PostV2AccessUploadsInitRequestVaultUpload? VaultUpload { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdPartsPartNumberResponse
    {
    
        [JsonPropertyName("mediaUploadId")]
        public string MediaUploadId { get; set; }
    
    
        [JsonPropertyName("partNumber")]
        public int PartNumber { get; set; }
    
    
        [JsonPropertyName("etag")]
        public string Etag { get; set; }
    }

    public enum PutV2AccessUploadsMediaUploadIdResponseMediaTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaReleaseFormsItemUser? User { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<PutV2AccessUploadsMediaUploadIdResponseMediaFilesFullSourcesItem> Sources { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<PutV2AccessUploadsMediaUploadIdResponseMediaFilesPreviewOptionsItem> Options { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMediaFiles
    {
    
        [JsonPropertyName("full")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaFilesSquarePreview? SquarePreview { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponseMedia
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<PutV2AccessUploadsMediaUploadIdResponseMediaReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public PutV2AccessUploadsMediaUploadIdResponseMediaFiles? Files { get; set; }
    }

    public class PutV2AccessUploadsMediaUploadIdResponse
    {
    
        [JsonPropertyName("mediaUploadId")]
        public string MediaUploadId { get; set; }
    
    
        [JsonPropertyName("media")]
        public PutV2AccessUploadsMediaUploadIdResponseMedia? Media { get; set; }
    }

    public enum PostV2AccessUploadsCompleteResponseMediaTypeEnum
    {
        [JsonPropertyName("photo")]
        Photo,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("gif")]
        Gif,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PostV2AccessUploadsCompleteResponseMediaReleaseFormsItemUserAvatarThumbs
    {
    
        [JsonPropertyName("c50")]
        public string C50 { get; set; }
    
    
        [JsonPropertyName("c144")]
        public string C144 { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaReleaseFormsItemUser
    {
    
        [JsonPropertyName("view")]
        public string View { get; set; }
    
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("username")]
        public string Username { get; set; }
    
    
        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }
    
    
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    
    
        [JsonPropertyName("avatarThumbs")]
        public PostV2AccessUploadsCompleteResponseMediaReleaseFormsItemUserAvatarThumbs AvatarThumbs { get; set; }
    
    
        [JsonPropertyName("ivStatus")]
        public string IvStatus { get; set; }
    
    
        [JsonPropertyName("isFromGuest")]
        public bool IsFromGuest { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaReleaseFormsItem
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
    
        [JsonPropertyName("partnerSource")]
        public string PartnerSource { get; set; }
    
    
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    
        [JsonPropertyName("user")]
        public PostV2AccessUploadsCompleteResponseMediaReleaseFormsItemUser? User { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaVideoSources
    {
    
        [JsonPropertyName("240")]
        public string? _240 { get; set; }
    
    
        [JsonPropertyName("720")]
        public string? _720 { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaFilesFullSourcesItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaFilesFull
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("sources")]
        public List<PostV2AccessUploadsCompleteResponseMediaFilesFullSourcesItem> Sources { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaFilesThumb
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaFilesPreviewOptionsItem
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("type")]
        public string? Type { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaFilesPreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
    
        [JsonPropertyName("options")]
        public List<PostV2AccessUploadsCompleteResponseMediaFilesPreviewOptionsItem> Options { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaFilesSquarePreview
    {
    
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
    
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
    
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMediaFiles
    {
    
        [JsonPropertyName("full")]
        public PostV2AccessUploadsCompleteResponseMediaFilesFull Full { get; set; }
    
    
        [JsonPropertyName("thumb")]
        public PostV2AccessUploadsCompleteResponseMediaFilesThumb? Thumb { get; set; }
    
    
        [JsonPropertyName("preview")]
        public PostV2AccessUploadsCompleteResponseMediaFilesPreview? Preview { get; set; }
    
    
        [JsonPropertyName("squarePreview")]
        public PostV2AccessUploadsCompleteResponseMediaFilesSquarePreview? SquarePreview { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponseMedia
    {
    
        [JsonPropertyName("id")]
        public double Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PostV2AccessUploadsCompleteResponseMediaTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("convertedToVideo")]
        public bool ConvertedToVideo { get; set; }
    
    
        [JsonPropertyName("canView")]
        public bool CanView { get; set; }
    
    
        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }
    
    
        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }
    
    
        [JsonPropertyName("isReady")]
        public bool IsReady { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("releaseForms")]
        public List<PostV2AccessUploadsCompleteResponseMediaReleaseFormsItem> ReleaseForms { get; set; }
    
    
        [JsonPropertyName("hasCustomPreview")]
        public bool? HasCustomPreview { get; set; }
    
    
        [JsonPropertyName("videoSources")]
        public PostV2AccessUploadsCompleteResponseMediaVideoSources? VideoSources { get; set; }
    
    
        [JsonPropertyName("files")]
        public PostV2AccessUploadsCompleteResponseMediaFiles? Files { get; set; }
    }

    public class PostV2AccessUploadsCompleteResponse
    {
    
        [JsonPropertyName("mediaUploadId")]
        public string MediaUploadId { get; set; }
    
    
        [JsonPropertyName("media")]
        public PostV2AccessUploadsCompleteResponseMedia? Media { get; set; }
    }

    public class PostV2AccessUploadsCompleteRequest
    {
    
        /// <summary>Upload session ID to complete</summary>
        [JsonPropertyName("mediaUploadId")]
        public string MediaUploadId { get; set; }
    }

    public class PostV2LinkInitResponse
    {
    
        /// <summary>URL to redirect the user to</summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
    
        /// <summary>ISO timestamp when the session expires</summary>
        [JsonPropertyName("expiresAt")]
        public string ExpiresAt { get; set; }
    }

    public class PostV2LinkInitRequestGeolocation
    {
    
        /// <summary>Geolocation country code override (e.g. US).</summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    
    
        /// <summary>Geolocation state/region override (e.g. CA for California).</summary>
        [JsonPropertyName("state")]
        public string? State { get; set; }
    
    
        /// <summary>Geolocation city override (e.g. San Francisco).</summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }
    }

    public class PostV2LinkInitRequest
    {
    
        /// <summary>URL to redirect to after completion. If omitted, uses first allowed redirect URI.</summary>
        [JsonPropertyName("redirectUrl")]
        public Uri? RedirectUrl { get; set; }
    
    
        /// <summary>Your internal reference ID for webhook correlation.</summary>
        [JsonPropertyName("clientReferenceId")]
        public string? ClientReferenceId { get; set; }
    
    
        /// <summary>Existing connection ID to reconnect.</summary>
        [JsonPropertyName("connectionId")]
        public string? ConnectionId { get; set; }
    
    
        [JsonPropertyName("geolocation")]
        public PostV2LinkInitRequestGeolocation? Geolocation { get; set; }
    }

    public enum GetV2LinkClientSecretResponseStatusEnum
    {
        [JsonPropertyName("initialized")]
        Initialized,
        [JsonPropertyName("pending")]
        Pending,
        [JsonPropertyName("awaiting_2fa")]
        Awaiting2fa,
        [JsonPropertyName("denied")]
        Denied,
        [JsonPropertyName("completed")]
        Completed,
        [JsonPropertyName("invalid_credentials")]
        InvalidCredentials,
        [JsonPropertyName("failed")]
        Failed,
        [JsonPropertyName("not_found")]
        NotFound
    }

    public class GetV2LinkClientSecretResponse
    {
    
        [JsonPropertyName("status")]
        public GetV2LinkClientSecretResponseStatusEnum Status { get; set; }
    
    
        [JsonPropertyName("data")]
        public object? Data { get; set; }
    }

    public class GetV2DynamicRulesResponseRules
    {
    
        [JsonPropertyName("static_param")]
        public string StaticParam { get; set; }
    
    
        [JsonPropertyName("format")]
        public string Format { get; set; }
    
    
        [JsonPropertyName("start")]
        public string Start { get; set; }
    
    
        [JsonPropertyName("end")]
        public string End { get; set; }
    
    
        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }
    
    
        [JsonPropertyName("suffix")]
        public string Suffix { get; set; }
    
    
        [JsonPropertyName("checksum_constant")]
        public double ChecksumConstant { get; set; }
    
    
        [JsonPropertyName("checksum_indexes")]
        public List<double> ChecksumIndexes { get; set; }
    
    
        [JsonPropertyName("app_token")]
        public string AppToken { get; set; }
    
    
        [JsonPropertyName("revision")]
        public string Revision { get; set; }
    }

    public class GetV2DynamicRulesResponse
    {
    
        [JsonPropertyName("rules")]
        public GetV2DynamicRulesResponseRules Rules { get; set; }
    
    
        [JsonPropertyName("is_current")]
        public bool IsCurrent { get; set; }
    
    
        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }
    
    
        [JsonPropertyName("is_early_access")]
        public bool IsEarlyAccess { get; set; }
    }

    public class PostV2DynamicRulesSignResponseSigned
    {
    
        [JsonPropertyName("sign")]
        public string Sign { get; set; }
    
    
        [JsonPropertyName("time")]
        public string Time { get; set; }
    
    
        [JsonPropertyName("user-id")]
        public string? UserId { get; set; }
    
    
        [JsonPropertyName("app-token")]
        public string AppToken { get; set; }
    }

    public class PostV2DynamicRulesSignResponse
    {
    
        [JsonPropertyName("signed")]
        public PostV2DynamicRulesSignResponseSigned Signed { get; set; }
    
    
        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }
    
    
        [JsonPropertyName("is_early_access")]
        public bool IsEarlyAccess { get; set; }
    }

    public class PostV2DynamicRulesSignRequest
    {
    
        [JsonPropertyName("endpoint")]
        public string Endpoint { get; set; }
    
    
        [JsonPropertyName("time")]
        public object? Time { get; set; }
    
    
        [JsonPropertyName("user-id")]
        public object? UserId { get; set; }
    }

    public class GetV2DynamicRulesStatusResponse
    {
    
        [JsonPropertyName("revision")]
        public string Revision { get; set; }
    
    
        [JsonPropertyName("early_access_revision")]
        public string EarlyAccessRevision { get; set; }
    
    
        [JsonPropertyName("public_revision")]
        public string PublicRevision { get; set; }
    
    
        [JsonPropertyName("is_current")]
        public bool IsCurrent { get; set; }
    
    
        [JsonPropertyName("is_early_access")]
        public bool IsEarlyAccess { get; set; }
    
    
        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }
    
    
        /// <summary>Whether the user has access to the latest rules, based on apikey header</summary>
        [JsonPropertyName("access_granted")]
        public bool AccessGranted { get; set; }
    }

    public class PostV2VaultPlusStoreListListIdResponse
    {
    
        [JsonPropertyName("queued")]
        public bool Queued { get; set; }
    
    
        [JsonPropertyName("listId")]
        public string ListId { get; set; }
    
    
        [JsonPropertyName("estimatedItems")]
        public double? EstimatedItems { get; set; }
    }

    public class GetV2VaultPlusStoreStatusResponse
    {
    
        [JsonPropertyName("connectionId")]
        public string ConnectionId { get; set; }
    
    
        [JsonPropertyName("totalMedia")]
        public double TotalMedia { get; set; }
    
    
        [JsonPropertyName("storedCount")]
        public double StoredCount { get; set; }
    
    
        [JsonPropertyName("pendingCount")]
        public double PendingCount { get; set; }
    
    
        [JsonPropertyName("totalSizeBytes")]
        public double TotalSizeBytes { get; set; }
    }

    public class GetV2VaultPlusStoreStatsResponse
    {
    
        [JsonPropertyName("totalConnections")]
        public double TotalConnections { get; set; }
    
    
        [JsonPropertyName("connectionsWithVaultPlus")]
        public double ConnectionsWithVaultPlus { get; set; }
    
    
        [JsonPropertyName("totalStorageBytes")]
        public double TotalStorageBytes { get; set; }
    
    
        [JsonPropertyName("totalMediaCount")]
        public double TotalMediaCount { get; set; }
    }

    public enum GetV2VaultPlusMediaIdResponseTypeEnum
    {
        [JsonPropertyName("image")]
        Image,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2VaultPlusMediaIdResponse
    {
    
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2VaultPlusMediaIdResponseTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("media")]
        public Dictionary<string, object> Media { get; set; }
    }

    public class DeleteV2VaultPlusMediaIdResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    
    
        [JsonPropertyName("mediaId")]
        public string MediaId { get; set; }
    
    
        [JsonPropertyName("freedBytes")]
        public double FreedBytes { get; set; }
    }

    public enum PostV2VaultPlusBatchResponseItemsItemTypeEnum
    {
        [JsonPropertyName("image")]
        Image,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("audio")]
        Audio
    }

    public class PostV2VaultPlusBatchResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public PostV2VaultPlusBatchResponseItemsItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("media")]
        public Dictionary<string, object> Media { get; set; }
    }

    public class PostV2VaultPlusBatchResponse
    {
    
        [JsonPropertyName("items")]
        public List<PostV2VaultPlusBatchResponseItemsItem> Items { get; set; }
    }

    public class PostV2VaultPlusBatchRequest
    {
    
        [JsonPropertyName("mediaIds")]
        public List<string> MediaIds { get; set; }
    }

    public enum GetV2VaultPlusListResponseItemsItemTypeEnum
    {
        [JsonPropertyName("image")]
        Image,
        [JsonPropertyName("video")]
        Video,
        [JsonPropertyName("audio")]
        Audio
    }

    public class GetV2VaultPlusListResponseItemsItem
    {
    
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
    
        [JsonPropertyName("type")]
        public GetV2VaultPlusListResponseItemsItemTypeEnum Type { get; set; }
    
    
        [JsonPropertyName("duration")]
        public double? Duration { get; set; }
    
    
        [JsonPropertyName("media")]
        public Dictionary<string, object> Media { get; set; }
    }

    public class GetV2VaultPlusListResponse
    {
    
        [JsonPropertyName("items")]
        public List<GetV2VaultPlusListResponseItemsItem> Items { get; set; }
    
    
        [JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }
    }

    public class DeleteV2VaultPlusPurgeResponse
    {
    
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    
    
        [JsonPropertyName("purgedCount")]
        public double PurgedCount { get; set; }
    
    
        [JsonPropertyName("freedBytes")]
        public double FreedBytes { get; set; }
    }

}
