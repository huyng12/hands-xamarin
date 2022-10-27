using System;
using System.Collections.Generic;

using Xamarin.Forms;

using Hands.ViewModels;

namespace Hands.Views
{
    public partial class CampaignDetailView : BaseContentPage
    {
        public CampaignDetailView()
        {
            BindingContext = new CampaignDetailViewModel();

            InitializeComponent();
        }
    }
}
