using System;
using System.Collections.Generic;

using Xamarin.Forms;

using Hands.ViewModels;

namespace Hands.Views
{
    public partial class CampaignsView : BaseContentPage
    {
        public CampaignsView()
        {
            BindingContext = new CampaignsViewModel();

            InitializeComponent();
        }
    }
}
