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
        TransactionArchive archive = new TransactionArchive();

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

        public void removeBookFromInventory(int id)
        {
            Book book = inventory.findBook(id);
            inventory.removeBook(book);
        }

        public void removeGameFromInventory(int id)
        {
            Videogame game = inventory.findGame(id);
            inventory.removeGame(game);
        }

        public void removeFilmFromInventory(int id)
        {
            Film film = inventory.findFilm(id);
            inventory.removeFilm(film);
        }


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

        //update CSV.file
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

        //select item 
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
            Item item = inventory.findItem(id);

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
            Item item = inventory.findItem(id);

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

        public (BindingSource, int total) filter(string queryMonth, string queryYear)
        {
            BindingList<Transaction> temporary = new BindingList<Transaction>();
            BindingList<Transaction> filterList = new BindingList<Transaction>();

            foreach (Transaction transaction in archive.transactions)
            {
                if (transaction.Month.ToString() == queryMonth) 
                {
                    temporary.Add(transaction);
                }
            }

            foreach (Transaction transaction in temporary)
            {
                if(transaction.Year.ToString() == queryYear)
                {
                    filterList.Add(transaction);
                }
            }

            int total = 0;
            foreach (Transaction transaction in filterList)
            {
                total += transaction.Amount;
            }
            BindingSource filterSource = new BindingSource();
            filterSource.DataSource = filterList;
            return (filterSource, total);
        }

        public BindingSource FilterYear(string query)
        {
            BindingList<Transaction> filterList = new BindingList<Transaction>();

            foreach (Transaction transaction in archive.transactions)
            {
                if (transaction.Year.ToString() == query)
                {
                    filterList.Add(transaction);
                }
            }

            BindingSource filterSource = new BindingSource();

            var groupedTransactions = filterList.GroupBy(t => new { t.ID },(key, g) => new { ID = key.ID, Amount = g.Sum(t => t.Amount) });

            var orderedList = groupedTransactions.OrderByDescending(t => t.Amount).Take(10);

            BindingList<object> mergedList = new BindingList<object>();
            foreach (var group in orderedList)
            {
                var obj = new { ID = group.ID, Amount = group.Amount };
                mergedList.Add(obj);
            }

            filterSource.DataSource = mergedList;
            return filterSource;
        }

        public void addTransactionToArchive(int id, int month, int year, int amount)
        {
            archive.addTransaction(id, month, year, amount);
        }

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
