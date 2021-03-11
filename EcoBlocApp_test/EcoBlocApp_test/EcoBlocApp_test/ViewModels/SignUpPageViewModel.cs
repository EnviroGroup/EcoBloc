using System;
using System.Data;
using System.Net.Mail;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EcoBlocApp_test.ViewModels
{
    public class SignUpPageViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public SignUpPageViewModel()
        {

        }

        public SignUpPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public SignUpPageViewModel(string v1, string v2)
        {
        }

        /*public partial class sign_up_form : SignUpPageViewModel
            {

                public sign_up_form()
                {
                    InitializeComponent();
                }

                private void btn_create_Click(object sender, EventArgs e)
                {
                    User users = new User();
                    users.fname = txt_fname.Text;
                    users.lname = txt_lname.Text;
                    users.username = txt_username.Text;
                    users.password = txt_password.Text;

                    XmlSerializer xs = new XmlSerializer(typeof(User));
                    using(FileStream fs = new FileStream("Data.xml", FileMode.Create))
                    {
                        xs.Serialize(fs, users);
                    }

                }
            }*/

    }


    
}
