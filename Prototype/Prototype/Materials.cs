using System;
using System.Collections.Generic;
using System.Text;

namespace FeedCalculator
{
    class Materials
    {
        // De user struct met unieke key
       // [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Material { get; set; }
        public string Voer { get; set; }
        public int CP { get; set; }
        public int CA { get; set; }
        public int CH { get; set; }
        public int PH { get; set; }
    }
}
