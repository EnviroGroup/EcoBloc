using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;
using static EcoBlocApp_test.Models.News;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.Services;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsFeed : ContentPage
    {
        List<Article> articles;

        public NewsFeed()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await News();

            BindingContext = new NewsFeedViewModel(Navigation,articles);


        }

        public async Task News()
        {


            var newstemp = new GetNews();
           articles =  await newstemp.GetNewsArticles();
        }
    }
}