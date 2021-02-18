using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class CreationPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public CreationPageViewModel()
        {
       
            AddCharCommand = new Command<string>((key) =>
                {
                    // Add the key to the input string.
                    InputString += key;
                });

            CancelCharCommand = new Command(() =>
                {
                    // Strip a character from the input string.
                    InputString = InputString.Substring(0, InputString.Length - 1);
                },
                () =>
                {
                    // Return true if there's something to delete.
                    return InputString.Length > 0;
                });
        }

        // Public properties
        public string InputString
        {
            protected set
            {
                if (inputString != value)
                {
                    inputString = value;
                    OnPropertyChanged("InputString");
                    DisplayText = FormatText(inputString);

                    // Perhaps the delete button must be enabled/disabled.
                    ((Command)CancelCharCommand).ChangeCanExecute();
                }
            }

            get { return inputString; }
        }

        public string DisplayText
        {
            protected set
            {
                if (displayText != value)
                {
                    displayText = value;
                    OnPropertyChanged("DisplayText");
                }
            }
            get { return displayText; }
        }
         public ICommand CreateCharCommand { protected set; get; }

        public ICommand CancelCharCommand { protected set; get; }
        
        public CreationPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        //public async void AddButton()
        // {
        //    await _navigation.PushAsync(new NewOrder()); ;
        //}


        //public async void SaveButton()
        //{
         //   await _navigation.PopAsync();
        //
       // }

    }
}
