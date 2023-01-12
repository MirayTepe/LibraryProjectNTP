namespace LibraryProject.LibraryUI
{
    partial class PunishmentProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PunishmentProcess));
            this.tbxLoanedBookId = new System.Windows.Forms.TextBox();
            this.lblLoanedBookId = new System.Windows.Forms.Label();
            this.dtpBookRetrieveOfDate = new System.Windows.Forms.DateTimePicker();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPunishmentProcess = new System.Windows.Forms.Label();
            this.btnLoanedBookPunishmentProcess = new System.Windows.Forms.Button();
            lblBookRetrieveOfDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBookRetrieveOfDate
            // 
            resources.ApplyResources(lblBookRetrieveOfDate, "lblBookRetrieveOfDate");
            lblBookRetrieveOfDate.BackColor = System.Drawing.Color.White;
            lblBookRetrieveOfDate.ForeColor = System.Drawing.Color.Black;
            lblBookRetrieveOfDate.Name = "lblBookRetrieveOfDate";
            // 
            // tbxLoanedBookId
            // 
            this.tbxLoanedBookId.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tbxLoanedBookId, "tbxLoanedBookId");
            this.tbxLoanedBookId.ForeColor = System.Drawing.Color.Black;
            this.tbxLoanedBookId.Name = "tbxLoanedBookId";
            this.tbxLoanedBookId.TextChanged += new System.EventHandler(this.tbxLoanedBookId_TextChanged);
            // 
            // lblLoanedBookId
            // 
            resources.ApplyResources(this.lblLoanedBookId, "lblLoanedBookId");
            this.lblLoanedBookId.BackColor = System.Drawing.Color.White;
            this.lblLoanedBookId.ForeColor = System.Drawing.Color.Black;
            this.lblLoanedBookId.Name = "lblLoanedBookId";
            // 
            // dtpBookRetrieveOfDate
            // 
            resources.ApplyResources(this.dtpBookRetrieveOfDate, "dtpBookRetrieveOfDate");
            this.dtpBookRetrieveOfDate.Name = "dtpBookRetrieveOfDate";
            this.dtpBookRetrieveOfDate.ValueChanged += new System.EventHandler(this.dtpBookRetrieveOfDate_ValueChanged);
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // lblPunishmentProcess
            // 
            resources.ApplyResources(this.lblPunishmentProcess, "lblPunishmentProcess");
            this.lblPunishmentProcess.Name = "lblPunishmentProcess";
            // 
            // btnLoanedBookPunishmentProcess
            // 
            resources.ApplyResources(this.btnLoanedBookPunishmentProcess, "btnLoanedBookPunishmentProcess");
            this.btnLoanedBookPunishmentProcess.Name = "btnLoanedBookPunishmentProcess";
            this.btnLoanedBookPunishmentProcess.UseVisualStyleBackColor = true;
            this.btnLoanedBookPunishmentProcess.Click += new System.EventHandler(this.btnLoanedBookPunishmentProcess_Click);
            // 
            // PunishmentProcess
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLoanedBookPunishmentProcess);
            this.Controls.Add(this.lblPunishmentProcess);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(lblBookRetrieveOfDate);
            this.Controls.Add(this.dtpBookRetrieveOfDate);
            this.Controls.Add(this.tbxLoanedBookId);
            this.Controls.Add(this.lblLoanedBookId);
            this.Name = "PunishmentProcess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLoanedBookId;
        private System.Windows.Forms.Label lblLoanedBookId;
        private System.Windows.Forms.DateTimePicker dtpBookRetrieveOfDate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPunishmentProcess;
        private System.Windows.Forms.Button btnLoanedBookPunishmentProcess;
    }
}