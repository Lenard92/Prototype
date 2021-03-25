using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FeedCalculator
{
    public class Animal
    {


        // De user struct met unieke key
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Dier { get; set; }
        public string Behoefte { get; set; }
        public int CP { get; set; }
        public int CA { get; set; }
        public int CH { get; set; }
        public int PH { get; set; }
    }
}
    