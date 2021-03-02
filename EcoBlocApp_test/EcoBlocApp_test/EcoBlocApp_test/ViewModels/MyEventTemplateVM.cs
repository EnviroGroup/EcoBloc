using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    class MyEventTemplateVM : BaseViewModel
    {
        private INavigation _navigation;

        public MyEventTemplateVM()
        {
        }

        public MyEventTemplateVM(INavigation navigation)
        {
            _navigation = navigation;
        }

    }
}
