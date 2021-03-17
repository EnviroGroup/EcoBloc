using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.Views;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    //dont forgot to add an alert to say thank you for reporting

    public class ReportPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        

        public ICommand ReportCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }
        public ICommand GetLocationCommand { get; private set; }
        public ICommand GetImageCommand { get; private set; }


        private ReportedDumpsite _reportedDumpsite;

        public ReportedDumpsite ReportedDumpsite
        {
            get
            {

                return _reportedDumpsite;
            }
            set
            {
                _reportedDumpsite = value;
                NotifyPropertyChanged("ReportedDumpsite");
            }
        }

        private string _comment;

        public string Comment
        {
            get
            {

                return _comment;
            }
            set
            {
                _comment = value;
                NotifyPropertyChanged("Comment");
            }
        }

        private ImageSource _image;

        public ImageSource Image
        {
            get
            {

                return _image;
            }
            set
            {
                _image = value;
                NotifyPropertyChanged("Image");
            }
        }

        private bool _rubble;

        public bool Rubble
        {
            get
            {

                return _rubble;
            }
            set
            {
                _rubble = value;
                NotifyPropertyChanged("Rubble");
            }
        }

        private bool _ewaste;

        public bool Ewaste
        {
            get
            {

                return _ewaste;
            }
            set
            {
                _ewaste = value;
                NotifyPropertyChanged("Ewaste");
            }
        }

        private bool _plastic;

        public bool Plastic
        {
            get
            {

                return _plastic;
            }
            set
            {
                _plastic = value;
                NotifyPropertyChanged("Plastic");
            }
        }

        private bool _mixture;

        public bool Mixture
        {
            get
            {

                return _mixture;
            }
            set
            {
                _mixture = value;
                NotifyPropertyChanged("Mixture");
            }
        }

        private string _photo;

        public string Photo
        {
            get
            {

                return _photo;
            }
            set
            {
                _photo = value;
                NotifyPropertyChanged("Photo");
            }
        }

        public ReportPageViewModel()
        {

        }

        public ReportPageViewModel(INavigation navigation)
        {
            

            _navigation = navigation;
            GetImageCommand = new Command(() => UploadPicture());
            GetLocationCommand = new Command(() => GetLocation());
            ReportCommand = new Command(() => Report());
            CancelCommand = new Command(() => Cancel());

            Image = "dumpsite.jpg";

        }

        public async void UploadPicture()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                //await DisplayAlert("No Camera", ":( No camera available.", "OK");
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

            //ImageSource = "dumpsite.png";

            Photo = ConvertPhotoToString(file.GetStream());

            Image = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();

                return stream;
            });

            
        }


        


        public string ConvertPhotoToString(Stream stream)
        {
            byte[] bytesInStream = new byte[stream.Length];

            stream.Read(bytesInStream, 0, (int)bytesInStream.Length);




            // Convert byte[] to Base64 String
            string base64String = Convert.ToBase64String(bytesInStream);

            //Photo photo = new Photo();

            //photo.StoredImage = base64String;
            // App._sQLiteDatabase.AddPhoto(photo);

            return base64String;

        }

        public void LoadPhoto()
        {
            string base64String = App._sQLiteDatabase.GetPhoto();
            //revert
            byte[] otherByteArray = Convert.FromBase64String(base64String);

            MemoryStream newStream = new MemoryStream(otherByteArray);



            




        }



        public async void GetLocation()
        {
            await _navigation.PushAsync(new LocateDumpsiteMap());
        }

        public async void Report()
        {


            string wasteTypes = "paper"; //need to link the check boxes with a variable
            string address = "123 road";
            

            App._sQLiteDatabase.UpdatePlaceHolderDumpsite(Photo, Comment, wasteTypes, address);


            bool check = App._sQLiteDatabase.AddReportedDumpsite();

            if (check == true)
            {
                // an await a pop up screen to say that they made a successful report
                await _navigation.PopAsync();
            }
            else
            {
                //add pop up for the failure 
            }


            
        }

        public async void Cancel()
        {
            await _navigation.PopAsync();
        }

    }
}
