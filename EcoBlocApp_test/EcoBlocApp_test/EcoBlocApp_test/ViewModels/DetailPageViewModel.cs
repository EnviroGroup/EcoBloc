using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public DetailPageViewModel() 
        { 
        }

        public DetailPageViewModel(INavigation navigation)
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
