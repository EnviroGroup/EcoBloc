using System;
using System.Data;
using System.Net.Mail;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static Android.Provider.CalendarContract;
using static EcoBlocApp_test.Models.MyEvent;

namespace EcoBlocApp_test.ViewModels
{
    public class SignUpPageViewModel : BaseViewModel
    {
        private INavigation Navigation
        {
            get; set;
        }
        public SignUpPageViewModel()
        {

        }

        public SignUpPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }


        public class Navigation : MyEventsPageViewModel
        {
            private SignUpPageViewModel myEvent;

            public SignUpPageViewModel GetMyEvent()
            {
                return myEvent;
            }

            public void SetMyEvent(SignUpPageViewModel value)
            {
                myEvent = value;
            }
        }
        public class ReportedDumpsite
        {
            
        }
        public class OpenDumpsite
        {
        
        }

        public class SignUpPageViewModel : MyEvent
        {
            private List<MyEvent> _myEvent;
            private MyEvent _currentMyEvent;
            private MyEventRepository _repository;

            public MyEventViewModel()
            {
                _repository = new MyEventrRepository();
                _myEvent = _repository.GetMyEvent();

                WireCommands();
            }

            private void WireCommands()
            {
                UpdateMyEventCommand = new RelayCommand(UpdateMyEvent);
            }

            public RelayCommand UpdateMyEventCommand
            {
                get;
                private set;
            }

            public List<MyEvent> MyEvent
            {
                get { return myEvent; }
                set { _myEvent = value; }
            }

            public MyEvent CurrentMyEvent
            {
                get
                {
                    return _currentmyEvent;
                }

                set
                {
                    if (_currentmyEvent != value)
                    {
                        _currentMyEvent = value;
                        OnPropertyChanged("CurrentMyEvent");
                        UpdateMyEventCommand.IsEnabled = true;
                    }
                }
            }

            public void UpdateMyEvent()
            {
                _repository.UpdateMyEvent(CurrentMyEvent);
            }

            public class RelayCommand : ICommand
            {
                private readonly Action _handler;
                private bool _isEnabled;

                public RelayCommand(Action handler)
                {
                    _handler = handler;
                }

                public bool IsEnabled
                { }
            }
        }
    }
};
                           



            
            
           
       

        
 

