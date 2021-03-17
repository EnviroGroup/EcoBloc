using EcoBlocApp_test.Models;
using EcoBlocApp_test.Views;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
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

            Image = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();

                return stream;
            });





            
        }

        public async void GetLocation()
        {
            await _navigation.PopAsync();
        }

        public async void Report()
        {
            await _navigation.PopAsync();
        }

        public async void Cancel()
        {
            await _navigation.PopAsync();
        }

    }
}
