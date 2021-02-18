using EcoBlocApp_test.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test
{
    public partial class App : Application
    {
        public static string FilePath;


        public App()
        {
            InitializeComponent();

            iNoteRepository repository;
            //TODO: get repository instance
            repository.Initialize();
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EventCreationPage());
        }

        public App(string filePath)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EventCreationPage());

            FilePath = FilePath;
        }



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EcoBlocApp_test.Views.BurgerMenu.FlyOutMainPage()); ////NavigationPage(new EcoBlocApp_test.Views.BurgerMenu.FlyOutMainPage())  NavigationPage(new MapView()

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
        public App()
        {
            InitializeComponent();

            Locator.Initialize();

            InitializeRepository();

            InitializeMainPage();

        }

        private void InitializeMainPage()
        {
            MainPage = new NavigationPage(Locator.Resolve<HomeView>());
        }

        private static void InitializeRepository()
        {
            INoteRepository repository = Locator.Resolve<INoteRepository>();
            repository.Initialize();
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
