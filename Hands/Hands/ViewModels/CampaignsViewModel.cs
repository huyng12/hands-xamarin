using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Hands.ViewModels.Base;
using Hands.Models.Campaign;

namespace Hands.ViewModels
{
    public class CampaignsViewModel : BaseViewModel
    {
        private readonly ObservableCollectionEx<CampaignItem> campaigns;
        public IList<CampaignItem> Campaigns => campaigns;

        public CampaignsViewModel()
        {
            Title = "Campaigns";
            campaigns = new ObservableCollectionEx<CampaignItem>();
        }

        public override async Task InitializeAsync()
        {
            Console.WriteLine("Hmm");
            await IsBusyFor(async () =>
            {
                Console.WriteLine("Hello");
                Campaigns data = await CampaignService.GetCampaignsAsync();
                campaigns.ReloadData(data.Items);
                Console.WriteLine(data.Items);
            });
        }
    }
}
