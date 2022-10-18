using System;

using Newtonsoft.Json;

namespace Hands.Models.Campaign
{
    public class CampaignComment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("from_avatar_url")]
        public string FromAvatarUrl { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
