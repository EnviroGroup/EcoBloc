using EcoBlocApp_test.Views;
using EcoBlocApp_test.Views.BurgerMenu;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.PopUp;

namespace EcoBlocApp_test
{
    public partial class App : Application
    {
        public static SQLiteDatabase _sQLiteDatabase { get; set; }

        public App()
        {
            InitializeComponent();

            _sQLiteDatabase = new SQLiteDatabase();

            MainPage = new NavigationPage(new LoginPage()); ////NavigationPage(new EcoBlocApp_test.Views.BurgerMenu.FlyOutMainPage())  NavigationPage(new MapView()

            
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
