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
    public partial class My_EventTemplate : ContentPage
    {
        Event tempEvent;

        private INavigation _navigation;

        public My_EventTemplate()
        {
            InitializeComponent();
        }

        public My_EventTemplate(Event @event, INavigation navigation)
        {
            InitializeComponent();
            tempEvent = @event;
            _navigation = navigation;
            BindingContext = new MyEventTemplateVM(_navigation, tempEvent);

        }

        
    }
}