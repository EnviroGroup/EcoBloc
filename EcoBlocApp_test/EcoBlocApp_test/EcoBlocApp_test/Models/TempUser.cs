﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class TempUser
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Event> EventsCreated { get; set; }   //need to make it an array of type event

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Participant> EventsParticipatedIn { get; set; } //need to make it an array of type IDK yet

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ReportedDumpsite> DumpsitesReported { get; set; }  //need to make it an array of type IDK yet

        public TempUser()
        {
            EventsCreated = new List<Event>();
            EventsParticipatedIn = new List<Participant>();
            DumpsitesReported = new List<ReportedDumpsite>();
        }

        public void AddEvent(Event @event)
        {
            EventsCreated.Add(@event);
            
        }

        public void ClearEvent()
        {
            EventsCreated.Clear();
        }

        public void AddReport(ReportedDumpsite dumpsite)
        {
            DumpsitesReported.Add(dumpsite);

        }

        public void ClearReports()
        {
            DumpsitesReported.Clear();
        }

        public void AddParticipant(Participant participant)
        {
            EventsParticipatedIn.Add(participant);
        }

        public void ClearParticipant()
        {
            EventsParticipatedIn.Clear();
        }

    }
}
