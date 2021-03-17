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
        public static SQLiteDatabase SQLiteDatabase { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UserProfilePage()); ////NavigationPage(new EcoBlocApp_test.Views.BurgerMenu.FlyOutMainPage())  NavigationPage(new MapView()

            SQLiteDatabase = new SQLiteDatabase();
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
