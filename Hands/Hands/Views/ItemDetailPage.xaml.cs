using System.ComponentModel;
using Xamarin.Forms;
using Hands.ViewModels;

namespace Hands.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
