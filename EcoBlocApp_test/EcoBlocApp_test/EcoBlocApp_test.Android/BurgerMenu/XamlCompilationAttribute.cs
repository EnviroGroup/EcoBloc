using System;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Droid.BurgerMenu
{
    internal class XamlCompilationAttribute : Attribute
    {
        private XamlCompilationOptions compile;

        public XamlCompilationAttribute(XamlCompilationOptions compile)
        {
            this.compile = compile;
        }
    }
}