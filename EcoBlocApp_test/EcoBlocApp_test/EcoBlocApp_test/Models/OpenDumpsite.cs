using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class OpenDumpsite
    {
        [PrimaryKey, AutoIncrement]
        public int OpenDumpsiteId { get; set; }

        public string WasteTypes { get; set; }

        public string StreetName { get; set; }

        public string ImageUrl { get; set; }

        public string Comment { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public DumpsiteMarker DumpsiteMarker { get; set; }

        public OpenDumpsite()
        {
           // DumpsiteMarker = new DumpsiteMarker();
        }


    }
}
