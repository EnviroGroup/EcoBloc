using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.ViewModels;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JoinedEventTemplate : ContentPage
    {
        public JoinedEventTemplate()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new JoinedEventTemplateVM(Navigation);


        }
    }
}