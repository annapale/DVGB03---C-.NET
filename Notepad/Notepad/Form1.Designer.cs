namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rows = new System.Windows.Forms.Label();
            this.words = new System.Windows.Forms.Label();
            this.charWOSpace = new System.Windows.Forms.Label();
            this.charWSpace = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 247);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(12, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(103, 43);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClear.Location = new System.Drawing.Point(230, 13);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(103, 43);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSaveAs.Location = new System.Drawing.Point(121, 13);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(103, 43);
            this.buttonSaveAs.TabIndex = 3;
            this.buttonSaveAs.Text = "Save As...";
            this.buttonSaveAs.UseVisualStyleBackColor = false;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonOpen.Location = new System.Drawing.Point(339, 13);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(103, 43);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClose.Location = new System.Drawing.Point(448, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(103, 43);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rows);
            this.panel1.Controls.Add(this.words);
            this.panel1.Controls.Add(this.charWOSpace);
            this.panel1.Controls.Add(this.charWSpace);
            this.panel1.Location = new System.Drawing.Point(12, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 79);
            this.panel1.TabIndex = 6;
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rows.Location = new System.Drawing.Point(296, 44);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(51, 18);
            this.rows.TabIndex = 3;
            this.rows.Text = "Rows:";
            this.rows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // words
            // 
            this.words.AutoSize = true;
            this.words.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.words.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.words.Location = new System.Drawing.Point(290, 11);
            this.words.Name = "words";
            this.words.Size = new System.Drawing.Size(57, 18);
            this.words.TabIndex = 2;
            this.words.Text = "Words:";
            this.words.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // charWOSpace
            // 
            this.charWOSpace.AutoSize = true;
            this.charWOSpace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.charWOSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charWOSpace.Location = new System.Drawing.Point(3, 44);
            this.charWOSpace.Name = "charWOSpace";
            this.charWOSpace.Size = new System.Drawing.Size(182, 18);
            this.charWOSpace.TabIndex = 1;
            this.charWOSpace.Text = "Characters without Space:";
            this.charWOSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // charWSpace
            // 
            this.charWSpace.AutoSize = true;
            this.charWSpace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.charWSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charWSpace.Location = new System.Drawing.Point(3, 11);
            this.charWSpace.Name = "charWSpace";
            this.charWSpace.Size = new System.Drawing.Size(161, 18);
            this.charWSpace.TabIndex = 0;
            this.charWSpace.Text = "Characters with Space:";
            this.charWSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label charWSpace;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Label words;
        private System.Windows.Forms.Label charWOSpace;
    }
}

