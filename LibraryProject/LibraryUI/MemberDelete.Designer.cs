namespace LibraryProject.LibraryUI
{
    partial class MemberDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwMemberList = new System.Windows.Forms.DataGridView();
            this.groupBoxMember = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblMemberAdress = new System.Windows.Forms.Label();
            this.tbxMemberAdres = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.tbxMemberId = new System.Windows.Forms.TextBox();
            this.btnMemberDelete = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblMemberNumber = new System.Windows.Forms.Label();
            this.lblUserIdMember = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxMemberNumber = new System.Windows.Forms.TextBox();
            this.tbxUserIdMember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearchByLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchByFirstName = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberList)).BeginInit();
            this.groupBoxMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = System.Drawing.Color.White;
            lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblEmail.Location = new System.Drawing.Point(24, 495);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(107, 23);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Mail Adresi";
            // 
            // dgwMemberList
            // 
            this.dgwMemberList.AllowUserToAddRows = false;
            this.dgwMemberList.AllowUserToDeleteRows = false;
            this.dgwMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwMemberList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwMemberList.BackgroundColor = System.Drawing.Color.White;
            this.dgwMemberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMemberList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMemberList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwMemberList.GridColor = System.Drawing.Color.Black;
            this.dgwMemberList.Location = new System.Drawing.Point(12, 81);
            this.dgwMemberList.Name = "dgwMemberList";
            this.dgwMemberList.ReadOnly = true;
            this.dgwMemberList.RowHeadersWidth = 51;
            this.dgwMemberList.RowTemplate.Height = 24;
            this.dgwMemberList.Size = new System.Drawing.Size(1265, 724);
            this.dgwMemberList.TabIndex = 8;
            this.dgwMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMemberList_CellClick);
            // 
            // groupBoxMember
            // 
            this.groupBoxMember.BackColor = System.Drawing.Color.White;
            this.groupBoxMember.Controls.Add(lblEmail);
            this.groupBoxMember.Controls.Add(this.tbxEmail);
            this.groupBoxMember.Controls.Add(this.lblLastName);
            this.groupBoxMember.Controls.Add(this.tbxLastName);
            this.groupBoxMember.Controls.Add(this.lblFirstName);
            this.groupBoxMember.Controls.Add(this.tbxFirstName);
            this.groupBoxMember.Controls.Add(this.lblMemberAdress);
            this.groupBoxMember.Controls.Add(this.tbxMemberAdres);
            this.groupBoxMember.Controls.Add(this.lblMemberId);
            this.groupBoxMember.Controls.Add(this.tbxMemberId);
            this.groupBoxMember.Controls.Add(this.btnMemberDelete);
            this.groupBoxMember.Controls.Add(this.lblPhoneNumber);
            this.groupBoxMember.Controls.Add(this.lblMemberNumber);
            this.groupBoxMember.Controls.Add(this.lblUserIdMember);
            this.groupBoxMember.Controls.Add(this.tbxPhoneNumber);
            this.groupBoxMember.Controls.Add(this.tbxMemberNumber);
            this.groupBoxMember.Controls.Add(this.tbxUserIdMember);
            this.groupBoxMember.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxMember.ForeColor = System.Drawing.Color.Black;
            this.groupBoxMember.Location = new System.Drawing.Point(1303, 64);
            this.groupBoxMember.Name = "groupBoxMember";
            this.groupBoxMember.Size = new System.Drawing.Size(484, 769);
            this.groupBoxMember.TabIndex = 7;
            this.groupBoxMember.TabStop = false;
            this.groupBoxMember.Text = "Üye Bilgileri";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(149, 488);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(319, 30);
            this.tbxEmail.TabIndex = 33;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(70, 446);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 23);
            this.lblLastName.TabIndex = 32;
            this.lblLastName.Text = "Soyad";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.ForeColor = System.Drawing.Color.White;
            this.tbxLastName.Location = new System.Drawing.Point(149, 444);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(319, 30);
            this.tbxLastName.TabIndex = 31;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(97, 395);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 23);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "Ad";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.White;
            this.tbxFirstName.Location = new System.Drawing.Point(149, 393);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(319, 30);
            this.tbxFirstName.TabIndex = 29;
            // 
            // lblMemberAdress
            // 
            this.lblMemberAdress.AutoSize = true;
            this.lblMemberAdress.BackColor = System.Drawing.Color.White;
            this.lblMemberAdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberAdress.ForeColor = System.Drawing.Color.Black;
            this.lblMemberAdress.Location = new System.Drawing.Point(33, 255);
            this.lblMemberAdress.Name = "lblMemberAdress";
            this.lblMemberAdress.Size = new System.Drawing.Size(98, 23);
            this.lblMemberAdress.TabIndex = 18;
            this.lblMemberAdress.Text = "Üye Adres";
            // 
            // tbxMemberAdres
            // 
            this.tbxMemberAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberAdres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMemberAdres.ForeColor = System.Drawing.Color.White;
            this.tbxMemberAdres.Location = new System.Drawing.Point(149, 255);
            this.tbxMemberAdres.Multiline = true;
            this.tbxMemberAdres.Name = "tbxMemberAdres";
            this.tbxMemberAdres.Size = new System.Drawing.Size(319, 117);
            this.tbxMemberAdres.TabIndex = 17;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.BackColor = System.Drawing.Color.White;
            this.lblMemberId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberId.ForeColor = System.Drawing.Color.Black;
            this.lblMemberId.Location = new System.Drawing.Point(102, 83);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(27, 23);
            this.lblMemberId.TabIndex = 16;
            this.lblMemberId.Text = "Id";
            // 
            // tbxMemberId
            // 
            this.tbxMemberId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMemberId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxMemberId.Location = new System.Drawing.Point(149, 76);
            this.tbxMemberId.Name = "tbxMemberId";
            this.tbxMemberId.Size = new System.Drawing.Size(319, 30);
            this.tbxMemberId.TabIndex = 15;
            // 
            // btnMemberDelete
            // 
            this.btnMemberDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberDelete.Location = new System.Drawing.Point(314, 678);
            this.btnMemberDelete.Name = "btnMemberDelete";
            this.btnMemberDelete.Size = new System.Drawing.Size(154, 43);
            this.btnMemberDelete.TabIndex = 14;
            this.btnMemberDelete.Text = "Sil";
            this.btnMemberDelete.UseVisualStyleBackColor = true;
            this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(29, 202);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(102, 23);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Telefon No";
            // 
            // lblMemberNumber
            // 
            this.lblMemberNumber.AutoSize = true;
            this.lblMemberNumber.BackColor = System.Drawing.Color.White;
            this.lblMemberNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.lblMemberNumber.Location = new System.Drawing.Point(56, 163);
            this.lblMemberNumber.Name = "lblMemberNumber";
            this.lblMemberNumber.Size = new System.Drawing.Size(73, 23);
            this.lblMemberNumber.TabIndex = 12;
            this.lblMemberNumber.Text = "Üye No";
            // 
            // lblUserIdMember
            // 
            this.lblUserIdMember.AutoSize = true;
            this.lblUserIdMember.BackColor = System.Drawing.Color.White;
            this.lblUserIdMember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserIdMember.ForeColor = System.Drawing.Color.Black;
            this.lblUserIdMember.Location = new System.Drawing.Point(59, 125);
            this.lblUserIdMember.Name = "lblUserIdMember";
            this.lblUserIdMember.Size = new System.Drawing.Size(72, 23);
            this.lblUserIdMember.TabIndex = 11;
            this.lblUserIdMember.Text = "User Id";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.tbxPhoneNumber.Location = new System.Drawing.Point(149, 202);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(319, 30);
            this.tbxPhoneNumber.TabIndex = 10;
            // 
            // tbxMemberNumber
            // 
            this.tbxMemberNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMemberNumber.ForeColor = System.Drawing.Color.White;
            this.tbxMemberNumber.Location = new System.Drawing.Point(149, 161);
            this.tbxMemberNumber.Name = "tbxMemberNumber";
            this.tbxMemberNumber.Size = new System.Drawing.Size(319, 30);
            this.tbxMemberNumber.TabIndex = 9;
            // 
            // tbxUserIdMember
            // 
            this.tbxUserIdMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxUserIdMember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserIdMember.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxUserIdMember.Location = new System.Drawing.Point(149, 123);
            this.tbxUserIdMember.Name = "tbxUserIdMember";
            this.tbxUserIdMember.Size = new System.Drawing.Size(319, 30);
            this.tbxUserIdMember.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(864, 47);
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
            this.tbxSearchByLastName.Location = new System.Drawing.Point(931, 47);
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
            this.label1.Location = new System.Drawing.Point(446, 47);
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
            this.tbxSearchByFirstName.Location = new System.Drawing.Point(489, 45);
            this.tbxSearchByFirstName.Name = "tbxSearchByFirstName";
            this.tbxSearchByFirstName.Size = new System.Drawing.Size(333, 30);
            this.tbxSearchByFirstName.TabIndex = 16;
            this.tbxSearchByFirstName.TextChanged += new System.EventHandler(this.tbxSearchByFirstName_TextChanged);
            // 
            // MemberDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1812, 914);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSearchByLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearchByFirstName);
            this.Controls.Add(this.dgwMemberList);
            this.Controls.Add(this.groupBoxMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberDelete";
            this.Text = "MemberDelete";
            this.Load += new System.EventHandler(this.MemberDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberList)).EndInit();
            this.groupBoxMember.ResumeLayout(false);
            this.groupBoxMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMemberList;
        private System.Windows.Forms.GroupBox groupBoxMember;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox tbxMemberId;
        private System.Windows.Forms.Button btnMemberDelete;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMemberNumber;
        private System.Windows.Forms.Label lblUserIdMember;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxMemberNumber;
        private System.Windows.Forms.TextBox tbxUserIdMember;
        private System.Windows.Forms.Label lblMemberAdress;
        private System.Windows.Forms.TextBox tbxMemberAdres;
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