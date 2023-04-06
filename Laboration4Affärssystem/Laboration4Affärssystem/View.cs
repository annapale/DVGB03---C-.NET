﻿using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboration4Affärssystem
{
    public partial class View : System.Windows.Forms.Form
    {
        Controller controller = new Controller();
        DataGridViewRow selectedItem = null;

        public View()
        {
            InitializeComponent();

            controller.importBooks();
            controller.importGames();
            controller.importFilms();

            addDataKassa(gridViewKassaBok, 1);
            addDataKassa(gridViewKassaSpel, 2);
            addDataKassa(gridViewKassaFilm, 3);

            addDataLager(gridViewLagerBok, 1);
            addDataLager(gridViewLagerSpel, 2);
            addDataLager(gridViewLagerFilm, 3);

        }

        private void addDataKassa(DataGridView table, int itemType)
        {
            // Disable automatic column generation
            table.AutoGenerateColumns = false;

            switch (itemType)
            {
                case 1:
                    //Add books to DataGridView
                    //Add columns
                    table.Columns.Add("ID", "ID");
                    table.Columns.Add("Name", "Namn");
                    table.Columns.Add("Price", "Pris");
                    table.Columns.Add("Author", "Författare");
                    table.Columns.Add("Genre", "Genre");
                    table.Columns.Add("Format", "Format");
                    table.Columns.Add("Language", "Språk");
                    table.Columns.Add("Amount", "Antal");

                    //Set column names
                    table.Columns["ID"].DataPropertyName = "ID";
                    table.Columns["Name"].DataPropertyName = "Name";
                    table.Columns["Price"].DataPropertyName = "Price";
                    table.Columns["Author"].DataPropertyName = "Author";
                    table.Columns["Genre"].DataPropertyName = "Genre";
                    table.Columns["Format"].DataPropertyName = "Format";
                    table.Columns["Language"].DataPropertyName = "Language";
                    table.Columns["Amount"].DataPropertyName = "Amount";

                    //Add data source
                    table.DataSource = controller.bookSource;

                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    break;

                case 2:
                    //Add games to DataGridView
                    //Add columns
                    table.Columns.Add("ID", "ID");
                    table.Columns.Add("Name", "Namn");
                    table.Columns.Add("Price", "Pris");
                    table.Columns.Add("Plattform", "Plattform");
                    table.Columns.Add("Amount", "Antal");

                    //Set column names
                    table.Columns["ID"].DataPropertyName = "ID";
                    table.Columns["Name"].DataPropertyName = "Name";
                    table.Columns["Price"].DataPropertyName = "Price";
                    table.Columns["Plattform"].DataPropertyName = "Plattform";
                    table.Columns["Amount"].DataPropertyName = "Amount";

                    //Add data source
                    table.DataSource = controller.gameSource;

                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;

                case 3:
                    //Add films to DataGridView
                    //Add columns
                    table.Columns.Add("ID", "ID");
                    table.Columns.Add("Name", "Namn");
                    table.Columns.Add("Price", "Pris");
                    table.Columns.Add("Format", "Format");
                    table.Columns.Add("Time", "Speltid");
                    table.Columns.Add("Amount", "Antal");

                    //Set column names
                    table.Columns["ID"].DataPropertyName = "ID";
                    table.Columns["Name"].DataPropertyName = "Name";
                    table.Columns["Price"].DataPropertyName = "Price";
                    table.Columns["Format"].DataPropertyName = "Format";
                    table.Columns["Time"].DataPropertyName = "Time";
                    table.Columns["Amount"].DataPropertyName = "Amount";

                    //Add data source
                    table.DataSource = controller.filmSource;

                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    break;
            }
            
        }

        private void addDataLager(DataGridView table, int itemType)
        {
            // Disable automatic column generation
            table.AutoGenerateColumns = false;

            switch (itemType)
            {
                case 1:
                    //Add books to DataGridView
                    //Add columns
                    table.Columns.Add("ID", "ID");
                    table.Columns.Add("Name", "Namn");

                    //Set column names
                    table.Columns["ID"].DataPropertyName = "ID";
                    table.Columns["Name"].DataPropertyName = "Name";

                    //Add data source
                    table.DataSource = controller.bookSource;

                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;

                case 2:
                    //Add games to DataGridView
                    //Add columns
                    table.Columns.Add("ID", "ID");
                    table.Columns.Add("Name", "Namn");

                    //Set column names
                    table.Columns["ID"].DataPropertyName = "ID";
                    table.Columns["Name"].DataPropertyName = "Name";

                    //Add data source
                    table.DataSource = controller.gameSource;

                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;

                case 3:
                    //Add films to DataGridView
                    //Add columns
                    table.Columns.Add("ID", "ID");
                    table.Columns.Add("Name", "Namn");

                    //Set column names
                    table.Columns["ID"].DataPropertyName = "ID";
                    table.Columns["Name"].DataPropertyName = "Name";

                    //Add data source
                    table.DataSource = controller.filmSource;

                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
            }
        }

        private void gridViewKassaBok_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewKassaBok.SelectedRows.Count > 0)
            {
                selectedItem = gridViewKassaBok.SelectedRows[0];
                //deselect any selected items in the other tables to avoid problems
                deselectGame();
                deselectFilm();
            }
        }

        private void gridViewKassaSpel_SelectionChanged(object sender, EventArgs e)
        {
            if(gridViewKassaSpel.SelectedRows.Count > 0)
            {
                selectedItem = gridViewKassaSpel.SelectedRows[0];
                deselectBook();
                deselectFilm();
            }
        }

        private void gridViewKassaFilm_SelectionChanged(object sender, EventArgs e)
        {
            if(gridViewKassaFilm.SelectedRows.Count > 0)
            {
                selectedItem = gridViewKassaFilm.SelectedRows[0];
                deselectBook();
                deselectGame();
            }
        }

        private void deselectBook()
        {
            if(gridViewKassaBok.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewKassaBok.SelectedRows[0];

                selectedRow.Selected = false;
            }
        }

        private void deselectGame()
        {
            if (gridViewKassaSpel.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewKassaSpel.SelectedRows[0];

                selectedRow.Selected = false;
            }
        }

        private void deselectFilm()
        {
            if (gridViewKassaFilm.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewKassaFilm.SelectedRows[0];

                selectedRow.Selected = false;
            }
        }

        private void addToShoppingCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedItem != null)
                {
                    //get data about the selected item
                    string id = selectedItem.Cells["ID"].Value.ToString();
                    string name = selectedItem.Cells["Name"].Value.ToString();
                    int amountInt = 1;
                    string price = selectedItem.Cells["Price"].Value.ToString();
                    bool itemInList = true;

                    string amount = amountInt.ToString();

                    //check if selected item is already in list, if it is update amount and price, if not add to list
                    foreach (ListViewItem listItem in shoppingBasketList.Items)
                    {
                        itemInList = false;
                        string itemId = listItem.SubItems[0].Text;

                        if (itemId.Equals(id))
                        {
                            string currentAmount = listItem.SubItems[3].Text;
                            amountInt = int.Parse(currentAmount);
                            amountInt++;
                            listItem.SubItems[3].Text = amountInt.ToString();

                            int priceInt = int.Parse(listItem.SubItems[2].Text) + int.Parse(price);
                            listItem.SubItems[2].Text = priceInt.ToString();
                        }
                        else
                        {
                            itemInList = true;
                        }
                    }

                    if (itemInList)
                    {
                        ListViewItem item = new ListViewItem(new[] { id, name, price, amount });
                        shoppingBasketList.Items.Add(item);
                    }

                    //update totalPrice
                    int totalPrice = int.Parse(totalPriceTextBox.Text) + int.Parse(price);
                    totalPriceTextBox.Text = totalPrice.ToString();
                }

                else
                {
                    throw new Exception("no item selected");
                }
            }
            
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem listItem in shoppingBasketList.Items)
                {
                    int listItemID = int.Parse(listItem.SubItems[0].Text);
                    int listItemAmount = int.Parse(listItem.SubItems[3].Text);

                    int total = int.Parse(totalPriceTextBox.Text);

                    controller.sellItem(listItemID, listItemAmount);

                    gridViewKassaBok.Refresh();
                    gridViewKassaSpel.Refresh();
                    gridViewKassaFilm.Refresh();

                    controller.createReceipt(shoppingBasketList, total);
                    shoppingBasketList.Items.Clear();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            controller.removeBook(int.Parse(selectedItem.Cells["ID"].Value.ToString()));
        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            controller.removeGame(int.Parse(selectedItem.Cells["ID"].Value.ToString()));
        }

        private void removeFilmButton_Click(object sender, EventArgs e)
        {
            controller.removeFilm(int.Parse(selectedItem.Cells["ID"].Value.ToString()));
        }

        private void gridViewLagerBok_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewLagerBok.SelectedRows.Count > 0)
            {
                selectedItem = gridViewLagerBok.SelectedRows[0];

                Book book = controller.findBook(int.Parse(selectedItem.Cells["ID"].Value.ToString()));

                IDBookText.Text = book.ID.ToString();
                AmountBookText.Text = book.Amount.ToString();
                NameBookText.Text = book.Name;
                PriceBookText.Text = book.Price.ToString();
                AuthorBookText.Text = book.Author;
                GenreBookText.Text = book.Genre;
                FormatBookText.Text = book.Format;
                LanguageBookText.Text = book.Language;
            }
        }

        private void gridViewLagerSpel_SelectionChanged(object sender, EventArgs e)
        {
            if(gridViewLagerSpel.SelectedRows.Count > 0)
            {
                selectedItem = gridViewLagerSpel.SelectedRows[0];

                Videogame game = controller.findGame(int.Parse(selectedItem.Cells["ID"].Value.ToString()));

                IDGameText.Text = game.ID.ToString();
                AmountGameText.Text = game.Amount.ToString();
                NameGameText.Text = game.Name;
                PriceGameText.Text = game.Price.ToString();
                PlattformGameText.Text = game.Plattform;
            }
        }

        private void gridViewLagerFilm_SelectionChanged(object sender, EventArgs e)
        {
            if(gridViewLagerFilm.SelectedRows.Count > 0)
            {
                selectedItem = gridViewLagerFilm.SelectedRows[0];

                Film film = controller.findFilm(int.Parse(selectedItem.Cells["ID"].Value.ToString()));

                IDFilmText.Text = film.ID.ToString();
                AmountFilmText.Text = film.Amount.ToString();
                NameFilmText.Text = film.Name;
                PriceFilmText.Text = film.Price.ToString();
                FormatFilmText.Text = film.Format;
                TimeFilmText.Text = film.Time.ToString();
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDBookText.Text == "")
                {
                    throw new Exception("Lägg till ett ID");
                }

                if (PriceBookText.Text == "")
                {
                    throw new Exception("Lägg till pris");
                }

                if (NameBookText.Text == "")
                {
                    throw new Exception("Lägg till ett Namn");
                }

                int id = int.Parse(IDBookText.Text);
                if (controller.checkID(id))
                {
                    throw new Exception("ID måste vara unik");
                }

                string name = NameBookText.Text;
                int price = int.Parse(PriceBookText.Text);
                int amount = int.Parse(AmountBookText.Text);
                string author = AuthorBookText.Text;
                string genre = GenreBookText.Text;
                string format = FormatBookText.Text;
                string language = LanguageBookText.Text;

                controller.addBook(id, name, price, amount, author, genre, format, language);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
          
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDGameText.Text == "")
                {
                    throw new Exception("Lägg till ett ID");
                }

                if (PriceGameText.Text == "")
                {
                    throw new Exception("Lägg till pris");
                }

                if (NameGameText.Text == "")
                {
                    throw new Exception("Lägg till ett Namn");
                }
                int id = int.Parse(IDGameText.Text);
                if (controller.checkID(id))
                {
                    throw new Exception("ID måste vara unik");
                }
                string name = NameGameText.Text;
                int price = int.Parse(PriceGameText.Text);
                int amount = int.Parse(AmountGameText.Text);
                string plattform = PlattformGameText.Text;

                controller.addGame(id, name, price, amount, plattform);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }
        
        private void addFilmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDFilmText.Text == "")
                {
                    throw new Exception("Lägg till ett ID");
                }

                if (PriceFilmText.Text == "")
                {
                    throw new Exception("Lägg till pris");
                }

                if (NameFilmText.Text == "")
                {
                    throw new Exception("Lägg till ett Namn");
                }

                int id = int.Parse(IDFilmText.Text);
                if (controller.checkID(id))
                {
                    throw new Exception("ID måste vara unik");
                }
                string name = NameFilmText.Text;
                int price = int.Parse(PriceFilmText.Text);
                int amount = int.Parse(AmountFilmText.Text);

                if (amount >= 0)
                {
                    throw new Exception("Speltid kan inte vara negativ");
                }
                string format = FormatFilmText.Text;
                int time = int.Parse(TimeFilmText.Text);

                controller.addFilm(id, name, price, amount, format, time);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        private void addShipmentBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input;
                int shipmentAmount;
                string itemType = "Book";
                int id = int.Parse(selectedItem.Cells["ID"].Value.ToString());
                input = Microsoft.VisualBasic.Interaction.InputBox("Hur stor är leveransen?:", "Integer Input", "0");

                shipmentAmount = int.Parse(input);


                if (shipmentAmount < 1)
                {
                    throw new Exception("Leverans måste vara större än 0");
                }

                controller.AddShipment(id, shipmentAmount, itemType);

                //update display
                gridViewLagerBok_SelectionChanged(null, null);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void addShipmentGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input;
                int shipmentAmount;
                string itemType = "Game";
                int id = int.Parse(selectedItem.Cells["ID"].Value.ToString());
                input = Microsoft.VisualBasic.Interaction.InputBox("Hur stor är leveransen?:", "Integer Input", "0");

                shipmentAmount = int.Parse(input);
                if (shipmentAmount < 1)
                {
                    throw new Exception("Leverans måste vara större än 0");
                }

                controller.AddShipment(id, shipmentAmount, itemType);

                //update display
                gridViewLagerSpel_SelectionChanged(null, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void addShipmentFilmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input;
                int shipmentAmount;
                string itemType = "Film";
                int id = int.Parse(selectedItem.Cells["ID"].Value.ToString());
                input = Microsoft.VisualBasic.Interaction.InputBox("Hur stor är leveransen?:", "Integer Input", "0");

                shipmentAmount = int.Parse(input);

                if (shipmentAmount < 1)
                {
                    throw new Exception("Leverans måste vara större än 0");
                }

                controller.AddShipment(id, shipmentAmount, itemType);

                //update display
                gridViewLagerFilm_SelectionChanged(null, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.updateBookFile();
            controller.updateGameFile();
            controller.updateFilmFile();
        }
    }
}
