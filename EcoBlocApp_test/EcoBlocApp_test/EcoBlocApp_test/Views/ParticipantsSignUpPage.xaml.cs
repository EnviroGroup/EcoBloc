using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static EcoBlocApp_test.Views.ParticipantsSignUpPage.ParticipantsSignUp;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParticipantsSignUpPage : ContentPage
    {
        public ParticipantsSignUpPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new SignUpPageViewModel(Navigation);
        }

        public class SignUpPageViewMode : List<ParticipantsSignUpPage>
        {

            public string Title { get; set; }
            public string ShortName { get; set; }// used for jump lists
            public string Subtitle { get; set; }
            private ParticipantsSignUpPage(string title; string shortName;)
            {


                Title = title;
                ShortName = shortName;
                }

        private static IList<ParticipantsSignUpPage> all;

        public static IList<ParticipantsSignUpPage> GetAll()
        {
            return all;
        }

        private static void SetAll(IList<ParticipantsSignUpPage> value)
        {
            all = value;
        }
    }

    public static IList<ParticipantsSignUpPage> All { private get; set; }
    static ParticipantsSignUpPage()
    {
        List < ParticipantsSignUpPage > = List < participantsSignUpPage >
      


        {
            new EventParticipant ("Name","Surname")
            {
                new EventParticipant ("Amelia","Cedar", new SwitchCell(),""),

             new EventParticipat("AlFie", "Pine", new SwitchCell(), ""),
             },
            new EventName
        
    

            
        }
    }

    }

