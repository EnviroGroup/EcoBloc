using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.ViewModels;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DumpsiteReportPage : ContentPage
    {


        public DumpsiteReportPage()
        {
            InitializeComponent();
            BindingContext = new ReportPageViewModel(Navigation);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

        }
     




    }

   
}



  
