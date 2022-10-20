using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hands.ViewModels;

namespace Hands.Views
{
    public partial class AccountView : BaseContentPage
    {
        public AccountView()
        {
            BindingContext = new AccountViewModel();

            InitializeComponent();
        }
    }
}
