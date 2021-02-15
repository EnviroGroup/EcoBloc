using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.ViewModels;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEventsPage : ContentPage
    {
        public MyEventsPage()
        {

    
            InitializeComponent();

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new MyEventsPageViewModel(Navigation);


        }

    }
}
    