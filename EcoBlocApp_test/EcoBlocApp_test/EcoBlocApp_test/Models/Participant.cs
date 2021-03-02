using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;


namespace EcoBlocApp_test.Models
{
    public class Participant
    {
        [PrimaryKey, AutoIncrement]
        public int ParticipantId { get; set; }

        public string Name { get; set; }

        public int ContactDetails { get; set; }

        public string ReasonForJoining { get; set; }

        public string Contribution { get; set; }


        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [ManyToOne]
        public User User { get; set; }

        [ForeignKey(typeof(Event))]
        public int EventId { get; set; }

        [ManyToOne]
        public Event Event { get; set; }

        public Participant()
        {

        }


        //needs a method for the participant to deregister from the event
    }
}
