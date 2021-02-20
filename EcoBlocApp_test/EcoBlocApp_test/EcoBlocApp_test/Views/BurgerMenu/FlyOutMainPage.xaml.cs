﻿using System;
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
        public partial class FlyoutHeaderTemplateSelector : DataTemplateSelector
        {
            public FlyoutHeaderTemplateSelector(DataTemplate navigationHeaderTemplate)
            {
                NavigationHeaderTemplate = navigationHeaderTemplate;
            }

            public DataTemplate NavigationHeaderTemplate { get; set; }
            public DataTemplate NavigationItemTemplate { get; set; }
            
            protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
            {
                if (item is ShellGroupItem && ((ShellGroupItem)item).Title == "Header")
                {
                    //making sure the header item is not clickable
                    ((ShellGroupItem)item).IsEnabled = false;
                    return NavigationHeaderTemplate;
                }
                else
                    return NavigationItemTemplate;
            }
        }

    

    void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            

            var item = e.SelectedItem as FlyOutItem;
            if (item != null )
            {
                if(item.Title == "Home" && (Detail.Title == item.Title || Detail.Title == null))
                {
                    flyoutPage.listView.SelectedItem = null;
                    IsPresented = false;
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