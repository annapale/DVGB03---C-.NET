//Anna-Maria Paleczek
//DVGB07
//Laboration 3
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboration3TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();

            this.AllowDrop = true;
        }

        //variable for saving fileName 
        string fileLocation = null;

        //check if text is changed 
        bool newText = false;

      
        //open file
        private void readFile()
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileStream inStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(inStream);
                    string fileText = reader.ReadToEnd();
                    richTextBox.Text = fileText;

                    //saves file Name so the "save" button works
                    fileLocation = openFileDialog1.FileName;

                    //change title 
                    this.Text = Path.GetFileName(fileLocation);

                    //no new text even if text in textbox has been changed
                    newText = false;

                    reader.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        //save text as textfile
        private void writeFile()
        {
            try
            {
                DialogResult result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    FileStream outStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(outStream);

                    writer.Write(richTextBox.Text);
                    fileLocation = saveFileDialog1.FileName;

                    writer.Dispose();

                    //no usaved text
                    newText = false;
                    this.Text = Path.GetFileName(fileLocation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //save text in the same file
        private void saveFile()
        {
            try
            {
                //if no file is currently openend goes to save as method instead
                if (fileLocation == null)
                {
                    writeFile();
                }
                else
                {
                    StreamWriter writer = new StreamWriter(fileLocation);
                    writer.Write(richTextBox.Text);
                    writer.Dispose();

                    //no unsaved text
                    newText = false;
                    this.Text = Path.GetFileName(fileLocation);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }

        }

        //open file
        private void openFile()
        {
            try
            {
                //if the text has changed
                if (newText)
                {
                    
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);

                    //saves old file and opens new file
                    if (result == DialogResult.Yes)
                    {
                        saveFile();
                        readFile();
                    }
                    //opens new file 
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
                    readFile();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                          
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled.txt";
        }

        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            if (newText)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);

                //saves old file and opens new file
                if (result == DialogResult.Yes)
                {
                    saveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            
            richTextBox.Text = string.Empty;
            this.Text = "Untitled.txt";
            fileLocation = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            writeFile();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox.Text = string.Empty;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            //adds * to title 
            if (fileLocation == null)
            {
                this.Text = "*Untitled.txt";
            }
            else
            {
                this.Text = "*" + Path.GetFileName(fileLocation);
            }

            newText = true;

            //updates status bar
            string text = richTextBox.Text;

            int charCountWSpaces = text.Length;
            int charCountWOSpaces = text.Replace(" ", "").Length;
            int wordCount = text.Split(' ', '\n', '\r').Length;
            int rowCount = richTextBox.Lines.Length;

            toolStripStatusWith.Text = "Characters With Space: " + charCountWSpaces.ToString();
            toolStripStatusWithout.Text = "Characters Without Space: " + charCountWOSpaces.ToString();
            toolStripStatusWords.Text = "Words: " + wordCount.ToString();
            toolStripStatusRows.Text = "Rows: " + rowCount.ToString();
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save prompt
            if (newText)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
                
                if (result == DialogResult.Yes)
                {
                    saveFile(); 
                }

                //don't close if cancel
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        //Drag&Drop
        private void TextEditor_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                foreach (string file in files)
                {
                   
                    switch (ModifierKeys)
                    {
                        //add text to end of textBox
                        case Keys.Control:
                            richTextBox.Text += File.ReadAllText(file);
                            break;

                        //add text to curser position
                        case Keys.Shift:
                            int currentPosition = richTextBox.SelectionStart;
                            richTextBox.SelectedText = File.ReadAllText(file);
                            break;

                        //if no key is pressed open file
                        case Keys.None:
                         //if text got changed
                             if (newText)
                             {
                                //if a file is already open
                                if (fileLocation != null)
                                {
                                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel);
                                    //save file and open new file
                                    if (result == DialogResult.Yes)
                                    {
                                        saveFile();

                                        StreamReader reader = new StreamReader(file);
                                        string fileText = reader.ReadToEnd();
                                        richTextBox.Text = fileText;

                                        fileLocation = file;

                                        this.Text = Path.GetFileName(fileLocation);

                                        reader.Dispose();

                                        //fix newText = true from the TextChanged-Method
                                        newText = false;
                                    }
                                    //open new file without saving 
                                    else if (result == DialogResult.No)
                                    {
                                        StreamReader reader = new StreamReader(file);
                                        string fileText = reader.ReadToEnd();
                                        richTextBox.Text = fileText;

                                        fileLocation = file;

                                        this.Text = Path.GetFileName(fileLocation);

                                        reader.Dispose();

                                        //fix newText = true from the TextChanged-Method
                                        newText = false;
                                    }
                                    //do nothing
                                    else if (result == DialogResult.Cancel)
                                    {
                                        return;
                                    }

                                }

                                //if no file is open
                                else
                                {
                                    readFile();
                                }
                             }

                             //if text wasnt changed open new file 
                             else
                             {
                                StreamReader reader = new StreamReader(file);
                                string fileText = reader.ReadToEnd();
                                richTextBox.Text = fileText;

                                fileLocation = file;

                                this.Text = Path.GetFileName(fileLocation);

                                reader.Dispose();

                                //fix newText = true from the TextChanged-Method
                                newText = false;
                             }                         
                             break;
                        
                         //do nothing if any other key is pressed
                        default:
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextEditor_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

       
    }
}
