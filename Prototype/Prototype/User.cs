using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Prototype
{
    public class User
    {
        // De user struct met unieke key
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // zodat de gegevens niet door elkaar gehaald worden tijdens de passwordcheck
        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        // deze functie checkt of een entry leeg is of niet.
        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
