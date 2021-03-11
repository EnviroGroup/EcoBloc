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

        public string NameOfEvent { get; set; }

        public DateTime EventCreationDate { get; set; }

        public string ReasonForCreation { get; set; }

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [ManyToOne]
        public User User { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public TempDumpsite EventDumpsite { get; set; }



        public PendingEvent()
        {

        }





    }
}
