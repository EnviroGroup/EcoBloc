using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using EcoBlocApp_test.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using static EcoBlocApp_test.Models.News;

namespace EcoBlocApp_test.ViewModels
{
    public class NewsArticleVM : BaseViewModel
    {


        private INavigation _navigation;


        

        private Article _article;

        public Article Article
        {
            get
            {


                return _article;
            }
            set
            {
                _article = value;
                NotifyPropertyChanged("Article");
            }

        }

        private string _picture;

        public string Picture
        {
            get
            {


                return _picture ;
            }
            set
            {
                _picture = value;
                NotifyPropertyChanged("Picture");
            }

        }

        private string _heading;

        public string Heading
        {
            get
            {


                return _heading;
            }
            set
            {
                _heading = value;
                NotifyPropertyChanged("Heading");
            }

        }

        private string _summary;

        public string Summary
        {
            get
            {


                return _summary;
            }
            set
            {
                _summary = value;
                NotifyPropertyChanged("Summary");
            }

        }



        public NewsArticleVM()
        {

        }

        public NewsArticleVM(INavigation navigation, Article article)
        {
            _navigation = navigation;
            Article = new Article();
            Article = article;
            Picture = Article.media;
            Heading = Article.title;
            Summary = Article.summary;
        }
    }
}
