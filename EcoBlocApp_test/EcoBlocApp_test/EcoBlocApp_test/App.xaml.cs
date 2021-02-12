using EcoBlocApp_test.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EcoBlocApp_test.Views.BurgerMenu.FlyOutMainPage();
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
