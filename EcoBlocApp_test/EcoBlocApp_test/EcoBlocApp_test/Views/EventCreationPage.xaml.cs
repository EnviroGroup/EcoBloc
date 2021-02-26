using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.Services;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventCreationPage : ContentPage
    {
        SQLiteDatabase _sQLiteDatabase;
        double[] geoLocate;

        public EventCreationPage()
        {

        }
        public EventCreationPage(SQLiteDatabase sQLiteDatabase , double[] location)
        {
            InitializeComponent();
            _sQLiteDatabase = sQLiteDatabase;
            geoLocate = location;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new CreationPageViewModel(Navigation,_sQLiteDatabase, geoLocate);


        }

    }
}