using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using Plugin.Media.Abstractions;
using EcoBlocApp_test.ViewModels;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Image = Xamarin.Forms.Image;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DumpsiteReportPage : ContentPage
    {
        
        public ImageSource ImageSource { get; private set; }

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
