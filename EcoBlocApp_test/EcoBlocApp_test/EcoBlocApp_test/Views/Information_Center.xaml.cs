using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Information_Center : ContentPage
    {
        public Information_Center()
        {
            InitializeComponent();
          //  ScaleTo2x(image);
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new InformationCenterViewModel(Navigation);


        }

       // public void ScaleTo2x(Image image)
       // {
         //   var animation = new Animation(v => image.Scale = v, 1, 2);
         //   animation.Commit(this, "ScaleIt", length: 2000, easing: Easing.Linear,
           //     finished: (v, c) => image.Scale = 1, repeat: () => true);
      //  }

    }
}