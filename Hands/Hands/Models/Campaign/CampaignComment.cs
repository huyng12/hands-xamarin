using System;

using Newtonsoft.Json;

namespace Hands.Models.Campaign
{
    public class CampaignCommentOwner : CampaignOwner { }

    public class CampaignComment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("owner")]
        public CampaignCommentOwner owner { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
