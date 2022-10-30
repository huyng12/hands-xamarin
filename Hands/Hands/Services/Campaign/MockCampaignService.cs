using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Hands.Models.Campaign;

namespace Hands.Services.Campaign
{
    public class MockCampaignService : ICampaignService
    {
        public async Task<Campaigns> GetCampaignsAsync()
        {
            await Task.Delay(100);
            return MockResponse.campaigns;
        }

        public async Task<CampaignItem> GetCampaignByIdAsync(int campaignId)
        {
            await Task.Delay(100);
            return MockResponse.campaigns.Items.Find(item => item.Id == campaignId);
        }
    }
}
