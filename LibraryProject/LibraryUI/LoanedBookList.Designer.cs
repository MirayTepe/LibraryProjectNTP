namespace LibraryProject.LibraryUI
{
    partial class LoanedBookList
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
            this.dgwLoanedBookList = new System.Windows.Forms.DataGridView();
            this.dtpBookRetrieveOfDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookLendingOfDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoanedBookList = new System.Windows.Forms.Button();
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
            lblBookRetrieveOfDate.Location = new System.Drawing.Point(1134, 37);
            lblBookRetrieveOfDate.Name = "lblBookRetrieveOfDate";
            lblBookRetrieveOfDate.Size = new System.Drawing.Size(272, 23);
            lblBookRetrieveOfDate.TabIndex = 87;
            lblBookRetrieveOfDate.Text = "Emanet Kitap Geri Alma Tarihi";
            lblBookRetrieveOfDate.Click += new System.EventHandler(this.lblBookRetrieveOfDate_Click);
            // 
            // lblBookLendingOfDate
            // 
            lblBookLendingOfDate.AutoSize = true;
            lblBookLendingOfDate.BackColor = System.Drawing.Color.White;
            lblBookLendingOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lblBookLendingOfDate.ForeColor = System.Drawing.Color.Black;
            lblBookLendingOfDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblBookLendingOfDate.Location = new System.Drawing.Point(70, 37);
            lblBookLendingOfDate.Name = "lblBookLendingOfDate";
            lblBookLendingOfDate.Size = new System.Drawing.Size(240, 23);
            lblBookLendingOfDate.TabIndex = 86;
            lblBookLendingOfDate.Text = "Emanet Kitap Verme Tarihi";
            lblBookLendingOfDate.Click += new System.EventHandler(this.lblBookLendingOfDate_Click);
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
            this.dgwLoanedBookList.Location = new System.Drawing.Point(33, 83);
            this.dgwLoanedBookList.Name = "dgwLoanedBookList";
            this.dgwLoanedBookList.ReadOnly = true;
            this.dgwLoanedBookList.RowHeadersWidth = 51;
            this.dgwLoanedBookList.RowTemplate.Height = 24;
            this.dgwLoanedBookList.Size = new System.Drawing.Size(1748, 715);
            this.dgwLoanedBookList.TabIndex = 26;
            // 
            // dtpBookRetrieveOfDate
            // 
            this.dtpBookRetrieveOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtpBookRetrieveOfDate.Location = new System.Drawing.Point(1458, 37);
            this.dtpBookRetrieveOfDate.Name = "dtpBookRetrieveOfDate";
            this.dtpBookRetrieveOfDate.Size = new System.Drawing.Size(262, 30);
            this.dtpBookRetrieveOfDate.TabIndex = 91;
            this.dtpBookRetrieveOfDate.ValueChanged += new System.EventHandler(this.dtpBookRetrieveOfDate_ValueChanged);
            // 
            // dtpBookLendingOfDate
            // 
            this.dtpBookLendingOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dtpBookLendingOfDate.Location = new System.Drawing.Point(360, 30);
            this.dtpBookLendingOfDate.Name = "dtpBookLendingOfDate";
            this.dtpBookLendingOfDate.Size = new System.Drawing.Size(262, 30);
            this.dtpBookLendingOfDate.TabIndex = 90;
            this.dtpBookLendingOfDate.ValueChanged += new System.EventHandler(this.dtpBookLendingOfDate_ValueChanged);
            // 
            // btnLoanedBookList
            // 
            this.btnLoanedBookList.BackColor = System.Drawing.Color.Navy;
            this.btnLoanedBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanedBookList.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoanedBookList.ForeColor = System.Drawing.Color.White;
            this.btnLoanedBookList.Location = new System.Drawing.Point(1533, 828);
            this.btnLoanedBookList.Name = "btnLoanedBookList";
            this.btnLoanedBookList.Size = new System.Drawing.Size(218, 77);
            this.btnLoanedBookList.TabIndex = 92;
            this.btnLoanedBookList.Text = "Emanet Kitap Listesini Yenile";
            this.btnLoanedBookList.UseVisualStyleBackColor = false;
            this.btnLoanedBookList.Click += new System.EventHandler(this.btnLoanedBookList_Click);
            // 
            // LoanedBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1839, 1055);
            this.Controls.Add(this.btnLoanedBookList);
            this.Controls.Add(this.dtpBookRetrieveOfDate);
            this.Controls.Add(this.dtpBookLendingOfDate);
            this.Controls.Add(lblBookRetrieveOfDate);
            this.Controls.Add(lblBookLendingOfDate);
            this.Controls.Add(this.dgwLoanedBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoanedBookList";
            this.Text = "LoanedBookList";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLoanedBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLoanedBookList;
        private System.Windows.Forms.DateTimePicker dtpBookRetrieveOfDate;
        private System.Windows.Forms.DateTimePicker dtpBookLendingOfDate;
        private System.Windows.Forms.Button btnLoanedBookList;
    }
}