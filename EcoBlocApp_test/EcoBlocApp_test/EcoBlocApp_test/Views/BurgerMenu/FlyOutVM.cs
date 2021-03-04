﻿using EcoBlocApp_test.Services;
using EcoBlocApp_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoBlocApp_test.Views.BurgerMenu
{
    class FlyOutVM : BaseViewModel
    {

        SQLiteDatabase _sQLiteDatabase;

        private List<FlyOutItem> _flyOutItems;

        public List<FlyOutItem> FlyOutItems
        {
            get
            {
                return _flyOutItems;
            }
            set
            {
                _flyOutItems = value;
                NotifyPropertyChanged("FlyOutItems");
            }

        }

        private bool loggedIn;
        private bool loggedOut;

        public FlyOutVM()
        {
            _sQLiteDatabase = new SQLiteDatabase();

            UserLoginCheck();

            FlyOutItems = new List<FlyOutItem>();

            FlyOutItem Home = new FlyOutItem();

            Home.Title = "Home";
            Home.TargetType = typeof(MainTabbedPage);
            Home.Visable = true;

            FlyOutItems.Add(Home);


            FlyOutItem SignIn = new FlyOutItem();

            SignIn.Title = "SignIn";
            SignIn.TargetType = typeof(LoginPage);
            SignIn.Visable = loggedOut;

            FlyOutItems.Add(SignIn);

            FlyOutItem SignOut = new FlyOutItem();

            SignOut.Title = "SignOut";
            SignOut.TargetType = typeof(MainTabbedPage);
            SignOut.Visable = loggedIn;

            FlyOutItems.Add(SignOut);
        }

        public void UserLoginCheck()
        {
           var tempBool = _sQLiteDatabase.CheckIfUserIsLoggedIn();

            if (tempBool == true)
            {
                loggedIn = true;
                loggedOut = false;
            }
            else
            {
                loggedIn = false;
                loggedOut = true;
            }
        }


    }
}
