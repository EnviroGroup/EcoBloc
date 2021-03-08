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
    Public class Itinerary : JoinedEventTemplateVM
}
public static List<SelectListItem> Itinerary = new List<SelectListItem>()
    {
        new SelectListItem() {Text="Spade"},
        new SelectListItem() { Text="Broom"},
        new SelectListItem() { Text="Plastic Bag},
        new SelectListItem() { Text="Gloves"},
        new SelectListItem() { Text="Boots"},
                               new SelectListItem() { Text="Wheelbarrow"},
                               new SelectListItem() { Text="California"},
                               new SelectListItem() { Text="Bakkie"},
     
    }
}

