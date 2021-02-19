using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class ReportedDumpsite
    {
        [PrimaryKey,AutoIncrement]
        public int ReprtedDumpsiteId { get; set; }

        public string WasteTypes { get; set; }

        public string Address { get; set; } //not sure yet

        public string ImageUrl { get; set; }

        public string Comment { get; set; }

        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }

        public ReportedDumpsite()
        {

        }
    }
}
