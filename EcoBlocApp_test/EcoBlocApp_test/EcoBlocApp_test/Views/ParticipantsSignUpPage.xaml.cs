using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoBlocApp_test.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParticipantsSignUpPage : ContentPage
    {
        public ParticipantsSignUpPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new SignUpPageViewModel(Navigation);
            }
            
           public partial class Register : EcoBlocApp_test.Views

{
    static string name=string.Empty;
    static string pswd=string.Empty;
    static string age=string.Empty;
    static string mobile=string.Empty;
    static XmlNode root;
    static XmlNode xn; XmlDocument xdoc; 

protected void Page_Load(object sender, EventArgs e)
    {
        lblErrorPswd.Visible = false;
        name = txtUname.Text;
        if(Page.IsPostBack)
      {
          //confirm Password 
        if (txtPswd.Text == txtCpswd.Text)
         {
            pswd = txtPswd.Text;
            age = txtAge.Text; 
            mobile=txtMobile.Text;
         }
       else
         {
         lblError.Visible=True;
          }
      }    
    }
protected void butRegister_Click(object sender, EventArgs e)
    {
   string xmlpath = @"C:\Users\XMlRegister.xml";
   xdoc = new XmlDocument();
        
//XmlDeclartion class used to declare XML prolog
    XmlDeclaration xdeclartion = xdoc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
            root = xdoc.CreateElement("logindetails");
            xdoc.AppendChild(root);
            AppendXml(root);
            xdoc.Save(xmlpath);
            Response.Redirect("login.aspx");
        }
//Add Details
protected void AppendXml(XmlNode root)
    {
        XmlNode person = xdoc.CreateElement("person");
        root.AppendChild(person);
        XmlNode uname = xdoc.CreateElement("uname");
        uname.InnerText = name;
        person.AppendChild(uname);
        XmlNode psswd = xdoc.CreateElement("pswd");
        psswd.InnerText = pswd;
        person.AppendChild(psswd);
        XmlNode agge = xdoc.CreateElement("age");
        agge.InnerText = age;
        person.AppendChild(agge);
        XmlNode mob = xdoc.CreateElement("mobile");
        mob.InnerText = mobile;
        person.AppendChild(mob);
    }

        }
    }
}
