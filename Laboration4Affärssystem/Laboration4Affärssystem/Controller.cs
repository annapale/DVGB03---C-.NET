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
using Microsoft.VisualBasic;
using Laboration4Affärssystem.Model;

namespace Laboration4Affärssystem
{
    internal class Controller
    {
        Inventory inventory = new Inventory();
        

        public void setBookSource(BindingSource source)
        {
            source.DataSource = inventory.bookList;   
        }

        public void setGameSource(BindingSource source)
        {
            source.DataSource = inventory.gameList;
        }

        public void setFilmSource(BindingSource source)
        {
            source.DataSource = inventory.filmList;
        }

        public void addBook(int id, string name, int price, int amount, string author, string genre, string format, string language)
        {
            inventory.bookList.Add(new Book(id, name, price, amount, author, genre, format, language));
        }

        public void addGame(int id, string name, int price, int amount, string plattform)
        {
            inventory.gameList.Add(new Videogame(id, name, price, amount, plattform));
        }

        public void addFilm(int id, string name, int price, int amount, string format, int time)
        {
            inventory.filmList.Add(new Film(id, name, price, amount, format, time));
        }

        //get items from database and add to lists
        public void importBooks()
        {
            try
            {
                string fileName = "booksFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
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

                            addBook(id, name, price, amount, author, genre, format, language);
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

                            addGame(id, name, price, amount, plattform);
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


                            addFilm(id, name, price, amount, format, time);

                            //filmSource.DataSource = inventory.filmList;
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
                        foreach (Book book in inventory.bookList)
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
                        foreach (Book book in inventory.bookList)
                        {
                            writer.WriteLine($"{book.ID},{book.Name},{book.Price},{book.Amount},{book.Author},{book.Genre},{book.Format},{book.Language}");
                        }
                    }
                }
            }
            catch (Exception error)
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
                        foreach (Videogame game in inventory.gameList)
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
                        foreach (Videogame game in inventory.gameList)
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
                        foreach (Film film in inventory.filmList)
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
                        foreach (Film film in inventory.filmList)
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

        public Item selectBook(DataGridViewRow row)
        {
            Item item = inventory.bookList[row.Index];
            return item;
        }

        public Item selectGame(DataGridViewRow row)
        {
            Item item = inventory.gameList[row.Index];
            return item;
        }

        public Item selectFilm(DataGridViewRow row) 
        {
            Item item = inventory.filmList[row.Index];
            return item;
        }

        public void removeBook(int id)
        {
            Book book = inventory.bookList.SingleOrDefault(p => p.ID == id);
            if (book.Amount > 0)
            {
                DialogResult result = MessageBox.Show("Vill du verkligen ta bort varan?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    inventory.bookList.Remove(book);
                }
                else
                {
                    return;
                }
            }

        }

        public void removeGame(int id)
        {
            Videogame game = inventory.gameList.SingleOrDefault(p => p.ID == id);

            if (game.Amount > 0)
            {
                DialogResult result = MessageBox.Show("Vill du verkligen ta bort varan?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    inventory.gameList.Remove(game);
                }
                else
                {
                    return;
                }
            }
        }

        public void removeFilm(int id)
        {
            Film film = inventory.filmList.SingleOrDefault(p => p.ID == id);

            if (film.Amount > 0)
            {
                DialogResult result = MessageBox.Show("Vill du verkligen ta bort varan?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    inventory.filmList.Remove(film);
                }
                else
                {
                    return;
                }
            }
        }

        public Book findBook(int id)
        {
            Book book = inventory.bookList.SingleOrDefault(p => p.ID == id);

            return book;
        }

        public Videogame findGame(int id)
        {
            Videogame game = inventory.gameList.SingleOrDefault(p => p.ID == id);

            return game;
        }

        public Film findFilm(int id)
        {
            Film film = inventory.filmList.SingleOrDefault(p => p.ID == id);

            return film;
        }

        public Item findItem(int id)
        {
            Item item = null;

            //search for the item in the book list
            item = inventory.bookList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                return item;
            }

            //if not found, search for the item in the videogame list
            item = inventory.gameList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                return item;
            }

            //if not found, search for the item in the film list
            item = inventory.filmList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                return item;
            }

            //if not found in any of the lists, throw an exception
            throw new Exception("Item not found");
        }
        public bool checkID(int id)
        {
            if (inventory.bookList.Any(book => book.ID == id))
            {
                return true;
            }
            else if (inventory.gameList.Any(game => game.ID == id))
            {
                return true;
            }
            else if (inventory.filmList.Any(film => film.ID == id))
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
            Item item = findItem(id);

            if (item != null)
            {
                if (item.Amount < amountSold)
                {
                    throw new Exception("Not enough products in stock");
                }
                else
                {
                    item.Sell(amountSold);
                }
            }
        }

        public void createReceipt(ListView shoppingBasket, int total)
        {
            RecieptForm receipt = new RecieptForm(shoppingBasket, total);
            receipt.ShowDialog();
        }

        public void AddItems(int id, int amount)
        {
            Item item = findItem(id);

            item.Add(amount);
        }

        public BindingSource Search(string query)
        {
            BindingList<Item> resultList = new BindingList<Item>();
            
            foreach (Book item in inventory.bookList)
            {
                if (item.Name.Contains(query))
                {
                    resultList.Add(item);
                }
            }

            foreach (Videogame item in inventory.gameList)
            {
                if(item.Name.Contains(query))
                {
                    resultList.Add(item);
                }
            }

            foreach (Film item in inventory.filmList)
            {
                if (item.Name.Contains(query))
                {
                    resultList.Add(item);
                }
            }

            BindingSource resultSource = new BindingSource();
            resultSource.DataSource = resultList;
            return resultSource;
        }
    }
}
