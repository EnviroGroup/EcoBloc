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
        

        public EventCreationPage()
        {
            InitializeComponent();
        }
        


        protected override void OnAppearing()
        {
            base.OnAppearing();

            // _sQLiteDatabase.ClearTempdumpsite();
            BindingContext = new CreationPageViewModel(Navigation);


        }

    }
}