﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventLogPage : ContentPage
    {
        public EventLogPage()
        {
            InitializeComponent();
            BindingContext = new LogViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }


    }
}