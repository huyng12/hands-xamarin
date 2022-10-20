using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Hands.Models.Campaign;

namespace Hands.Services.Campaign
{
    public interface ICampaignService
    {
        Task<Campaigns> GetCampaignsAsync();
        Task<CampaignItem> GetCampaignByIdAsync();
    }
}
