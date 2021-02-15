using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisioForge.Shared.MediaFoundation.OPM;
using Xamarin.Forms;

namespace Eco_Block
{
    
    private object e { get; set; }

    static TodoItemDatabase

 await Database.EnableWriteAheadLoggingAsync();

    static void string(Button() async e)
object Button()
    {
        throw new NotImplementedException();
    }

    Button saveButton = new Button { Text = "Save" };
    saveButton.Clicked += async (sender, e) =>
    {
        var todoItem = (TodoItem)BindingContext;
        await App.Database.SaveItemAsync(todoItem);
        await Navigation.PopAsync();
    };

}