using EcoBlocApp_test.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcoBlocApp_test.Views.BurgerMenu
{
    class FlyOutVM : BaseViewModel
    {
        

        private List<FlyOutItem> _flyOutItems;

        public List<FlyOutItem> FlyOutItems
        {
            get
            {
                return _flyOutItems;
            }
            set
            {
                _flyOutItems = value;
                NotifyPropertyChanged("FlyOutItems");
            }

        }

        

        public FlyOutVM()
        {
            FlyOutItems = new List<FlyOutItem>();

            FlyOutItem Home = new FlyOutItem();

            Home.Title = "Home";
            Home.TargetType = typeof(MainTabbedPage);
            Home.Visable = true;

            FlyOutItems.Add(Home);


        }
    }
}
