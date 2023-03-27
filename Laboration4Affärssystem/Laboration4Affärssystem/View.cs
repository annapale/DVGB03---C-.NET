using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            controller.createBookList();
            controller.createGameList();
            controller.createFilmList();

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

                    break;
            }
        }

        private void gridViewKassaBok_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewKassaBok.SelectedRows.Count > 0)
            {
               selectedItem = gridViewKassaBok.SelectedRows[0];
            }
        }

        private void gridViewKassaSpel_SelectionChanged(object sender, EventArgs e)
        {
            if(gridViewKassaSpel.SelectedRows.Count > 0)
            {
                selectedItem = gridViewKassaSpel.SelectedRows[0];
            }
        }

        private void gridViewKassaFilm_SelectionChanged(object sender, EventArgs e)
        {
            if(gridViewKassaFilm.SelectedRows.Count > 0)
            {
                selectedItem = gridViewKassaFilm.SelectedRows[0];
            }
        }

        private void addToShoppingCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedItem != null)
                {
                    string id = selectedItem.Cells["ID"].Value.ToString();
                    string name = selectedItem.Cells["Name"].Value.ToString();
                    int amountInt = 1;
                    string price = selectedItem.Cells["Price"].Value.ToString();
                    int counter = 0;

                    string amount = amountInt.ToString();

                    foreach (ListViewItem listItem in kundKorg.Items)
                    {
                        counter++;
                        string itemId = listItem.SubItems[0].Text;
                        if (itemId.Equals(id))
                        {
                            string currentAmount = listItem.SubItems[3].Text;
                            amountInt = int.Parse(currentAmount);
                            amountInt++;
                            listItem.SubItems[3].Text = amountInt.ToString();

                            int priceInt = int.Parse(listItem.SubItems[2].Text) + int.Parse(price);
                            listItem.SubItems[2].Text = priceInt.ToString();
                            break;
                        }
                        else
                        {
                            counter = 0;
                        }
                    }

                    if (counter == 0)
                    {
                        ListViewItem item = new ListViewItem(new[] { id, name, price, amount });
                        kundKorg.Items.Add(item);
                    }

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
                TimeFilmText.Text = film.Time;
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
                string format = FormatFilmText.Text;
                string time = TimeFilmText.Text;

                controller.addFilm(id, name, price, amount, format, time);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            

        }

        private void addShipmentFilmButton_Click(object sender, EventArgs e)
        {
            try
            { 

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
