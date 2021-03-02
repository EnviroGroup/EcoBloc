using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class Event
    {
        [PrimaryKey,AutoIncrement]
        public int EventId { get; set; }

        public string NameOfEvent { get; set; }

        public DateTime EventCreationDate { get; set; }

        public int NumberOfParticipants { get; set; }

        public string ReasonForCreation { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public ClosedDumpsite EventDumpsite { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Participant> Participants { get; set; }

        public Event()
        {
            Participants = new List<Participant>();
        }


        public void AddParticipant(Participant participant)
        {
            Participants.Add(participant);
        }

        //needs a method for the event creator to edit the details of their event
    }
}
