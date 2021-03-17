using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using EcoBlocApp_test.Views;

namespace EcoBlocApp_test.ViewModels
{
    public class EditEventPageVM : BaseViewModel
    {
        private INavigation _navigation;

        public EditEventPageVM()
        {

        }

        public EditEventPageVM(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
