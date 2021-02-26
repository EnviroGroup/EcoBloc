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

        SiteInformation _SiteInformation;

        private string _name;
        public string Name 
        {
            get
            {              
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }





        public DetailPageViewModel() 
        { 
        }

        public DetailPageViewModel(INavigation navigation, SiteInformation siteInformation)
        {

            
            _SiteInformation = new SiteInformation();
            _navigation = navigation;
            _SiteInformation = siteInformation;

            Name = _SiteInformation.Name;
                
            
        }

    }
}
