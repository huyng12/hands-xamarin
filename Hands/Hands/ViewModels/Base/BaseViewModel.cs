using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;

using Hands.Services.User;
using Hands.Services.Campaign;

namespace Hands.ViewModels.Base
{
    public class BaseViewModel : IBaseViewModel, INotifyPropertyChanged, IDisposable
    {
        #region Get services
        public IUserService UserService => DependencyService.Get<IUserService>();
        public ICampaignService CampaignService => DependencyService.Get<ICampaignService>();
        #endregion

        private readonly SemaphoreSlim isBusyLock = new SemaphoreSlim(1, 1);
        private bool disposedValue;

        #region State declarations

        bool isInitialized = false;
        public bool IsInitialized
        {
            get { return isInitialized; }
            set { SetProperty(ref isInitialized, value); }
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            private set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        #endregion

        public virtual void ApplyQueryAttributes(IDictionary<string, string> query) { }

        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public async Task IsBusyFor(Func<Task> unitOfWork)
        {
            await isBusyLock.WaitAsync();

            try
            {
                IsBusy = true;
                await unitOfWork();
            }
            finally
            {
                IsBusy = false;
                isBusyLock.Release();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    isBusyLock?.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
