using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamNote.Models;
<<<<<<< Updated upstream
using Xamarin.forms;
=======
>>>>>>> Stashed changes

namespace EcoBlocApp_test.Data
{
    public interface INoteRepository
    {
        Task Initialize();
        Task<List<Note>> GetNotes();
        Task AddOrUpdateNote(Note note);
    }
}