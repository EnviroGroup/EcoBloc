using EcoBlocApp_test.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using static EcoBlocApp_test.Models.News;

namespace EcoBlocApp_test.ViewModels
{
    public class NewsFeedViewModel : BaseViewModel
    {
        private INavigation _navigation;


        List<Article> templist;

        private ObservableCollection<Article> _articles;

        public ObservableCollection<Article> Articles
        {
            get
            {


                return _articles;
            }
            set
            {
                _articles = value;
                NotifyPropertyChanged("Articles");
            }

        }

        private Article _selectedArticle;
        public Article SelectedArticle
        {
            get { return _selectedArticle; }
            set
            {
                _selectedArticle = value;
                NotifyPropertyChanged("SelectedArticle");




                if (_selectedArticle != null)
                {

                    GoToArticle(_selectedArticle);
               
                }




            }
        }

      

        public NewsFeedViewModel()
        {

        }

        public NewsFeedViewModel(INavigation navigation, List<Article> articles)
        {
            _navigation = navigation;

            templist = articles;

            Articles = new ObservableCollection<Article>(templist);

        }


        private async void GoToArticle(Article selectedArticle)
        {
            SelectedArticle = null;
            await _navigation.PushAsync(new NewsArticle(_navigation, selectedArticle));
        }

    }
}
