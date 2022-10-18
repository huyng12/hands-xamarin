using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Hands.Models.Campaign
{
    public class Campaigns
    {
        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public List<CampaignItem> Data;
    }
}
