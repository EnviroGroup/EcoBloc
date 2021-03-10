using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using EcoBlocApp_test.ViewModels;

namespace EcoBlocApp_test.PopUp
{
    public class PopupVM : BaseViewModel
    {
        private string _welcome;

        public string Welcome
        {
            get
            {
                return _welcome;
            }
            set
            {
                _welcome = value;
                NotifyPropertyChanged("Welcome");
            }

        }

        public PopupVM()
        {
            Welcome = "HIIIIIIIIII";
        }


        private void BackgroundClickedCommandExecute(object parameter)
        {
            var label = (Label)parameter;
            label.Text = "Great, it works!";
        }

    }
}
