using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using Plugin.Media.Abstractions;
using EcoBlocApp_test.ViewModels;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Image = Xamarin.Forms.Image;

namespace EcoBlocApp_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DumpsiteReportPage : ContentPage
    {
        public EventHandler DynamicButton { get; set; }
        public object Controls { get; private set; }
        public EventHandler DynamicButton_Clicked { get; private set; }
        public ImageSource ImageSource { get; private set; }

        public DumpsiteReportPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new MapViewModel();



            /*public void WriteXml (System.IO.TextWriter? writer, System.Data.XmlWriteMode mode);
            {
            private void DupsiteReportPageReadWriteXMLDocumentWithFileStream()
            {
                // Create a DataSet with one table and two columns.
                DataSet originalDataSet = new DataSet("dataSet");
                DataTable table = new DataTable("table");
                DataColumn idColumn = new DataColumn("id",
                    Type.GetType("System.Int32"));
                idColumn.AutoIncrement= true;

                DataColumn itemColumn = new DataColumn("item");
                table.Columns.Add(idColumn);
                table.Columns.Add(itemColumn);
                originalDataSet.Tables.Add(table);


                DataRow newRow;
                for(int i = 0; i < 3; i++)
                {
                    newRow = table.NewRow();
                    newRow["item"]= "item " + i;
                    table.Rows.Add(newRow);
                }
                originalDataSet.AcceptChanges();


                // Print out values of each table in the DataSet
                // using the function defined below

                PrintValues(originalDataSet, "Original DataSet");

                // Write the schema and data to XML file with FileStream.
                string xmlFilename = "DumpsiteReportPage.xml";
                System.IO.FileStream streamWrite = new System.IO.FileStream
                    (xmlFilename, System.IO.FileMode.Create);

                originalDataSet.WriteXml(streamWrite);


                streamWrite.Close();


                originalDataSet.Dispose();

                DataSet newDataSet = new DataSet("New DataSet");


                System.IO.FileStream streamRead = new System.IO.FileStream
                    (xmlFilename,System.IO.FileMode.Open);
                newDataSet.ReadXml(streamRead);


                PrintValues(newDataSet,"New DataSet");
            }

            private void PrintValues(DataSet dataSet, string Dumpsiteb Report Page)
            {
                Console.WriteLine("\n" + Dumpsite Report Page);
                foreach(DataTable table in dataSet.Tables)
                {
                    Console.WriteLine("TableName: " + table.TableName);
                    foreach(DataRow row in table.Rows)
                    {
                        foreach(DataColumn column in table.Columns)
                        {
                            Console.Write("\table " + row[column] );
                        }
                        Console.WriteLine();
                    }
                }
            }
            }*/
            //PLEASE CHECK THIS
        }
          //  public Button CreateDynamicButton()
         //   {
          //      Button dynamicButton = new Button();
          //      dynamicButton.Clicked = new EventHandler(DynamicButton_Clicked);
          //  EventHandler() = dynamicButton<Button>;
          //  Button Button = button1;
            
          //  Type type = Controls.Add(Button);
          //      return dynamicButton;
          //  }

            private async void Button_Clicked(object sender, EventArgs e)
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("No Camera", ":( No camera available.", "OK");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    CompressionQuality = 50,
                    PhotoSize = PhotoSize.Custom,
                    CustomPhotoSize = 50,
                    Directory = "Sample",
                    Name = "test.jpg"
                });

                if (file == null)
                    return;

                await DisplayAlert("File Location", file.Path, "OK");

            //var imagefile = File.ReadAllBytes(file.Path);

            ImageSource = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();

                    return stream;
                });
                /*public class HomeController : Controller
               {
                   // GET: Home
                   public ActionResult Index()
                   {
                       List<CustomerModel> customers = new List<CustomerModel>();

                       //Load the XML file in XmlDocument.
                       XmlDocument doc = new XmlDocument();
                       doc.Load(Server.MapPath("~/XML/Customers.xml"));

                       //Loop through the selected Nodes.
                       foreach (XmlNode node in doc.SelectNodes("/Customers/Customer"))
                       {
                           //Fetch the Node values and assign it to Model.
                           customers.Add(new CustomerModel
                           {
                               CustomerId = int.Parse(node["Id"].InnerText),
                               Name = node["Name"].InnerText,
                               Country = node["Country"].InnerText
                           });
                       }

                       return View(customers);
                   }

                        }

                        public class CustomerModel
               {
                   ///<summary>
                   /// Gets or sets CustomerId.
                   ///</summary>
                   public int CustomerId { get; set; }

                   ///<summary>
                   /// Gets or sets Name.
                   ///</summary>
                   public string Name { get; set; }

                   ///<summary>
                   /// Gets or sets Country.
                   ///</summary>
                   public string Country { get; set; }
               }
                   }
                   public struct HyperlinkButton 
                       {
                   var hyperLinkButton = new HyperlinkButton();
               helpLinkButton.Content = "Green Scorpions";
               helpLinkButton.NavigateUri = new Uri(https://www.westerncape.gov.za/eadp/report-environmenenvironmentaltal-crimes);
                   }
                  return new Uri(https://www.westerncape.gov.za/eadp/report-environmenenvironmentaltal-crimes);  
               }
                                 private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

               private void InitializeComponent()
               {
                   this.reportViewer1 = new DumpsiteReportPage();
                   this.SuspendLayout();
                   // 
                   // reportViewer1
                   // 
                   this.reportViewer1.Location = new System.Drawing.Point(168, 132);
                   this.reportViewer1.Name = "reportPage1";
                   this.reportViewer1.ServerReport.BearerToken = null;
                   this.reportViewer1.Size = new System.Drawing.Size(396, 246);
                   this.reportViewer1.TabIndex = 0;
                   // 
                   // Form1
                   // 
                   this.Controls.Add(this.reportViewer1);
               }*/
            }
        }
    }
