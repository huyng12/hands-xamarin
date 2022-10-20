﻿using System;
using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;

using Hands.ViewModels.Base;

namespace Hands.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand OpenWebCommand { get; }

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }
    }
}
