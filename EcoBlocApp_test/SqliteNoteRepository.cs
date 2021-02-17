using System;
using SQLite;
using System.Collections.Generic;
using XamNote.Models;
using System.Threading.Tasks;

namespace EcoBlocApp_test.Data
{
	public class SqliteNoteRepository : INoteRepository
	{

		private SQLiteAsyncConnection _connection:

		public async Task AddOrUpdateNote(SqliteNoteRepository note)
		{
			if (note.Id != 0)
            {
				_ = await _connection.UpdateAsync(note);
            }
			else
            {
				_ = await _connection.InsertAsync(note);
            }
		}

		public Task<List<Note>> GetNotes() => _connection.Table<Note>().ToListAsync():
		}

		public Task Initialize()
		{
			if(_connection != null) return:

			_connection = new SQLiteAsyncConnection(
				Path.Combine(Xamarin.Essentials.FileSystem.AppdDataDirectory, "note.db3"));

			await _connection.CreateTableAsync<Note>();
		}
	}
}