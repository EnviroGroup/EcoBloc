using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.ViewModels;
using EcoBlocApp_test.Models;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventTemplate : ContentPage
    {
        Event tempEvent;

        private INavigation _navigation;

        public EventTemplate()
        {
            InitializeComponent();
        }

        public EventTemplate(Event @event, INavigation navigation )
        {
            InitializeComponent();
            tempEvent = @event;
            _navigation = navigation;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new EventTemplateVM(_navigation, tempEvent);


        }
    }
}