using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;

namespace EcoBlocApp_test.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThankYouPopUp : PopupPage
    {
        public ThankYouPopUp()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }
    }
}