using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Prototype
{
    public class Meting
    {
        // een primary key en autoincrement zijn niet noodzakelijk, maar wel goodpractices bij het vormgeven van een gestructureerde database, zeker ook wanneer deze meerdere tables krijgt. 
        //Autoincrement wil zeggen dat elke nieuwe entry een unieke key krijgt in de vorm van een MeetId

        [PrimaryKey, AutoIncrement]
        public int MeetId { get; set; }
        public string GrasMeting { get; set; }
        public string Eenheid { get; set; }
        // De Dag property van meetgegevens kan op twee manieren ingevuld worden (savebutton of kalanderselectie), zie Readme @ github voor een gedetailleerde uitleg
        public DateTime Dag { get; set; }
        
    }

}
