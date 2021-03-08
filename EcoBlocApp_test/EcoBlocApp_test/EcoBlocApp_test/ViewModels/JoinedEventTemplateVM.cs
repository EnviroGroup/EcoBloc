using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Web;

namespace EcoBlocApp_test.ViewModels
{
    class JoinedEventTemplateVM : BaseViewModel
    {
        private INavigation _navigation;

        public JoinedEventTemplateVM()
        {
        }

        public JoinedEventTemplateVM(INavigation navigation)
        {
            _navigation = navigation;
        }

    }
}
public class Itinerary
    {
        public string Spade { get; set; }
        public string Broom { get; set; }
        public string Plastic Bag { get; set; }
        public string Gloves { get; set; }
        public string Boots { get; set; }
        public string Wheelbarrow { get; set; }
        public string Bakkie { get; set; }
    }
}

