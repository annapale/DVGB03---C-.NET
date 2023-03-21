namespace Laboration4Affärssystem
{
    partial class View
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.checkoutTab = new System.Windows.Forms.TabPage();
            this.labelKundKorg = new System.Windows.Forms.Label();
            this.kundKorg = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pris = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridViewKassaBok = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addToShoppingCartButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gridViewKassaSpel = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.gridViewKassaFilm = new System.Windows.Forms.DataGridView();
            this.lagerTab = new System.Windows.Forms.TabPage();
            this.tabLager = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.addShipmentBookButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.gridViewLagerBok = new System.Windows.Forms.DataGridView();
            this.gamesTab = new System.Windows.Forms.TabPage();
            this.addShipmentGameButton = new System.Windows.Forms.Button();
            this.removeGameButton = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.gridViewLagerSpel = new System.Windows.Forms.DataGridView();
            this.filmsTab = new System.Windows.Forms.TabPage();
            this.addShipmentFilmButton = new System.Windows.Forms.Button();
            this.removeFilmButton = new System.Windows.Forms.Button();
            this.addFilmButton = new System.Windows.Forms.Button();
            this.gridViewLagerFilm = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Antal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.checkoutTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKassaBok)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKassaSpel)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKassaFilm)).BeginInit();
            this.lagerTab.SuspendLayout();
            this.tabLager.SuspendLayout();
            this.booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLagerBok)).BeginInit();
            this.gamesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLagerSpel)).BeginInit();
            this.filmsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLagerFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.checkoutTab);
            this.tabControl1.Controls.Add(this.lagerTab);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // checkoutTab
            // 
            this.checkoutTab.Controls.Add(this.totalPriceTextBox);
            this.checkoutTab.Controls.Add(this.totalPriceLabel);
            this.checkoutTab.Controls.Add(this.labelKundKorg);
            this.checkoutTab.Controls.Add(this.kundKorg);
            this.checkoutTab.Controls.Add(this.tabControl3);
            this.checkoutTab.Location = new System.Drawing.Point(4, 30);
            this.checkoutTab.Name = "checkoutTab";
            this.checkoutTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkoutTab.Size = new System.Drawing.Size(885, 392);
            this.checkoutTab.TabIndex = 0;
            this.checkoutTab.Text = "Kassa";
            this.checkoutTab.UseVisualStyleBackColor = true;
            // 
            // labelKundKorg
            // 
            this.labelKundKorg.AutoSize = true;
            this.labelKundKorg.Location = new System.Drawing.Point(12, 247);
            this.labelKundKorg.Name = "labelKundKorg";
            this.labelKundKorg.Size = new System.Drawing.Size(85, 21);
            this.labelKundKorg.TabIndex = 4;
            this.labelKundKorg.Text = "KundKorg";
            // 
            // kundKorg
            // 
            this.kundKorg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Namn,
            this.Pris,
            this.Antal});
            this.kundKorg.HideSelection = false;
            this.kundKorg.Location = new System.Drawing.Point(6, 271);
            this.kundKorg.Name = "kundKorg";
            this.kundKorg.Size = new System.Drawing.Size(363, 118);
            this.kundKorg.TabIndex = 3;
            this.kundKorg.UseCompatibleStateImageBehavior = false;
            this.kundKorg.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 48;
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
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(6, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(858, 238);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridViewKassaBok);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.addToShoppingCartButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Böcker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridViewKassaBok
            // 
            this.gridViewKassaBok.AllowUserToAddRows = false;
            this.gridViewKassaBok.AllowUserToDeleteRows = false;
            this.gridViewKassaBok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewKassaBok.Location = new System.Drawing.Point(6, 6);
            this.gridViewKassaBok.Name = "gridViewKassaBok";
            this.gridViewKassaBok.Size = new System.Drawing.Size(841, 161);
            this.gridViewKassaBok.TabIndex = 5;
            this.gridViewKassaBok.SelectionChanged += new System.EventHandler(this.gridViewKassaBok_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(231, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "spara leverans";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(117, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "ta bort Bok";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addToShoppingCartButton
            // 
            this.addToShoppingCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToShoppingCartButton.Location = new System.Drawing.Point(3, 171);
            this.addToShoppingCartButton.Name = "addToShoppingCartButton";
            this.addToShoppingCartButton.Size = new System.Drawing.Size(108, 34);
            this.addToShoppingCartButton.TabIndex = 2;
            this.addToShoppingCartButton.Text = "sälja Bok";
            this.addToShoppingCartButton.UseVisualStyleBackColor = true;
            this.addToShoppingCartButton.Click += new System.EventHandler(this.addToShoppingCartButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.gridViewKassaSpel);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dataspel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "spara leverans";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "ta bort Spel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 34);
            this.button6.TabIndex = 3;
            this.button6.Text = "lägg till Spel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // gridViewKassaSpel
            // 
            this.gridViewKassaSpel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewKassaSpel.Location = new System.Drawing.Point(6, 6);
            this.gridViewKassaSpel.Name = "gridViewKassaSpel";
            this.gridViewKassaSpel.Size = new System.Drawing.Size(631, 286);
            this.gridViewKassaSpel.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.gridViewKassaFilm);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(850, 208);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Filmer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(260, 298);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 34);
            this.button7.TabIndex = 7;
            this.button7.Text = "spara leverans";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(133, 298);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 34);
            this.button8.TabIndex = 6;
            this.button8.Text = "ta bort Film";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 298);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 34);
            this.button9.TabIndex = 5;
            this.button9.Text = "lägg till Film";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // gridViewKassaFilm
            // 
            this.gridViewKassaFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewKassaFilm.Location = new System.Drawing.Point(6, 6);
            this.gridViewKassaFilm.Name = "gridViewKassaFilm";
            this.gridViewKassaFilm.Size = new System.Drawing.Size(726, 286);
            this.gridViewKassaFilm.TabIndex = 0;
            // 
            // lagerTab
            // 
            this.lagerTab.Controls.Add(this.tabLager);
            this.lagerTab.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerTab.Location = new System.Drawing.Point(4, 30);
            this.lagerTab.Name = "lagerTab";
            this.lagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.lagerTab.Size = new System.Drawing.Size(885, 392);
            this.lagerTab.TabIndex = 1;
            this.lagerTab.Text = "Lager";
            this.lagerTab.UseVisualStyleBackColor = true;
            // 
            // tabLager
            // 
            this.tabLager.Controls.Add(this.booksTab);
            this.tabLager.Controls.Add(this.gamesTab);
            this.tabLager.Controls.Add(this.filmsTab);
            this.tabLager.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLager.Location = new System.Drawing.Point(6, 6);
            this.tabLager.Name = "tabLager";
            this.tabLager.SelectedIndex = 0;
            this.tabLager.Size = new System.Drawing.Size(858, 368);
            this.tabLager.TabIndex = 0;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.addShipmentBookButton);
            this.booksTab.Controls.Add(this.removeBookButton);
            this.booksTab.Controls.Add(this.addBookButton);
            this.booksTab.Controls.Add(this.gridViewLagerBok);
            this.booksTab.Location = new System.Drawing.Point(4, 26);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(850, 338);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Böcker";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // addShipmentBookButton
            // 
            this.addShipmentBookButton.Location = new System.Drawing.Point(231, 298);
            this.addShipmentBookButton.Name = "addShipmentBookButton";
            this.addShipmentBookButton.Size = new System.Drawing.Size(121, 34);
            this.addShipmentBookButton.TabIndex = 4;
            this.addShipmentBookButton.Text = "spara leverans";
            this.addShipmentBookButton.UseVisualStyleBackColor = true;
            // 
            // removeBookButton
            // 
            this.removeBookButton.Location = new System.Drawing.Point(117, 298);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(108, 34);
            this.removeBookButton.TabIndex = 3;
            this.removeBookButton.Text = "ta bort Bok";
            this.removeBookButton.UseVisualStyleBackColor = true;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(3, 298);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(108, 34);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "lägg till Bok";
            this.addBookButton.UseVisualStyleBackColor = true;
            // 
            // gridViewLagerBok
            // 
            this.gridViewLagerBok.AllowUserToAddRows = false;
            this.gridViewLagerBok.AllowUserToDeleteRows = false;
            this.gridViewLagerBok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLagerBok.Location = new System.Drawing.Point(6, 6);
            this.gridViewLagerBok.Name = "gridViewLagerBok";
            this.gridViewLagerBok.ReadOnly = true;
            this.gridViewLagerBok.Size = new System.Drawing.Size(841, 286);
            this.gridViewLagerBok.TabIndex = 1;
            // 
            // gamesTab
            // 
            this.gamesTab.Controls.Add(this.addShipmentGameButton);
            this.gamesTab.Controls.Add(this.removeGameButton);
            this.gamesTab.Controls.Add(this.addGameButton);
            this.gamesTab.Controls.Add(this.gridViewLagerSpel);
            this.gamesTab.Location = new System.Drawing.Point(4, 26);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Padding = new System.Windows.Forms.Padding(3);
            this.gamesTab.Size = new System.Drawing.Size(850, 338);
            this.gamesTab.TabIndex = 1;
            this.gamesTab.Text = "Dataspel";
            this.gamesTab.UseVisualStyleBackColor = true;
            // 
            // addShipmentGameButton
            // 
            this.addShipmentGameButton.Location = new System.Drawing.Point(234, 298);
            this.addShipmentGameButton.Name = "addShipmentGameButton";
            this.addShipmentGameButton.Size = new System.Drawing.Size(125, 34);
            this.addShipmentGameButton.TabIndex = 5;
            this.addShipmentGameButton.Text = "spara leverans";
            this.addShipmentGameButton.UseVisualStyleBackColor = true;
            // 
            // removeGameButton
            // 
            this.removeGameButton.Location = new System.Drawing.Point(120, 298);
            this.removeGameButton.Name = "removeGameButton";
            this.removeGameButton.Size = new System.Drawing.Size(108, 34);
            this.removeGameButton.TabIndex = 4;
            this.removeGameButton.Text = "ta bort Spel";
            this.removeGameButton.UseVisualStyleBackColor = true;
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(6, 298);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(108, 34);
            this.addGameButton.TabIndex = 3;
            this.addGameButton.Text = "lägg till Spel";
            this.addGameButton.UseVisualStyleBackColor = true;
            // 
            // gridViewLagerSpel
            // 
            this.gridViewLagerSpel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLagerSpel.Location = new System.Drawing.Point(6, 6);
            this.gridViewLagerSpel.Name = "gridViewLagerSpel";
            this.gridViewLagerSpel.Size = new System.Drawing.Size(829, 286);
            this.gridViewLagerSpel.TabIndex = 0;
            // 
            // filmsTab
            // 
            this.filmsTab.Controls.Add(this.addShipmentFilmButton);
            this.filmsTab.Controls.Add(this.removeFilmButton);
            this.filmsTab.Controls.Add(this.addFilmButton);
            this.filmsTab.Controls.Add(this.gridViewLagerFilm);
            this.filmsTab.Location = new System.Drawing.Point(4, 26);
            this.filmsTab.Name = "filmsTab";
            this.filmsTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmsTab.Size = new System.Drawing.Size(850, 338);
            this.filmsTab.TabIndex = 2;
            this.filmsTab.Text = "Filmer";
            this.filmsTab.UseVisualStyleBackColor = true;
            // 
            // addShipmentFilmButton
            // 
            this.addShipmentFilmButton.Location = new System.Drawing.Point(260, 298);
            this.addShipmentFilmButton.Name = "addShipmentFilmButton";
            this.addShipmentFilmButton.Size = new System.Drawing.Size(121, 34);
            this.addShipmentFilmButton.TabIndex = 7;
            this.addShipmentFilmButton.Text = "spara leverans";
            this.addShipmentFilmButton.UseVisualStyleBackColor = true;
            // 
            // removeFilmButton
            // 
            this.removeFilmButton.Location = new System.Drawing.Point(133, 298);
            this.removeFilmButton.Name = "removeFilmButton";
            this.removeFilmButton.Size = new System.Drawing.Size(121, 34);
            this.removeFilmButton.TabIndex = 6;
            this.removeFilmButton.Text = "ta bort Film";
            this.removeFilmButton.UseVisualStyleBackColor = true;
            // 
            // addFilmButton
            // 
            this.addFilmButton.Location = new System.Drawing.Point(6, 298);
            this.addFilmButton.Name = "addFilmButton";
            this.addFilmButton.Size = new System.Drawing.Size(121, 34);
            this.addFilmButton.TabIndex = 5;
            this.addFilmButton.Text = "lägg till Film";
            this.addFilmButton.UseVisualStyleBackColor = true;
            // 
            // gridViewLagerFilm
            // 
            this.gridViewLagerFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLagerFilm.Location = new System.Drawing.Point(6, 6);
            this.gridViewLagerFilm.Name = "gridViewLagerFilm";
            this.gridViewLagerFilm.Size = new System.Drawing.Size(726, 286);
            this.gridViewLagerFilm.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Antal
            // 
            this.Antal.Text = "Antal";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(375, 365);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(98, 21);
            this.totalPriceLabel.TabIndex = 5;
            this.totalPriceLabel.Text = "Att betala:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(479, 365);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 27);
            this.totalPriceTextBox.TabIndex = 6;
            this.totalPriceTextBox.Text = "0";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(952, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "View";
            this.Text = "Affärssystem";
            this.tabControl1.ResumeLayout(false);
            this.checkoutTab.ResumeLayout(false);
            this.checkoutTab.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKassaBok)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKassaSpel)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKassaFilm)).EndInit();
            this.lagerTab.ResumeLayout(false);
            this.tabLager.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLagerBok)).EndInit();
            this.gamesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLagerSpel)).EndInit();
            this.filmsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLagerFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage checkoutTab;
        private System.Windows.Forms.TabPage lagerTab;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabLager;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.DataGridView gridViewLagerBok;
        private System.Windows.Forms.TabPage gamesTab;
        private System.Windows.Forms.DataGridView gridViewLagerSpel;
        private System.Windows.Forms.TabPage filmsTab;
        private System.Windows.Forms.DataGridView gridViewLagerFilm;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Button addShipmentBookButton;
        private System.Windows.Forms.Button addShipmentGameButton;
        private System.Windows.Forms.Button removeGameButton;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button addShipmentFilmButton;
        private System.Windows.Forms.Button removeFilmButton;
        private System.Windows.Forms.Button addFilmButton;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridViewKassaBok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addToShoppingCartButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView gridViewKassaSpel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView gridViewKassaFilm;
        private System.Windows.Forms.ListView kundKorg;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Pris;
        private System.Windows.Forms.Label labelKundKorg;
        private System.Windows.Forms.ColumnHeader Antal;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox totalPriceTextBox;
    }
}

