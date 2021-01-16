using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Prototype
{
    public class MetingDatabase
    {
        //hier wordt een connectie met SQlite gemaakt en wordt de tabel van de relevante database gegenereerd. 
        readonly SQLiteAsyncConnection database;

        // De dbpath wordt door de localfilehelper samengevoegd met de filepath en dat is de plak waar de database aangemaakt of aangepast wordt.

        // deze functie haalt de meest recente meting op (aangepast of nieuw) en voegt deze toe aan de lijst
        public MetingDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Meting>().Wait();
        }
        // deze functie haalt de metingen op en voegt deze toe aan een lijst
        public Task<List<Meting>> GetMetingAsync()
        {
            return database.Table<Meting>().ToListAsync();
        }
        // deze functie haalt de meest recente meting op (aangepast of nieuw)
        public Task<Meting> GetMetingAsync(int id)
        {
            return database.Table<Meting>().Where(i => i.MeetId == id).FirstOrDefaultAsync();
        }
        // deze functie voegt de nieuwe of aangepaste meting toe aan de database
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
        // deze functie verwijdert een Meting entry uit de database
        public Task<int> DeleteMetingAsync(Meting meting)
        {
            return database.DeleteAsync(meting);
        }
    }
}