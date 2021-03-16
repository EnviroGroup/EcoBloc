﻿using System;
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

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [ManyToOne]
        public User User { get; set; }

        public ReportedDumpsite()
        {

        }
    }
}
