using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using EcoBlocApp_test.Views.BurgerMenu;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
    class LoginPageVM : BaseViewModel
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

        private string placeHolder;
        public string PlaceHolder
        {
            get { return placeHolder; }
            set
            {
                placeHolder = value;
                NotifyPropertyChanged("PlaceHolder");
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
        public ICommand SubmitCommand { protected set; get; }
        public ICommand RegisterCommand { protected set; get; }
        public ICommand ContinueCommand { protected set; get; }


        public LoginPageVM()
        {

        }

        public LoginPageVM(INavigation navigation)
        {
            _sQLiteDatabase = new SQLiteDatabase();
            User = new User();
            _navigation = navigation;
            SubmitCommand = new Command(() => OnSubmit());
            RegisterCommand = new Command(() => Register());
            ContinueCommand = new Command(() => AnonMode());
            
            
            PlaceHolder = "Enter Text Here";

        }
        public async void OnSubmit()
        {
           var tempAns = _sQLiteDatabase.CheckUser(Password, UserName);

            if (tempAns == true)
            {
              User = _sQLiteDatabase.GetUser(Password, UserName);


                //_sQLiteDatabase.AddTempUser(User);


                await _navigation.PushAsync(new FlyOutMainPage() );
            }
            else
            {
                UserName = null;
                Password = null;
                PlaceHolder = "Incorrect Username or Password!!!";
            }
            
        }

        public async void Register()
        {
            await _navigation.PushAsync(new RegisterPage());
        }

        public async void AnonMode()
        {

            User.FirstName = "Anon";
            _sQLiteDatabase.AddTempUser(User);
            await _navigation.PushAsync(new FlyOutMainPage());
        }


    }
}
