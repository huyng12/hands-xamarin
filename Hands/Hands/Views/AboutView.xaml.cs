using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hands.ViewModels;

namespace Hands.Views
{
    public partial class AboutView : BaseContentPage
    {
        public AboutView()
        {
            BindingContext = new AboutViewModel();

            InitializeComponent();
        }
    }
}
