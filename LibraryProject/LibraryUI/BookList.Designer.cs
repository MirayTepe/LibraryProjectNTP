namespace LibraryProject.LibraryUI
{
    partial class BookList
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
            System.Windows.Forms.Label lblBookPublisher;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.lblBookId = new System.Windows.Forms.Label();
            this.tbxBookId = new System.Windows.Forms.TextBox();
            this.tbxBookPublisher = new System.Windows.Forms.TextBox();
            this.lblBookLanguage = new System.Windows.Forms.Label();
            this.tbxBookLanguage = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbxBookAuthor = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            lblBookPublisher = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookPublisher
            // 
            lblBookPublisher.AutoSize = true;
            lblBookPublisher.BackColor = System.Drawing.Color.White;
            lblBookPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblBookPublisher.ForeColor = System.Drawing.Color.Black;
            lblBookPublisher.Location = new System.Drawing.Point(1388, 299);
            lblBookPublisher.Name = "lblBookPublisher";
            lblBookPublisher.Size = new System.Drawing.Size(81, 23);
            lblBookPublisher.TabIndex = 44;
            lblBookPublisher.Text = "Yayınevi";
            lblBookPublisher.Click += new System.EventHandler(this.lblBookPublisher_Click);
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
            this.dgwBookList.Location = new System.Drawing.Point(26, 34);
            this.dgwBookList.Name = "dgwBookList";
            this.dgwBookList.ReadOnly = true;
            this.dgwBookList.RowHeadersWidth = 51;
            this.dgwBookList.RowTemplate.Height = 24;
            this.dgwBookList.Size = new System.Drawing.Size(1308, 732);
            this.dgwBookList.TabIndex = 10;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.BackColor = System.Drawing.Color.White;
            this.lblBookId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookId.ForeColor = System.Drawing.Color.Black;
            this.lblBookId.Location = new System.Drawing.Point(1440, 89);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(27, 23);
            this.lblBookId.TabIndex = 47;
            this.lblBookId.Text = "Id";
            // 
            // tbxBookId
            // 
            this.tbxBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookId.ForeColor = System.Drawing.Color.White;
            this.tbxBookId.Location = new System.Drawing.Point(1498, 82);
            this.tbxBookId.Name = "tbxBookId";
            this.tbxBookId.Size = new System.Drawing.Size(268, 30);
            this.tbxBookId.TabIndex = 46;
            this.tbxBookId.TextChanged += new System.EventHandler(this.tbxBookId_TextChanged);
            // 
            // tbxBookPublisher
            // 
            this.tbxBookPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookPublisher.ForeColor = System.Drawing.Color.White;
            this.tbxBookPublisher.Location = new System.Drawing.Point(1499, 297);
            this.tbxBookPublisher.Name = "tbxBookPublisher";
            this.tbxBookPublisher.Size = new System.Drawing.Size(268, 30);
            this.tbxBookPublisher.TabIndex = 43;
            this.tbxBookPublisher.TextChanged += new System.EventHandler(this.tbxBookPublisher_TextChanged);
            // 
            // lblBookLanguage
            // 
            this.lblBookLanguage.AutoSize = true;
            this.lblBookLanguage.BackColor = System.Drawing.Color.White;
            this.lblBookLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblBookLanguage.Location = new System.Drawing.Point(1431, 260);
            this.lblBookLanguage.Name = "lblBookLanguage";
            this.lblBookLanguage.Size = new System.Drawing.Size(34, 23);
            this.lblBookLanguage.TabIndex = 42;
            this.lblBookLanguage.Text = "Dil";
            this.lblBookLanguage.Click += new System.EventHandler(this.lblBookLanguage_Click);
            // 
            // tbxBookLanguage
            // 
            this.tbxBookLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookLanguage.ForeColor = System.Drawing.Color.White;
            this.tbxBookLanguage.Location = new System.Drawing.Point(1498, 253);
            this.tbxBookLanguage.Name = "tbxBookLanguage";
            this.tbxBookLanguage.Size = new System.Drawing.Size(268, 30);
            this.tbxBookLanguage.TabIndex = 41;
            this.tbxBookLanguage.TextChanged += new System.EventHandler(this.tbxBookLanguage_TextChanged);
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.BackColor = System.Drawing.Color.White;
            this.lblBookAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblBookAuthor.Location = new System.Drawing.Point(1408, 214);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(59, 23);
            this.lblBookAuthor.TabIndex = 38;
            this.lblBookAuthor.Text = "Yazar";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.White;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Location = new System.Drawing.Point(1367, 168);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(104, 23);
            this.lblBookName.TabIndex = 37;
            this.lblBookName.Text = "Kitabın Adı";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.White;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryName.Location = new System.Drawing.Point(1383, 126);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(84, 23);
            this.lblCategoryName.TabIndex = 36;
            this.lblCategoryName.Text = "Kategori";
            // 
            // tbxBookAuthor
            // 
            this.tbxBookAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookAuthor.ForeColor = System.Drawing.Color.White;
            this.tbxBookAuthor.Location = new System.Drawing.Point(1500, 207);
            this.tbxBookAuthor.Name = "tbxBookAuthor";
            this.tbxBookAuthor.Size = new System.Drawing.Size(268, 30);
            this.tbxBookAuthor.TabIndex = 35;
            this.tbxBookAuthor.TextChanged += new System.EventHandler(this.tbxBookAuthor_TextChanged);
            // 
            // tbxBookName
            // 
            this.tbxBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.ForeColor = System.Drawing.Color.White;
            this.tbxBookName.Location = new System.Drawing.Point(1500, 161);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(268, 30);
            this.tbxBookName.TabIndex = 34;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxCategoryName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCategoryName.ForeColor = System.Drawing.Color.White;
            this.tbxCategoryName.Location = new System.Drawing.Point(1498, 119);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(268, 30);
            this.tbxCategoryName.TabIndex = 48;
            this.tbxCategoryName.TextChanged += new System.EventHandler(this.tbxCategoryId_TextChanged);
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1840, 1032);
            this.Controls.Add(this.tbxCategoryName);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.tbxBookId);
            this.Controls.Add(lblBookPublisher);
            this.Controls.Add(this.tbxBookPublisher);
            this.Controls.Add(this.lblBookLanguage);
            this.Controls.Add(this.tbxBookLanguage);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.tbxBookAuthor);
            this.Controls.Add(this.tbxBookName);
            this.Controls.Add(this.dgwBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookList";
            this.Text = "BookList";
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBookList;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox tbxBookId;
        private System.Windows.Forms.TextBox tbxBookPublisher;
        private System.Windows.Forms.Label lblBookLanguage;
        private System.Windows.Forms.TextBox tbxBookLanguage;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbxBookAuthor;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxCategoryName;
    }
}