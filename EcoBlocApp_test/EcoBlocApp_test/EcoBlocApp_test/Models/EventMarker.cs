using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class EventMarker
    {

        [PrimaryKey,AutoIncrement]
        public int EventMarkerId { get; set; }
        public string PinLabel { get; set; }
        public string PinAddress { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        [ForeignKey(typeof(ClosedDumpsite))]
        public int ClosedDumpsiteId { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public ClosedDumpsite ClosedDumpsite { get; set; }

        public EventMarker()
        {

        }
    }
}
