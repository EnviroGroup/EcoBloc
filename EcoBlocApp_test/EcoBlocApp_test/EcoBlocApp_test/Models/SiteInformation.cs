using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace EcoBlocApp_test.Models
{
    public class SiteInformation 
    {
        [PrimaryKey,AutoIncrement]
        public int SiteInformationId { get; set; }


        public string Name { get; set; }

        public string ImageUrl { get; set; }


        public string Address { get; set; }

        public string WebsiteLink { get; set; }

        public int PhoneNumber { get; set; }

        public string About { get; set; }

        public string PinLabel { get; set; }
        public string PinAddress { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }


        public SiteInformation()
        {

        }




    }
}
