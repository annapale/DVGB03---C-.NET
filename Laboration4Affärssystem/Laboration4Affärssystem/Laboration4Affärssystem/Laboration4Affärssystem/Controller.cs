using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Laboration4Affärssystem
{
    internal class Controller
    {
        public BindingList<Book> bookList = new BindingList<Book>();
        public BindingSource bookSource = new BindingSource();

        public BindingList<Videogame> gameList = new BindingList<Videogame>();
        public BindingSource gameSource = new BindingSource();

        public BindingList<Film> filmList = new BindingList<Film>();
        public BindingSource filmSource = new BindingSource();


        public void createBookList()
        {
            bookList.Add(new Book(124, "One Piece", 70, "Eichhiro Oda", "Shonen", "Manga", "German"));
            bookSource.DataSource = bookList;
        }

        public BindingList<Videogame> createGameList()
        {
            gameSource.DataSource = gameList;

            return gameList;
        }

        public BindingList<Film> createFilmList()
        {
           
            filmSource.DataSource = filmList;

            return filmList;
        }
    }
}
