namespace VideoRentalStore
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MoviesList = new System.Windows.Forms.DataGridView();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_Ratings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRatingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieDelete = new System.Windows.Forms.Button();
            this.MovieModify = new System.Windows.Forms.Button();
            this.MovieAdd = new System.Windows.Forms.Button();
            this.MovieGenreBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MovieCostText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AvailableCopiesValue = new System.Windows.Forms.NumericUpDown();
            this.MovieAvailableCopies = new System.Windows.Forms.Label();
            this.MovieRatings = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieReleaseDateText = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.MovieTitleText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.modifyCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomersList = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ReturnMovie = new System.Windows.Forms.Button();
            this.IssueMovie = new System.Windows.Forms.Button();
            this.RentTillMovie = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.RentFromMovie = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RentalsList = new System.Windows.Forms.DataGridView();
            this.RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentTill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCopiesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRatings)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(4, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MoviesList);
            this.tabPage1.Controls.Add(this.MovieDelete);
            this.tabPage1.Controls.Add(this.MovieModify);
            this.tabPage1.Controls.Add(this.MovieAdd);
            this.tabPage1.Controls.Add(this.MovieGenreBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.MovieCostText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.AvailableCopiesValue);
            this.tabPage1.Controls.Add(this.MovieAvailableCopies);
            this.tabPage1.Controls.Add(this.MovieRatings);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MovieReleaseDateText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.MovieTitleText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MoviesList
            // 
            this.MoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.MovieTitle,
            this.ReleaseDate,
            this.Movie_Ratings,
            this.AvailableCopies,
            this.MovieRatingCost,
            this.Genre});
            this.MoviesList.Location = new System.Drawing.Point(6, 3);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(917, 641);
            this.MoviesList.TabIndex = 33;
            this.MoviesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MoviesList_CellClick);
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "ID";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            this.MovieID.Width = 52;
            // 
            // MovieTitle
            // 
            this.MovieTitle.DataPropertyName = "Movietitle";
            this.MovieTitle.HeaderText = "Movie Title";
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            this.MovieTitle.Width = 170;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "MovieReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 250;
            // 
            // Movie_Ratings
            // 
            this.Movie_Ratings.DataPropertyName = "MovieRatings";
            this.Movie_Ratings.HeaderText = "Ratings";
            this.Movie_Ratings.Name = "Movie_Ratings";
            this.Movie_Ratings.ReadOnly = true;
            // 
            // AvailableCopies
            // 
            this.AvailableCopies.DataPropertyName = "MovieCopies";
            this.AvailableCopies.HeaderText = "Copies";
            this.AvailableCopies.Name = "AvailableCopies";
            this.AvailableCopies.ReadOnly = true;
            // 
            // MovieRatingCost
            // 
            this.MovieRatingCost.DataPropertyName = "MovieRentingCost";
            this.MovieRatingCost.HeaderText = "Price";
            this.MovieRatingCost.Name = "MovieRatingCost";
            this.MovieRatingCost.ReadOnly = true;
            // 
            // Genre
            // 
            this.Genre.DataPropertyName = "MovieGenre";
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // MovieDelete
            // 
            this.MovieDelete.Location = new System.Drawing.Point(929, 612);
            this.MovieDelete.Name = "MovieDelete";
            this.MovieDelete.Size = new System.Drawing.Size(311, 32);
            this.MovieDelete.TabIndex = 32;
            this.MovieDelete.Text = "Delete Movie";
            this.MovieDelete.UseVisualStyleBackColor = true;
            this.MovieDelete.Click += new System.EventHandler(this.MovieDelete_Click);
            // 
            // MovieModify
            // 
            this.MovieModify.Location = new System.Drawing.Point(1092, 300);
            this.MovieModify.Name = "MovieModify";
            this.MovieModify.Size = new System.Drawing.Size(147, 40);
            this.MovieModify.TabIndex = 31;
            this.MovieModify.Text = "Modify Movie";
            this.MovieModify.UseVisualStyleBackColor = true;
            this.MovieModify.Click += new System.EventHandler(this.MovieModify_Click);
            // 
            // MovieAdd
            // 
            this.MovieAdd.Location = new System.Drawing.Point(929, 300);
            this.MovieAdd.Name = "MovieAdd";
            this.MovieAdd.Size = new System.Drawing.Size(156, 40);
            this.MovieAdd.TabIndex = 30;
            this.MovieAdd.Text = "Add Movie";
            this.MovieAdd.UseVisualStyleBackColor = true;
            this.MovieAdd.Click += new System.EventHandler(this.MovieAdd_Click);
            // 
            // MovieGenreBox
            // 
            this.MovieGenreBox.FormattingEnabled = true;
            this.MovieGenreBox.Location = new System.Drawing.Point(929, 272);
            this.MovieGenreBox.Name = "MovieGenreBox";
            this.MovieGenreBox.Size = new System.Drawing.Size(310, 21);
            this.MovieGenreBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(926, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Genre";
            // 
            // MovieCostText
            // 
            this.MovieCostText.Location = new System.Drawing.Point(929, 227);
            this.MovieCostText.Name = "MovieCostText";
            this.MovieCostText.ReadOnly = true;
            this.MovieCostText.Size = new System.Drawing.Size(311, 20);
            this.MovieCostText.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(926, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Renting Price";
            // 
            // AvailableCopiesValue
            // 
            this.AvailableCopiesValue.Location = new System.Drawing.Point(1091, 181);
            this.AvailableCopiesValue.Name = "AvailableCopiesValue";
            this.AvailableCopiesValue.Size = new System.Drawing.Size(148, 20);
            this.AvailableCopiesValue.TabIndex = 25;
            // 
            // MovieAvailableCopies
            // 
            this.MovieAvailableCopies.AutoSize = true;
            this.MovieAvailableCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieAvailableCopies.Location = new System.Drawing.Point(1088, 160);
            this.MovieAvailableCopies.Name = "MovieAvailableCopies";
            this.MovieAvailableCopies.Size = new System.Drawing.Size(116, 18);
            this.MovieAvailableCopies.TabIndex = 24;
            this.MovieAvailableCopies.Text = "Available Copies";
            // 
            // MovieRatings
            // 
            this.MovieRatings.Location = new System.Drawing.Point(929, 182);
            this.MovieRatings.Name = "MovieRatings";
            this.MovieRatings.Size = new System.Drawing.Size(156, 20);
            this.MovieRatings.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(926, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Movie Ratings";
            // 
            // MovieReleaseDateText
            // 
            this.MovieReleaseDateText.Location = new System.Drawing.Point(929, 137);
            this.MovieReleaseDateText.Name = "MovieReleaseDateText";
            this.MovieReleaseDateText.Size = new System.Drawing.Size(311, 20);
            this.MovieReleaseDateText.TabIndex = 21;
            this.MovieReleaseDateText.ValueChanged += new System.EventHandler(this.MovieReleaseDateText_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(929, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Movie Release Date";
            // 
            // MovieTitleText
            // 
            this.MovieTitleText.Location = new System.Drawing.Point(929, 89);
            this.MovieTitleText.Name = "MovieTitleText";
            this.MovieTitleText.Size = new System.Drawing.Size(311, 20);
            this.MovieTitleText.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(928, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Movie Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marcellus SC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1001, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = "Movies";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteCustomer);
            this.tabPage2.Controls.Add(this.modifyCustomer);
            this.tabPage2.Controls.Add(this.addCustomer);
            this.tabPage2.Controls.Add(this.phoneNumberText);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.addressText);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lastNameText);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.firstNameText);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.CustomersList);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(928, 609);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(311, 32);
            this.deleteCustomer.TabIndex = 46;
            this.deleteCustomer.Text = "Delete Customer";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // modifyCustomer
            // 
            this.modifyCustomer.Location = new System.Drawing.Point(1092, 249);
            this.modifyCustomer.Name = "modifyCustomer";
            this.modifyCustomer.Size = new System.Drawing.Size(147, 40);
            this.modifyCustomer.TabIndex = 45;
            this.modifyCustomer.Text = "Modify Customer";
            this.modifyCustomer.UseVisualStyleBackColor = true;
            this.modifyCustomer.Click += new System.EventHandler(this.ModifyCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(929, 249);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(156, 40);
            this.addCustomer.TabIndex = 44;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Location = new System.Drawing.Point(929, 223);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(311, 20);
            this.phoneNumberText.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(926, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 42;
            this.label11.Text = "Phone Number";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(929, 178);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(311, 20);
            this.addressText.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(926, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Address";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(929, 133);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(311, 20);
            this.lastNameText.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(926, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Last Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(929, 88);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(311, 20);
            this.firstNameText.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(928, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Marcellus SC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(956, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 60);
            this.label8.TabIndex = 35;
            this.label8.Text = "Customers";
            // 
            // CustomersList
            // 
            this.CustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.LastName,
            this.Address,
            this.PhoneNumber});
            this.CustomersList.Location = new System.Drawing.Point(6, 3);
            this.CustomersList.Name = "CustomersList";
            this.CustomersList.Size = new System.Drawing.Size(917, 641);
            this.CustomersList.TabIndex = 34;
            this.CustomersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersList_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 323;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 200;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReturnMovie);
            this.tabPage3.Controls.Add(this.IssueMovie);
            this.tabPage3.Controls.Add(this.RentTillMovie);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.RentFromMovie);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.RentalsList);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1246, 647);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReturnMovie
            // 
            this.ReturnMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReturnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnMovie.Location = new System.Drawing.Point(1088, 279);
            this.ReturnMovie.Name = "ReturnMovie";
            this.ReturnMovie.Size = new System.Drawing.Size(155, 40);
            this.ReturnMovie.TabIndex = 47;
            this.ReturnMovie.Text = "Return Movie";
            this.ReturnMovie.UseVisualStyleBackColor = true;
            this.ReturnMovie.Click += new System.EventHandler(this.ReturnMovie_Click);
            // 
            // IssueMovie
            // 
            this.IssueMovie.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.IssueMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueMovie.Location = new System.Drawing.Point(926, 279);
            this.IssueMovie.Name = "IssueMovie";
            this.IssueMovie.Size = new System.Drawing.Size(156, 40);
            this.IssueMovie.TabIndex = 46;
            this.IssueMovie.Text = "Issue Movie";
            this.IssueMovie.UseVisualStyleBackColor = true;
            this.IssueMovie.Click += new System.EventHandler(this.IssueMovie_Click);
            // 
            // RentTillMovie
            // 
            this.RentTillMovie.Location = new System.Drawing.Point(923, 253);
            this.RentTillMovie.Name = "RentTillMovie";
            this.RentTillMovie.Size = new System.Drawing.Size(320, 20);
            this.RentTillMovie.TabIndex = 40;
            this.RentTillMovie.ValueChanged += new System.EventHandler(this.RentTillMovie_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(923, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 18);
            this.label14.TabIndex = 39;
            this.label14.Text = "First Name";
            // 
            // RentFromMovie
            // 
            this.RentFromMovie.Location = new System.Drawing.Point(923, 176);
            this.RentFromMovie.Name = "RentFromMovie";
            this.RentFromMovie.Size = new System.Drawing.Size(320, 20);
            this.RentFromMovie.TabIndex = 38;
            this.RentFromMovie.ValueChanged += new System.EventHandler(this.RentFromMovie_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(923, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 18);
            this.label13.TabIndex = 37;
            this.label13.Text = "First Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Marcellus SC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(995, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 60);
            this.label12.TabIndex = 36;
            this.label12.Text = "Rental";
            // 
            // RentalsList
            // 
            this.RentalsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalID,
            this.Customer,
            this.Movie,
            this.RentFrom,
            this.RentTill});
            this.RentalsList.Location = new System.Drawing.Point(4, 3);
            this.RentalsList.Name = "RentalsList";
            this.RentalsList.Size = new System.Drawing.Size(913, 641);
            this.RentalsList.TabIndex = 34;
            this.RentalsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalsList_CellClick);
            // 
            // RentalID
            // 
            this.RentalID.DataPropertyName = "RentalID";
            this.RentalID.HeaderText = "ID";
            this.RentalID.Name = "RentalID";
            this.RentalID.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "CustomerID";
            this.Customer.HeaderText = "CustomerID";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Movie
            // 
            this.Movie.DataPropertyName = "MovieID";
            this.Movie.HeaderText = "Movie ID";
            this.Movie.Name = "Movie";
            this.Movie.ReadOnly = true;
            // 
            // RentFrom
            // 
            this.RentFrom.DataPropertyName = "RentFrom";
            this.RentFrom.HeaderText = "Renting Date";
            this.RentFrom.Name = "RentFrom";
            this.RentFrom.ReadOnly = true;
            this.RentFrom.Width = 280;
            // 
            // RentTill
            // 
            this.RentTill.DataPropertyName = "RentTill";
            this.RentTill.HeaderText = "Returning Date";
            this.RentTill.Name = "RentTill";
            this.RentTill.ReadOnly = true;
            this.RentTill.Width = 285;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCopiesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRatings)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView MoviesList;
        private System.Windows.Forms.Button MovieDelete;
        private System.Windows.Forms.Button MovieModify;
        private System.Windows.Forms.Button MovieAdd;
        private System.Windows.Forms.ComboBox MovieGenreBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MovieCostText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AvailableCopiesValue;
        private System.Windows.Forms.Label MovieAvailableCopies;
        private System.Windows.Forms.NumericUpDown MovieRatings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker MovieReleaseDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MovieTitleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView CustomersList;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView RentalsList;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button modifyCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker RentTillMovie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker RentFromMovie;
        private System.Windows.Forms.Button ReturnMovie;
        private System.Windows.Forms.Button IssueMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_Ratings;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRatingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentTill;
    }
}

