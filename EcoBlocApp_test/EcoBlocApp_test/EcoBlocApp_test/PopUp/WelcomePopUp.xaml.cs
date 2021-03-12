﻿using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePopUp : PopupPage
    {
        public WelcomePopUp()
        {
            InitializeComponent();
            BindingContext = new WelcomeVM();
        }

        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}