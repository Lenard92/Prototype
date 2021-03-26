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
        public string Dier { get; set; }
        public int Id { get; set; }
        public int CP { get; set; }
        public int CH  { get; set; }
        public int CA { get; set; }
        public int PH { get; set; }
        public DateTime Dag { get; set; }

    // zodat de gegevens niet door elkaar gehaald worden tijdens de passwordcheck
    public User() { }
        public User(string Username)
        {
            this.Dier = Username;
            
        }

        // deze functie checkt of een entry leeg is of niet.
        public bool CheckInformation()
        {
            if (!this.Dier.Equals("Poultry") )
                return true;
            else
                return false;
        }
    }
}
