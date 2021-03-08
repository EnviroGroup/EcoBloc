using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.ViewModels;
using Plugin.Media;
using Xamarin.Essentials;
using System.IO;
using Plugin.Media.Abstractions;

namespace EcoBlocApp_test.Views
{ 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DumpsiteReportPage : ContentPage
    {
        public DumpsiteReportPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = new ReportPageViewModel(Navigation);
            }
            
private void ReadXmlButton_Click(object sender, EventArgs e)
{
    string filePath = "Complete path where you saved the XML file";

    AuthorsDataSet.ReadXml(filePath);

    dataGridView1.DataSource = AuthorsDataSet;
    dataGridView1.DataMember = "authors";
}

      private void ShowSchemaButton_Click(object sender, EventArgs e)
{
    System.IO.StringWriter swXML = new System.IO.StringWriter();
    AuthorsDataSet.WriteXmlSchema(swXML);
    textBox1.Text = swXML.ToString();
}

public void WriteXml (System.IO.TextWriter? writer, System.Data.XmlWriteMode mode);
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
}
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

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                
                return stream;
            });
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
}
