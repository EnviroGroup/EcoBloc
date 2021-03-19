using EcoBlocApp_test.Models;
using EcoBlocApp_test.ViewModels;
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
    public partial class UserEditPage : ContentPage
    {
        public UserEditPage()
        {
            InitializeComponent();
            
        }

        public UserEditPage(User user)
        {
            InitializeComponent();
            BindingContext = new UserEditPageVM(Navigation, user);
        }
    }
}