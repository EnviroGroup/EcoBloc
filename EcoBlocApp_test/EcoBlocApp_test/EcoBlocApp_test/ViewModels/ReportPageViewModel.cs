using EcoBlocApp_test.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    //dont forgot to add an alert to say thank you for reporting

    public class ReportPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public ICommand UploadCommand { get; private set; }



        public ReportPageViewModel()
        {

        }

        public ReportPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
            UploadCommand = new Command(() => UploadPicture());

        }

        public async void UploadPicture()
        {
            await _navigation.PushAsync(new RegisterPage());
        }

    }
}
