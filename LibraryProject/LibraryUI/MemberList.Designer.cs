namespace LibraryProject.LibraryUI
{
    partial class MemberList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwMemberList = new System.Windows.Forms.DataGridView();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblMemberAdress = new System.Windows.Forms.Label();
            this.tbxMemberAdres = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.tbxMemberId = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblMemberNumber = new System.Windows.Forms.Label();
            this.lblUserIdMember = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxMemberNumber = new System.Windows.Forms.TextBox();
            this.tbxUserIdMember = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = System.Drawing.Color.White;
            lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblEmail.ForeColor = System.Drawing.Color.Black;
            lblEmail.Location = new System.Drawing.Point(1434, 523);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(107, 23);
            lblEmail.TabIndex = 50;
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwMemberList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgwMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwMemberList.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgwMemberList.GridColor = System.Drawing.Color.Black;
            this.dgwMemberList.Location = new System.Drawing.Point(12, 22);
            this.dgwMemberList.Name = "dgwMemberList";
            this.dgwMemberList.ReadOnly = true;
            this.dgwMemberList.RowHeadersWidth = 51;
            this.dgwMemberList.RowTemplate.Height = 24;
            this.dgwMemberList.Size = new System.Drawing.Size(1386, 766);
            this.dgwMemberList.TabIndex = 8;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Location = new System.Drawing.Point(1554, 516);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(274, 30);
            this.tbxEmail.TabIndex = 49;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(1475, 474);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 23);
            this.lblLastName.TabIndex = 48;
            this.lblLastName.Text = "Soyad";
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLastName.ForeColor = System.Drawing.Color.White;
            this.tbxLastName.Location = new System.Drawing.Point(1554, 472);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(274, 30);
            this.tbxLastName.TabIndex = 47;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(1502, 423);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 23);
            this.lblFirstName.TabIndex = 46;
            this.lblFirstName.Text = "Ad";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.White;
            this.tbxFirstName.Location = new System.Drawing.Point(1554, 421);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(274, 30);
            this.tbxFirstName.TabIndex = 45;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // lblMemberAdress
            // 
            this.lblMemberAdress.AutoSize = true;
            this.lblMemberAdress.BackColor = System.Drawing.Color.White;
            this.lblMemberAdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberAdress.ForeColor = System.Drawing.Color.Black;
            this.lblMemberAdress.Location = new System.Drawing.Point(1438, 283);
            this.lblMemberAdress.Name = "lblMemberAdress";
            this.lblMemberAdress.Size = new System.Drawing.Size(98, 23);
            this.lblMemberAdress.TabIndex = 44;
            this.lblMemberAdress.Text = "Üye Adres";
            // 
            // tbxMemberAdres
            // 
            this.tbxMemberAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberAdres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMemberAdres.ForeColor = System.Drawing.Color.White;
            this.tbxMemberAdres.Location = new System.Drawing.Point(1554, 283);
            this.tbxMemberAdres.Multiline = true;
            this.tbxMemberAdres.Name = "tbxMemberAdres";
            this.tbxMemberAdres.Size = new System.Drawing.Size(274, 117);
            this.tbxMemberAdres.TabIndex = 43;
            this.tbxMemberAdres.TextChanged += new System.EventHandler(this.tbxMemberAdres_TextChanged);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.BackColor = System.Drawing.Color.White;
            this.lblMemberId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberId.ForeColor = System.Drawing.Color.Black;
            this.lblMemberId.Location = new System.Drawing.Point(1507, 111);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(27, 23);
            this.lblMemberId.TabIndex = 42;
            this.lblMemberId.Text = "Id";
            // 
            // tbxMemberId
            // 
            this.tbxMemberId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMemberId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxMemberId.Location = new System.Drawing.Point(1554, 104);
            this.tbxMemberId.Name = "tbxMemberId";
            this.tbxMemberId.Size = new System.Drawing.Size(274, 30);
            this.tbxMemberId.TabIndex = 41;
            this.tbxMemberId.TextChanged += new System.EventHandler(this.tbxMemberId_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNumber.Location = new System.Drawing.Point(1434, 230);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(102, 23);
            this.lblPhoneNumber.TabIndex = 40;
            this.lblPhoneNumber.Text = "Telefon No";
            // 
            // lblMemberNumber
            // 
            this.lblMemberNumber.AutoSize = true;
            this.lblMemberNumber.BackColor = System.Drawing.Color.White;
            this.lblMemberNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.lblMemberNumber.Location = new System.Drawing.Point(1461, 191);
            this.lblMemberNumber.Name = "lblMemberNumber";
            this.lblMemberNumber.Size = new System.Drawing.Size(73, 23);
            this.lblMemberNumber.TabIndex = 39;
            this.lblMemberNumber.Text = "Üye No";
            // 
            // lblUserIdMember
            // 
            this.lblUserIdMember.AutoSize = true;
            this.lblUserIdMember.BackColor = System.Drawing.Color.White;
            this.lblUserIdMember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserIdMember.ForeColor = System.Drawing.Color.Black;
            this.lblUserIdMember.Location = new System.Drawing.Point(1464, 153);
            this.lblUserIdMember.Name = "lblUserIdMember";
            this.lblUserIdMember.Size = new System.Drawing.Size(72, 23);
            this.lblUserIdMember.TabIndex = 38;
            this.lblUserIdMember.Text = "User Id";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.tbxPhoneNumber.Location = new System.Drawing.Point(1554, 230);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(274, 30);
            this.tbxPhoneNumber.TabIndex = 37;
            this.tbxPhoneNumber.TextChanged += new System.EventHandler(this.tbxPhoneNumber_TextChanged);
            // 
            // tbxMemberNumber
            // 
            this.tbxMemberNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMemberNumber.ForeColor = System.Drawing.Color.White;
            this.tbxMemberNumber.Location = new System.Drawing.Point(1554, 189);
            this.tbxMemberNumber.Name = "tbxMemberNumber";
            this.tbxMemberNumber.Size = new System.Drawing.Size(274, 30);
            this.tbxMemberNumber.TabIndex = 36;
            this.tbxMemberNumber.TextChanged += new System.EventHandler(this.tbxMemberNumber_TextChanged);
            // 
            // tbxUserIdMember
            // 
            this.tbxUserIdMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxUserIdMember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserIdMember.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxUserIdMember.Location = new System.Drawing.Point(1554, 151);
            this.tbxUserIdMember.Name = "tbxUserIdMember";
            this.tbxUserIdMember.Size = new System.Drawing.Size(274, 30);
            this.tbxUserIdMember.TabIndex = 35;
            this.tbxUserIdMember.TextChanged += new System.EventHandler(this.tbxUserIdMember_TextChanged);
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 862);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblMemberAdress);
            this.Controls.Add(this.tbxMemberAdres);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.tbxMemberId);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblMemberNumber);
            this.Controls.Add(this.lblUserIdMember);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.tbxMemberNumber);
            this.Controls.Add(this.tbxUserIdMember);
            this.Controls.Add(this.dgwMemberList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberList";
            this.Text = "MemberList";
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMemberList;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblMemberAdress;
        private System.Windows.Forms.TextBox tbxMemberAdres;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox tbxMemberId;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMemberNumber;
        private System.Windows.Forms.Label lblUserIdMember;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxMemberNumber;
        private System.Windows.Forms.TextBox tbxUserIdMember;
    }
}