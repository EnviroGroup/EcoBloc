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

        SQLiteDatabase _sQLiteDatabase;

        User user;

        public FlyOutMainPage()
        {
            InitializeComponent();

            _sQLiteDatabase = new SQLiteDatabase();



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
               

                if ((Detail.Title == item.Title || Detail.Title == null))
                {
                    
                    flyoutPage.listView.SelectedItem = null;
                    IsPresented = false;
                }

                if (item.Title == "SignOut")
                {
                    //_sQLiteDatabase.ClearUser();
                }

                else
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                    flyoutPage.listView.SelectedItem = null;
                    IsPresented = false;
                }
                

                
            }
        }
    }
}