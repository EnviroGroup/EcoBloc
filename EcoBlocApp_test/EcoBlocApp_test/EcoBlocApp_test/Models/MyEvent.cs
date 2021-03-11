using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using Xamarin.Forms.Maps;

namespace EcoBlocApp_test.Models
{
    public class MyEvent : SignUpPageViewModel
    
  
        {
        public class MyEventrRepository
        {
            private List<MyEvent> _myEvent;

            public int Participant
            { get; set; }
            public myEventRepository()
            {
                _myEvent = new List<MyEvent>
            {
                new MyEvent(){ MyEventID = 1, Discription ="Dana Birkby", Participant =""},
                new MyEvent(){ MyEventID = 2, Discription ="Adriana Giorgi", Participant =""},
                new MyEvent(){ MyEventID = 3, Discription ="Wei Yu", Participant =""}
            };
            }

            public List<MyEvent> GetMyEvent()
            {
                return _myEvent;
            }

            public void UpdateMyEvent(MyEvent SelectedMyEvent)
            {
                MyEvent myEventToChange = _myEvent.Single(c => c.MyEventID == SelectedMyEvent.MyEventID);
                myEventToChange = SelectedMyEvent;
            }
        }
    }
}
