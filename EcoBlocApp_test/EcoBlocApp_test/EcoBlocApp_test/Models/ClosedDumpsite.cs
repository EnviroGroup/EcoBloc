using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoBlocApp_test.Models
{
    public class ClosedDumpsite
    {
        [PrimaryKey,AutoIncrement]
        public int ClosedDumpsiteId { get; set; }

        public string WasteTypes { get; set; }

        public string StreetName { get; set; }

        public string ImageUrl { get; set; }

        public string Comment { get; set; }


        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public EventMarker EventMarker { get; set; }


        [ForeignKey(typeof(Event))]
        public int EventId { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Event Event { get; set; }


        public ClosedDumpsite()
        {

        }

    }
}
