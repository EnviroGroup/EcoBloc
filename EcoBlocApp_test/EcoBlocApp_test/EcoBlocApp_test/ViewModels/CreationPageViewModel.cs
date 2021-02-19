using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.Models;
using System.Windows.Input;

namespace EcoBlocApp_test.ViewModels
{
    public class CreationPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        SQLiteDatabase _sQLiteDatabase;

        private PendingEvent _pendingEvent;


        public PendingEvent _PendingEvent 
        {
            get
            {

                return _pendingEvent;
            }
            set
            {
                _pendingEvent = value;
                NotifyPropertyChanged("_PendingEvent");
            }
        }


        private string inputText;

        public string InputText 
        {
            get
            {

                return inputText;
            }
            set
            {
                inputText = value;
                NotifyPropertyChanged("InputText");
            }
        }


        public ICommand ReportCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }

        public CreationPageViewModel()
        {

        }

        public CreationPageViewModel(INavigation navigation, SQLiteDatabase sQLiteDatabase )
        {
            _sQLiteDatabase = sQLiteDatabase;
            _PendingEvent = new PendingEvent();
            _navigation = navigation;

            ReportCommand = new Command(() => AddButton());

            CancelCommand = new Command(() => CancelButton());
        }

        public async void AddButton()
         {
            _PendingEvent.ReasonForCreation = InputText;
            _PendingEvent.EventDate = DateTime.Now;
            _sQLiteDatabase.AddPendingEvent(_PendingEvent);
           
           await _navigation.PopAsync(); 
        }


        public async void CancelButton()
        {
            await _navigation.PopAsync();
        
        }

    }
}
