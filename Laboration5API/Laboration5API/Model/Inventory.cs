﻿using System;
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
                var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api");
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(text);

                foreach (XmlElement element in doc.FirstChild.ChildNodes)
                {
                    if (element.Name == "products")
                    {
                        int id = 0;
                        int price = 0;
                        int stock = 0;
                        foreach (XmlElement pElement in element.ChildNodes)
                        {
                            foreach (XmlElement product in pElement.ChildNodes)
                            {
                                if (product.Name == "id")
                                {
                                    id = int.Parse(product.InnerText);
                                }
                                else if (product.Name == "price")
                                {
                                    price = int.Parse(product.InnerText);
                                }
                                else if (product.Name == "stock")
                                {
                                    stock = int.Parse(product.InnerText);
                                }
                            }

                            Item item = findItem(id);
                            if (item != null)
                            {
                                item.Update(stock, price);
                            }

                        }
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public async Task sync(int id, int stock)
        {
            // create a new HttpClient instance
            using (var httpClient = new HttpClient())
            {
                // create the URL with the ID and stock values
                var apiUrl = $"https://hex.cse.kau.se/~jonavest/csharp-api/?action=update&id={id}&stock={stock}";

                // send the GET request to the API endpoint
                var response = await httpClient.GetAsync(apiUrl);

                // check the response status code
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine(response.Content);
                }
                else
                {
                    // handle the error response
                }
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
            throw new Exception("Item not found");
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
