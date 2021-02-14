using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views.BurgerMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }
        public NewsFeed()
        {
            get; set;
        }
        public MapView()
        {
            get; set;
        }
        public Information_Center()
        {
            get; set;
        }
    }
}