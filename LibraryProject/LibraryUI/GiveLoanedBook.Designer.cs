namespace LibraryProject.LibraryUI
{
    partial class GiveLoanedBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGiveLoanedBook = new System.Windows.Forms.Button();
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiveLoanedBook
            // 
            this.btnGiveLoanedBook.BackColor = System.Drawing.Color.Navy;
            this.btnGiveLoanedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveLoanedBook.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiveLoanedBook.ForeColor = System.Drawing.Color.White;
            this.btnGiveLoanedBook.Location = new System.Drawing.Point(1556, 284);
            this.btnGiveLoanedBook.Name = "btnGiveLoanedBook";
            this.btnGiveLoanedBook.Size = new System.Drawing.Size(218, 72);
            this.btnGiveLoanedBook.TabIndex = 21;
            this.btnGiveLoanedBook.Text = "Emanet Kitap Ver";
            this.btnGiveLoanedBook.UseVisualStyleBackColor = false;
            this.btnGiveLoanedBook.Click += new System.EventHandler(this.btnGiveLoanedBook_Click);
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
            this.dgwBookList.Location = new System.Drawing.Point(68, 129);
            this.dgwBookList.Name = "dgwBookList";
            this.dgwBookList.ReadOnly = true;
            this.dgwBookList.RowHeadersWidth = 51;
            this.dgwBookList.RowTemplate.Height = 24;
            this.dgwBookList.Size = new System.Drawing.Size(1324, 732);
            this.dgwBookList.TabIndex = 22;
            this.dgwBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLoanedBookList_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1556, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 77);
            this.button1.TabIndex = 23;
            this.button1.Text = "Emanet Kitap Listesini Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.White;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Location = new System.Drawing.Point(864, 81);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(104, 23);
            this.lblBookName.TabIndex = 39;
            this.lblBookName.Text = "Kitabın Adı";
            // 
            // tbxBookName
            // 
            this.tbxBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxBookName.ForeColor = System.Drawing.Color.White;
            this.tbxBookName.Location = new System.Drawing.Point(996, 79);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(268, 30);
            this.tbxBookName.TabIndex = 38;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // GiveLoanedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.tbxBookName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwBookList);
            this.Controls.Add(this.btnGiveLoanedBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GiveLoanedBook";
            this.Text = "GiveLoanedBook";
            this.Load += new System.EventHandler(this.GiveLoanedBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGiveLoanedBook;
        private System.Windows.Forms.DataGridView dgwBookList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox tbxBookName;
    }
}