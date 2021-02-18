using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Models;
using System.Collections.ObjectModel;

namespace EcoBlocApp_test.ViewModels
{
    public class EventJoinedViewModel : BaseViewModel
    {
        private INavigation _navigation;


        private ObservableCollection<Event> _events;

        public ObservableCollection<Event> Events 
        {
            get
            {
                return _events;
            }
            set
            {
                _events = value;
                NotifyPropertyChanged("Events");
            }
        }

        private Event _selectedEvent;
        public Event SelectedEvent
        {
            get { return _selectedEvent; }
            set
            {
                _selectedEvent = value;
                NotifyPropertyChanged("SelectedEvent");
            }
        }

        public EventJoinedViewModel() 
        {
        }

        public EventJoinedViewModel(INavigation navigation)
        {
            _navigation = navigation;


            var temp1 = new Event();
            temp1.Name = "Dummy event";
            

            Event[] temps = new Event[2];

            temps[0] = temp1;
            temps[1] = temp1;



            Events = new ObservableCollection<Event>(temps);
            //Events.Name = "Dummy event";
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
