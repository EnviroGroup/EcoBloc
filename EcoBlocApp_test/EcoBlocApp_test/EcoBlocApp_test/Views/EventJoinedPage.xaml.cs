using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventJoinedPage : ContentPage
    {
        public EventJoinedPage()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new EventJoinedViewModel(Navigation);


        }
        public partial class NoteView : ContentPage
        {
            public NoteView(NoteViewModel noteViewModel)
            {
                InitializeComponent();

                noteViewModel.Navigation = Navigation;
                BindingContext = noteViewModel;
            }
        }
>>>>>>> Stashed changes
    }

}
}