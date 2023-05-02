using Laboration5API.Model;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Laboration5API
{
    internal class Controller
    {
        Inventory inventory = new Inventory();
        TransactionArchive archive = new TransactionArchive();

        //LABORATION 5
        public void updateItems()
        {
            inventory.update();
        }


        //set sources
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


        //get items from database and add to lists
        public void importData()
        {
            inventory.importBooks();
            inventory.importGames();
            inventory.importFilms();
        }


        //handler methods for adding items to inventory
        public void addBookToInventory(int id, string name, int price, int amount, string author, string genre, string format, string language)
        {
            inventory.addBook(id, name, price, amount, author, genre, format, language);
        }

        public void addGameToInventory(int id, string name, int price, int amount, string plattform)
        {
            inventory.addGame(id, name, price, amount, plattform);
        }

        public void addFilmToInventory(int id, string name, int price, int amount, string format, int time)
        {
            inventory.addFilm(id, name, price, amount, format, time);
        }


        //handler methods for removing items
        public void removeBookFromInventory(int id)
        {
            Book book = inventory.findBook(id);

            if (book.Amount != 0)
            {
                DialogResult result = MessageBox.Show("Ska varan verkligen tas bort?", "Lagerstatus är inte null", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    inventory.removeBook(book);
                }

                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                inventory.removeBook(book);
            }
        }

        public void removeGameFromInventory(int id)
        {
            Videogame game = inventory.findGame(id);

            if (game.Amount != 0)
            {
                DialogResult result = MessageBox.Show("Ska varan verkligen tas bort?", "Lagerstatus är inte null", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    inventory.removeGame(game);
                }

                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                inventory.removeGame(game);
            }
        }

        public void removeFilmFromInventory(int id)
        {
            Film film = inventory.findFilm(id);
            if (film.Amount != 0)
            {
                DialogResult result = MessageBox.Show("Ska varan verkligen tas bort?", "Lagerstatus är inte null", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    inventory.removeFilm(film);
                }

                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                inventory.removeFilm(film);
            }
        }


        //handler methods for returning items
        public Item getItemFromInventory(int id)
        {
            Item item = inventory.findItem(id);
            return item;
        }

        public Book getBookFromInventory(int id)
        {
            return inventory.findBook(id);
        }

        public Videogame getGameFromInventory(int id)
        {
            return inventory.findGame(id);
        }

        public Film getFilmFromInventory(int id)
        {
            return inventory.findFilm(id);
        }


        //update CSV.files
        public void updateBookFile()
        {
            try
            {
                string fileName = "booksFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                //check if there is a bookFile already, save to it if there is, create new one if not
                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        //write headers in first line
                        writer.WriteLine("Id, Name, Price, Amount, Author, Genre, Format, Language");

                        //write books into file
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


        //check if id exists 
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


        //sell item
        public void sellItem(int id, int amountSold)
        {
            //find item in list
            Item item = inventory.findItem(id);

            if (item != null)
            {
                if (item.Amount < amountSold)
                {
                    throw new Exception("Not enough products in stock");
                }
                else
                {
                    //sell item
                    item.Sell(amountSold);
                }
            }
        }


        //open Receipt form
        public void createReceipt(ListView shoppingBasket, int total)
        {
            RecieptForm receipt = new RecieptForm(shoppingBasket, total);
            receipt.ShowDialog();
        }

        //add item
        public void addItems(int id, int amount)
        {
            //find item
            Item item = inventory.findItem(id);

            item.Add(amount);
        }


        //handler methods for searching and filtering
        public BindingSource searchInInventory(string query)
        {
            BindingSource source = inventory.search(query);
            return source;
        }

        public (BindingSource, int) filterTransactions(string queryMonth, string queryYear)
        {
            (BindingSource source, int total) = archive.filter(queryMonth, queryYear);
            return (source, total);
        }

        public BindingSource getTop10Transactions(string query)
        {
            BindingSource source = archive.getTop10(query);
            return source;
        }


        //add transaction 
        public void addTransactionToArchive(int id, int month, int year, int amount)
        {
            archive.addTransaction(id, month, year, amount);
        }

        //update transaction file
        public void updateTransactionFile()
        {
            try
            {
                string fileName = "transactions.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        writer.WriteLine("Id, Month, Year, Amount");
                        foreach (Transaction transaction in archive.transactions)
                        {
                            writer.WriteLine($"{transaction.ID},{transaction.Month},{transaction.Year},{transaction.Amount}");
                        }
                    }
                }

                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("Id, Month, Year, Amount");
                        foreach (Transaction transaction in archive.transactions)
                        {
                            writer.WriteLine($"{transaction.ID},{transaction.Month},{transaction.Year},{transaction.Amount}");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        //handler method for importing transactions
        public void importTransactionData()
        {
            archive.importTransactions();
        }

        public void setTransactionSource(BindingSource source)
        {
            source.DataSource = archive.transactions;
        }

        
    }
}
