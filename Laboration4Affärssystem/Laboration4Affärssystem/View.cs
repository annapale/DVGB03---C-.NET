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

            addData(gridViewKassaBok, 1);
            addData(gridViewKassaSpel, 2);
            addData(gridViewKassaFilm, 3);

            addData(gridViewLagerBok, 1);
            addData(gridViewLagerSpel, 2);
            addData(gridViewLagerFilm, 3);

        }

        private void addData(DataGridView table, int itemType)
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

        private void gridViewKassaBok_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewKassaBok.SelectedRows.Count > 0)
            {
               selectedItem = gridViewKassaBok.SelectedRows[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
