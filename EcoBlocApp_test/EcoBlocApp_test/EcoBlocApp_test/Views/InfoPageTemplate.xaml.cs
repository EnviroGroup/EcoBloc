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
using System.IO;
using EcoBlocApp_test.Models;
using EcoBlocApp_test.ViewModels;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPageTemplate : ContentPage
    {

        public InfoPageTemplate()
        {
            InitializeComponent();

            image.Source = "dumpsite.jpg";
            image2.Source = "dumpsite.jpg";



            ScaleTo2x(image);
            //ScaleTo2x(image2);


            
            


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new Class1();
           // await News();
        }

        public void ScaleTo2x(Image image)
        {
            var animation = new Animation(v => image.Scale = v, 1, 2);
            animation.Commit(this, "ScaleIt", length: 2000, easing: Easing.Linear,
                finished: (v, c) => image.Scale = 1, repeat: () => true);
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

            //await DisplayAlert("File Location", file.Path, "OK");

            //var imagefile = File.ReadAllBytes(file.Path);

            SavePhoto(file.GetStream());

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();

                

                return stream;
            });

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            LoadPhoto();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        public void SavePhoto(Stream stream)
        {
            byte[] bytesInStream = new byte[stream.Length];

            stream.Read(bytesInStream, 0, (int)bytesInStream.Length);

            


            // Convert byte[] to Base64 String
            string base64String = Convert.ToBase64String(bytesInStream);

            Photo photo = new Photo();

            photo.StoredImage = base64String;
            App._sQLiteDatabase.AddPhoto(photo);
            

           
        }

        public void LoadPhoto()
        {
            string base64String = App._sQLiteDatabase.GetPhoto();
            //revert
            byte[] otherByteArray = Convert.FromBase64String(base64String);

            MemoryStream newStream = new MemoryStream(otherByteArray);


           
            image2.Source = ImageSource.FromStream(() =>
            {
                Stream stream = newStream;

                return stream;
            });




        }
    }
}