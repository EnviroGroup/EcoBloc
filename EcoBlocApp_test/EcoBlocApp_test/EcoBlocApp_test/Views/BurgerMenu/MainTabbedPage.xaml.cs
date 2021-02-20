using System;
using System.Collections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views.BurgerMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : Xamarin.Forms.TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }



        public IEnumerable MenuTabbedList { get; internal set; }


    }

    public class MenuTabbedPage
    {
        public string MapView { get; set; }
        public string NewsFeed { get; set; }
        public string Information_Center { get; set; }
    }
    public partial class MenuTabbedList : Xamarin.Forms.TabbedPage
    {
        public MenuTabbedList()
        {
            InitializeComponent();
            var vm = new MenuTabbedList();
            this.ItemsSource = vm.MainTabbedPage;


        }

        public IEnumerable MainTabbedPage { get; set; }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
    public partial class TabbedPage : Xamarin.Forms.TabbedPage
    {
        public TabbedPage()
        {
            InitializeComponent();
            Children.Add(new Views.NewsFeed());
            Children.Add(new Views.MapView());
            Children.Add(new Views.Information_Center());
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
      
         
           
      
    

