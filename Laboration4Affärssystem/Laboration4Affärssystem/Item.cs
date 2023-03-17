using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4Affärssystem
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //Constructor Item
        public Item(int id, string name, int price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }


    public class Book : Item 
    { 
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }


        //Constructor Book
        public Book(int id, string name, int price, string author, string genre, string format, string language) : base(id, name, price)
        { 
            Author = author;
            Genre = genre;
            Format = format;
            Language = language;
        }
    }

    public class Videogame : Item
    {
        private string Plattform { get; set; }

        //Contructor Videogame
        public Videogame(int id, string name, int price, string plattform) : base(id, name, price)
        {
            Plattform = plattform;
        }
    }

    public class Film : Item
    {
        private string Format { set; get; }
        private string Time { set; get; }

        //Constructor Film
        public Film (int id, string name, int price, string format, string time) : base(id, name, price)
        {
            Format = format;
            Time = time;
        }
    }

    

}
