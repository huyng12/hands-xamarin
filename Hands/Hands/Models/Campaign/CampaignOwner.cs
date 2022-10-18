using System;

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
}
