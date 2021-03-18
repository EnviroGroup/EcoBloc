using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
    public class DumpsiteDetailPageVM : BaseViewModel
    {

        private INavigation _navigation;


        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set
            {
                _comment = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private string _waste;
        public string Waste
        {
            get { return _waste; }
            set
            {
                _waste = value;
                NotifyPropertyChanged("Waste");
            }
        }

        private string _streetName;
        public string StreetName
        {
            get { return _streetName; }
            set
            {
                _streetName = value;
                NotifyPropertyChanged("");
            }
        }

        private string _photo;
        public string Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                NotifyPropertyChanged("Photo");
            }
        }

        public DumpsiteDetailPageVM()
        {

        }


        public DumpsiteDetailPageVM(INavigation navigation, OpenDumpsite openDumpsite)
        {
            _navigation = navigation;

            Photo = openDumpsite.ImageUrl;
            Waste = openDumpsite.WasteTypes;
            Comment = openDumpsite.Comment;
            StreetName = openDumpsite.StreetName;



        }

    }
}
