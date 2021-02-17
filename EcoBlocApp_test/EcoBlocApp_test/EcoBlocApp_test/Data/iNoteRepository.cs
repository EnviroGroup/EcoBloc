using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamNote.Models;
using Xamarin.forms;

namespace EcoBlocApp_test.Data
{
    public interface INoteRepository
    {
        Task Initialize();
        Task<List<Note>> GetNotes();
        Task AddOrUpdateNote(Note note);
    }
}