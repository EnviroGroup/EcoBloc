using System;
using System.Data;
using System.Data.SqlClient;
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
        
public partial class sign_up_form : SignUpPageViewModel
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
    }
protected void btnSubmit_Click(object sender, EventArgs e)
{
try
{
DataSet ds = new DataSet();
using (SqlConnection con = new SqlConnection("Data Source=SureshDasari;Integrated Security=true;Initial Catalog=MySampleDB"))
{
con.Open();
SqlCommand cmd = new SqlCommand("SELECT UserName,Password FROM UserInfo Where Email= '" + txtEmail.Text.Trim() + "'", con);
SqlDataAdapter da = new SqlDataAdapter(cmd);
da.Fill(ds);
con.Close();
}
if(ds.Tables[0].Rows.Count>0)
{
MailMessage Msg = new MailMessage();

Msg.From = new MailAddress(txtEmail.Text);
// Recipient e-mail address.
Msg.To.Add(txtEmail.Text);
Msg.Subject = "Your Password Details";
Msg.Body = "Hi, <br/>Please check your Login Detailss<br/><br/>Your Username: " + ds.Tables[0].Rows[0]["UserName"] + "<br/><br/>Your Password: " + ds.Tables[0].Rows[0]["Password"] + "<br/><br/>";
Msg.IsBodyHtml = true;
// your remote SMTP server IP. not 100% sure on details
SmtpClient smtp = new SmtpClient();
smtp.Host = "smtp.gmail.com";
smtp.Port = 587;
smtp.Credentials = new System.Net.NetworkCredential ("yourusername@gmail.com", "yourpassword");
smtp.EnableSsl = true;
smtp.Send(Msg);

lbltxt.Text = "Your Password Details Sent to your mail";

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

        //public async void AddButton()
        // {
        //    await _navigation.PushAsync(new NewOrder()); ;
        //}

        //public async void SaveButton()
        //{
        //   await _navigation.PopAsync();
        //
        // }

    }
}
