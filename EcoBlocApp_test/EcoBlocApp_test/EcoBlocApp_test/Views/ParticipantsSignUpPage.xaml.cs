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

        public class SignUpPageViewModel : List<ParticipantsSignUpPage>
        {

            public string Title { get; set; }
            public string ShortName { get; set; }// used for jump lists
            public string Subtitle { get; set; }
            private SignUpPageViewModel(string Title, string ShortName)
            {
                Title = title;
                ShortName = shortName;
            }



            private static void SetAll(IList<SignUpPageViewModel> value)
            {
                all = value;
            }
        }

        public static IList<SignUpPageViewModel> All { private get; set; }
        static SignUpPageViewModel()
        {
            List<SignUpPageViewModel> Groups = new List<SignUpPageViewModel>



            {
                new SignUpPageViewModel("Name", "Surname", "DOB")
                {
                    new PageModel("Amelia", "Cedar","1952/02/03", new SwitchCell(), ""),
                    new PageModel("Ben", "Able","1988/02/04", new SwitchCell(), ""),

                },

                All = Groups
            };


        }
       

}
        }
   