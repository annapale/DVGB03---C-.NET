using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4Affärssystem
{
    public class Item
    {
        private int ID { get; set; }
        private string name { get; set; }
        private string price { get; set; }
    }


    public class Book : Item 
    { 
        private string author { get; set; }
        private string genre { get; set; }
        private string format { get; set; }
        private string language { get; set; }
    }

    public class Videogame : Item
    {
        private string plattform { get; set; }
    }

    public class Film : Item
    {
        private string format { set; get; }
        private string time { set; get; }
    }

    

}
