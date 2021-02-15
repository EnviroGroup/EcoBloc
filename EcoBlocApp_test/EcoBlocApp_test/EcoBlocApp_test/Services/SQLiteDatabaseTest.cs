using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using System.Linq;


namespace EcoBlocApp_test.Services
{
    public class SQLiteDatabaseTest
    {
        private SQLiteConnection _database;

        public SQLiteDatabaseTest()
        {
            var path = GetDbPath();
            _database = new SQLiteConnection(path);

            //_database.CreateTable<Order>(); needs to create more tables
            //SeedDataBase();

        }

        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ecobloc.db");

            return path;
        }



    }
}
