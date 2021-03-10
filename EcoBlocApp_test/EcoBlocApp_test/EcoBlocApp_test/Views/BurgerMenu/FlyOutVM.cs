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

        private string welcome;
        public string Welcome
        {
            get { return welcome; }
            set
            {
                welcome = value;
                NotifyPropertyChanged("Welcome");
            }
        }


        
        private bool loggedIn;
        private bool loggedOut;

        public FlyOutVM()
        {
            _sQLiteDatabase = new SQLiteDatabase();

            FlyOutItems = new List<FlyOutItem>();

            UserLoginCheck();

            //var temp = _sQLiteDatabase.GetTempUser();

            Welcome = "Welcome";


            
        }

        public void UserLoginCheck()
        {
           var tempBool = _sQLiteDatabase.CheckIfUserIsLoggedIn();

            if (tempBool == true)
            {
                loggedIn = true;
                loggedOut = false;

                FlyOutItems.Clear();

                FlyOutItem Home = new FlyOutItem();

                Home.Title = "Home";
                Home.TargetType = typeof(MainTabbedPage);
                Home.Visable = true;
                Home.Enabled = true;

                FlyOutItems.Add(Home);

                FlyOutItem UserProfilePage = new FlyOutItem();

                UserProfilePage.Title = "UserProfile";
                UserProfilePage.TargetType = typeof(UserProfilePage);
                UserProfilePage.Visable = loggedIn;
                UserProfilePage.Enabled = loggedIn;

                FlyOutItems.Add(UserProfilePage);


                FlyOutItem SignOut = new FlyOutItem();

                SignOut.Title = "SignOut";
                SignOut.TargetType = typeof(FlyOutMainPage);
                SignOut.Visable = loggedIn;
                SignOut.Enabled = loggedIn;

                FlyOutItems.Add(SignOut);

            }
            else
            {
                loggedIn = false;
                loggedOut = true;

                FlyOutItems.Clear();

                FlyOutItem Home = new FlyOutItem();

                Home.Title = "Home";
                Home.TargetType = typeof(MainTabbedPage);
                Home.Visable = true;
                Home.Enabled = true;

                FlyOutItems.Add(Home);

                FlyOutItem SignIn = new FlyOutItem();

                SignIn.Title = "SignIn";
                SignIn.TargetType = typeof(LoginPage);
                SignIn.Visable = loggedOut;
                SignIn.Enabled = loggedOut;

                FlyOutItems.Add(SignIn);


            }
        }


    }
}