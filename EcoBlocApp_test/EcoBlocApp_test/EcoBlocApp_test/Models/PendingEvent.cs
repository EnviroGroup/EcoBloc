using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class PendingEvent
    {

        [PrimaryKey,AutoIncrement]
        public int PendingEventId { get; set; }

       

        public DateTime EventDate { get; set; }

        public string ReasonForCreation { get; set; }


        


        public PendingEvent()
        {

        }





    }
}
