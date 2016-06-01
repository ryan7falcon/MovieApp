namespace Tabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpInput = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.rbCanadian = new System.Windows.Forms.RadioButton();
            this.rbInternational = new System.Windows.Forms.RadioButton();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nDuration = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tpSelect = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.lbxSelect = new System.Windows.Forms.ListBox();
            this.tpFind = new System.Windows.Forms.TabPage();
            this.lbxMovieFound = new System.Windows.Forms.ListBox();
            this.lbMovieFound = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbFindMovie = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbDate1 = new System.Windows.Forms.DateTimePicker();
            this.cbxRating = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tpFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpInput.SuspendLayout();
            this.gbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDuration)).BeginInit();
            this.tpSelect.SuspendLayout();
            this.tpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRating)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFile);
            this.tabControl1.Controls.Add(this.tpInput);
            this.tabControl1.Controls.Add(this.tpSelect);
            this.tabControl1.Controls.Add(this.tpFind);
            this.tabControl1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tpFile
            // 
            this.tpFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpFile.Controls.Add(this.pictureBox1);
            this.tpFile.Controls.Add(this.btnCreate);
            this.tpFile.Controls.Add(this.tbFilename);
            this.tpFile.Controls.Add(this.label1);
            this.tpFile.Location = new System.Drawing.Point(4, 32);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(308, 453);
            this.tpFile.TabIndex = 0;
            this.tpFile.Text = "File";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 239);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCreate.Location = new System.Drawing.Point(84, 405);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 36);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create or Open";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbFilename
            // 
            this.tbFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilename.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilename.Location = new System.Drawing.Point(7, 330);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(290, 40);
            this.tbFilename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Filename:";
            // 
            // tpInput
            // 
            this.tpInput.Controls.Add(this.cbxRating);
            this.tpInput.Controls.Add(this.tbDate1);
            this.tpInput.Controls.Add(this.label5);
            this.tpInput.Controls.Add(this.gbLocation);
            this.tpInput.Controls.Add(this.nPrice);
            this.tpInput.Controls.Add(this.label9);
            this.tpInput.Controls.Add(this.nDuration);
            this.tpInput.Controls.Add(this.label8);
            this.tpInput.Controls.Add(this.label7);
            this.tpInput.Controls.Add(this.label6);
            this.tpInput.Controls.Add(this.cbxGenre);
            this.tpInput.Controls.Add(this.label4);
            this.tpInput.Controls.Add(this.tbNumber);
            this.tpInput.Controls.Add(this.label3);
            this.tpInput.Controls.Add(this.label2);
            this.tpInput.Controls.Add(this.tbName);
            this.tpInput.Controls.Add(this.btnSave);
            this.tpInput.Location = new System.Drawing.Point(4, 32);
            this.tpInput.Name = "tpInput";
            this.tpInput.Size = new System.Drawing.Size(308, 453);
            this.tpInput.TabIndex = 2;
            this.tpInput.Text = "Input";
            this.tpInput.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enter Movie Details";
            // 
            // gbLocation
            // 
            this.gbLocation.Controls.Add(this.rbCanadian);
            this.gbLocation.Controls.Add(this.rbInternational);
            this.gbLocation.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLocation.Location = new System.Drawing.Point(7, 176);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Size = new System.Drawing.Size(289, 65);
            this.gbLocation.TabIndex = 18;
            this.gbLocation.TabStop = false;
            this.gbLocation.Text = "Location";
            // 
            // rbCanadian
            // 
            this.rbCanadian.AutoSize = true;
            this.rbCanadian.Location = new System.Drawing.Point(22, 22);
            this.rbCanadian.Name = "rbCanadian";
            this.rbCanadian.Size = new System.Drawing.Size(100, 27);
            this.rbCanadian.TabIndex = 8;
            this.rbCanadian.TabStop = true;
            this.rbCanadian.Text = "Canadian";
            this.rbCanadian.UseVisualStyleBackColor = true;
            // 
            // rbInternational
            // 
            this.rbInternational.AutoSize = true;
            this.rbInternational.Location = new System.Drawing.Point(144, 22);
            this.rbInternational.Name = "rbInternational";
            this.rbInternational.Size = new System.Drawing.Size(128, 27);
            this.rbInternational.TabIndex = 9;
            this.rbInternational.TabStop = true;
            this.rbInternational.Text = "International";
            this.rbInternational.UseVisualStyleBackColor = true;
            // 
            // nPrice
            // 
            this.nPrice.DecimalPlaces = 2;
            this.nPrice.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPrice.Location = new System.Drawing.Point(142, 367);
            this.nPrice.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(155, 31);
            this.nPrice.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Price";
            // 
            // nDuration
            // 
            this.nDuration.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDuration.Location = new System.Drawing.Point(142, 330);
            this.nDuration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nDuration.Name = "nDuration";
            this.nDuration.Size = new System.Drawing.Size(155, 31);
            this.nDuration.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Genre";
            // 
            // cbxGenre
            // 
            this.cbxGenre.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Location = new System.Drawing.Point(142, 256);
            this.cbxGenre.MaxLength = 10;
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(154, 31);
            this.cbxGenre.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Release Date";
            // 
            // tbNumber
            // 
            this.tbNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.Location = new System.Drawing.Point(142, 104);
            this.tbNumber.MaxLength = 10;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(154, 31);
            this.tbNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISBN13 Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movie Name";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(142, 67);
            this.tbName.MaxLength = 15;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(154, 31);
            this.tbName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSave.Location = new System.Drawing.Point(122, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tpSelect
            // 
            this.tpSelect.Controls.Add(this.label11);
            this.tpSelect.Controls.Add(this.btnRead);
            this.tpSelect.Controls.Add(this.lbxSelect);
            this.tpSelect.Location = new System.Drawing.Point(4, 32);
            this.tpSelect.Name = "tpSelect";
            this.tpSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelect.Size = new System.Drawing.Size(308, 453);
            this.tpSelect.TabIndex = 1;
            this.tpSelect.Text = "Select";
            this.tpSelect.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 33);
            this.label11.TabIndex = 2;
            this.label11.Text = "Select a Movie";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRead.Location = new System.Drawing.Point(104, 403);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(89, 38);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbxSelect
            // 
            this.lbxSelect.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSelect.FormattingEnabled = true;
            this.lbxSelect.ItemHeight = 23;
            this.lbxSelect.Items.AddRange(new object[] {
            "Please load a File using the File tab"});
            this.lbxSelect.Location = new System.Drawing.Point(7, 71);
            this.lbxSelect.Name = "lbxSelect";
            this.lbxSelect.Size = new System.Drawing.Size(290, 326);
            this.lbxSelect.TabIndex = 0;
            // 
            // tpFind
            // 
            this.tpFind.Controls.Add(this.lbxMovieFound);
            this.tpFind.Controls.Add(this.lbMovieFound);
            this.tpFind.Controls.Add(this.label10);
            this.tpFind.Controls.Add(this.btnUpdate);
            this.tpFind.Controls.Add(this.btnDelete);
            this.tpFind.Controls.Add(this.tbFindMovie);
            this.tpFind.Controls.Add(this.btnFind);
            this.tpFind.Location = new System.Drawing.Point(4, 32);
            this.tpFind.Name = "tpFind";
            this.tpFind.Size = new System.Drawing.Size(308, 453);
            this.tpFind.TabIndex = 3;
            this.tpFind.Text = "Find";
            this.tpFind.UseVisualStyleBackColor = true;
            // 
            // lbxMovieFound
            // 
            this.lbxMovieFound.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMovieFound.FormattingEnabled = true;
            this.lbxMovieFound.ItemHeight = 23;
            this.lbxMovieFound.Location = new System.Drawing.Point(7, 209);
            this.lbxMovieFound.Name = "lbxMovieFound";
            this.lbxMovieFound.Size = new System.Drawing.Size(290, 188);
            this.lbxMovieFound.TabIndex = 6;
            // 
            // lbMovieFound
            // 
            this.lbMovieFound.AutoSize = true;
            this.lbMovieFound.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovieFound.Location = new System.Drawing.Point(85, 174);
            this.lbMovieFound.Name = "lbMovieFound";
            this.lbMovieFound.Size = new System.Drawing.Size(138, 26);
            this.lbMovieFound.TabIndex = 5;
            this.lbMovieFound.Text = "Movies Found:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 33);
            this.label10.TabIndex = 4;
            this.label10.Text = "Movie Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(197, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Coral;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(7, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbFindMovie
            // 
            this.tbFindMovie.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFindMovie.Location = new System.Drawing.Point(7, 60);
            this.tbFindMovie.Name = "tbFindMovie";
            this.tbFindMovie.Size = new System.Drawing.Size(290, 31);
            this.tbFindMovie.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFind.Location = new System.Drawing.Point(102, 105);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(92, 38);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbDate1
            // 
            this.tbDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDate1.Location = new System.Drawing.Point(142, 143);
            this.tbDate1.Name = "tbDate1";
            this.tbDate1.Size = new System.Drawing.Size(148, 31);
            this.tbDate1.TabIndex = 20;
            // 
            // cbxRating
            // 
            this.cbxRating.Location = new System.Drawing.Point(142, 293);
            this.cbxRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cbxRating.Name = "cbxRating";
            this.cbxRating.Size = new System.Drawing.Size(155, 31);
            this.cbxRating.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 484);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpInput.ResumeLayout(false);
            this.tpInput.PerformLayout();
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDuration)).EndInit();
            this.tpSelect.ResumeLayout(false);
            this.tpSelect.PerformLayout();
            this.tpFind.ResumeLayout(false);
            this.tpFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpSelect;
        private System.Windows.Forms.ListBox lbxSelect;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabPage tpInput;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TabPage tpFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbFindMovie;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.RadioButton rbInternational;
        private System.Windows.Forms.RadioButton rbCanadian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbxMovieFound;
        private System.Windows.Forms.Label lbMovieFound;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker tbDate1;
        private System.Windows.Forms.NumericUpDown cbxRating;
    }
}

