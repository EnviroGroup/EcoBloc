using EcoBlocApp_test.Services;
using EcoBlocApp_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoBlocApp_test.PopUp
{
    class WelcomeVM : BaseViewModel
    {

        SQLiteDatabase _sQLiteDatabase;

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }

        }

        public WelcomeVM()
        {

            _sQLiteDatabase = new SQLiteDatabase();
            var temp = _sQLiteDatabase.GetTempUser();
            Name = temp.FirstName;
        }
    }
}
