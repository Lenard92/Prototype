using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Prototype
{
    public class MetingDatabase
    {
        readonly SQLiteAsyncConnection database;

        public MetingDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Meting>().Wait();
        }

        public Task<List<Meting>> GetMetingAsync()
        {
            return database.Table<Meting>().ToListAsync();
        }

        public Task<Meting> GetMetingAsync(int id)
        {
            return database.Table<Meting>().Where(i => i.MeetId == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveMetingAsync(Meting meting)
        {
            if (meting.MeetId == 0)
            {
                return database.InsertAsync(meting);
            }
            else
            {
                return database.UpdateAsync(meting);
            }
        }
        public Task<int> DeleteMetingAsync(Meting meting)
        {
            return database.DeleteAsync(meting);
        }
    }
}