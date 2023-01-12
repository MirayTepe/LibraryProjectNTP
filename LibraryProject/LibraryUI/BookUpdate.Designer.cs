namespace LibraryProject.LibraryUI
{
    partial class BookUpdate
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
            System.Windows.Forms.Label lblBookDescriptiom;
            System.Windows.Forms.Label lblBookPublisher;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.tbxBookId = new System.Windows.Forms.TextBox();
            this.tbxBookDescription = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.tbxBookPublisher = new System.Windows.Forms.TextBox();
            this.lblBookLanguage = new System.Windows.Forms.Label();
            this.tbxBookLanguage = new System.Windows.Forms.TextBox();
            this.lblNumberOfPage = new System.Windows.Forms.Label();
            this.tbxNumberOfPage = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbxBookAuthor = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchByBookName = new System.Windows.Forms.TextBox();
            lblBookDescriptiom = new System.Windows.Forms.Label();
            lblBookPublisher = new System.Windows.Forms.Label();
            this.groupBoxBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookDescriptiom
            // 
            lblBookDescriptiom.AutoSize = true;
            lblBookDescriptiom.BackColor = System.Drawing.Color.White;
            lblBookDescriptiom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblBookDescriptiom.ForeColor = System.Drawing.Color.Black;
            lblBookDescriptiom.Location = new System.Drawing.Point(8, 366);
            lblBookDescriptiom.Name = "lblBookDescriptiom";
            lblBookDescriptiom.Size = new System.Drawing.Size(152, 23);
            lblBookDescriptiom.TabIndex = 31;
            lblBookDescriptiom.Text = "Kitap Açıklaması";
            // 
            // lblBookPublisher
            // 
            lblBookPublisher.AutoSize = true;
            lblBookPublisher.BackColor = System.Drawing.Color.White;
            lblBookPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblBookPublisher.ForeColor = System.Drawing.Color.Black;
            lblBookPublisher.Location = new System.Drawing.Point(72, 316);
            lblBookPublisher.Name = "lblBookPublisher";
            lblBookPublisher.Size = new System.Drawing.Size(81, 23);
            lblBookPublisher.TabIndex = 28;
            lblBookPublisher.Text = "Yayınevi";
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.BackColor = System.Drawing.Color.White;
            this.groupBoxBook.Controls.Add(this.btnBookUpdate);
            this.groupBoxBook.Controls.Add(this.btnCategories);
            this.groupBoxBook.Controls.Add(this.lblBookId);
            this.groupBoxBook.Controls.Add(this.tbxBookId);
            this.groupBoxBook.Controls.Add(lblBookDescriptiom);
            this.groupBoxBook.Controls.Add(this.tbxBookDescription);
            this.groupBoxBook.Controls.Add(this.comboBoxCategory);
            this.groupBoxBook.Controls.Add(lblBookPublisher);
            this.groupBoxBook.Controls.Add(this.tbxBookPublisher);
            this.groupBoxBook.Controls.Add(this.lblBookLanguage);
            this.groupBoxBook.Controls.Add(this.tbxBookLanguage);
            this.groupBoxBook.Controls.Add(this.lblNumberOfPage);
            this.groupBoxBook.Controls.Add(this.tbxNumberOfPage);
            this.groupBoxBook.Controls.Add(this.lblBookAuthor);
            this.groupBoxBook.Controls.Add(this.lblBookName);
            this.groupBoxBook.Controls.Add(this.lblCategoryName);
            this.groupBoxBook.Controls.Add(this.tbxBookAuthor);
            this.groupBoxBook.Controls.Add(this.tbxBookName);
            this.groupBoxBook.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxBook.ForeColor = System.Drawing.Color.Black;
            this.groupBoxBook.Location = new System.Drawing.Point(1303, 72);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(600, 726);
            this.groupBoxBook.TabIndex = 12;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Kitap Bilgileri";
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookUpdate.Location = new System.Drawing.Point(344, 625);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(141, 43);
            this.btnBookUpdate.TabIndex = 35;
            this.btnBookUpdate.Text = "Güncelle";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click_1);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.Location = new System.Drawing.Point(494, 83);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(30, 29);
            this.btnCategories.TabIndex = 34;
            this.btnCategories.Text = "+";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.BackColor = System.Drawing.Color.White;
            this.lblBookId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookId.ForeColor = System.Drawing.Color.Black;
            this.lblBookId.Location = new System.Drawing.Point(122, 56);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(27, 23);
            this.lblBookId.TabIndex = 33;
            this.lblBookId.Text = "Id";
            // 
            // tbxBookId
            // 
            this.tbxBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookId.ForeColor = System.Drawing.Color.White;
            this.tbxBookId.Location = new System.Drawing.Point(179, 49);
            this.tbxBookId.Name = "tbxBookId";
            this.tbxBookId.Size = new System.Drawing.Size(306, 30);
            this.tbxBookId.TabIndex = 32;
            // 
            // tbxBookDescription
            // 
            this.tbxBookDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookDescription.ForeColor = System.Drawing.Color.White;
            this.tbxBookDescription.Location = new System.Drawing.Point(181, 364);
            this.tbxBookDescription.Multiline = true;
            this.tbxBookDescription.Name = "tbxBookDescription";
            this.tbxBookDescription.Size = new System.Drawing.Size(306, 124);
            this.tbxBookDescription.TabIndex = 30;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxCategory.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(179, 83);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(309, 31);
            this.comboBoxCategory.TabIndex = 29;
            // 
            // tbxBookPublisher
            // 
            this.tbxBookPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookPublisher.ForeColor = System.Drawing.Color.White;
            this.tbxBookPublisher.Location = new System.Drawing.Point(182, 314);
            this.tbxBookPublisher.Name = "tbxBookPublisher";
            this.tbxBookPublisher.Size = new System.Drawing.Size(306, 30);
            this.tbxBookPublisher.TabIndex = 27;
            // 
            // lblBookLanguage
            // 
            this.lblBookLanguage.AutoSize = true;
            this.lblBookLanguage.BackColor = System.Drawing.Color.White;
            this.lblBookLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblBookLanguage.Location = new System.Drawing.Point(115, 277);
            this.lblBookLanguage.Name = "lblBookLanguage";
            this.lblBookLanguage.Size = new System.Drawing.Size(34, 23);
            this.lblBookLanguage.TabIndex = 26;
            this.lblBookLanguage.Text = "Dil";
            // 
            // tbxBookLanguage
            // 
            this.tbxBookLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookLanguage.ForeColor = System.Drawing.Color.White;
            this.tbxBookLanguage.Location = new System.Drawing.Point(181, 270);
            this.tbxBookLanguage.Name = "tbxBookLanguage";
            this.tbxBookLanguage.Size = new System.Drawing.Size(306, 30);
            this.tbxBookLanguage.TabIndex = 25;
            // 
            // lblNumberOfPage
            // 
            this.lblNumberOfPage.AutoSize = true;
            this.lblNumberOfPage.BackColor = System.Drawing.Color.White;
            this.lblNumberOfPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumberOfPage.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfPage.Location = new System.Drawing.Point(37, 226);
            this.lblNumberOfPage.Name = "lblNumberOfPage";
            this.lblNumberOfPage.Size = new System.Drawing.Size(112, 23);
            this.lblNumberOfPage.TabIndex = 24;
            this.lblNumberOfPage.Text = "Sayfa Sayısı";
            // 
            // tbxNumberOfPage
            // 
            this.tbxNumberOfPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxNumberOfPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNumberOfPage.ForeColor = System.Drawing.Color.White;
            this.tbxNumberOfPage.Location = new System.Drawing.Point(181, 219);
            this.tbxNumberOfPage.Name = "tbxNumberOfPage";
            this.tbxNumberOfPage.Size = new System.Drawing.Size(306, 30);
            this.tbxNumberOfPage.TabIndex = 23;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.BackColor = System.Drawing.Color.White;
            this.lblBookAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblBookAuthor.Location = new System.Drawing.Point(90, 181);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(59, 23);
            this.lblBookAuthor.TabIndex = 13;
            this.lblBookAuthor.Text = "Yazar";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.White;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Location = new System.Drawing.Point(49, 135);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(104, 23);
            this.lblBookName.TabIndex = 12;
            this.lblBookName.Text = "Kitabın Adı";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.White;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryName.Location = new System.Drawing.Point(65, 93);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(84, 23);
            this.lblCategoryName.TabIndex = 11;
            this.lblCategoryName.Text = "Kategori";
            // 
            // tbxBookAuthor
            // 
            this.tbxBookAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookAuthor.ForeColor = System.Drawing.Color.White;
            this.tbxBookAuthor.Location = new System.Drawing.Point(181, 174);
            this.tbxBookAuthor.Name = "tbxBookAuthor";
            this.tbxBookAuthor.Size = new System.Drawing.Size(306, 30);
            this.tbxBookAuthor.TabIndex = 10;
            // 
            // tbxBookName
            // 
            this.tbxBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.ForeColor = System.Drawing.Color.White;
            this.tbxBookName.Location = new System.Drawing.Point(181, 128);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(306, 30);
            this.tbxBookName.TabIndex = 9;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // dgwBookList
            // 
            this.dgwBookList.AllowUserToAddRows = false;
            this.dgwBookList.AllowUserToDeleteRows = false;
            this.dgwBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwBookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBookList.BackgroundColor = System.Drawing.Color.White;
            this.dgwBookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBookList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwBookList.GridColor = System.Drawing.Color.Black;
            this.dgwBookList.Location = new System.Drawing.Point(12, 90);
            this.dgwBookList.Name = "dgwBookList";
            this.dgwBookList.ReadOnly = true;
            this.dgwBookList.RowHeadersWidth = 51;
            this.dgwBookList.RowTemplate.Height = 24;
            this.dgwBookList.Size = new System.Drawing.Size(1254, 732);
            this.dgwBookList.TabIndex = 11;
            this.dgwBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(776, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kitabın Adı";
            // 
            // tbxSearchByBookName
            // 
            this.tbxSearchByBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxSearchByBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchByBookName.ForeColor = System.Drawing.Color.White;
            this.tbxSearchByBookName.Location = new System.Drawing.Point(909, 38);
            this.tbxSearchByBookName.Name = "tbxSearchByBookName";
            this.tbxSearchByBookName.Size = new System.Drawing.Size(268, 30);
            this.tbxSearchByBookName.TabIndex = 38;
            this.tbxSearchByBookName.TextChanged += new System.EventHandler(this.tbxSearchByBookName_TextChanged);
            // 
            // BookUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 923);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearchByBookName);
            this.Controls.Add(this.groupBoxBook);
            this.Controls.Add(this.dgwBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookUpdate";
            this.Text = "BookUpdate";
            this.Load += new System.EventHandler(this.BookUpdate_Load);
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox tbxBookId;
        private System.Windows.Forms.TextBox tbxBookDescription;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox tbxBookPublisher;
        private System.Windows.Forms.Label lblBookLanguage;
        private System.Windows.Forms.TextBox tbxBookLanguage;
        private System.Windows.Forms.Label lblNumberOfPage;
        private System.Windows.Forms.TextBox tbxNumberOfPage;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbxBookAuthor;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.DataGridView dgwBookList;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchByBookName;
    }
}