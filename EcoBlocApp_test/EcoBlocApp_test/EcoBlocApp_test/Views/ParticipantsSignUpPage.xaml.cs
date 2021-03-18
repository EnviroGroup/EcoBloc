using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.Models;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParticipantsSignUpPage : ContentPage
    {
        

        public ParticipantsSignUpPage()
        {
            InitializeComponent();
            
        }

        public ParticipantsSignUpPage(Event @event)
        {
            InitializeComponent();
            
            BindingContext = new SignUpPageViewModel(Navigation,@event);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            
            }
            
           
    }
}
