using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using EcoBlocApp_test.Views.BurgerMenu;
using EcoBlocApp_test.Views;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.Models;

namespace EcoBlocApp_test.ViewModels
{
    public class RegisterPageVM : BaseViewModel
    {
        SQLiteDatabase _sQLiteDatabase;

        private INavigation _navigation;

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

        private string fieldRequired;
        public string FieldRequired
        {
            get { return fieldRequired; }
            set
            {
                fieldRequired = value;
                NotifyPropertyChanged("FieldRequired");
            }
        }

        private bool check;
        public bool Check
        {
            get { return check; }
            set
            {
                check = value;
                NotifyPropertyChanged("Check");
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

        private string passwordCheck;
        public string PasswordCheck
        {
            get { return passwordCheck; }
            set
            {
                passwordCheck = value;
                NotifyPropertyChanged("PasswordCheck");
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

        public ICommand RegisterCommand { protected set; get; }

        public RegisterPageVM()
        {

        }

        public RegisterPageVM(INavigation navigation)
        {
            _navigation = navigation;
            RegisterCommand = new Command(() => Register());
            
            _sQLiteDatabase = new SQLiteDatabase();

            User = new User();

            Check = false;
            

        }

        public async void Register()
        {
            if (UserName == null || FirstName == null || LastName == null || Password == null || PasswordCheck == null || Email == null )
            {
                Check = true;
                FieldRequired = "Please enter all details";
            }
            else
            {
                Check = false;
                _sQLiteDatabase.AddUser(UserName, FirstName, LastName, Password, Email);
                _sQLiteDatabase.AddTempUser(User);

                await _navigation.PushAsync(new FlyOutMainPage());
            }

            
        }




    }
}
