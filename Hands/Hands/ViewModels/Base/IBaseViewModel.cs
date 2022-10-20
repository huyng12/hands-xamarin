using System;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hands.ViewModels.Base
{
    public interface IBaseViewModel : IQueryAttributable
    {
        bool IsBusy { get; }

        bool IsInitialized { get; set; }

        string Title { get; set; }

        Task InitializeAsync();
    }
}
