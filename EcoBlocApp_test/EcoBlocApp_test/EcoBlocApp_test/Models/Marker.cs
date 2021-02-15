using System;
using System.Collections.Generic;
using System.Text;

namespace EcoBlocApp_test.Models
{
    class Marker
    {

        public int ID { get; set; }
        public string PinLabel { get; set; }
        public string PinAddress { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }


    }
}
