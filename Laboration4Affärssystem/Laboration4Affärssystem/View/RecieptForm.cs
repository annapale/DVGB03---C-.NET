using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration4Affärssystem
{
    public partial class RecieptForm : Form
    {
        Controller controller = new Controller();

        public RecieptForm(ListView shoppingBasket, int total)
        {
            InitializeComponent();

            DateTimeLabel.Text = DateTime.Now.ToString();

            foreach (ListViewItem item in shoppingBasket.Items)
            {
                ListViewItem receiptItem = (ListViewItem)item.Clone();
                receiptItemsList.Items.Add(receiptItem);
            }

            PriceLabel.Text = total.ToString();
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintReceipt);

            // Display the PrintDialog to get the user's printer and print settings
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the printer settings and start the printing process
                pd.PrinterSettings = printDialog.PrinterSettings;
                pd.Print();
            }
        }

        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            // Define the font and brush to use for printing
            Font font = new Font("Times New Roman", 16);
            Brush brush = Brushes.Black;

            // Calculate the position of the next line of text
            int lineHeight = font.Height + 5;
            int x = 100;
            int y = 100;

            // Print the transaction details on the page
            e.Graphics.DrawString("Kvitto", font, brush, new PointF(x, y));
            y += lineHeight;
            e.Graphics.DrawString("Datum: " + DateTime.Now.ToString(), font, brush, new PointF(x, y));
            y += lineHeight;
            
            foreach (ListViewItem item in receiptItemsList.Items)
            {
                y += lineHeight;
                e.Graphics.DrawString(item.SubItems[3].Text + "x" + item.SubItems[1].Text + "   " + item.SubItems[2].Text + "kr" , font, brush, new PointF(x, y));
            }
            y += lineHeight;
            e.Graphics.DrawString("Total: " + PriceLabel.Text.ToString() + "kr", font, brush, new PointF(x, y));
        }
    }
}
