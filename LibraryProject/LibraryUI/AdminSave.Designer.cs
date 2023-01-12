namespace LibraryProject.LibraryUI
{
    partial class AdminSave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxUserSave = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.tbxUserId = new System.Windows.Forms.TextBox();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.btnAdminSave = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdmiUserName = new System.Windows.Forms.Label();
            this.lblUserIdAdmin = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxAdminUserName = new System.Windows.Forms.TextBox();
            this.tbxUserIdAdmin = new System.Windows.Forms.TextBox();
            this.dgwUserList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearchByLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchByFirstName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxUserSave.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUserSave
            // 
            this.groupBoxUserSave.BackColor = System.Drawing.Color.White;
            this.groupBoxUserSave.Controls.Add(this.btnClear);
            this.groupBoxUserSave.Controls.Add(this.tbxEmail);
            this.groupBoxUserSave.Controls.Add(this.btnUserDelete);
            this.groupBoxUserSave.Controls.Add(this.lblUserId);
            this.groupBoxUserSave.Controls.Add(this.tbxUserId);
            this.groupBoxUserSave.Controls.Add(this.btnUserUpdate);
            this.groupBoxUserSave.Controls.Add(this.btnUserSave);
            this.groupBoxUserSave.Controls.Add(this.lblEmail);
            this.groupBoxUserSave.Controls.Add(this.lblLastName);
            this.groupBoxUserSave.Controls.Add(this.lblFirstName);
            this.groupBoxUserSave.Controls.Add(this.tbxLastName);
            this.groupBoxUserSave.Controls.Add(this.tbxFirstName);
            this.groupBoxUserSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxUserSave.ForeColor = System.Drawing.Color.Black;
            this.groupBoxUserSave.Location = new System.Drawing.Point(1090, 107);
            this.groupBoxUserSave.Name = "groupBoxUserSave";
            this.groupBoxUserSave.Size = new System.Drawing.Size(688, 310);
            this.groupBoxUserSave.TabIndex = 0;
            this.groupBoxUserSave.TabStop = false;
            this.groupBoxUserSave.Text = "Kullanıcı Bilgileri";
            this.groupBoxUserSave.Enter += new System.EventHandler(this.groupBoxUserSave_Enter);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(216, 163);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(319, 30);
            this.tbxEmail.TabIndex = 32;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.Location = new System.Drawing.Point(188, 237);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(146, 43);
            this.btnUserDelete.TabIndex = 31;
            this.btnUserDelete.Text = "Sil";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.BackColor = System.Drawing.Color.White;
            this.lblUserId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserId.ForeColor = System.Drawing.Color.Black;
            this.lblUserId.Location = new System.Drawing.Point(138, 52);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(72, 23);
            this.lblUserId.TabIndex = 22;
            this.lblUserId.Text = "User Id";
            // 
            // tbxUserId
            // 
            this.tbxUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxUserId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxUserId.Location = new System.Drawing.Point(216, 50);
            this.tbxUserId.Name = "tbxUserId";
            this.tbxUserId.Size = new System.Drawing.Size(319, 30);
            this.tbxUserId.TabIndex = 20;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserUpdate.Location = new System.Drawing.Point(6, 237);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(164, 43);
            this.btnUserUpdate.TabIndex = 19;
            this.btnUserUpdate.Text = "Güncelle";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSave.Location = new System.Drawing.Point(352, 237);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(138, 43);
            this.btnUserSave.TabIndex = 16;
            this.btnUserSave.Text = "Kaydet";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(99, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 23);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Mail Adresi";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(145, 134);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 23);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Soyad";
            this.lblLastName.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(172, 93);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 23);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "Ad";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.ForeColor = System.Drawing.Color.White;
            this.tbxLastName.Location = new System.Drawing.Point(216, 127);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(319, 30);
            this.tbxLastName.TabIndex = 9;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxFirstName.Location = new System.Drawing.Point(216, 91);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(319, 30);
            this.tbxFirstName.TabIndex = 8;
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.BackColor = System.Drawing.Color.White;
            this.groupBoxAdmin.Controls.Add(this.btnAdminSave);
            this.groupBoxAdmin.Controls.Add(this.lblPassword);
            this.groupBoxAdmin.Controls.Add(this.lblAdmiUserName);
            this.groupBoxAdmin.Controls.Add(this.lblUserIdAdmin);
            this.groupBoxAdmin.Controls.Add(this.tbxPassword);
            this.groupBoxAdmin.Controls.Add(this.tbxAdminUserName);
            this.groupBoxAdmin.Controls.Add(this.tbxUserIdAdmin);
            this.groupBoxAdmin.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAdmin.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAdmin.Location = new System.Drawing.Point(1205, 448);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(507, 300);
            this.groupBoxAdmin.TabIndex = 1;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin Bilgileri";
            this.groupBoxAdmin.Enter += new System.EventHandler(this.groupBoxAdmin_Enter);
            // 
            // btnAdminSave
            // 
            this.btnAdminSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminSave.Location = new System.Drawing.Point(307, 214);
            this.btnAdminSave.Name = "btnAdminSave";
            this.btnAdminSave.Size = new System.Drawing.Size(154, 43);
            this.btnAdminSave.TabIndex = 14;
            this.btnAdminSave.Text = "Kaydet";
            this.btnAdminSave.UseVisualStyleBackColor = true;
            this.btnAdminSave.Click += new System.EventHandler(this.btnAdminSave_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(71, 143);
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
            this.lblAdmiUserName.Location = new System.Drawing.Point(6, 97);
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
            this.lblUserIdAdmin.Location = new System.Drawing.Point(50, 59);
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
            this.tbxPassword.Location = new System.Drawing.Point(142, 136);
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
            this.tbxAdminUserName.Location = new System.Drawing.Point(142, 90);
            this.tbxAdminUserName.Name = "tbxAdminUserName";
            this.tbxAdminUserName.Size = new System.Drawing.Size(319, 30);
            this.tbxAdminUserName.TabIndex = 9;
            // 
            // tbxUserIdAdmin
            // 
            this.tbxUserIdAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxUserIdAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserIdAdmin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxUserIdAdmin.Location = new System.Drawing.Point(142, 52);
            this.tbxUserIdAdmin.Name = "tbxUserIdAdmin";
            this.tbxUserIdAdmin.Size = new System.Drawing.Size(319, 30);
            this.tbxUserIdAdmin.TabIndex = 8;
            // 
            // dgwUserList
            // 
            this.dgwUserList.AllowUserToAddRows = false;
            this.dgwUserList.AllowUserToDeleteRows = false;
            this.dgwUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwUserList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwUserList.BackgroundColor = System.Drawing.Color.White;
            this.dgwUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwUserList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwUserList.GridColor = System.Drawing.Color.Black;
            this.dgwUserList.Location = new System.Drawing.Point(30, 79);
            this.dgwUserList.Name = "dgwUserList";
            this.dgwUserList.ReadOnly = true;
            this.dgwUserList.RowHeadersWidth = 51;
            this.dgwUserList.RowTemplate.Height = 24;
            this.dgwUserList.Size = new System.Drawing.Size(973, 769);
            this.dgwUserList.TabIndex = 2;
            this.dgwUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUserList_CellClick);
            this.dgwUserList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwUserList_CellFormatting);
            this.dgwUserList.SelectionChanged += new System.EventHandler(this.dgwUserList_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(584, 36);
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
            this.tbxSearchByLastName.Location = new System.Drawing.Point(651, 36);
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
            this.label1.Location = new System.Drawing.Point(166, 36);
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
            this.tbxSearchByFirstName.Location = new System.Drawing.Point(209, 34);
            this.tbxSearchByFirstName.Name = "tbxSearchByFirstName";
            this.tbxSearchByFirstName.Size = new System.Drawing.Size(333, 30);
            this.tbxSearchByFirstName.TabIndex = 16;
            this.tbxSearchByFirstName.TextChanged += new System.EventHandler(this.tbxSearchByFirstName_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(513, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(158, 39);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AdminSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1806, 918);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSearchByLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearchByFirstName);
            this.Controls.Add(this.dgwUserList);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.groupBoxUserSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSave";
            this.Text = "AdminSave";
            this.Load += new System.EventHandler(this.AdminSave_Load);
            this.groupBoxUserSave.ResumeLayout(false);
            this.groupBoxUserSave.PerformLayout();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserSave;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAdmiUserName;
        private System.Windows.Forms.Label lblUserIdAdmin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxAdminUserName;
        private System.Windows.Forms.TextBox tbxUserIdAdmin;
        private System.Windows.Forms.Button btnAdminSave;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.DataGridView dgwUserList;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox tbxUserId;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearchByLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearchByFirstName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnClear;
    }
}