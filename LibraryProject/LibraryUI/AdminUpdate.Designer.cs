namespace LibraryProject.LibraryUI
{
    partial class AdminUpdate
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
            this.dgwAdminList = new System.Windows.Forms.DataGridView();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.tbxAdminId = new System.Windows.Forms.TextBox();
            this.btnAdminUpdate = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdmiUserName = new System.Windows.Forms.Label();
            this.lblUserIdAdmin = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxAdminUserName = new System.Windows.Forms.TextBox();
            this.tbxUserIdAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearchByLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchByFirstName = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminList)).BeginInit();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = System.Drawing.Color.White;
            lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblEmail.Location = new System.Drawing.Point(22, 358);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(107, 23);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Mail Adresi";
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
            this.dgwAdminList.Location = new System.Drawing.Point(23, 75);
            this.dgwAdminList.Name = "dgwAdminList";
            this.dgwAdminList.ReadOnly = true;
            this.dgwAdminList.RowHeadersWidth = 51;
            this.dgwAdminList.RowTemplate.Height = 24;
            this.dgwAdminList.Size = new System.Drawing.Size(1281, 654);
            this.dgwAdminList.TabIndex = 8;
            this.dgwAdminList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdminList_CellClick);
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
            this.groupBoxAdmin.Controls.Add(this.btnAdminUpdate);
            this.groupBoxAdmin.Controls.Add(this.lblPassword);
            this.groupBoxAdmin.Controls.Add(this.lblAdmiUserName);
            this.groupBoxAdmin.Controls.Add(this.lblUserIdAdmin);
            this.groupBoxAdmin.Controls.Add(this.tbxPassword);
            this.groupBoxAdmin.Controls.Add(this.tbxAdminUserName);
            this.groupBoxAdmin.Controls.Add(this.tbxUserIdAdmin);
            this.groupBoxAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAdmin.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAdmin.Location = new System.Drawing.Point(1326, 53);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(507, 654);
            this.groupBoxAdmin.TabIndex = 7;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin Bilgileri";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(149, 351);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(319, 30);
            this.tbxEmail.TabIndex = 21;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(66, 314);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 23);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "Soyad";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.ForeColor = System.Drawing.Color.White;
            this.tbxLastName.Location = new System.Drawing.Point(149, 307);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(319, 30);
            this.tbxLastName.TabIndex = 19;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(93, 263);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 23);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "Ad";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.White;
            this.tbxFirstName.Location = new System.Drawing.Point(149, 256);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(319, 30);
            this.tbxFirstName.TabIndex = 17;
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.Color.White;
            this.lblAdminId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminId.ForeColor = System.Drawing.Color.Black;
            this.lblAdminId.Location = new System.Drawing.Point(99, 83);
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
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUpdate.Location = new System.Drawing.Point(314, 437);
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Size = new System.Drawing.Size(154, 43);
            this.btnAdminUpdate.TabIndex = 14;
            this.btnAdminUpdate.Text = "Güncelle";
            this.btnAdminUpdate.UseVisualStyleBackColor = true;
            this.btnAdminUpdate.Click += new System.EventHandler(this.btnAdminUpdate_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(75, 214);
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
            this.lblUserIdAdmin.Location = new System.Drawing.Point(54, 123);
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
            this.tbxAdminUserName.Location = new System.Drawing.Point(149, 166);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(824, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soyad";
            // 
            // tbxSearchByLastName
            // 
            this.tbxSearchByLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxSearchByLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchByLastName.ForeColor = System.Drawing.Color.White;
            this.tbxSearchByLastName.Location = new System.Drawing.Point(891, 29);
            this.tbxSearchByLastName.Name = "tbxSearchByLastName";
            this.tbxSearchByLastName.Size = new System.Drawing.Size(333, 30);
            this.tbxSearchByLastName.TabIndex = 18;
            this.tbxSearchByLastName.TextChanged += new System.EventHandler(this.tbxSearchByLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(406, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad";
            // 
            // tbxSearchByFirstName
            // 
            this.tbxSearchByFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxSearchByFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearchByFirstName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxSearchByFirstName.Location = new System.Drawing.Point(449, 27);
            this.tbxSearchByFirstName.Name = "tbxSearchByFirstName";
            this.tbxSearchByFirstName.Size = new System.Drawing.Size(333, 30);
            this.tbxSearchByFirstName.TabIndex = 16;
            this.tbxSearchByFirstName.TextChanged += new System.EventHandler(this.tbxSearchByFirstName_TextChanged);
            // 
            // AdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1859, 983);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSearchByLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearchByFirstName);
            this.Controls.Add(this.dgwAdminList);
            this.Controls.Add(this.groupBoxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUpdate";
            this.Text = "AdminUpdate";
            this.Load += new System.EventHandler(this.AdminUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminList)).EndInit();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAdminList;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.TextBox tbxAdminId;
        private System.Windows.Forms.Button btnAdminUpdate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdmiUserName;
        private System.Windows.Forms.Label lblUserIdAdmin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxAdminUserName;
        private System.Windows.Forms.TextBox tbxUserIdAdmin;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearchByLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchByFirstName;
    }
}