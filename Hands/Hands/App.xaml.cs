using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hands.Views;
using Hands.Services.User;

namespace Hands
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IUserService, MockUserService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

