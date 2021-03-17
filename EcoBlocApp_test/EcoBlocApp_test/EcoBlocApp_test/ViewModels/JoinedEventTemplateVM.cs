using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Web;
using EcoBlocApp_test.Models;
using EcoBlocApp_test.Views;
using EcoBlocApp_test.Services;


namespace EcoBlocApp_test.ViewModels
{
    class JoinedEventTemplateVM : BaseViewModel
    {
  
        private INavigation _navigation;
       

        Event selectedEvent;

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

        private DateTime _creationDate;

        public DateTime CreationDate
        {
            get
            {

                return _creationDate;
            }
            set
            {
                _creationDate = value;
                NotifyPropertyChanged("CreationDate");
            }
        }

        private string _reason;

        public string Reason
        {
            get
            {

                return _reason;
            }
            set
            {
                _reason = value;
                NotifyPropertyChanged("Reason");
            }
        }

        private string _dumpsiteName;

        public string DumpsiteName
        {
            get
            {

                return _dumpsiteName;
            }
            set
            {
                _dumpsiteName = value;
                NotifyPropertyChanged("DumpsiteName");
            }
        }

        private string _dumpsiteImage;

        public string DumpsiteImage
        {
            get
            {

                return _dumpsiteImage;
            }
            set
            {
                _dumpsiteImage = value;
                NotifyPropertyChanged("DumpsiteImage");
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

        private int _numberOfParticipants;

        public int NumberOfParticipants
        {
            get
            {

                return _numberOfParticipants;
            }
            set
            {
                _numberOfParticipants = value;
                NotifyPropertyChanged("NumberOfParticipants");
            }
        }




        public JoinedEventTemplateVM()
        {
        }

        public JoinedEventTemplateVM(INavigation navigation, Event @event)
        {
            _navigation = navigation;
            selectedEvent = new Event();

            selectedEvent = @event;

          
        }
    }

}
    
    /*Public class Itinerary : JoinedEventTemplateVM
}
public static List<SelectListItem> Itinerary = new List<SelectListItem>()
    {
        new SelectListItem() {Text="Spade"},
        new SelectListItem() { Text="Broom"},
        new SelectListItem() { Text="Plastic Bag},
        new SelectListItem() { Text="Gloves"},
        new SelectListItem() { Text="Boots"},
                               new SelectListItem() { Text="Wheelbarrow"},
                               new SelectListItem() { Text="California"},
                               new SelectListItem() { Text="Bakkie"},
     
    }
}*/

