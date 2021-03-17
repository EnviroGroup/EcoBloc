using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InformationCenter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralInformation : ContentPage
    {
        public GeneralInformation()
        {
            InitializeComponent();
            BindingContext = new InformationCenterViewModel();
        }
    }
}