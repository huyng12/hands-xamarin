using System;
using System.Collections.Generic;

using Xamarin.Forms;

using Hands.Views;

namespace Hands
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            AppShell.InitializeRouting();
            InitializeComponent();
        }

        private static void InitializeRouting()
        {
            Routing.RegisterRoute("CampaignDetail", typeof(CampaignDetailView));
        }
    }
}
