using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Eco_Bloc_App.Views;

namespace EcoBloc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(); //NavigationPage(new MainTabbedPage()
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
