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

namespace Laboration4Affärssystem
{
    public partial class View : System.Windows.Forms.Form
    {
        public View()
        {
            InitializeComponent();

            Controller controller = new Controller();

            controller.createBookList();

            dataGridViewKassaBooks.DataSource = controller.bookSource;
        }
           
    }
}
