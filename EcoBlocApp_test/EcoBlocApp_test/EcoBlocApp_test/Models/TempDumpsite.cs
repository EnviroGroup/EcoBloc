using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace EcoBlocApp_test.Models
{
    public class TempDumpsite
    {
        [PrimaryKey, AutoIncrement]
        public int TempDumpsiteId { get; set; }

        public string WasteTypes { get; set; }

        public string StreetName { get; set; }

        public string ImageUrl { get; set; }

        public string Comment { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public TempDumpsiteMarker TempDumpsiteMarker { get; set; }

       public TempDumpsite()
        {
            TempDumpsiteMarker = new TempDumpsiteMarker();
        }

    }
}
