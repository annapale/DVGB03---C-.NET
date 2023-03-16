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
            this.lagerTab = new System.Windows.Forms.TabPage();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.filmsTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gamesTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.addBookButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.addShipmentBookButton = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.removeGameButton = new System.Windows.Forms.Button();
            this.addShipmentGameButton = new System.Windows.Forms.Button();
            this.addFilmButton = new System.Windows.Forms.Button();
            this.removeFilmButton = new System.Windows.Forms.Button();
            this.addShipmentFilmButton = new System.Windows.Forms.Button();
            this.IDGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plattform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormatBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.lagerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.filmsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gamesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tabControl2.SuspendLayout();
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
            this.checkoutTab.Location = new System.Drawing.Point(4, 30);
            this.checkoutTab.Name = "checkoutTab";
            this.checkoutTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkoutTab.Size = new System.Drawing.Size(826, 392);
            this.checkoutTab.TabIndex = 0;
            this.checkoutTab.Text = "Kassa";
            this.checkoutTab.UseVisualStyleBackColor = true;
            // 
            // lagerTab
            // 
            this.lagerTab.Controls.Add(this.tabControl2);
            this.lagerTab.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerTab.Location = new System.Drawing.Point(4, 30);
            this.lagerTab.Name = "lagerTab";
            this.lagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.lagerTab.Size = new System.Drawing.Size(885, 392);
            this.lagerTab.TabIndex = 1;
            this.lagerTab.Text = "Lager";
            this.lagerTab.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // filmsTab
            // 
            this.filmsTab.Controls.Add(this.addShipmentFilmButton);
            this.filmsTab.Controls.Add(this.removeFilmButton);
            this.filmsTab.Controls.Add(this.addFilmButton);
            this.filmsTab.Controls.Add(this.dataGridView2);
            this.filmsTab.Location = new System.Drawing.Point(4, 26);
            this.filmsTab.Name = "filmsTab";
            this.filmsTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmsTab.Size = new System.Drawing.Size(850, 338);
            this.filmsTab.TabIndex = 2;
            this.filmsTab.Text = "Filmer";
            this.filmsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFilm,
            this.Film,
            this.PriceFilm,
            this.Time,
            this.amountFilm});
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(726, 286);
            this.dataGridView2.TabIndex = 0;
            // 
            // gamesTab
            // 
            this.gamesTab.Controls.Add(this.addShipmentGameButton);
            this.gamesTab.Controls.Add(this.removeGameButton);
            this.gamesTab.Controls.Add(this.addGameButton);
            this.gamesTab.Controls.Add(this.dataGridView1);
            this.gamesTab.Location = new System.Drawing.Point(4, 26);
            this.gamesTab.Name = "gamesTab";
            this.gamesTab.Padding = new System.Windows.Forms.Padding(3);
            this.gamesTab.Size = new System.Drawing.Size(850, 338);
            this.gamesTab.TabIndex = 1;
            this.gamesTab.Text = "Dataspel";
            this.gamesTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGame,
            this.Game,
            this.PriceGame,
            this.Plattform,
            this.amountGame});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.addShipmentBookButton);
            this.booksTab.Controls.Add(this.removeBookButton);
            this.booksTab.Controls.Add(this.addBookButton);
            this.booksTab.Controls.Add(this.dataGridViewBooks);
            this.booksTab.Location = new System.Drawing.Point(4, 26);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(850, 338);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Böcker";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBook,
            this.Book,
            this.PriceBook,
            this.Author,
            this.Genre,
            this.FormatBook,
            this.Language,
            this.amountBook});
            this.dataGridViewBooks.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(841, 286);
            this.dataGridViewBooks.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.booksTab);
            this.tabControl2.Controls.Add(this.gamesTab);
            this.tabControl2.Controls.Add(this.filmsTab);
            this.tabControl2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(858, 368);
            this.tabControl2.TabIndex = 0;
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
            // removeBookButton
            // 
            this.removeBookButton.Location = new System.Drawing.Point(117, 298);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(108, 34);
            this.removeBookButton.TabIndex = 3;
            this.removeBookButton.Text = "ta bort Bok";
            this.removeBookButton.UseVisualStyleBackColor = true;
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
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(6, 298);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(108, 34);
            this.addGameButton.TabIndex = 3;
            this.addGameButton.Text = "lägg till Spel";
            this.addGameButton.UseVisualStyleBackColor = true;
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
            // addShipmentGameButton
            // 
            this.addShipmentGameButton.Location = new System.Drawing.Point(234, 298);
            this.addShipmentGameButton.Name = "addShipmentGameButton";
            this.addShipmentGameButton.Size = new System.Drawing.Size(125, 34);
            this.addShipmentGameButton.TabIndex = 5;
            this.addShipmentGameButton.Text = "spara leverans";
            this.addShipmentGameButton.UseVisualStyleBackColor = true;
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
            // removeFilmButton
            // 
            this.removeFilmButton.Location = new System.Drawing.Point(133, 298);
            this.removeFilmButton.Name = "removeFilmButton";
            this.removeFilmButton.Size = new System.Drawing.Size(121, 34);
            this.removeFilmButton.TabIndex = 6;
            this.removeFilmButton.Text = "ta bort Film";
            this.removeFilmButton.UseVisualStyleBackColor = true;
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
            // IDGame
            // 
            this.IDGame.HeaderText = "ID";
            this.IDGame.Name = "IDGame";
            // 
            // Game
            // 
            this.Game.HeaderText = "Namn";
            this.Game.Name = "Game";
            // 
            // PriceGame
            // 
            this.PriceGame.HeaderText = "Price";
            this.PriceGame.Name = "PriceGame";
            // 
            // Plattform
            // 
            this.Plattform.HeaderText = "Plattform";
            this.Plattform.Name = "Plattform";
            // 
            // amountGame
            // 
            this.amountGame.HeaderText = "Antal";
            this.amountGame.Name = "amountGame";
            // 
            // IDFilm
            // 
            this.IDFilm.HeaderText = "ID";
            this.IDFilm.Name = "IDFilm";
            // 
            // Film
            // 
            this.Film.HeaderText = "Namn";
            this.Film.Name = "Film";
            // 
            // PriceFilm
            // 
            this.PriceFilm.HeaderText = "Pris";
            this.PriceFilm.Name = "PriceFilm";
            // 
            // Time
            // 
            this.Time.HeaderText = "Speltid";
            this.Time.Name = "Time";
            // 
            // amountFilm
            // 
            this.amountFilm.HeaderText = "Antal";
            this.amountFilm.Name = "amountFilm";
            // 
            // IDBook
            // 
            this.IDBook.HeaderText = "ID";
            this.IDBook.Name = "IDBook";
            // 
            // Book
            // 
            this.Book.HeaderText = "Namn";
            this.Book.Name = "Book";
            // 
            // PriceBook
            // 
            this.PriceBook.HeaderText = "Pris";
            this.PriceBook.Name = "PriceBook";
            // 
            // Author
            // 
            this.Author.HeaderText = "Författare";
            this.Author.Name = "Author";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // FormatBook
            // 
            this.FormatBook.HeaderText = "Format";
            this.FormatBook.Name = "FormatBook";
            // 
            // Language
            // 
            this.Language.HeaderText = "Språk";
            this.Language.Name = "Language";
            // 
            // amountBook
            // 
            this.amountBook.HeaderText = "Antal";
            this.amountBook.Name = "amountBook";
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
            this.lagerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.filmsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gamesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.booksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage checkoutTab;
        private System.Windows.Forms.TabPage lagerTab;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TabPage gamesTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage filmsTab;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Button addShipmentBookButton;
        private System.Windows.Forms.Button addShipmentGameButton;
        private System.Windows.Forms.Button removeGameButton;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormatBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plattform;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGame;
        private System.Windows.Forms.Button addShipmentFilmButton;
        private System.Windows.Forms.Button removeFilmButton;
        private System.Windows.Forms.Button addFilmButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountFilm;
    }
}

