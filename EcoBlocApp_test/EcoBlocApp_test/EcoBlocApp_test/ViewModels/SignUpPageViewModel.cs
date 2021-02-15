using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class SignUpPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public SignUpPageViewModel()
        {

        }

        public SignUpPageViewModel(INavigation navigation)
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
