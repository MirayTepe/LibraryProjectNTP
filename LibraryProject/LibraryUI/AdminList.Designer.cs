namespace LibraryProject.LibraryUI
{
    partial class AdminList
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
            this.lblAdminId = new System.Windows.Forms.Label();
            this.tbxAdminId = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblAdmiUserName = new System.Windows.Forms.Label();
            this.lblUserIdAdmin = new System.Windows.Forms.Label();
            this.tbxAdminUserName = new System.Windows.Forms.TextBox();
            this.tbxUserIdAdmin = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = System.Drawing.Color.White;
            lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblEmail.Location = new System.Drawing.Point(1418, 355);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(107, 23);
            lblEmail.TabIndex = 40;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy;
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
            this.dgwAdminList.Location = new System.Drawing.Point(12, 12);
            this.dgwAdminList.Name = "dgwAdminList";
            this.dgwAdminList.ReadOnly = true;
            this.dgwAdminList.RowHeadersWidth = 51;
            this.dgwAdminList.RowTemplate.Height = 24;
            this.dgwAdminList.Size = new System.Drawing.Size(1383, 764);
            this.dgwAdminList.TabIndex = 7;
            this.dgwAdminList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdminList_CellClick);
            this.dgwAdminList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdminList_CellContentClick);
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.BackColor = System.Drawing.Color.White;
            this.lblAdminId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminId.ForeColor = System.Drawing.Color.Black;
            this.lblAdminId.Location = new System.Drawing.Point(1498, 126);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(27, 23);
            this.lblAdminId.TabIndex = 18;
            this.lblAdminId.Text = "Id";
            // 
            // tbxAdminId
            // 
            this.tbxAdminId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxAdminId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdminId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxAdminId.Location = new System.Drawing.Point(1545, 124);
            this.tbxAdminId.Name = "tbxAdminId";
            this.tbxAdminId.Size = new System.Drawing.Size(278, 30);
            this.tbxAdminId.TabIndex = 17;
            this.tbxAdminId.TextChanged += new System.EventHandler(this.tbxAdminId_TextChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(1546, 348);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(278, 30);
            this.tbxEmail.TabIndex = 39;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(1462, 311);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 23);
            this.lblLastName.TabIndex = 38;
            this.lblLastName.Text = "Soyad";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.ForeColor = System.Drawing.Color.White;
            this.tbxLastName.Location = new System.Drawing.Point(1545, 304);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(278, 30);
            this.tbxLastName.TabIndex = 37;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(1489, 260);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 23);
            this.lblFirstName.TabIndex = 36;
            this.lblFirstName.Text = "Ad";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.White;
            this.tbxFirstName.Location = new System.Drawing.Point(1545, 253);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(278, 30);
            this.tbxFirstName.TabIndex = 35;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // lblAdmiUserName
            // 
            this.lblAdmiUserName.AutoSize = true;
            this.lblAdmiUserName.BackColor = System.Drawing.Color.White;
            this.lblAdmiUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdmiUserName.ForeColor = System.Drawing.Color.Black;
            this.lblAdmiUserName.Location = new System.Drawing.Point(1409, 209);
            this.lblAdmiUserName.Name = "lblAdmiUserName";
            this.lblAdmiUserName.Size = new System.Drawing.Size(116, 23);
            this.lblAdmiUserName.TabIndex = 33;
            this.lblAdmiUserName.Text = "Kullanıcı Adı";
            // 
            // lblUserIdAdmin
            // 
            this.lblUserIdAdmin.AutoSize = true;
            this.lblUserIdAdmin.BackColor = System.Drawing.Color.White;
            this.lblUserIdAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserIdAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblUserIdAdmin.Location = new System.Drawing.Point(1453, 166);
            this.lblUserIdAdmin.Name = "lblUserIdAdmin";
            this.lblUserIdAdmin.Size = new System.Drawing.Size(72, 23);
            this.lblUserIdAdmin.TabIndex = 32;
            this.lblUserIdAdmin.Text = "User Id";
            // 
            // tbxAdminUserName
            // 
            this.tbxAdminUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxAdminUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdminUserName.ForeColor = System.Drawing.Color.White;
            this.tbxAdminUserName.Location = new System.Drawing.Point(1545, 202);
            this.tbxAdminUserName.Name = "tbxAdminUserName";
            this.tbxAdminUserName.Size = new System.Drawing.Size(278, 30);
            this.tbxAdminUserName.TabIndex = 30;
            this.tbxAdminUserName.TextChanged += new System.EventHandler(this.tbxAdminUserName_TextChanged);
            // 
            // tbxUserIdAdmin
            // 
            this.tbxUserIdAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxUserIdAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserIdAdmin.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxUserIdAdmin.Location = new System.Drawing.Point(1545, 164);
            this.tbxUserIdAdmin.Name = "tbxUserIdAdmin";
            this.tbxUserIdAdmin.Size = new System.Drawing.Size(278, 30);
            this.tbxUserIdAdmin.TabIndex = 29;
            this.tbxUserIdAdmin.TextChanged += new System.EventHandler(this.tbxUserIdAdmin_TextChanged);
            // 
            // AdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1855, 879);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblAdmiUserName);
            this.Controls.Add(this.lblUserIdAdmin);
            this.Controls.Add(this.tbxAdminUserName);
            this.Controls.Add(this.tbxUserIdAdmin);
            this.Controls.Add(this.lblAdminId);
            this.Controls.Add(this.tbxAdminId);
            this.Controls.Add(this.dgwAdminList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminList";
            this.Text = "AdminListed";
            this.Load += new System.EventHandler(this.AdminList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdminList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAdminList;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.TextBox tbxAdminId;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblAdmiUserName;
        private System.Windows.Forms.Label lblUserIdAdmin;
        private System.Windows.Forms.TextBox tbxAdminUserName;
        private System.Windows.Forms.TextBox tbxUserIdAdmin;
    }
}