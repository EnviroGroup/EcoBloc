﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.Models;
using System.Windows.Input;
using System.Threading.Tasks;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
    public class UserEditPageVM : BaseViewModel
    {
        private INavigation _navigation;

        public ICommand UpdateCommand { get; private set; }


        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                NotifyPropertyChanged("UserName");
            }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }


        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }

        private string newPassword;
        public string NewPassword
        {
            get { return newPassword; }
            set
            {
                newPassword = value;
                NotifyPropertyChanged("NewPassword");
            }
        }


        private string newPasswordCheck;
        public string NewPasswordCheck
        {
            get { return newPasswordCheck; }
            set
            {
                newPasswordCheck = value;
                NotifyPropertyChanged("NewPasswordCheck");
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                NotifyPropertyChanged("Email");
            }
        }

        private bool _checkPassword;

        public bool CheckPassword
        {
            get
            {

                return _checkPassword;
            }
            set
            {
                _checkPassword = value;
                NotifyPropertyChanged("CheckPassword");
            }
        }



        public UserEditPageVM()
        {

        }

        public UserEditPageVM(INavigation navigation, User user)
        {
            
            _navigation = navigation;
            User = new User();
            User = user;
            UpdateCommand = new Command(() => Update());
        }

        private async void Update()
        {
            await _navigation.PopAsync();
        }
    }
}