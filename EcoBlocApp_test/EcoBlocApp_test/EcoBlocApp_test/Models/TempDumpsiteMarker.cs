using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class TempDumpsiteMarker
    {
        [PrimaryKey, AutoIncrement]
        public int TempDumpsiteMarkerId { get; set; }
        public string PinLabel { get; set; }
        public string PinAddress { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        [ForeignKey(typeof(TempDumpsite))]
        public int TempDumpsiteId { get; set; }

        //[OneToOne]
        //public OpenDumpsite TempDumpsite { get; set; }

    }
}
