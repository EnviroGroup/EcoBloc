using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.Models;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Marker_detail_page : ContentPage
    {
        SiteInformation _SiteInformation;

        public Marker_detail_page()
        {
            InitializeComponent();
        }

        public Marker_detail_page(SiteInformation siteInformation)
        {
            InitializeComponent();
            _SiteInformation = siteInformation;
            BindingContext = new DetailPageViewModel(Navigation,_SiteInformation);
        }

        

    }
}