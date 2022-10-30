using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Hands.Models.Campaign
{
    public class CampaignOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public bool IsVerified { get; set; }
    }

    public class CampaignCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CampaignItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public CampaignOwner Owner { get; set; }
        public CampaignCategory Category { get; set; }
        public Int64 TargetAmount { get; set; }
        public Int64 RaisedAmount { get; set; }
        public string ThumbnailUrl { get; set; }
        public DateTime EndAt { get; set; }
    }
}
