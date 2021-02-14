using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Web.UI;

namespace EcoBlocApp_test.Droid.BurgerMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPage : ContentPage
    {
        private NavigationPage(MainPage mainpage)
        {
            InitializeComponent();
        }

        [Obsolete]
        public MainPage
        MainPage = new MasterDetailPage.FocusRequestArgs()
        {
            master = new MasterPage()
            { Title = "Main Page" },
    Detail = new NavigationPage(new MainPage.MasterPage())
};
    }
}