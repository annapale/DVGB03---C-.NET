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

            this.AllowDrop = true;

            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
           // this.DragOver += new DragEventHandler(Form1_DragOver);
        }

        string fileLocation = null;
        bool newText = false;

        private void readFile()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream inStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(inStream);
                string fileText = reader.ReadToEnd();
                richTextBox1.Text = fileText;

                //saves file Name so the "save" button works
                fileLocation = openFileDialog1.FileName;
               
                this.Text = Path.GetFileName(fileLocation);

                newText = false;

                reader.Dispose();
            }
        }

        private void writeFile()
        {
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream outStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outStream);

                writer.Write(richTextBox1.Text);
                fileLocation = saveFileDialog1.FileName;

                writer.Dispose();
                newText = false;
            }
        }

        private void saveFile()
        {
            //saves file to same location
            if (fileLocation == null)
            {
                writeFile();
            }
            else
            {
                StreamWriter writer = new StreamWriter(fileLocation);
                writer.Write(richTextBox1.Text);
                writer.Dispose();
                newText = false;
            }
          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (newText)
            {
                if (fileLocation != null)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        saveFile();
                        readFile();
                    }
                    else if (result == DialogResult.No)
                    {
                        readFile();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return;
                    }

                }
                else
                {
                    //if there is no location saved, saves new file
                    readFile();
                }
            }
            else
            {
                readFile();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled.txt";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            writeFile();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(fileLocation == null)
            {
                this.Text = "*Untitled.txt";
            }
            else
            {
                this.Text = "*" + Path.GetFileName(fileLocation);
            }

            newText = true;

            string text = richTextBox1.Text;
            int charCountWSpaces = text.Length;
            int charCountWOSpaces = text.Replace(" ", "").Length;
            int wordCount = text.Split(' ', '\n', '\r').Length;
            int rowCount = richTextBox1.Lines.Length;

            charWSpace.Text = "Characters With Space: " + charCountWSpaces.ToString();
            charWOSpace.Text = "Characters Without Space: " + charCountWOSpaces.ToString();
            words.Text = "Words: " + wordCount.ToString();
            rows.Text = "Rows: " + rowCount.ToString();
            

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newText)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (fileLocation == null)
                    {
                        writeFile();
                    }
                    else
                    {
                        saveFile();
                    }
                }

                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    richTextBox1.Text += File.ReadAllText(file);
                    break;
                }
                else if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    int mousePoint = richTextBox1.GetCharIndexFromPosition(richTextBox1.PointToClient(new Point(e.X, e.Y)));
                    richTextBox1.Select(mousePoint, 0);
                    richTextBox1.SelectedText = File.ReadAllText(file);
                }
                else
                {
                    //FileStream inStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file);
                    string fileText = reader.ReadToEnd();
                    richTextBox1.Text = fileText;

                    //saves file Name so the "save" button works
                    fileLocation = openFileDialog1.FileName;

                    this.Text = Path.GetFileName(fileLocation);

                    reader.Dispose();
                }
            }



        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            } 
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /*private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }*/
    }
}
