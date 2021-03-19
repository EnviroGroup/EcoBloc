using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
    
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Directory : ContentPage
    {
        public Directory()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new InformationCenterViewModel(Navigation);


        }
    }
}