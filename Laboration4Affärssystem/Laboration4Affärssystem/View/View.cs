using Laboration4Affärssystem.Model;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboration4Affärssystem
{
    public partial class View : System.Windows.Forms.Form
    {
        public BindingSource bookSource = new BindingSource();
        public BindingSource gameSource = new BindingSource();
        public BindingSource filmSource = new BindingSource();
        public BindingSource transactionsSource = new BindingSource();

        Controller controller = new Controller();
        
        Item currentItem = null;

        public View()
        {
            InitializeComponent();

            controller.importData();
            controller.importTransactionData();

            controller.setBookSource(bookSource);
            controller.setGameSource(gameSource);
            controller.setFilmSource(filmSource);
            controller.setTransactionSource(transactionsSource);

            addDataKassa(gridViewKassaBok, 1);
            addDataKassa(gridViewKassaSpel, 2);
            addDataKassa(gridViewKassaFilm, 3);

            addDataLager(gridViewLagerBok, 1);
            addDataLager(gridViewLagerSpel, 2);
            addDataLager(gridViewLagerFilm, 3);

            addDataTransactions();

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
                    table.DataSource = bookSource;

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
                    table.DataSource = gameSource;

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
                    table.DataSource = filmSource;

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
                    table.DataSource = bookSource;

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
                    table.DataSource = gameSource;

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
                    table.DataSource = filmSource;

                    table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
            }
        }

        //save selected row as current item
        private void gridViewKassaBok_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridViewKassaBok.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = gridViewKassaBok.SelectedRows[0];
                    currentItem = controller.getItemFromInventory(int.Parse(row.Cells[0].Value.ToString()));
                    //deselect any selected items in the other tables to avoid problems
                    deselectGame();
                    deselectFilm();
                    deselectResult();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void gridViewKassaSpel_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridViewKassaSpel.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = gridViewKassaSpel.SelectedRows[0];
                    currentItem = controller.getItemFromInventory(int.Parse(row.Cells[0].Value.ToString()));
                    //deselect any selected items in the other tables to avoid problems
                    deselectGame();
                    deselectFilm();
                    deselectResult();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void gridViewKassaFilm_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridViewKassaFilm.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = gridViewKassaFilm.SelectedRows[0];
                    currentItem = controller.getItemFromInventory(int.Parse(row.Cells[0].Value.ToString()));
                    //deselect any selected items in the other tables to avoid problems
                    deselectGame();
                    deselectFilm();
                    deselectResult();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //automatically selects row in correct tab if the user selects a row in the search field
        private void gridViewResult_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridViewResult.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = gridViewResult.SelectedRows[0];
                    currentItem = controller.getItemFromInventory(int.Parse(selectedRow.Cells["ID"].Value.ToString()));

                    if (currentItem.GetType().Name == "Book")
                    {
                        //switch to correct tab
                        tabControlKassa.SelectedTab = kassaBookTab;
                        tabControlLager.SelectedTab = lagerBookTab;

                        //search correct row
                        foreach (DataGridViewRow row in gridViewKassaBok.Rows)
                        {
                            if (row.Cells["ID"].Value.ToString() == currentItem.ID.ToString())
                            {
                                //select row
                                row.Selected = true;

                                gridViewKassaBok.FirstDisplayedScrollingRowIndex = row.Index;
                            }
                        }

                        foreach (DataGridViewRow row in gridViewLagerBok.Rows)
                        {
                            if (row.Cells["ID"].Value.ToString() == currentItem.ID.ToString())
                            {
                                row.Selected = true;

                                gridViewLagerBok.FirstDisplayedScrollingRowIndex = row.Index;
                            }
                        }
                    }

                    if (currentItem.GetType().Name == "Videogame")
                    {
                        tabControlKassa.SelectedTab = kassaGameTab;
                        tabControlLager.SelectedTab = lagerGamesTab;
                        foreach (DataGridViewRow row in gridViewKassaSpel.Rows)
                        {
                            if (row.Cells["ID"].Value.ToString() == currentItem.ID.ToString())
                            {
                                row.Selected = true;

                                gridViewKassaSpel.FirstDisplayedScrollingRowIndex = row.Index;
                            }
                        }

                        foreach (DataGridViewRow row in gridViewLagerSpel.Rows)
                        {
                            if (row.Cells["ID"].Value.ToString() == currentItem.ID.ToString())
                            {
                                row.Selected = true;

                                gridViewLagerSpel.FirstDisplayedScrollingRowIndex = row.Index;
                            }
                        }
                    }

                    if (currentItem.GetType().Name == "Book")
                    {
                        tabControlKassa.SelectedTab = kassaFilmTab;
                        tabControlLager.SelectedTab = lagerFilmsTab;
                        foreach (DataGridViewRow row in gridViewKassaFilm.Rows)
                        {
                            if (row.Cells["ID"].Value.ToString() == currentItem.ID.ToString())
                            {
                                row.Selected = true;

                                gridViewKassaFilm.FirstDisplayedScrollingRowIndex = row.Index;
                            }
                        }

                        foreach (DataGridViewRow row in gridViewLagerFilm.Rows)
                        {
                            if (row.Cells["ID"].Value.ToString() == currentItem.ID.ToString())
                            {
                                row.Selected = true;

                                gridViewLagerFilm.FirstDisplayedScrollingRowIndex = row.Index;
                            }
                        }
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //save selected row as current item and show info 
        private void gridViewLagerBok_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewLagerBok.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewLagerBok.SelectedRows[0];

                Book book = controller.getBookFromInventory(int.Parse(selectedRow.Cells["ID"].Value.ToString()));

                currentItem = book;

                //show information about selected item
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
            if (gridViewLagerSpel.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewLagerSpel.SelectedRows[0];

                Videogame game = controller.getGameFromInventory(int.Parse(selectedRow.Cells["ID"].Value.ToString()));

                currentItem = game;

                IDGameText.Text = game.ID.ToString();
                AmountGameText.Text = game.Amount.ToString();
                NameGameText.Text = game.Name;
                PriceGameText.Text = game.Price.ToString();
                PlattformGameText.Text = game.Plattform;
            }
        }

        private void gridViewLagerFilm_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewLagerFilm.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewLagerFilm.SelectedRows[0];

                Film film = controller.getFilmFromInventory(int.Parse(selectedRow.Cells["ID"].Value.ToString()));

                currentItem = film;

                IDFilmText.Text = film.ID.ToString();
                AmountFilmText.Text = film.Amount.ToString();
                NameFilmText.Text = film.Name;
                PriceFilmText.Text = film.Price.ToString();
                FormatFilmText.Text = film.Format;
                TimeFilmText.Text = film.Time.ToString();
            }
        }

        //deselect items
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

        private void deselectResult()
        {
            if(gridViewResult.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewResult.SelectedRows[0];
                selectedRow.Selected = false;
            }
        }

        //add currentItem to shoppingCart
        private void addToShoppingCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentItem != null)
                {
                    //get data about the selected item

                    int amountInt = 1;
                    
                    bool itemInList = true;

                    string amount = amountInt.ToString();

                    string itemType = currentItem.GetType().Name;
                    string id = currentItem.ID.ToString();
                    string name = currentItem.Name;
                    string price = currentItem.Price.ToString();


                    //check if selected item is already in list, if it is update amount and price, if not add to list
                    foreach (ListViewItem listItem in shoppingBasketList.Items)
                    {
                        itemInList = false;
                        string itemId = listItem.SubItems[1].Text;

                        if (itemId.Equals(id))
                        {
                            //uppdate amount of items in shoppingcart
                            amountInt = int.Parse(listItem.SubItems[4].Text);
                            amountInt++;
                            listItem.SubItems[4].Text = amountInt.ToString();

                            //update price
                            int priceInt = int.Parse(listItem.SubItems[3].Text) + int.Parse(price);
                            listItem.SubItems[3].Text = priceInt.ToString();
                        }
                        else
                        {
                            itemInList = true;
                        }
                    }

                    if (itemInList)
                    {
                        //add new item to shoppingCart
                        ListViewItem item = new ListViewItem(new[] { itemType , id, name, price, amount });
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

        //remove items in shoppingCart from inventory and open receiptForm
        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem listItem in shoppingBasketList.Items)
                {
                    int listItemID = int.Parse(listItem.SubItems[1].Text);
                    int listItemAmount = int.Parse(listItem.SubItems[4].Text);

                    int total = int.Parse(totalPriceTextBox.Text);

                    controller.sellItem(listItemID, listItemAmount);

                    //refresh lists
                    gridViewKassaBok.Refresh();
                    gridViewKassaSpel.Refresh();
                    gridViewKassaFilm.Refresh();

                    //show reciept 
                    controller.createReceipt(shoppingBasketList, total);

                    foreach (ListViewItem item in shoppingBasketList.Items)
                    {
                        int id = int.Parse(item.SubItems[1].Text);
                        int month = DateTime.Now.Month;
                        int year = DateTime.Now.Year;
                        int amount = int.Parse(item.SubItems[4].Text);
                        controller.addTransactionToArchive(id, month, year, amount);
                    }

                    transactionsView.Refresh();

                    //empty shopping cart
                    shoppingBasketList.Items.Clear();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        //remove Items

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if(currentItem.GetType().Name == "Book")
            {
                controller.removeBookFromInventory(currentItem.ID);
            }
            
            else if(currentItem.GetType().Name == "Videogame")
            {
                controller.removeGameFromInventory(currentItem.ID);
            }

            else if (currentItem.GetType().Name == "Film")
            {
                controller.removeFilmFromInventory(currentItem.ID);
            }
        }
        
        //add items
        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                //exception handeling for wrong input
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

                //get and save information
                string name = NameBookText.Text;
                int price = int.Parse(PriceBookText.Text);
                int amount = int.Parse(AmountBookText.Text);
                string author = AuthorBookText.Text;
                string genre = GenreBookText.Text;
                string format = FormatBookText.Text;
                string language = LanguageBookText.Text;

                controller.addBookToInventory(id, name, price, amount, author, genre, format, language);
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

                controller.addGameToInventory(id, name, price, amount, plattform);
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

                controller.addFilmToInventory(id, name, price, amount, format, time);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        //add shipment 
        private void addShipmentBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input;
                int shipmentAmount;
                int id = currentItem.ID;
                input = Microsoft.VisualBasic.Interaction.InputBox("Hur stor är leveransen?:", "Integer Input", "0");

                shipmentAmount = int.Parse(input);

                //exception handeling for wrong input
                if (shipmentAmount < 1)
                {
                    throw new Exception("Leverans måste vara större än 0");
                }

                controller.AddItems(id, shipmentAmount);

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
                int id = currentItem.ID;
                input = Microsoft.VisualBasic.Interaction.InputBox("Hur stor är leveransen?:", "Integer Input", "0");

                shipmentAmount = int.Parse(input);
                if (shipmentAmount < 1)
                {
                    throw new Exception("Leverans måste vara större än 0");
                }

                controller.AddItems(id, shipmentAmount);

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
                int id = currentItem.ID;
                input = Microsoft.VisualBasic.Interaction.InputBox("Hur stor är leveransen?:", "Integer Input", "0");

                shipmentAmount = int.Parse(input);

                if (shipmentAmount < 1)
                {
                    throw new Exception("Leverans måste vara större än 0");
                }

                controller.AddItems(id, shipmentAmount);

                //update display
                gridViewLagerFilm_SelectionChanged(null, null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //return item (similar to add shipment)
        private void returnButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input;
                int amount;
                int id = currentItem.ID;

                input = Microsoft.VisualBasic.Interaction.InputBox("Hur många produkter ska återlämnas?:", "Integer Input", "0");

                amount = int.Parse(input);

                if (amount < 1)
                {
                    throw new Exception("Antal produkter måsta vara större än 0");
                }

                controller.AddItems(id, amount);

                gridViewKassaBok.Refresh();
                gridViewKassaFilm.Refresh();
                gridViewKassaSpel.Refresh();
                gridViewResult.Refresh();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //search
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = searchInput.Text.Trim();

                DataGridView table = gridViewResult;

                table.AutoGenerateColumns = false;

                //style result table
                table.Columns.Add("ID", "ID");
                table.Columns.Add("Name", "Namn");
                table.Columns.Add("Price", "Pris");
                table.Columns.Add("Amount", "Antal");

                table.Columns["ID"].DataPropertyName = "ID";
                table.Columns["Name"].DataPropertyName = "Name";
                table.Columns["Price"].DataPropertyName = "Price";
                table.Columns["Amount"].DataPropertyName = "Amount";

                //add results to table
                table.DataSource = controller.Search(query);

                table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //update database when closing 
        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.updateBookFile();
            controller.updateGameFile();
            controller.updateFilmFile();
            controller.updateTransactionFile();
        }

        private void emptyCartButton_Click(object sender, EventArgs e)
        {
            shoppingBasketList.Items.Clear();
        }

        public void addDataTransactions()
        {
            transactionsView.AutoGenerateColumns = false;

            transactionsView.Columns.Add("ID", "ID");
            transactionsView.Columns.Add("Month", "Månad");
            transactionsView.Columns.Add("Year", "År");
            transactionsView.Columns.Add("Amount", "Antal");


            //Set column names
            transactionsView.Columns["ID"].DataPropertyName = "ID";
            transactionsView.Columns["Month"].DataPropertyName = "Month";
            transactionsView.Columns["Year"].DataPropertyName = "Year";
            transactionsView.Columns["Amount"].DataPropertyName = "Amount";

            //Add data source
            transactionsView.DataSource = transactionsSource;

            transactionsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            filterView.AutoGenerateColumns = false;

            filterView.Columns.Add("ID", "ID");
            filterView.Columns.Add("Month", "Månad");
            filterView.Columns.Add("Year", "År");
            filterView.Columns.Add("Amount", "Antal");


            //Set column names
            filterView.Columns["ID"].DataPropertyName = "ID";
            filterView.Columns["Month"].DataPropertyName = "Month";
            filterView.Columns["Year"].DataPropertyName = "Year";
            filterView.Columns["Amount"].DataPropertyName = "Amount";

            //Add data source
            filterView.DataSource = transactionsSource;

            filterView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void viewArchiveButton_Click(object sender, EventArgs e)
        {

        }

        private void archiveTab_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = comboBox1.SelectedItem.ToString();
            top10View.DataSource = controller.FilterYear(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryMonth = monthBox.SelectedItem.ToString();
            string queryYear = yearBox.SelectedItem.ToString();
            (BindingSource source, int total) = controller.filter(queryMonth, queryYear);
            filterView.DataSource = source;
            totalAntalLabel.Text = total.ToString();
        }
    }
}
