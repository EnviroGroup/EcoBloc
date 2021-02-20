using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.Views.BurgerMenu
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
    class FlyOutItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
        public AsSingleItem FlyoutDisplayOptions { get; set; }
        public EventTabbedPage CurrentItem { get; set; }
        private IList<Tab> FlayoutItem { get; set; }
        private IList<Tab> Item { get; set; }
        public ImageSource FlyoutIcon { get; set; }
        public ImageSource Icon { get; set; }
        private bool IsChecked { get; set; }
        private bool Isenabaled { get; set; }
        private bool IsTabStop { set; get; }
        private bool TabIndex  {get; set;}
        private bool IsVisible { get; set; }
        public DataTemplate FlyoutHeaderTemplate { get; set; } 


       
        public object ecoBlocApp_test { get; private set; }
    }

    public class AsSingleItem
    {
    }
}
