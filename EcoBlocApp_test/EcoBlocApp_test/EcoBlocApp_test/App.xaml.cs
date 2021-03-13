using EcoBlocApp_test.Views;
using EcoBlocApp_test.Views.BurgerMenu;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.Services;

namespace EcoBlocApp_test
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewsFeed()); ////NavigationPage(new EcoBlocApp_test.Views.BurgerMenu.FlyOutMainPage())  NavigationPage(new MapView()

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
