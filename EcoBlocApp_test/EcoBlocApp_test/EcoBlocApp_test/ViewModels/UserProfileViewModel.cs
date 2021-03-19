using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using EcoBlocApp_test.Models;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
   public class UserProfileViewModel : BaseViewModel
    {
        private INavigation _navigation;

        

        public ICommand SourceCommand { get; private set; }

        private User _user;
        public User _User
        {
            get { return _user; }
            set
            {
                _user = value;
                NotifyPropertyChanged("_User");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyPropertyChanged("Email");
            }
        }

        public UserProfileViewModel()
        {

        }

        public UserProfileViewModel(INavigation navigation)
        {
            

            LoginCheck();

            _navigation = navigation;

            SourceCommand = new Command(()=> EditProfile());
           
        }

        private async void EditProfile()
        {
            await _navigation.PushAsync(new UserEditPage(_User));
        }

        public void LoginCheck()
        {
            var check = App._sQLiteDatabase.CheckIfUserIsLoggedIn();

            if (check == true)
            {
                var tempUser = App._sQLiteDatabase.GetUserDetails();
                _User = tempUser;
                Name = _User.UserName;
                FirstName = _User.FirstName;
                Email = _User.Email;
            }
            else
            {
                Name = "";
            }
        }

    }

}
