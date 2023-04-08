using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration4Affärssystem.Model
{
    public class Inventory
    {
        public BindingList<Book> bookList = new BindingList<Book>();
        

        public BindingList<Videogame> gameList = new BindingList<Videogame>();
        

        public BindingList<Film> filmList = new BindingList<Film>();
        
    }
}
