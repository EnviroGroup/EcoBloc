using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    //dont forgot to add an alert to say thank you for reporting

    public class ReportPageViewModel : BaseViewModel
    {
        private INavigation _navigation;


        private string me;


        public string Me 
        { 
            get; 
            set; 
        }



        public ReportPageViewModel()
        {

        }

        public ReportPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        //public async void AddButton()
        // {
        //    await _navigation.PushAsync(new NewOrder()); ;
        //}


        //public async void SaveButton()
        //{
        //   await _navigation.PopAsync();
        //
        // }

    }
}
