using System;
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

        private string _tempDumpName;

        public string _TempDumpName
        {
            get
            {

                return _tempDumpName;
            }
            set
            {
                _tempDumpName = value;
                NotifyPropertyChanged("_TempDumpName");
            }
        }


        private TempDumpsite _tempDumpsite;

        public TempDumpsite _TempDumpsite 
        {
            get
            {

                return _tempDumpsite;
            }
            set
            {
                _tempDumpsite = value;
                NotifyPropertyChanged("_TempDumpsite");
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

        private bool _rubble;
        
        public bool Rubble
        {
            get
            {

                return _rubble;
            }
            set
            {
                _rubble = value;
                NotifyPropertyChanged("Rubble");
            }
        }

        private bool _ewaste;

        public bool Ewaste
        {
            get
            {

                return _ewaste;
            }
            set
            {
                _ewaste = value;
                NotifyPropertyChanged("Ewaste");
            }
        }

        private bool _plastic;

        public bool Plastic
        {
            get
            {

                return _plastic;
            }
            set
            {
                _plastic = value;
                NotifyPropertyChanged("Plastic");
            }
        }

        private bool _mixture;

        public bool Mixture
        {
            get
            {

                return _mixture;
            }
            set
            {
                _mixture = value;
                NotifyPropertyChanged("Mixture");
            }
        }


        public ICommand ReportCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }
        public ICommand GetDumpsiteCommand { get; private set; }


        public CreationPageViewModel()
        {

        }

        public CreationPageViewModel(INavigation navigation, SQLiteDatabase sQLiteDatabase )
        {
            
            _sQLiteDatabase = sQLiteDatabase;
            _PendingEvent = new PendingEvent();
            _tempDumpsite = new TempDumpsite();
            _navigation = navigation;

            _PendingEvent.tempDumpsite = _tempDumpsite;

            GetTempDumpsite();

            ReportCommand = new Command(() => AddButton());

            CancelCommand = new Command(() => CancelButton());

            GetDumpsiteCommand = new Command(() => GetDumpsiteButton());
        }



        public async void AddButton()
         {
            _PendingEvent.ReasonForCreation = InputText;
            _PendingEvent.EventDate = DateTime.Now;
            //_sQLiteDatabase.AddPendingEvent(_PendingEvent);
           
           await _navigation.PopAsync(); 
        }


        public async void CancelButton()
        {
            if (_TempDumpsite != null)
            {
                _sQLiteDatabase.DeleteTempDumpsite(_TempDumpsite);
                

            }
            


            await _navigation.PopAsync();
        
        }

        public async void GetDumpsiteButton()
        {
           
            await _navigation.PushAsync(new DumpsiteMap()); ;

        }

        public void GetTempDumpsite()
        {
           var temp = _sQLiteDatabase.GetTempDumpsite();

            if (temp != null)
            {
                _TempDumpsite = temp;
                _tempDumpName = _TempDumpsite.StreetName;
            }
        }

    }
}
