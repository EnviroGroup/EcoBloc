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

        public class MyEvent : List<ParticipantsSignUpPage>
        {

            public string MyEventID { get; set; }
            public string Discription { get; set; }
            public int Participant { get; set; }
            private MyEvent(string MyEventID, string Discription)
            {
                MyEventID = myEventID;

                Discription = discription;
            }



            private static void SetAll(IList<MyEvent> value)
            {
                all = value;
            }
        }

        

}
        }
   