using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Hands.Models.Campaign
{
    public class CampaignOwner
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }
    }

    public class CampaignCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CampaignItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("category")]
        public CampaignCategory Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("target_amount")]
        public Int64 TargetAmount { get; set; }

        [JsonProperty("raised_amount")]
        public Int64 RaisedAmount { get; set; }

        [JsonProperty("owner")]
        public CampaignOwner Owner { get; set; }

        [JsonProperty("comments")]
        public IEnumerable<CampaignComment> Comments { get; set; }

        [JsonProperty("expired_at")]
        public DateTime ExpiredAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
