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

        private string _image;
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                NotifyPropertyChanged("Image");
            }
        }

        private string _address;
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                NotifyPropertyChanged("Address");
            }
        }

        private string _website;
        public string Website
        {
            get
            {
                return _website;
            }
            set
            {
                _website = value;
                NotifyPropertyChanged("Website");
            }
        }

        private int _phonenumber;
        public int PhoneNumber
        {
            get
            {
                return _phonenumber;
            }
            set
            {
                _phonenumber = value;
                NotifyPropertyChanged("PhoneNumber");
            }
        }

        private string _about;
        public string About
        {
            get
            {
                return _about;
            }
            set
            {
                _about = value;
                NotifyPropertyChanged("About");
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
            Image = _SiteInformation.ImageUrl;
            Address = _SiteInformation.Address;
            PhoneNumber = _SiteInformation.PhoneNumber;
            Website = _SiteInformation.WebsiteLink ;
            About = _SiteInformation.About;                
            
        }

    }
}
