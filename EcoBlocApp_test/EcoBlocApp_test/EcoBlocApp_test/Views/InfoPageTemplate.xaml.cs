using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.Services;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPageTemplate : ContentPage
    {

        public InfoPageTemplate()
        {
            InitializeComponent();

            

            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await News();
        }

        public async Task News()
        {
            var newstemp = new GetNews();
            await newstemp.GetNewsArticles();
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

           // image.Source = ImageSource.FromStream(() =>
           // {
            //    var stream = file.GetStream();
            //
             //   return stream;
           // });

        }   
    }
}