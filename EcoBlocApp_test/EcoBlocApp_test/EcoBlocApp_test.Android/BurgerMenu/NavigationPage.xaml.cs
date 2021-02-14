using System;
using Xamarin.Forms;
using System.Web.UI;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Droid.BurgerMenu.ViewCell1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage(MasterPage masterpage)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        public MainPage
        MasterPage = new VisualElement.FocusRequestArgs()
        {
            MasterPage = new MasterPage()
            { Title = "Main Page" },
            Detail = new NavigationPage(new MainPage.mainpage())
};
    }
}