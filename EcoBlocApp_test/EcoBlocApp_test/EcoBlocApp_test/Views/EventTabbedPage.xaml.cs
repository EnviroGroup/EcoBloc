using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventTabbedPage : TabbedPage
    {
        public EventTabbedPage()
        {
            InitializeComponent();
        }
    }
}