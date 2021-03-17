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
    public partial class GeneralInformation : ContentPage
    {
        public GeneralInformation()
        {
            InitializeComponent();

            //BindingContext = new InformationCenterViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new InformationCenterViewModel(Navigation);


        }

       // private async void Subtopic_Clicked(Object sender, EventArgs e)
      //  {
          //  await Navigation.PushAsync(new WasteTypes()); 
       // }

    }
}