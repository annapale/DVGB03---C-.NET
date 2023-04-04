using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration4Affärssystem
{
    public partial class RecieptForm : Form
    {
        public RecieptForm(ListView shoppingBasket)
        {
            InitializeComponent();

            DateTimeLabel.Text = DateTime.Now.ToString();

            foreach (ListViewItem item in shoppingBasket.Items)
            {
                ListViewItem receiptItem = (ListViewItem)item.Clone();
                receiptItemsList.Items.Add(receiptItem);
            }
        }

        private void RecieptForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DateTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
