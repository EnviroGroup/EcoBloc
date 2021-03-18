using EcoBlocApp_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.Models;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DumpsiteDetailPage : ContentPage
    {
        public DumpsiteDetailPage()
        {
            InitializeComponent();

            
        }

        public DumpsiteDetailPage(OpenDumpsite openDumpsite)
        {
            InitializeComponent();

            BindingContext = new DumpsiteDetailPageVM(Navigation, openDumpsite);
        }
    }
}