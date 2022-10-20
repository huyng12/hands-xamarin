using System;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

using Hands.ViewModels.Base;
using Hands.Models.User;

namespace Hands.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        public AccountViewModel()
        {
            Title = "Account";
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string email;
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public override async Task InitializeAsync()
        {
            UserInfo user = await UserService.GetCurrentUser();
            Name = $"Hello, {user.FirstName} {user.LastName}";
            Email = user.Email;
        }
    }
}
