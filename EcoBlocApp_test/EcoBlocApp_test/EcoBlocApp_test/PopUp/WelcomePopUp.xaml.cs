using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePopUp : PopupPage
    {
        private bool off;
        public WelcomePopUp()
        {
            InitializeComponent();
            BindingContext = new WelcomeVM();
            off = true;
            AnimateHand(hand);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            off = false;
            // await News();
        }
        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();
        }

        public void AnimateHand(Image image)
        {
            

            new Animation {
        { 0, 0.125, new Animation(v => image.TranslationX = v, 0, -13) },
        { 0.125, 0.250, new Animation(v => image.TranslationX = v, -13, 13) },
        { 0.125, 0.250, new Animation(v => image.Rotation = v, -13, 13) },
        { 0.250, 0.375, new Animation(v => image.TranslationX = v, 13, -11) },
         { 0.250, 0.375, new Animation(v => image.Rotation = v, 13, -11) },
        { 0.375, 0.5, new Animation(v => image.TranslationX = v, -11, 11) },
        { 0.375, 0.5, new Animation(v => image.Rotation = v, -11, 11) },
        { 0.5, 0.625, new Animation(v => image.TranslationX = v, 11, -7) },
        { 0.625, 0.75, new Animation(v => image.TranslationX = v, -7, 7) },
        { 0.625, 0.75, new Animation(v => image.Rotation = v, -7, 7) },
        { 0.75, 0.875, new Animation(v => image.TranslationX = v, 7, -5) },
        { 0.75, 0.875, new Animation(v => image.Rotation = v, 7, -5) },
        { 0.875, 1, new Animation(v => image.TranslationX = v, -5, 0) }
    }
    .Commit(this, "AppleShakeChildAnimations", length: 1000, easing: Easing.Linear, finished: (x, y) => off = false, repeat: () => true);
        }
    }

    
}