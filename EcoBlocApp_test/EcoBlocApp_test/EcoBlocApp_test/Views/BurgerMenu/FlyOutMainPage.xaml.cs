using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
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
    public partial class FlyOutMainPage : FlyoutPage
    {

        

       

        public FlyOutMainPage()
        {
            InitializeComponent();

            



            flyoutPage.listView.ItemSelected += OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover;
            }
        }

       

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            

            var item = e.SelectedItem as FlyOutItem;

            

            if (item != null )
            {
               

                if ((Detail.Title == item.Title || (item.Title == "Home" && Detail.Title == item.Title)))
                {
                    
                    flyoutPage.listView.SelectedItem = null;
                    IsPresented = false;
                }

                

                else
                {
                    if (item.Title == "SignOut")
                    {
                        App._sQLiteDatabase.ClearUser();
                    }

                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                    flyoutPage.listView.SelectedItem = null;
                    IsPresented = false;
                }
                

                
            }
        }
    }
}