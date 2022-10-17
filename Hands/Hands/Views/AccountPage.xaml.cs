using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hands.Models.User;
using Hands.ViewModels;

namespace Hands.Views
{
    public partial class AccountPage : ContentPage
    {
        AccountViewModel _vm;

        public AccountPage()
        {
            InitializeComponent();

            BindingContext = _vm = new AccountViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _vm.OnAppearing();
        }
    }
}
