using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net.Http;

namespace Laboration5API.Model
{
    public class Inventory
    {
        public BindingList<Book> bookList = new BindingList<Book>();


        public BindingList<Videogame> gameList = new BindingList<Videogame>();


        public BindingList<Film> filmList = new BindingList<Film>();

        //LABORATION 5 
        public void update()
        {
            try
            {
                WebClient client = new WebClient();

                //get XML-Document
                var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api/");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(text);
               
                foreach (XmlElement type in doc.FirstChild.ChildNodes)
                {
                    //search for products in XML-file
                    if (type.Name == "products")
                    {
                        int id = 0, price = 0, stock = 0;
                        
                        //iterate through all products
                        foreach (XmlElement product in type.ChildNodes)
                        {
                            string productType = product.Name;

                            //iterate through all tags for each product to get id, price and stock
                            foreach (XmlElement tag in product.ChildNodes)
                            {
                                if (tag.Name == "id")
                                {
                                    id = int.Parse(tag.InnerText);
                                }
                                else if (tag.Name == "price")
                                {
                                    price = int.Parse(tag.InnerText);
                                }
                                else if (tag.Name == "stock")
                                {
                                    stock = int.Parse(tag.InnerText);
                                }
                            }

                            //check if item is already in list
                            Item item = findItem(id);

                            //if it is just update stock and price
                            if (item != null)
                            {
                                item.Update(stock, price);
                            }

                            //if not add item to list
                            else
                            {
                                switch (productType)
                                {
                                    case "book":
                                        string name = "", author = "", genre = "", format = "", language = "";

                                        foreach (XmlElement tag in product.ChildNodes)
                                        {
                                            if (tag.Name == "name")
                                            {
                                                name = tag.InnerText;
                                            }
                                            else if (tag.Name == "author")
                                            {
                                                author = tag.InnerText;
                                            }
                                            else if (tag.Name == "genre")
                                            {
                                                genre = tag.InnerText;
                                            }
                                            else if (tag.Name == "format")
                                            {
                                                format = tag.InnerText;
                                            }
                                            else if (tag.Name == "language")
                                            {
                                                language = tag.InnerText;
                                            }
                                        }

                                        addBook(id, name, price, stock, author, genre, format, language);
                                        break;

                                    case "game":
                                        name = "";
                                        string plattform = "";

                                        foreach (XmlElement tag in product.ChildNodes)
                                        {
                                            if (tag.Name == "name")
                                            {
                                                name = tag.InnerText;
                                            }
                                            else if (tag.Name == "plattform")
                                            {
                                                author = tag.InnerText;
                                            }
                                        }

                                        addGame(id, name, price, stock, plattform);
                                        break;
                                    case "movie":

                                        name = "";
                                        format = "";
                                        int playtime = 0;

                                        foreach (XmlElement tag in product.ChildNodes)
                                        {
                                            if (tag.Name == "name")
                                            {
                                                name = tag.InnerText;
                                            }
                                            else if (tag.Name == "format")
                                            {
                                                format = tag.InnerText;
                                            }
                                            else if (tag.Name == "playtime")
                                            {
                                                playtime = int.Parse(tag.InnerText);
                                            }
                                        }

                                        addFilm(id, name, price, stock, format, playtime);
                                        break;
                                }
                            }                         
                        } 
                    }
                    //throw exception if there is an error
                    if (type.Name == "error")
                    {
                        throw new WebException(type.InnerText);
                    }
                }
            }     
            catch (WebException error)
            {
                MessageBox.Show("Felmeddellande från Centrallager: " + error.Message);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public async Task sync(int id, int stock)
        {
            try
            {
                // create a new HttpClient instance
                using (var httpClient = new HttpClient())
                {
                    // create the URL with the ID and stock values
                    var apiUrl = $"https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id={id}&stock={stock}";

                    var response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine(response.Content);
                    }
                    else
                    {
                        throw new WebException("någonting gick fel");
                    }
                }

                MessageBox.Show("Sync successful");
            }
            catch (WebException error)
            {
                MessageBox.Show("Felmeddellande från Centrallager: " + error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    

        //add items
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


        //get data from csv.files
        public void importBooks()
        {
            try
            {
                string fileName = "booksFile.csv";

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

                //check if there is a file throw exception otherwise
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        //skip first line
                        reader.ReadLine();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            //tar bort extra mellanrum
                            line = String.Join(" ", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                            //split string to get array
                            string[] data = line.Split(',');

                            //save values
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


        //search items
        public Book findBook(int id)
        {
            Book book = bookList.SingleOrDefault(p => p.ID == id);

            return book;
        }

        public Videogame findGame(int id)
        {
            Videogame game = gameList.SingleOrDefault(p => p.ID == id);

            return game;
        }

        public Film findFilm(int id)
        {
            Film film = filmList.SingleOrDefault(p => p.ID == id);

            return film;
        }

        public Item findItem(int id)
        {
            Item item = null;

            //search for the item in the book list
            item = bookList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                return item;
            }

            //if not found, search for the item in the videogame list
            item = gameList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                return item;
            }

            //if not found, search for the item in the film list
            item = filmList.SingleOrDefault(p => p.ID == id);

            if (item != null)
            {
                return item;
            }

            //if not found in any of the lists, throw an exception
            //throw new Exception("Item not found");
            return item;
        }


        //remove items
        public void removeBook(Book book)
        {
            bookList.Remove(book);
        }

        public void removeGame(Videogame game)
        {
            gameList.Remove(game);
        }

        public void removeFilm(Film film)
        {
            filmList.Remove(film);
        }


        //search in lists
        public BindingSource search(string query)
        {
            //check every item in every list for query, add to resultList if name contains query
            BindingList<Item> resultList = new BindingList<Item>();

            foreach (Book item in bookList)
            {
                if (item.Name.Contains(query))
                {
                    resultList.Add(item);
                }
            }

            foreach (Videogame item in gameList)
            {
                if (item.Name.Contains(query))
                {
                    resultList.Add(item);
                }
            }

            foreach (Film item in filmList)
            {
                if (item.Name.Contains(query))
                {
                    resultList.Add(item);
                }
            }

            //set and return bindingsource
            BindingSource resultSource = new BindingSource();
            resultSource.DataSource = resultList;
            return resultSource;
        }

    }
}
