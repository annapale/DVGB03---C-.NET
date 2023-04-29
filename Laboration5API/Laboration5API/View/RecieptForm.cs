using Laboration5API.Model;
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

namespace Laboration5API
{
    public partial class RecieptForm : Form
    {

        public RecieptForm(ListView shoppingBasket, int total)
        {
            InitializeComponent();

            try
            {
                DateTimeLabel.Text = DateTime.Now.ToString();

                //clone shippingcart items
                foreach (ListViewItem item in shoppingBasket.Items)
                {
                    ListViewItem receiptItem = (ListViewItem)item.Clone();
                    receiptItemsList.Items.Add(receiptItem);
                }

                PriceLabel.Text = total.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(PrintReceipt);

                //display print dialog
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    //start printing
                    pd.PrinterSettings = printDialog.PrinterSettings;
                    pd.Print();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            try
            {
                // set font, brush and line height
                Font font = new Font("Times New Roman", 16);
                Brush brush = Brushes.Black;

                int lineHeight = font.Height + 5;
                int x = 100;
                int y = 100;

                //print info
                e.Graphics.DrawString("Kvitto", font, brush, new PointF(x, y));
                y += lineHeight;
                e.Graphics.DrawString("Datum: " + DateTime.Now.ToString(), font, brush, new PointF(x, y));
                y += lineHeight;

                foreach (ListViewItem item in receiptItemsList.Items)
                {
                    y += lineHeight;
                    e.Graphics.DrawString(item.SubItems[4].Text + " x " + item.SubItems[2].Text + "   " + item.SubItems[3].Text + "kr", font, brush, new PointF(x, y));
                }
                y += lineHeight;
                e.Graphics.DrawString("Total: " + PriceLabel.Text.ToString() + "kr", font, brush, new PointF(x, y));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
