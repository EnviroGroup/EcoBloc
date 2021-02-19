using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Data.SqlClient;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class ReportedMarker
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string PinLabel { get; set; }
        public string PinAddress { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }




    }
}
