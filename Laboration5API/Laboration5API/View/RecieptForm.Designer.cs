namespace Laboration5API
{
    partial class RecieptForm
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
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.receiptItemsList = new System.Windows.Forms.ListView();
            this.Produkt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Antal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Location = new System.Drawing.Point(201, 29);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(69, 17);
            this.DateTimeLabel.TabIndex = 0;
            this.DateTimeLabel.Text = "DateTime";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(203, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(67, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Kvitto";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(204, 60);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(46, 20);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price";
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.Location = new System.Drawing.Point(398, 9);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(75, 23);
            this.printReceiptButton.TabIndex = 5;
            this.printReceiptButton.Text = "Skriv ut";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // receiptItemsList
            // 
            this.receiptItemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.receiptItemsList.BackColor = System.Drawing.Color.Lavender;
            this.receiptItemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Produkt,
            this.ID,
            this.Namn,
            this.Pris,
            this.Antal});
            this.receiptItemsList.HideSelection = false;
            this.receiptItemsList.Location = new System.Drawing.Point(12, 83);
            this.receiptItemsList.Name = "receiptItemsList";
            this.receiptItemsList.Size = new System.Drawing.Size(461, 352);
            this.receiptItemsList.TabIndex = 6;
            this.receiptItemsList.UseCompatibleStateImageBehavior = false;
            this.receiptItemsList.View = System.Windows.Forms.View.Details;
            // 
            // Produkt
            // 
            this.Produkt.Text = "Produkt";
            this.Produkt.Width = 100;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 175;
            // 
            // Pris
            // 
            this.Pris.Text = "Pris";
            // 
            // Antal
            // 
            this.Antal.Text = "Antal";
            // 
            // RecieptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 447);
            this.Controls.Add(this.receiptItemsList);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DateTimeLabel);
            this.Name = "RecieptForm";
            this.Text = "Kvitto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.ListView receiptItemsList;
        private System.Windows.Forms.ColumnHeader Produkt;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Pris;
        private System.Windows.Forms.ColumnHeader Antal;
    }
}