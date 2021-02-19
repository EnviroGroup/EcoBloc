using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class DumpsiteMarker
    {
        [PrimaryKey, AutoIncrement]
        public int DumpsiteMarkerId { get; set; }
        public string PinLabel { get; set; }
        public string PinAddress { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        [ForeignKey(typeof(OpenDumpsite))]
        public int OpenDumpsiteId { get; set; }

        [OneToOne]
        public OpenDumpsite OpenDumpsite { get; set; }

        public DumpsiteMarker()
        {


        }

    }
}
