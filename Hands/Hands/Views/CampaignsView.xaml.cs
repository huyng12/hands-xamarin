using System;
using System.Collections.Generic;

using Xamarin.Forms;

using Hands.ViewModels;
using Hands.Models.Campaign;
using System.Collections.ObjectModel;
using System.Linq;

namespace Hands.Views
{
    public partial class CampaignsView : BaseContentPage
    {
        private readonly CampaignsViewModel vm;

        public CampaignsView()
        {
            BindingContext = vm = new CampaignsViewModel();

            InitializeComponent();
        }

        public async void OnCampaignItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = e.Item as CampaignItem;
            await vm.OnCampaignItemTapped(item);
        }
    }
}
