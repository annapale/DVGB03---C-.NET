using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

        public void addBook(int id, string name, int price, int amount, string author, string genre, string format, string language)
        {
            bookList.Add(new Book(id, name, price, amount, author, genre, format, language));
        }

        public void addGame(int id, string name, int price, int amount, string plattform)
        {
            gameList.Add(new Videogame(id, name, price, amount, plattform));
        }

        public void addFilm(int id, string name, int price, int amount, string format, int time)
        {
            filmList.Add(new Film(id, name, price, amount, format, time));
        }

        public void importBooks()
        {
           try
           {
                string fileName = "booksFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if(File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                    reader.ReadLine();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            //tar bort extra mellanrum
                            line = String.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                            string[] data = line.Split(',');

                            int id = int.Parse(data[0]);
                            string name = data[1];
                            int price = int.Parse(data[2]);
                            int amount = int.Parse(data[3]);
                            string author = data[4];
                            string genre = data[5];
                            string format = data[6];
                            string language = data[7];

                            bookList.Add(new Book(id, name, price, amount, author, genre, format, language));

                            bookSource.DataSource = bookList;
                        }
                    }
                }

                else
                {
                    throw new Exception("File not found");
                }
           }

           catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        public void importGames()
        {
            try
            {
                string fileName = "gamesFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        //the first line is not saved
                        reader.ReadLine();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            line = String.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                            string[] data = line.Split(',');

                            int id = int.Parse(data[0]);
                            string name = data[1];
                            int price = int.Parse(data[2]);
                            int amount = int.Parse(data[3]);
                            string plattform = data[4];

                            gameList.Add(new Videogame(id, name, price, amount, plattform));

                            gameSource.DataSource = gameList;
                        }
                    }
                }

                else
                {
                    throw new Exception("File not found");
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void importFilms()
        {
            try
            {
                string fileName = "filmsFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        reader.ReadLine();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            line = String.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                            string[] data = line.Split(',');

                            int id = int.Parse(data[0]);
                            string name = data[1];
                            int price = int.Parse(data[2]);
                            int amount = int.Parse(data[3]);
                            string format = data[4];
                            int time = int.Parse(data[5]);
                            

                            filmList.Add(new Film(id, name, price, amount, format, time));

                            filmSource.DataSource = filmList;
                        }
                    }
                }

                else
                {
                    throw new Exception("File not found");
                }
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void updateBookFile()
        {
            try
            {
                string fileName = "booksFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        writer.WriteLine("Id, Name, Price, Amount, Author, Genre, Format, Language");
                        foreach (Book book in bookList)
                        {
                            writer.WriteLine($"{book.ID},{book.Name},{book.Price},{book.Amount},{book.Author},{book.Genre},{book.Format},{book.Language}");
                        }
                    }
                }

                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Id, Name, Price, Amount, Author, Genre, Format, Language");
                        //int id, string name, int price, int amount, string author, string genre, string format, string language
                        foreach (Book book in bookList)
                        {
                            writer.WriteLine($"{book.ID},{book.Name},{book.Price},{book.Amount},{book.Author},{book.Genre},{book.Format},{book.Language}");
                        }
                    }
                }
            }
            catch(Exception error )
            {
                MessageBox.Show(error.Message);
            }
        }

        public void updateGameFile()
        {
            try
            {
                string fileName = "gamesFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        writer.WriteLine("ID, Name, Price, Amount, Plattform");
                        foreach (Videogame game in gameList)
                        {
                            writer.WriteLine($"{game.ID},{game.Name},{game.Price},{game.Amount},{game.Plattform}");
                        }
                    }
                }

                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("ID, Name, Price, Amount, Plattform");
                        foreach (Videogame game in gameList)
                        {
                            writer.WriteLine($"{game.ID},{game.Name},{game.Price},{game.Amount},{game.Plattform}");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void updateFilmFile()
        {
            try
            {
                string fileName = "filmsFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        writer.WriteLine("ID, Name, Price, Amount, Format, Time");
                        foreach (Film film in filmList)
                        {
                            writer.WriteLine($"{film.ID},{film.Name},{film.Price},{film.Amount},{film.Format},{film.Time}");
                        }
                    }
                }

                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("ID, Name, Price, Amount, Format, Time");
                        foreach (Film film in filmList)
                        {
                            writer.WriteLine($"{film.ID},{film.Name},{film.Price},{film.Amount},{film.Format},{film.Time}");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void removeBook(int id)
        {
            Book book = bookList.SingleOrDefault(p => p.ID == id);
            if(book.Amount > 0)
            {
                DialogResult result = MessageBox.Show("Vill du verkligen ta bort varan?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bookList.Remove(book);
                }
                else
                {
                    return;
                }
            }
            
        }

        public void removeGame(int id)
        {
            Videogame game = gameList.SingleOrDefault(p => p.ID == id);

            if (game.Amount > 0)
            {
                DialogResult result = MessageBox.Show("Vill du verkligen ta bort varan?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    gameList.Remove(game);
                }
                else
                {
                    return;
                }
            }
        }

        public void removeFilm (int id)
        {
            Film film = filmList.SingleOrDefault(p => p.ID == id);

            if (film.Amount > 0)
            {
                DialogResult result = MessageBox.Show("Vill du verkligen ta bort varan?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    filmList.Remove(film);
                }
                else
                {
                    return;
                }
            }
        }

        public Book findBook (int id)
        {
            Book book = bookList.SingleOrDefault(p => p.ID == id);

            return book;
        }

        public Videogame findGame(int id)
        {
            Videogame game = gameList.SingleOrDefault(p => p.ID == id);

            return game;
        }

        public Film findFilm (int id)
        {
            Film film = filmList.SingleOrDefault (p => p.ID == id);

            return film;
        }

        public bool checkID (int id)
        {
            if (bookList.Any(book => book.ID == id))
            {
                return true;
            }
            else if (gameList.Any(game => game.ID == id))
            {
                return true;
            }
            else if (filmList.Any(film => film.ID == id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void sellItem(int id, int amountSold)
        {
            Item item = null;

            //search for the item in the book list
            item = bookList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                if (item.Amount < amountSold)
                {
                    throw new Exception("Not enough products in stock");
                }
                else
                {
                    item.Sell(amountSold);
                    
                    return;
                }
            }

            //if not found, search for the item in the videogame list
            item = gameList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                if (item.Amount < amountSold)
                {
                    throw new Exception("Not enough products in stock");
                }
                else
                {
                    item.Sell(amountSold);
                    
                    return;
                }
                
            }

            //if not found, search for the item in the film list
            item = filmList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                if (item.Amount < amountSold)
                {
                    throw new Exception("Not enough products in stock");
                }
                else
                {
                    item.Sell(amountSold);
                    return;
                }
                
            }

            //if not found in any of the lists, throw an exception
            throw new Exception("Item not found");
        }

        public void createReceipt(ListView shoppingBasket, int total)
        {
            RecieptForm receipt = new RecieptForm(shoppingBasket, total);
            receipt.ShowDialog();
        }

        public void AddShipment(int id, int shipmentAmount, string itemType)
        {
            Item item = null;

            switch(itemType)
            {
                case "Book":
                    item = bookList.SingleOrDefault(p => p.ID == id);
                    if (item != null)
                    {
                        item.Shipment(shipmentAmount);
                    }
                    break;
                case "Game":
                    item = gameList.SingleOrDefault(p => p.ID == id);
                    if (item != null)
                    {
                        item.Shipment(shipmentAmount);
                    }
                    break;
                case "Film":
                    item = filmList.SingleOrDefault(p => p.ID == id);
                    if (item != null)
                    {
                        item.Shipment(shipmentAmount);
                    }
                    break;
            }
        }


    }
}
