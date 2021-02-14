using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Droid.BurgerMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Android : fitsSystemWindows
    {
        private const object XamlCompilationOptions;

        public Android()
        {
            InitializeComponent();
        }
    }
}