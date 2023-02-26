using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream outStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outStream);

                writer.Write(richTextBox1.Text);

                writer.Dispose();
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream inStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inStream);
                string fileText = reader.ReadToEnd();
                richTextBox1.Text = fileText;
                reader.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled.txt"; 
        }
    }
}
