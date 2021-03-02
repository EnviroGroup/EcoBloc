using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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
