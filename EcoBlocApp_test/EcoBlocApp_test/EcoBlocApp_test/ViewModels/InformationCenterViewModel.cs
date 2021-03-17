using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using EcoBlocApp_test.Models;
using System.Collections.ObjectModel;
using EcoBlocApp_test.Views;
using System.Windows.Input;

namespace EcoBlocApp_test.ViewModels
{
    public class InformationCenterViewModel : BaseViewModel
    {
        private INavigation _navigation;



     

        public ICommand GeneralInformationCommand { get; set; }
        public ICommand SustainablePracticesCommand { get; set; }
        public ICommand DirectoryCommand { get; set; }
        public ICommand IDWasteCommand { get; set; }
        public ICommand DisposeWasteCommand { get; set; }
        //public ICommand WasteManagementCommand { get; set; }
        public ICommand EnvironmentalSustainabilityCommand { get; set; }
        public ICommand RecyclingCommand { get; set; }
        public ICommand BackCommand { get; set; }

       



        public InformationCenterViewModel()
             {
      
             }



 

        //public async void SaveButton()
            //{
               //await _navigation.PopAsync();
            
    //      }

        

        public InformationCenterViewModel(INavigation navigation)
        {
        
            _navigation = navigation;

            GeneralInformationCommand = new Command(() => GeneralInformationPage());
            SustainablePracticesCommand = new Command(() => SustainablePracticesPage());
            DirectoryCommand = new Command(() => DirectoryPage());
            IDWasteCommand = new Command(() => IDWastePage());
            DisposeWasteCommand = new Command(() => DisposeWastePage());
           // WasteManagementCommand = new Command(() => WasteManagementPage());
            EnvironmentalSustainabilityCommand = new Command(() => EnvironmentalSustainabilityPage());
            RecyclingCommand = new Command(() => RecyclingPage());

           
        }

        public async void GeneralInformationPage()
        {


            await _navigation.PushAsync(new GeneralInformation());
        }
        public async void SustainablePracticesPage()
        {

            await _navigation.PushAsync(new SustainablePractices());
        }
        public async void DirectoryPage()
        {

            await _navigation.PushAsync(new Directory());
        }
        public async void IDWastePage()
        {

            await _navigation.PushAsync(new WasteTypes());
        }
        public async void DisposeWastePage()
        {

            await _navigation.PushAsync(new DisposingWaste());
        }
       /* private void WasteManagementPage()
        {

            await _navigation.PushAsync(new SolidWasteManagement());
        }*/
        public async void EnvironmentalSustainabilityPage()
        {

            await _navigation.PushAsync(new EnvironmentalSustainability());
        }
        public async void RecyclingPage()
        {

            await _navigation.PushAsync(new Recycling());
        }
    }
}
