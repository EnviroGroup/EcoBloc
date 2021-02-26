using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Models;


namespace EcoBlocApp_test.ViewModels
{
    public class DetailPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        List<SiteInformation> _SiteInformation;
        public DetailPageViewModel() 
        { 
        }

        public DetailPageViewModel(INavigation navigation, List<SiteInformation> siteInformation)
        {
            _SiteInformation = new List<SiteInformation>();
            _navigation = navigation;
            _SiteInformation = siteInformation;
           
            
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
