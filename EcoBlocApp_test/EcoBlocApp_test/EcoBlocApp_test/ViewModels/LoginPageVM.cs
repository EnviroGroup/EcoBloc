using EcoBlocApp_test.Models;
using EcoBlocApp_test.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using EcoBlocApp_test.Views.BurgerMenu;
using EcoBlocApp_test.Views;
using System.Data;
using System.Net.Mail;
using EcoBlocApp_test.PopUp;
using Rg.Plugins.Popup.Services;

namespace EcoBlocApp_test.ViewModels
{
    class LoginPageVM : BaseViewModel
    {

        SQLiteDatabase _sQLiteDatabase;

        private INavigation _navigation;

        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }



        private string placeHolder;
        public string PlaceHolder
        {
            get { return placeHolder; }
            set
            {
                placeHolder = value;
                NotifyPropertyChanged("PlaceHolder");
            }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                NotifyPropertyChanged("UserName");
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }
        public ICommand SubmitCommand { protected set; get; }
        public ICommand RegisterCommand { protected set; get; }
        public ICommand ContinueCommand { protected set; get; }


        public LoginPageVM()
        {

        }

        public LoginPageVM(INavigation navigation)
        {
            _sQLiteDatabase = new SQLiteDatabase();
            User = new User();
            _navigation = navigation;
            SubmitCommand = new Command(() => OnSubmit());
            RegisterCommand = new Command(() => Register());
            ContinueCommand = new Command(() => AnonMode());

            UserName = "Bob123";
            Password = "Ibuildthings";
            PlaceHolder = "Enter Text Here";
            
        }
        public async void OnSubmit()
        {
            var tempAns = _sQLiteDatabase.CheckUser(Password, UserName);

            if (tempAns == true)
            {
                User = _sQLiteDatabase.GetUser(Password, UserName);


                _sQLiteDatabase.AddTempUser(User);

                var page = new WelcomePopUp();

                await PopupNavigation.Instance.PushAsync(page);

                await _navigation.PushAsync(new FlyOutMainPage());
            }
            else
            {
                UserName = null;
                Password = null;
                PlaceHolder = "Incorrect Username or Password!!!";
            }

        }

        public async void Register()
        {
            await _navigation.PushAsync(new RegisterPage());
        }

        public async void AnonMode()
        {

            User.FirstName = "Anon";

            _sQLiteDatabase.AddTempUser(User);
            await _navigation.PushAsync(new FlyOutMainPage());
        }

        /*
                protected void btnSubmit_Click(object sender, EventArgs e)
        {
        try
        {//SQL database information needed here 
        DataSet ds = new DataSet();
        using (SqlConnection con = new SqlConnection("Data Source=Username;Integrated Security=true;Initial Catalog=DBnamespace"))
        {
        con.Open()
        SqlCommand cmd = new SqlCommand("SELECT UserName,Password FROM UserInfo Where Email= '" + txtEmail.Text.Trim() + "'", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        }
        if(ds.Tables[0].Rows.Count>0)
        {
        MailMessage Msg = new MailMessage();
        // Sender e-mail address.
        Msg.From = new MailAddress(txtEmail.Text);
        // Recipient e-mail address.
        Msg.To.Add(txtEmail.Text);
        Msg.Subject = "Your Password Details";
        Msg.Body = "Hi, <br/>Please check your Login Detailss<br/><br/>Your Username: " + ds.Tables[0].Rows[0]["UserName"] + "<br/><br/>Your Password: " + ds.Tables[0].Rows[0]["Password"] + "<br/><br/>";
        Msg.IsBodyHtml = true;
        // your remote SMTP server IP.The Simple Mail Transfer Protocol must be set up by us via Gmail 
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential ("yourusername@gmail.com", "yourpassword");
        smtp.EnableSsl = true;
        smtp.Send(Msg);
        //Msg = null;
        lbltxt.Text = "Your Password Details Sent to your mail";
        // Clear the textbox valuess
        txtEmail.Text = "";
        }
        else
        {
        lbltxt.Text = "The Email you entered not exists.";
        }
        }
        catch (Exception ex)
        {
        Console.WriteLine("{0} Exception caught.", ex);
        }
        }
        }


            }*/
    }
}
