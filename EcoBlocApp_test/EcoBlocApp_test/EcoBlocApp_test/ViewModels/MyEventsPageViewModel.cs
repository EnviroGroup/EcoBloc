using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class MyEventsPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public MyEventsPageViewModel()
        {

        }

        public MyEventsPageViewModel(INavigation navigation)
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
