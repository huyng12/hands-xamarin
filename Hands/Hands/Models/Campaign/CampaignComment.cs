using System;

namespace Hands.Models.Campaign
{
    public class CampaignCommentOwner : CampaignOwner { }

    public class CampaignComment
    {
        public string Id { get; set; }

        public CampaignCommentOwner owner { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
