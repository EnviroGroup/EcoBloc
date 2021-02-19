using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email { get; set; }
        
        public string EventsCreated { get; set; }   //need to make it an array of type event

        public string  EventsParticipatedIn { get; set; } //need to make it an array of type IDK yet

        public string DumpsitesReported { get; set; }  //need to make it an array of type IDK yet


    }
}
