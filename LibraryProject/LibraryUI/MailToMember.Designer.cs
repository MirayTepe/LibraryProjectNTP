namespace LibraryProject.LibraryUI
{
    partial class MailToMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailToMember));
            this.lblLoanedBookMail = new System.Windows.Forms.Label();
            this.lblMailHeader = new System.Windows.Forms.Label();
            this.lblSendMail = new System.Windows.Forms.Label();
            this.tbxSendMail = new System.Windows.Forms.TextBox();
            this.tbxMailHeader = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoanedBookMail
            // 
            resources.ApplyResources(this.lblLoanedBookMail, "lblLoanedBookMail");
            this.lblLoanedBookMail.Name = "lblLoanedBookMail";
            // 
            // lblMailHeader
            // 
            resources.ApplyResources(this.lblMailHeader, "lblMailHeader");
            this.lblMailHeader.Name = "lblMailHeader";
            // 
            // lblSendMail
            // 
            resources.ApplyResources(this.lblSendMail, "lblSendMail");
            this.lblSendMail.Name = "lblSendMail";
            // 
            // tbxSendMail
            // 
            this.tbxSendMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tbxSendMail, "tbxSendMail");
            this.tbxSendMail.ForeColor = System.Drawing.Color.White;
            this.tbxSendMail.Name = "tbxSendMail";
            this.tbxSendMail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // tbxMailHeader
            // 
            this.tbxMailHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tbxMailHeader, "tbxMailHeader");
            this.tbxMailHeader.ForeColor = System.Drawing.Color.White;
            this.tbxMailHeader.Name = "tbxMailHeader";
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.tbxEmail, "tbxEmail");
            this.tbxEmail.ForeColor = System.Drawing.Color.White;
            this.tbxEmail.Name = "tbxEmail";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // btnSendEmail
            // 
            resources.ApplyResources(this.btnSendEmail, "btnSendEmail");
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // MailToMembers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxSendMail);
            this.Controls.Add(this.tbxMailHeader);
            this.Controls.Add(this.lblSendMail);
            this.Controls.Add(this.lblMailHeader);
            this.Controls.Add(this.lblLoanedBookMail);
            this.Name = "MailToMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanedBookMail;
        private System.Windows.Forms.Label lblMailHeader;
        private System.Windows.Forms.Label lblSendMail;
        private System.Windows.Forms.TextBox tbxSendMail;
        private System.Windows.Forms.TextBox tbxMailHeader;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSendEmail;
    }
}