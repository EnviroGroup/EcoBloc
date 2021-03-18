using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoBlocApp_test.Models
{
    public class Photo
    {
        [PrimaryKey, AutoIncrement]
        public int PhotoId { get; set; }

        public string StoredImage { get; set; }

        public Photo()
        {

        }
    }
}
