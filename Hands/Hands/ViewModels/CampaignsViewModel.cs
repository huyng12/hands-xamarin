using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

using CommunityToolkit.Mvvm.Input;

using Hands.ViewModels.Base;
using Hands.Models.Campaign;
using System.Linq;
using System.Xml.Linq;

namespace Hands.ViewModels
{
    public class CampaignsViewModel : BaseViewModel
    {
        private readonly ObservableCollectionEx<CampaignItem> campaigns = new ObservableCollectionEx<CampaignItem>();
        public ObservableCollection<CampaignItem> Campaigns => campaigns;

        private CampaignItem selectedCampaign;
        public CampaignItem SelectedCampaign
        {
            get => selectedCampaign;
            set => SetProperty(ref selectedCampaign, value);
        }

        public CampaignsViewModel()
        {
            Title = "Campaigns";
            campaigns = new ObservableCollectionEx<CampaignItem>();
        }

        public override async Task InitializeAsync()
        {
            await IsBusyFor(async () =>
            {
                var data = await CampaignService.GetCampaignsAsync();
                campaigns.ReloadData(data.Items);
            });
        }

        public async Task OnCampaignItemTapped(CampaignItem campaign)
        {
            if (campaign is null) { return; }
            await Shell.Current.GoToAsync($"CampaignDetail?Id={campaign.Id}");
        }
    }
}
