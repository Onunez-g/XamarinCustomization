using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinCustomization.Services;

namespace XamarinCustomization.ViewModels
{
    class MenuPageViewModel
    {
        public ICommand GetOrientationCommand { get; set; }
        public MenuPageViewModel()
        {
            GetOrientationCommand = new Command(async () =>
            {
                var deviceOrientation= DependencyService.Get<IDeviceOrientationService>().GetOrientation();
                await App.Current.MainPage.DisplayAlert("Orientation", deviceOrientation.ToString(), "Ok");
            });
        }
    }
}
