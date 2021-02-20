using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcoBlocApp_test.ViewModels;

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
        public class ReportInformation
        {
            public string ReportID { get; set; }
            public string ReportName { get; set; }
            public string DisplayName { get; set; }
        }
        public string Dumpsite1 { get; set; }
        public string Dumpsite1ColumnName { get; set; }
        public string Dumpsite1Flag { get; set; }
        public string Dumpsite2 { get; set; }
        public string Dumpsite2ColumnName { get; set; }
        public string Dumpsite2Flag { get; set; }
        public string Dumpsite3 { get; set; }
        public string Dumpsite3ColumnName { get; set; }
        public string Dumpsite3Flag { get; set; }
        public string Dumpsite4 { get; set; }
        public string Dumpsite4ColumnName { get; set; }
        public string Dumpsite4Flag { get; set; }
        public string Dumpsite5 { get; set; }
        public string Dumpsite5ColumnName { get; set; }
        public string Dumpsite5Flag { get; set; }
        public string Dumpsite6 { get; set; }
        public string Dumpsite6ColumnName { get; set; }
        public string Dumpsite6Flag { get; set; }
        public string Dumpsite7 { get; set; }
        public string Dumpsite7ColumnName { get; set; }
        public string Dumpsite7Flag { get; set; }
        public string Dumpsite8 { get; set; }
        public string Dumpsite8ColumnName { get; set; }
        public string Dumpsite8Flag { get; set; }
        public string Dumpsite9 { get; set; }
        public string Dumpsite9ColumnName { get; set; }
        public string Dumpsite9Flag { get; set; }
        public string Dumpsite10 { get; set; }
        public string Dumpsite10ColumnName { get; set; }
        public string Dumpsite10Flag { get; set; }
        public string Dumpsite11 { get; set; }
        public string Dumpsite11ColumnName { get; set; }
        public string Dumpsite11Flag { get; set; }
        public string Dumpsite12 { get; set; }
        public string Dumpsite12ColumnName { get; set; }
        public string Dumpsite12Flag { get; set; }
        public string Dumpsite13 { get; set; }
        public string Dumpsite13ColumnName { get; set; }
        public string Dumpsite13Flag { get; set; }
        public string Dumpsite14 { get; set; }
        public string Dumpsite14ColumnName { get; set; }
        public string Dumpsite14Flag { get; set; }
        public string Dumpsite15 { get; set; }
        public string Dumpsite15ColumnName { get; set; }
        public string Dumpsite15Flag { get; set; }
        public string Dumpsite16 { get; set; }
        public string Dumpsite16ColumnName { get; set; }
        public string Dumpsite16Flag { get; set; }
        public string Dumpsite17 { get; set; }
        public string Dumpsite17ColumnName { get; set; }
        public string Dumpsite17Flag { get; set; }
        public string Dumpsite18 { get; set; }
        public string Dumpsite18ColumnName { get; set; }
        public string Dumpsite18Flag { get; set; }
        public string Dumpsite19 { get; set; }
        public string Dumpsite19ColumnName { get; set; }
        public string Dumpsite19Flag { get; set; }
        public string Dumpsite20 { get; set; }
        public string Dumpsite20ColumnName { get; set; }
        public string Dumpsite20Flag { get; set; }

        private struct Grid()
            {
            Grid grid = new Grid()
            { ColumnSpacing = 2 };
    }
    private interface columnCount;
    private List<GenericItem> genericItems { get; set; } = new List<GenericItem>();
    await PopulateGenericReport();
    BuildGrid();
    if (genericItems != null && genericItems.Count>0)
        {
        GenericItem genericItems = genericItems[0];
    columnCount = 0;
        if(genericItems.Dumpsite1Flag=="1")
        {
        columnCount = ++;
        }
if (genericItems.Dumpsite2Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite3Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite4Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite5Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite6Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite7Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite8Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite9Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite10Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite11Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite12Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite13Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite14Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite15Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite16Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite17Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite18Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite19Flag == "1")
{
    columnCount++;
}
if (genericItems.Dumpsite20Flag == "1")
{
    columnCount++;
}
private void BuildGrid()
{
    GridHolder.Children.Clear();
    CreateGrid();
    PopulateGrid();
    GridHolder.Children.Add(grid);
}
private void CreateGrid()
{
    grid = new Grid();
    BuildGrid.RowDefinitions.Clear();
    BuildGrid.ColumnDefinitions.Clear();
    
    for(int i=0; i<genericItems.Count; i++)
    {
        BuildGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnit Type.Auto) });
    }
    for (int j = 0; j , columnCount;j++)
{
    BuildGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
}
        }
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "1")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "2")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "2")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "3")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "4")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "5")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "6")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "7")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "8")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "9")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "10")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "11")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "12")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "13")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "14")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "15")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "16")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "17")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "18")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "19")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
foreach (GenericItem genericDisplayItem in genericItems)
{
    column = 0;
    if (genericItems.Property1Flag == "20")
    {
        headerLabel = new Label { Text = genericItems{ genericItems Counter }.Property1ColumnName };
        BuildGrid.Children.Add(headerLabel, column, 0);

        displayLabel = new Label { Text = genericItems[genericItemsCounter].Property1 };
        displayLabel.VerticalOptions = LayoutOptions.Center;
        displayLabel.FontSize = 10;
        grid.Children.Add(displayLabel, column++, row);
    }
}
private void HandleMoreButtonClicked(object sender, EventArgs e)
{
    Button the button = (Button)sender;
    int row = BuildGrid.GetRow(theButton);
    for(int i =0; i< genericItems.Count;i++)
    {
        if(i==row-1)
        {
            GenericItem genericItem = genericItems[i];
            Navigation.PushAsync(new GenricDetailPage(genericItem));
        }
    }
}