using System;
using System.Threading.Tasks;

using Xamarin.Forms;

using Hands.ViewModels.Base;
using Hands.Services.Campaign;
using Hands.Models.Campaign;

namespace Hands.ViewModels
{
    [QueryProperty(nameof(CampaignId), "Id")]
    public class CampaignDetailViewModel : BaseViewModel
    {
        public int CampaignId { get; set; }

        private CampaignItem campaign;
        public CampaignItem Campaign
        {
            get => campaign;
            set => SetProperty(ref campaign, value);
        }

        public CampaignDetailViewModel()
        {
            Title = "Campaign Detail";
        }

        public override async Task InitializeAsync()
        {
            await IsBusyFor(async () =>
            {
                Campaign = await CampaignService.GetCampaignByIdAsync(CampaignId);
            });
        }
    }
}
