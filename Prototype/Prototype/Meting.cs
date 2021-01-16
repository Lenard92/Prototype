using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Prototype
{
    public class Meting
    {
        [PrimaryKey, AutoIncrement]
        public int MeetId { get; set; }
        public string GrasMeting { get; set; }
        public string Eenheid { get; set; }
        public DateTime Dag { get; set; }
        
    }

}
