using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.ViewModels;
using Plugin.Media;
using Xamarin.Essentials;
using System.IO;
using Plugin.Media.Abstractions;

namespace EcoBlocApp_test.Views
{ 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DumpsiteReportPage : ContentPage
    {
        public DumpsiteReportPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new ReportPageViewModel(Navigation);


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                CompressionQuality = 50,
                PhotoSize = PhotoSize.Custom,
                CustomPhotoSize = 50,
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");

            //var imagefile = File.ReadAllBytes(file.Path);

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
                return stream;
            });
        }
    }
}