using EcoBlocApp_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static EcoBlocApp_test.Models.News;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsArticle : ContentPage
    {
        public NewsArticle()
        {
            InitializeComponent();
            
        }

        public NewsArticle(INavigation navigation, Article article)
        {
            InitializeComponent();
            BindingContext = new NewsArticleVM(Navigation, article);

        }
        

    }
}