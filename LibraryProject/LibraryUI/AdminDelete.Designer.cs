namespace LibraryProject.LibraryUI
{
    partial class AdminDelete
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
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.tbxAdminId = new System.Windows.Forms.TextBox();
            this.btnAdminDelete = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdmiUserName = new System.Windows.Forms.Label();
            this.lblUserIdAdmin = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxAdminUserName = new System.Windows.Forms.TextBox();
            this.tbxUserIdAdmin = new System.Windows.Forms.TextBox();
            this.dgwAdminList = new System.Windows.Forms.DataGridView();
            this.lblLastNameSearch = new System.Windows.Forms.Label();
            this.tbxSearchByLastName = new System.Windows.Forms.TextBox();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.tbxSearchByFirstName = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            this.groupBoxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = System.Drawing.Color.White;
            lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblEmail.Location = new System.Drawing.Point(22, 354);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(107, 23);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Mail Adresi";
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.BackColor = System.Drawing.Color.White;
            this.groupBoxAdmin.Controls.Add(lblEmail);
            this.groupBoxAdmin.Controls.Add(this.tbxEmail);
            this.groupBoxAdmin.Controls.Add(this.lblLastName);
            this.groupBoxAdmin.Controls.Add(this.tbxLastName);
            this.groupBoxAdmin.Controls.Add(this.lblFirstName);
            this.groupBoxAdmin.Controls.Add(this.tbxFirstName);
            this.groupBoxAdmin.Controls.Add(this.lblAdminId);
            this.groupBoxAdmin.Controls.Add(this.tbxAdminId);
            this.groupBoxAdmin.Controls.Add(this.btnAdminDelete);
            this.groupBoxAdmin.Controls.Add(this.lblPassword);
            this.groupBoxAdmin.Controls.Add(this.lblAdmiUserName);
            this.groupBoxAdmin.Controls.Add(this.lblUserIdAdmin);
            this.groupBoxAdmin.Controls.Add(this.tbxPassword);
            this.groupBoxAdmin.Controls.Add(this.tbxAdminUserName);
            this.groupBoxAdmin.Controls.Add(this.tbxUserIdAdmin);
            this.groupBoxAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAdmin.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAdmin.Location = new System.Drawing.Point(1342, 58);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(507, 713);
            this.groupBoxAdmin.TabIndex = 4;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin Bilgileri";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(150, 347);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(319, 30);
            this.tbxEmail.TabIndex = 27;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(66, 310);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 23);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "Soyad";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.ForeColor = System.Drawing.Color.White;
            this.tbxLastName.Location = new System.Drawing.Point(149, 303);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(319, 30);
            this.tbxLastName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(93, 259);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 23);
            this.lblFirstName.TabIndex = 24;
            this.lblFirstName.Text = "Ad";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.White;
            this.tbxFirstName.Location = new System.Drawing.Point(149, 252);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(319, 30);
            this.tbxFirstName.TabIndex = 23;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.Color.White;
            this.lblAdminId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminId.ForeColor = System.Drawing.Color.Black;
            this.lblAdminId.Location = new System.Drawing.Point(102, 78);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(27, 23);
            this.lblAdminId.TabIndex = 16;
            this.lblAdminId.Text = "Id";
            // 
            // tbxAdminId
            // 
            this.tbxAdminId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxAdminId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdminId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxAdminId.Location = new System.Drawing.Point(149, 76);
            this.tbxAdminId.Name = "tbxAdminId";
            this.tbxAdminId.Size = new System.Drawing.Size(319, 30);
            this.tbxAdminId.TabIndex = 15;
            // 
            // btnAdminDelete
            // 
            this.btnAdminDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDelete.Location = new System.Drawing.Point(301, 435);
            this.btnAdminDelete.Name = "btnAdminDelete";
            this.btnAdminDelete.Size = new System.Drawing.Size(154, 43);
            this.btnAdminDelete.TabIndex = 14;
            this.btnAdminDelete.Text = "Sil";
            this.btnAdminDelete.UseVisualStyleBackColor = true;
            this.btnAdminDelete.Click += new System.EventHandler(this.btnAdminDelete_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(78, 214);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 23);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Şifre";
            // 
            // lblAdmiUserName
            // 
            this.lblAdmiUserName.AutoSize = true;
            this.lblAdmiUserName.BackColor = System.Drawing.Color.White;
            this.lblAdmiUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmiUserName.ForeColor = System.Drawing.Color.Black;
            this.lblAdmiUserName.Location = new System.Drawing.Point(13, 168);
            this.lblAdmiUserName.Name = "lblAdmiUserName";
            this.lblAdmiUserName.Size = new System.Drawing.Size(116, 23);
            this.lblAdmiUserName.TabIndex = 12;
            this.lblAdmiUserName.Text = "Kullanıcı Adı";
            // 
            // lblUserIdAdmin
            // 
            this.lblUserIdAdmin.AutoSize = true;
            this.lblUserIdAdmin.BackColor = System.Drawing.Color.White;
            this.lblUserIdAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserIdAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblUserIdAdmin.Location = new System.Drawing.Point(57, 125);
            this.lblUserIdAdmin.Name = "lblUserIdAdmin";
            this.lblUserIdAdmin.Size = new System.Drawing.Size(72, 23);
            this.lblUserIdAdmin.TabIndex = 11;
            this.lblUserIdAdmin.Text = "User Id";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.ForeColor = System.Drawing.Color.White;
            this.tbxPassword.Location = new System.Drawing.Point(149, 207);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(319, 30);
            this.tbxPassword.TabIndex = 10;
            // 
            // tbxAdminUserName
            // 
            this.tbxAdminUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxAdminUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdminUserName.ForeColor = System.Drawing.Color.White;
            this.tbxAdminUserName.Location = new System.Drawing.Point(149, 161);
            this.tbxAdminUserName.Name = "tbxAdminUserName";
            this.tbxAdminUserName.Size = new System.Drawing.Size(319, 30);
            this.tbxAdminUserName.TabIndex = 9;
            // 
            // tbxUserIdAdmin
            // 
            this.tbxUserIdAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxUserIdAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserIdAdmin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxUserIdAdmin.Location = new System.Drawing.Point(149, 123);
            this.tbxUserIdAdmin.Name = "tbxUserIdAdmin";
            this.tbxUserIdAdmin.Size = new System.Drawing.Size(319, 30);
            this.tbxUserIdAdmin.TabIndex = 8;
            // 
            // dgwAdminList
            // 
            this.dgwAdminList.AllowUserToAddRows = false;
            this.dgwAdminList.AllowUserToDeleteRows = false;
            this.dgwAdminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwAdminList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwAdminList.BackgroundColor = System.Drawing.Color.White;
            this.dgwAdminList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAdminList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwAdminList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwAdminList.GridColor = System.Drawing.Color.Black;
            this.dgwAdminList.Location = new System.Drawing.Point(12, 86);
            this.dgwAdminList.Name = "dgwAdminList";
            this.dgwAdminList.ReadOnly = true;
            this.dgwAdminList.RowHeadersWidth = 51;
            this.dgwAdminList.RowTemplate.Height = 24;
            this.dgwAdminList.Size = new System.Drawing.Size(1310, 728);
            this.dgwAdminList.TabIndex = 6;
            this.dgwAdminList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdminList_CellClick);
            // 
            // lblLastNameSearch
            // 
            this.lblLastNameSearch.AutoSize = true;
            this.lblLastNameSearch.BackColor = System.Drawing.Color.White;
            this.lblLastNameSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastNameSearch.ForeColor = System.Drawing.Color.Black;
            this.lblLastNameSearch.Location = new System.Drawing.Point(846, 27);
            this.lblLastNameSearch.Name = "lblLastNameSearch";
            this.lblLastNameSearch.Size = new System.Drawing.Size(61, 23);
            this.lblLastNameSearch.TabIndex = 19;
            this.lblLastNameSearch.Text = "Soyad";
            // 
            // tbxSearchByLastName
            // 
            this.tbxSearchByLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxSearchByLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchByLastName.ForeColor = System.Drawing.Color.White;
            this.tbxSearchByLastName.Location = new System.Drawing.Point(913, 27);
            this.tbxSearchByLastName.Name = "tbxSearchByLastName";
            this.tbxSearchByLastName.Size = new System.Drawing.Size(333, 30);
            this.tbxSearchByLastName.TabIndex = 18;
            this.tbxSearchByLastName.TextChanged += new System.EventHandler(this.tbxSearchByLastName_TextChanged);
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.BackColor = System.Drawing.Color.White;
            this.lblSearchFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblSearchFirstName.Location = new System.Drawing.Point(428, 27);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(34, 23);
            this.lblSearchFirstName.TabIndex = 17;
            this.lblSearchFirstName.Text = "Ad";
            // 
            // tbxSearchByFirstName
            // 
            this.tbxSearchByFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxSearchByFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchByFirstName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxSearchByFirstName.Location = new System.Drawing.Point(471, 25);
            this.tbxSearchByFirstName.Name = "tbxSearchByFirstName";
            this.tbxSearchByFirstName.Size = new System.Drawing.Size(333, 30);
            this.tbxSearchByFirstName.TabIndex = 16;
            this.tbxSearchByFirstName.TextChanged += new System.EventHandler(this.tbxSearchByFirstName_TextChanged);
            // 
            // AdminDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1861, 983);
            this.Controls.Add(this.lblLastNameSearch);
            this.Controls.Add(this.tbxSearchByLastName);
            this.Controls.Add(this.lblSearchFirstName);
            this.Controls.Add(this.tbxSearchByFirstName);
            this.Controls.Add(this.dgwAdminList);
            this.Controls.Add(this.groupBoxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDelete";
            this.Text = "AdminDelete";
            this.Load += new System.EventHandler(this.AdminDelete_Load);
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Button btnAdminDelete;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdmiUserName;
        private System.Windows.Forms.Label lblUserIdAdmin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxAdminUserName;
        private System.Windows.Forms.TextBox tbxUserIdAdmin;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.TextBox tbxAdminId;
        private System.Windows.Forms.DataGridView dgwAdminList;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblLastNameSearch;
        private System.Windows.Forms.TextBox tbxSearchByLastName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox tbxSearchByFirstName;
    }
}