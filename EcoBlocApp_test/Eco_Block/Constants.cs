using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.UI.Xaml.Shapes;
using Xamarin.Forms;

namespace EcoBlocApp_test
{
    public class ContentPage : Xamarin.Forms.ContentView
    {
        public static object Environment { get; private set; }
        public static string DatabasePath { get; internal set; }
        public static bool Flags { get; internal set; }

        public static class EcoBlocApp_test
        {
            public const string DatabaseFilename = "TodoSQLite.db3";

            public const SQLite.SQLiteOpenFlags Flags =
               
                SQLite.SQLiteOpenFlags.ReadWrite |
             
                SQLite.SQLiteOpenFlags.Create |
               
                SQLite.SQLiteOpenFlags.SharedCache;

            public static string DatabasePath
            {
                get
                {
                    var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    return Path(basePath, DatabaseFilename);
                }
            }

         
        }
    }
