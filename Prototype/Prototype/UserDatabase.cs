using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Prototype
{
    public class UserDatabase
    {
        //hier wordt een connectie met SQlite gemaakt en wordt de tabel van de relevante database gegenereerd. 
        readonly SQLiteAsyncConnection udatabase;

        // De dbpath wordt door de localfilehelper samengevoegd met de filepath en dat is de plak waar de database aangemaakt of aangepast wordt.
        public UserDatabase(string dbPath)
        {
            udatabase = new SQLiteAsyncConnection(dbPath);
            udatabase.CreateTableAsync<User>().Wait();
        }
        // deze functie haalt de users op en voegt deze toe aan een lijst
        public Task<List<User>> GetUserAsync()
        {
            return udatabase.Table<User>().ToListAsync();
        }
        // deze functie haalt de meest recente user op (aangepast of nieuw)
        public Task<User> GetUserAsync(int id)
        {
            return udatabase.Table<User>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
        // deze functie voegt de nieuwe of aangepaste user toe aan de database
        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id == 0)
            {
                return udatabase.InsertAsync(user);
            }
            else
            {
                return udatabase.UpdateAsync(user);
            }
        }
        // deze functie verwijdert een userentry uit de database
        public Task<int> DeleteUserAsync(User user)
        {
            return udatabase.DeleteAsync(user);
        }
    }
}