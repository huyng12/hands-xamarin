using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Hands.Models.Campaign;

namespace Hands.Services.Campaign
{
    public class MockCampaignService : ICampaignService
    {
        private readonly Campaigns campaigns = new Campaigns
        {
            PageIndex = 0,
            TotalPages = 12,
            Items = new List<CampaignItem> {
                new CampaignItem {
                    Id = "fcbb29b0-5029-11ed-bdc3-0242ac120002",
                    Category = new CampaignCategory
                    {
                        Id = "ebe7f760-19ed-4a1b-8b8e-455a2bdffa2f",
                        Name = "Health",
                    },
                    Title = "Help Them Smile Again",
                    Description = "In the near future, many children will be " +
                        "the result of a catastrophic outbreak that is sweeping " +
                        "across the world. They are in a severe & weak condition, " +
                        "it is possible that they also feel confused with their lives.",
                    ThumbnailUrl = "",
                    TargetAmount = 2000000000,
                    RaisedAmount = 1257410000,
                    Owner = new CampaignOwner
                    {
                        Id = "91eda8ec-0674-4e2b-b979-97c656dd4184",
                        Name = "Sobat Amal Jariyah",
                        AvatarUrl = "",
                        IsVerified = true,
                    },
                    Comments = Enumerable.Empty<CampaignComment>(),
                    ExpiredAt = DateTime.Today.AddDays(10),
                    CreatedAt = DateTime.Today.AddDays(-20)
                },
            },
        };

        public async Task<Campaigns> GetCampaignsAsync()
        {
            await Task.Delay(10);
            return campaigns;
        }

        public async Task<CampaignItem> GetCampaignByIdAsync()
        {
            await Task.Delay(10);
            return campaigns.Items.ElementAt(0);
        }
    }
}
