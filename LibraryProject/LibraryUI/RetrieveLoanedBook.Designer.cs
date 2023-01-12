namespace LibraryProject.LibraryUI
{
    partial class RetrieveLoanedBooks
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
            System.Windows.Forms.Label lblBookRetrieveOfDate;
            System.Windows.Forms.Label lblBookLendingOfDate;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dgwLoanedBookList = new System.Windows.Forms.DataGridView();
            this.btnRetrieveLoanedBook = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.dtpBookRetrieveOfDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookLendingOfDate = new System.Windows.Forms.DateTimePicker();
            this.btnPunishmentProcess = new System.Windows.Forms.Button();
            lblBookRetrieveOfDate = new System.Windows.Forms.Label();
            lblBookLendingOfDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLoanedBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookRetrieveOfDate
            // 
            lblBookRetrieveOfDate.AutoSize = true;
            lblBookRetrieveOfDate.BackColor = System.Drawing.Color.White;
            lblBookRetrieveOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lblBookRetrieveOfDate.ForeColor = System.Drawing.Color.Black;
            lblBookRetrieveOfDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblBookRetrieveOfDate.Location = new System.Drawing.Point(739, 19);
            lblBookRetrieveOfDate.Name = "lblBookRetrieveOfDate";
            lblBookRetrieveOfDate.Size = new System.Drawing.Size(272, 23);
            lblBookRetrieveOfDate.TabIndex = 93;
            lblBookRetrieveOfDate.Text = "Emanet Kitap Geri Alma Tarihi";
            // 
            // lblBookLendingOfDate
            // 
            lblBookLendingOfDate.AutoSize = true;
            lblBookLendingOfDate.BackColor = System.Drawing.Color.White;
            lblBookLendingOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lblBookLendingOfDate.ForeColor = System.Drawing.Color.Black;
            lblBookLendingOfDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblBookLendingOfDate.Location = new System.Drawing.Point(19, 19);
            lblBookLendingOfDate.Name = "lblBookLendingOfDate";
            lblBookLendingOfDate.Size = new System.Drawing.Size(240, 23);
            lblBookLendingOfDate.TabIndex = 92;
            lblBookLendingOfDate.Text = "Emanet Kitap Verme Tarihi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1416, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 77);
            this.button1.TabIndex = 26;
            this.button1.Text = "Emanet Kitap Listesini Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDgwLoanedBookNew_Click);
            // 
            // dgwLoanedBookList
            // 
            this.dgwLoanedBookList.AllowUserToAddRows = false;
            this.dgwLoanedBookList.AllowUserToDeleteRows = false;
            this.dgwLoanedBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwLoanedBookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwLoanedBookList.BackgroundColor = System.Drawing.Color.White;
            this.dgwLoanedBookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwLoanedBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwLoanedBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwLoanedBookList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwLoanedBookList.GridColor = System.Drawing.Color.Black;
            this.dgwLoanedBookList.Location = new System.Drawing.Point(23, 84);
            this.dgwLoanedBookList.Name = "dgwLoanedBookList";
            this.dgwLoanedBookList.ReadOnly = true;
            this.dgwLoanedBookList.RowHeadersWidth = 51;
            this.dgwLoanedBookList.RowTemplate.Height = 24;
            this.dgwLoanedBookList.Size = new System.Drawing.Size(1274, 682);
            this.dgwLoanedBookList.TabIndex = 25;
            // 
            // btnRetrieveLoanedBook
            // 
            this.btnRetrieveLoanedBook.BackColor = System.Drawing.Color.Navy;
            this.btnRetrieveLoanedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveLoanedBook.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRetrieveLoanedBook.ForeColor = System.Drawing.Color.White;
            this.btnRetrieveLoanedBook.Location = new System.Drawing.Point(1416, 253);
            this.btnRetrieveLoanedBook.Name = "btnRetrieveLoanedBook";
            this.btnRetrieveLoanedBook.Size = new System.Drawing.Size(218, 72);
            this.btnRetrieveLoanedBook.TabIndex = 24;
            this.btnRetrieveLoanedBook.Text = "Emanet Kitap Geri Al";
            this.btnRetrieveLoanedBook.UseVisualStyleBackColor = false;
            this.btnRetrieveLoanedBook.Click += new System.EventHandler(this.btnRetrieveLoanedBook_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.Navy;
            this.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMail.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Location = new System.Drawing.Point(1416, 391);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(218, 72);
            this.btnSendMail.TabIndex = 27;
            this.btnSendMail.Text = "Mail Gönder";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // dtpBookRetrieveOfDate
            // 
            this.dtpBookRetrieveOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtpBookRetrieveOfDate.Location = new System.Drawing.Point(1063, 19);
            this.dtpBookRetrieveOfDate.Name = "dtpBookRetrieveOfDate";
            this.dtpBookRetrieveOfDate.Size = new System.Drawing.Size(262, 30);
            this.dtpBookRetrieveOfDate.TabIndex = 95;
            this.dtpBookRetrieveOfDate.ValueChanged += new System.EventHandler(this.dtpBookRetrieveOfDate_ValueChanged);
            // 
            // dtpBookLendingOfDate
            // 
            this.dtpBookLendingOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtpBookLendingOfDate.Location = new System.Drawing.Point(309, 12);
            this.dtpBookLendingOfDate.Name = "dtpBookLendingOfDate";
            this.dtpBookLendingOfDate.Size = new System.Drawing.Size(262, 30);
            this.dtpBookLendingOfDate.TabIndex = 94;
            this.dtpBookLendingOfDate.ValueChanged += new System.EventHandler(this.dtpBookLendingOfDate_ValueChanged);
            // 
            // btnPunishmentProcess
            // 
            this.btnPunishmentProcess.BackColor = System.Drawing.Color.Navy;
            this.btnPunishmentProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPunishmentProcess.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPunishmentProcess.ForeColor = System.Drawing.Color.White;
            this.btnPunishmentProcess.Location = new System.Drawing.Point(1416, 565);
            this.btnPunishmentProcess.Name = "btnPunishmentProcess";
            this.btnPunishmentProcess.Size = new System.Drawing.Size(218, 72);
            this.btnPunishmentProcess.TabIndex = 96;
            this.btnPunishmentProcess.Text = "Cezai  İşlem";
            this.btnPunishmentProcess.UseVisualStyleBackColor = false;
            this.btnPunishmentProcess.Click += new System.EventHandler(this.btnPunishmentProcess_Click);
            // 
            // RetrieveLoanedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1731, 895);
            this.Controls.Add(this.btnPunishmentProcess);
            this.Controls.Add(this.dtpBookRetrieveOfDate);
            this.Controls.Add(this.dtpBookLendingOfDate);
            this.Controls.Add(lblBookRetrieveOfDate);
            this.Controls.Add(lblBookLendingOfDate);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwLoanedBookList);
            this.Controls.Add(this.btnRetrieveLoanedBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetrieveLoanedBooks";
            this.Text = "RetrieveLoanedBook";
            this.Load += new System.EventHandler(this.RetrieveLoanedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLoanedBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgwLoanedBookList;
        private System.Windows.Forms.Button btnRetrieveLoanedBook;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.DateTimePicker dtpBookRetrieveOfDate;
        private System.Windows.Forms.DateTimePicker dtpBookLendingOfDate;
        private System.Windows.Forms.Button btnPunishmentProcess;
    }
}