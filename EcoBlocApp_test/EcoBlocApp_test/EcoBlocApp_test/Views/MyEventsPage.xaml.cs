
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyEventsPage : ContentPage
    {
        public MyEventsPage()
        {
<<<<<<< Updated upstream
            Label header = new Label
            {
                Text = "ListView",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            // Define some data.
            List<Person> people = new List<Person>
            {
                new Person("Abigail", new DateTime(1975, 1, 15), Color.Aqua),
                
            };

            // Create the ListView.
            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = people,

                // Define template for displaying each item.
                // (Argument of DataTemplate constructor is called for 
                //      each item; it must return a Cell derivative.)
                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Label birthdayLabel = new Label();
                    birthdayLabel.SetBinding(Label.TextProperty,
                        new Binding("event", BindingMode.OneWay,
                                    null, null, "Event {0:d}"));

                    BoxView boxView = new BoxView();
                    boxView.SetBinding(BoxView.ColorProperty, "Event");

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                boxView,
                                new StackLayout
                                {
                                    VerticalOptions = LayoutOptions.Center,
                                    Spacing = 0,
                                    Children =
                                    {
                                        nameLabel,
                                        birthdayLabel
                                    }
                                }
                            }
                        }
                    };
                }),

                Margin = new Thickness(10, 0)
            };

            // Build the page.
            Title = "ListView Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    listView
                }
            };
=======
            InitializeComponent();
>>>>>>> Stashed changes
        }

    }
}
    