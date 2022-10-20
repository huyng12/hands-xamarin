using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hands.Views;
using Hands.Services.User;
using Hands.Services.Campaign;

namespace Hands
{
    public partial class App : Application
    {
        public App()
        {
            #region Register services
            DependencyService.Register<IUserService, MockUserService>();
            DependencyService.Register<ICampaignService, MockCampaignService>();
            #endregion

            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
