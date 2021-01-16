using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Prototype
{
    public class UserDatabase
    {
        readonly SQLiteAsyncConnection udatabase;

        public UserDatabase(string dbPath)
        {
            udatabase = new SQLiteAsyncConnection(dbPath);
            udatabase.CreateTableAsync<User>().Wait();
        }

        public Task<List<User>> GetUserAsync()
        {
            return udatabase.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsync(int id)
        {
            return udatabase.Table<User>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
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
        public Task<int> DeleteUserAsync(User user)
        {
            return udatabase.DeleteAsync(user);
        }
    }
}