namespace LibraryProject.LibraryUI
{
    partial class RetrieveBookInformations
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
            System.Windows.Forms.Label lblBookLendingOfDate;
            System.Windows.Forms.Label lblBookDescriptiom;
            System.Windows.Forms.Label lblBookPublisher;
            System.Windows.Forms.Label lblBookRetrieveOfDate;
            this.groupBoxLoanedBook = new System.Windows.Forms.GroupBox();
            this.tbxCategoryId = new System.Windows.Forms.TextBox();
            this.tbxBookRetrieveOfDate = new System.Windows.Forms.TextBox();
            this.tbxBookLendingOfDate = new System.Windows.Forms.TextBox();
            this.tbxLoanedBookId = new System.Windows.Forms.TextBox();
            this.lblLoanedBookId = new System.Windows.Forms.Label();
            this.gruopBoxMemberSave = new System.Windows.Forms.GroupBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblMemberNumber = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.tbxPhoneNo = new System.Windows.Forms.TextBox();
            this.tbxMemberNo = new System.Windows.Forms.TextBox();
            this.tbxMemberId = new System.Windows.Forms.TextBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.tbxBookId = new System.Windows.Forms.TextBox();
            this.tbxBookDescription = new System.Windows.Forms.TextBox();
            this.tbxBookPublisher = new System.Windows.Forms.TextBox();
            this.lblBookLanguage = new System.Windows.Forms.Label();
            this.tbxBookLanguage = new System.Windows.Forms.TextBox();
            this.lblNumberOfPage = new System.Windows.Forms.Label();
            this.tbxNumberOfPage = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tbxBookAuthor = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.btnLoanedBookDelete = new System.Windows.Forms.Button();
            lblBookLendingOfDate = new System.Windows.Forms.Label();
            lblBookDescriptiom = new System.Windows.Forms.Label();
            lblBookPublisher = new System.Windows.Forms.Label();
            lblBookRetrieveOfDate = new System.Windows.Forms.Label();
            this.groupBoxLoanedBook.SuspendLayout();
            this.gruopBoxMemberSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookLendingOfDate
            // 
            lblBookLendingOfDate.AutoSize = true;
            lblBookLendingOfDate.BackColor = System.Drawing.Color.White;
            lblBookLendingOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lblBookLendingOfDate.ForeColor = System.Drawing.Color.Black;
            lblBookLendingOfDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblBookLendingOfDate.Location = new System.Drawing.Point(599, 524);
            lblBookLendingOfDate.Name = "lblBookLendingOfDate";
            lblBookLendingOfDate.Size = new System.Drawing.Size(240, 23);
            lblBookLendingOfDate.TabIndex = 80;
            lblBookLendingOfDate.Text = "Emanet Kitap Verme Tarihi";
            // 
            // lblBookDescriptiom
            // 
            lblBookDescriptiom.AutoSize = true;
            lblBookDescriptiom.BackColor = System.Drawing.Color.White;
            lblBookDescriptiom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lblBookDescriptiom.ForeColor = System.Drawing.Color.Black;
            lblBookDescriptiom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblBookDescriptiom.Location = new System.Drawing.Point(687, 425);
            lblBookDescriptiom.Name = "lblBookDescriptiom";
            lblBookDescriptiom.Size = new System.Drawing.Size(152, 23);
            lblBookDescriptiom.TabIndex = 75;
            lblBookDescriptiom.Text = "Kitap Açıklaması";
            // 
            // lblBookPublisher
            // 
            lblBookPublisher.AutoSize = true;
            lblBookPublisher.BackColor = System.Drawing.Color.White;
            lblBookPublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lblBookPublisher.ForeColor = System.Drawing.Color.Black;
            lblBookPublisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblBookPublisher.Location = new System.Drawing.Point(731, 375);
            lblBookPublisher.Name = "lblBookPublisher";
            lblBookPublisher.Size = new System.Drawing.Size(81, 23);
            lblBookPublisher.TabIndex = 72;
            lblBookPublisher.Text = "Yayınevi";
            // 
            // lblBookRetrieveOfDate
            // 
            lblBookRetrieveOfDate.AutoSize = true;
            lblBookRetrieveOfDate.BackColor = System.Drawing.Color.White;
            lblBookRetrieveOfDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            lblBookRetrieveOfDate.ForeColor = System.Drawing.Color.Black;
            lblBookRetrieveOfDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lblBookRetrieveOfDate.Location = new System.Drawing.Point(567, 573);
            lblBookRetrieveOfDate.Name = "lblBookRetrieveOfDate";
            lblBookRetrieveOfDate.Size = new System.Drawing.Size(272, 23);
            lblBookRetrieveOfDate.TabIndex = 83;
            lblBookRetrieveOfDate.Text = "Emanet Kitap Geri Alma Tarihi";
            // 
            // groupBoxLoanedBook
            // 
            this.groupBoxLoanedBook.BackColor = System.Drawing.Color.White;
            this.groupBoxLoanedBook.Controls.Add(this.tbxCategoryId);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookRetrieveOfDate);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookLendingOfDate);
            this.groupBoxLoanedBook.Controls.Add(lblBookRetrieveOfDate);
            this.groupBoxLoanedBook.Controls.Add(this.tbxLoanedBookId);
            this.groupBoxLoanedBook.Controls.Add(this.lblLoanedBookId);
            this.groupBoxLoanedBook.Controls.Add(this.gruopBoxMemberSave);
            this.groupBoxLoanedBook.Controls.Add(lblBookLendingOfDate);
            this.groupBoxLoanedBook.Controls.Add(this.lblBookId);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookId);
            this.groupBoxLoanedBook.Controls.Add(lblBookDescriptiom);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookDescription);
            this.groupBoxLoanedBook.Controls.Add(lblBookPublisher);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookPublisher);
            this.groupBoxLoanedBook.Controls.Add(this.lblBookLanguage);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookLanguage);
            this.groupBoxLoanedBook.Controls.Add(this.lblNumberOfPage);
            this.groupBoxLoanedBook.Controls.Add(this.tbxNumberOfPage);
            this.groupBoxLoanedBook.Controls.Add(this.lblBookAuthor);
            this.groupBoxLoanedBook.Controls.Add(this.lblBookName);
            this.groupBoxLoanedBook.Controls.Add(this.lblCategoryName);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookAuthor);
            this.groupBoxLoanedBook.Controls.Add(this.tbxBookName);
            this.groupBoxLoanedBook.Controls.Add(this.btnLoanedBookDelete);
            this.groupBoxLoanedBook.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBoxLoanedBook.ForeColor = System.Drawing.Color.Black;
            this.groupBoxLoanedBook.Location = new System.Drawing.Point(68, 39);
            this.groupBoxLoanedBook.Name = "groupBoxLoanedBook";
            this.groupBoxLoanedBook.Size = new System.Drawing.Size(1250, 711);
            this.groupBoxLoanedBook.TabIndex = 61;
            this.groupBoxLoanedBook.TabStop = false;
            this.groupBoxLoanedBook.Text = "Emanet Kitap Bilgileri";
            this.groupBoxLoanedBook.Enter += new System.EventHandler(this.groupBoxLoanedBook_Enter);
            // 
            // tbxCategoryId
            // 
            this.tbxCategoryId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxCategoryId.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxCategoryId.ForeColor = System.Drawing.Color.White;
            this.tbxCategoryId.Location = new System.Drawing.Point(877, 144);
            this.tbxCategoryId.Name = "tbxCategoryId";
            this.tbxCategoryId.Size = new System.Drawing.Size(279, 30);
            this.tbxCategoryId.TabIndex = 86;
            // 
            // tbxBookRetrieveOfDate
            // 
            this.tbxBookRetrieveOfDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookRetrieveOfDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookRetrieveOfDate.ForeColor = System.Drawing.Color.White;
            this.tbxBookRetrieveOfDate.Location = new System.Drawing.Point(885, 565);
            this.tbxBookRetrieveOfDate.Name = "tbxBookRetrieveOfDate";
            this.tbxBookRetrieveOfDate.Size = new System.Drawing.Size(276, 30);
            this.tbxBookRetrieveOfDate.TabIndex = 85;
            // 
            // tbxBookLendingOfDate
            // 
            this.tbxBookLendingOfDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookLendingOfDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookLendingOfDate.ForeColor = System.Drawing.Color.White;
            this.tbxBookLendingOfDate.Location = new System.Drawing.Point(884, 518);
            this.tbxBookLendingOfDate.Name = "tbxBookLendingOfDate";
            this.tbxBookLendingOfDate.Size = new System.Drawing.Size(277, 30);
            this.tbxBookLendingOfDate.TabIndex = 84;
            // 
            // tbxLoanedBookId
            // 
            this.tbxLoanedBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxLoanedBookId.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxLoanedBookId.ForeColor = System.Drawing.Color.White;
            this.tbxLoanedBookId.Location = new System.Drawing.Point(877, 49);
            this.tbxLoanedBookId.Name = "tbxLoanedBookId";
            this.tbxLoanedBookId.Size = new System.Drawing.Size(279, 30);
            this.tbxLoanedBookId.TabIndex = 82;
            this.tbxLoanedBookId.TextChanged += new System.EventHandler(this.tbxLoanedBookId_TextChanged);
            // 
            // lblLoanedBookId
            // 
            this.lblLoanedBookId.AutoSize = true;
            this.lblLoanedBookId.BackColor = System.Drawing.Color.White;
            this.lblLoanedBookId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoanedBookId.ForeColor = System.Drawing.Color.Black;
            this.lblLoanedBookId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLoanedBookId.Location = new System.Drawing.Point(691, 56);
            this.lblLoanedBookId.Name = "lblLoanedBookId";
            this.lblLoanedBookId.Size = new System.Drawing.Size(148, 23);
            this.lblLoanedBookId.TabIndex = 81;
            this.lblLoanedBookId.Text = "Emanet Kitap Id";
            // 
            // gruopBoxMemberSave
            // 
            this.gruopBoxMemberSave.BackColor = System.Drawing.Color.White;
            this.gruopBoxMemberSave.Controls.Add(this.lblAdress);
            this.gruopBoxMemberSave.Controls.Add(this.tbxAdress);
            this.gruopBoxMemberSave.Controls.Add(this.lblPhoneNo);
            this.gruopBoxMemberSave.Controls.Add(this.lblMemberNumber);
            this.gruopBoxMemberSave.Controls.Add(this.lblMemberId);
            this.gruopBoxMemberSave.Controls.Add(this.tbxPhoneNo);
            this.gruopBoxMemberSave.Controls.Add(this.tbxMemberNo);
            this.gruopBoxMemberSave.Controls.Add(this.tbxMemberId);
            this.gruopBoxMemberSave.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gruopBoxMemberSave.Location = new System.Drawing.Point(67, 107);
            this.gruopBoxMemberSave.Name = "gruopBoxMemberSave";
            this.gruopBoxMemberSave.Size = new System.Drawing.Size(524, 224);
            this.gruopBoxMemberSave.TabIndex = 66;
            this.gruopBoxMemberSave.TabStop = false;
            this.gruopBoxMemberSave.Text = "Üye Bilgileri";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.White;
            this.lblAdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblAdress.ForeColor = System.Drawing.Color.Black;
            this.lblAdress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAdress.Location = new System.Drawing.Point(61, 179);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(60, 23);
            this.lblAdress.TabIndex = 16;
            this.lblAdress.Text = "Adres";
            // 
            // tbxAdress
            // 
            this.tbxAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxAdress.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxAdress.ForeColor = System.Drawing.Color.White;
            this.tbxAdress.Location = new System.Drawing.Point(146, 172);
            this.tbxAdress.Multiline = true;
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(303, 30);
            this.tbxAdress.TabIndex = 15;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.BackColor = System.Drawing.Color.White;
            this.lblPhoneNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNo.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneNo.Location = new System.Drawing.Point(38, 128);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(102, 23);
            this.lblPhoneNo.TabIndex = 13;
            this.lblPhoneNo.Text = "Telefon No";
            // 
            // lblMemberNumber
            // 
            this.lblMemberNumber.AutoSize = true;
            this.lblMemberNumber.BackColor = System.Drawing.Color.White;
            this.lblMemberNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.lblMemberNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMemberNumber.Location = new System.Drawing.Point(45, 82);
            this.lblMemberNumber.Name = "lblMemberNumber";
            this.lblMemberNumber.Size = new System.Drawing.Size(73, 23);
            this.lblMemberNumber.TabIndex = 12;
            this.lblMemberNumber.Text = "Üye No";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.BackColor = System.Drawing.Color.White;
            this.lblMemberId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberId.ForeColor = System.Drawing.Color.Black;
            this.lblMemberId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMemberId.Location = new System.Drawing.Point(45, 35);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(66, 23);
            this.lblMemberId.TabIndex = 11;
            this.lblMemberId.Text = "Üye Id";
            // 
            // tbxPhoneNo
            // 
            this.tbxPhoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxPhoneNo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxPhoneNo.ForeColor = System.Drawing.Color.White;
            this.tbxPhoneNo.Location = new System.Drawing.Point(146, 126);
            this.tbxPhoneNo.Name = "tbxPhoneNo";
            this.tbxPhoneNo.Size = new System.Drawing.Size(303, 30);
            this.tbxPhoneNo.TabIndex = 10;
            // 
            // tbxMemberNo
            // 
            this.tbxMemberNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberNo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxMemberNo.ForeColor = System.Drawing.Color.White;
            this.tbxMemberNo.Location = new System.Drawing.Point(146, 80);
            this.tbxMemberNo.Name = "tbxMemberNo";
            this.tbxMemberNo.Size = new System.Drawing.Size(303, 30);
            this.tbxMemberNo.TabIndex = 9;
            // 
            // tbxMemberId
            // 
            this.tbxMemberId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxMemberId.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxMemberId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxMemberId.Location = new System.Drawing.Point(146, 28);
            this.tbxMemberId.Name = "tbxMemberId";
            this.tbxMemberId.Size = new System.Drawing.Size(303, 30);
            this.tbxMemberId.TabIndex = 8;
            this.tbxMemberId.TextChanged += new System.EventHandler(this.tbxMemberId_TextChanged);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.BackColor = System.Drawing.Color.White;
            this.lblBookId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookId.ForeColor = System.Drawing.Color.Black;
            this.lblBookId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBookId.Location = new System.Drawing.Point(741, 107);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(78, 23);
            this.lblBookId.TabIndex = 77;
            this.lblBookId.Text = "Kitap Id";
            // 
            // tbxBookId
            // 
            this.tbxBookId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookId.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookId.ForeColor = System.Drawing.Color.White;
            this.tbxBookId.Location = new System.Drawing.Point(877, 100);
            this.tbxBookId.Name = "tbxBookId";
            this.tbxBookId.Size = new System.Drawing.Size(279, 30);
            this.tbxBookId.TabIndex = 76;
            this.tbxBookId.TextChanged += new System.EventHandler(this.tbxBookId_TextChanged);
            // 
            // tbxBookDescription
            // 
            this.tbxBookDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookDescription.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookDescription.ForeColor = System.Drawing.Color.White;
            this.tbxBookDescription.Location = new System.Drawing.Point(880, 423);
            this.tbxBookDescription.Multiline = true;
            this.tbxBookDescription.Name = "tbxBookDescription";
            this.tbxBookDescription.Size = new System.Drawing.Size(277, 88);
            this.tbxBookDescription.TabIndex = 74;
            // 
            // tbxBookPublisher
            // 
            this.tbxBookPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookPublisher.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookPublisher.ForeColor = System.Drawing.Color.White;
            this.tbxBookPublisher.Location = new System.Drawing.Point(880, 375);
            this.tbxBookPublisher.Name = "tbxBookPublisher";
            this.tbxBookPublisher.Size = new System.Drawing.Size(276, 30);
            this.tbxBookPublisher.TabIndex = 71;
            // 
            // lblBookLanguage
            // 
            this.lblBookLanguage.AutoSize = true;
            this.lblBookLanguage.BackColor = System.Drawing.Color.White;
            this.lblBookLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblBookLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBookLanguage.Location = new System.Drawing.Point(774, 336);
            this.lblBookLanguage.Name = "lblBookLanguage";
            this.lblBookLanguage.Size = new System.Drawing.Size(34, 23);
            this.lblBookLanguage.TabIndex = 70;
            this.lblBookLanguage.Text = "Dil";
            // 
            // tbxBookLanguage
            // 
            this.tbxBookLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookLanguage.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookLanguage.ForeColor = System.Drawing.Color.White;
            this.tbxBookLanguage.Location = new System.Drawing.Point(879, 328);
            this.tbxBookLanguage.Name = "tbxBookLanguage";
            this.tbxBookLanguage.Size = new System.Drawing.Size(277, 30);
            this.tbxBookLanguage.TabIndex = 69;
            // 
            // lblNumberOfPage
            // 
            this.lblNumberOfPage.AutoSize = true;
            this.lblNumberOfPage.BackColor = System.Drawing.Color.White;
            this.lblNumberOfPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfPage.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumberOfPage.Location = new System.Drawing.Point(696, 285);
            this.lblNumberOfPage.Name = "lblNumberOfPage";
            this.lblNumberOfPage.Size = new System.Drawing.Size(112, 23);
            this.lblNumberOfPage.TabIndex = 68;
            this.lblNumberOfPage.Text = "Sayfa Sayısı";
            // 
            // tbxNumberOfPage
            // 
            this.tbxNumberOfPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxNumberOfPage.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxNumberOfPage.ForeColor = System.Drawing.Color.White;
            this.tbxNumberOfPage.Location = new System.Drawing.Point(879, 277);
            this.tbxNumberOfPage.Name = "tbxNumberOfPage";
            this.tbxNumberOfPage.Size = new System.Drawing.Size(277, 30);
            this.tbxNumberOfPage.TabIndex = 67;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.BackColor = System.Drawing.Color.White;
            this.lblBookAuthor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblBookAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBookAuthor.Location = new System.Drawing.Point(749, 240);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(59, 23);
            this.lblBookAuthor.TabIndex = 65;
            this.lblBookAuthor.Text = "Yazar";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.White;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBookName.Location = new System.Drawing.Point(712, 194);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(104, 23);
            this.lblBookName.TabIndex = 64;
            this.lblBookName.Text = "Kitabın Adı";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.White;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryName.ForeColor = System.Drawing.Color.Black;
            this.lblCategoryName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCategoryName.Location = new System.Drawing.Point(728, 151);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(84, 23);
            this.lblCategoryName.TabIndex = 63;
            this.lblCategoryName.Text = "Kategori";
            // 
            // tbxBookAuthor
            // 
            this.tbxBookAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookAuthor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookAuthor.ForeColor = System.Drawing.Color.White;
            this.tbxBookAuthor.Location = new System.Drawing.Point(879, 232);
            this.tbxBookAuthor.Name = "tbxBookAuthor";
            this.tbxBookAuthor.Size = new System.Drawing.Size(277, 30);
            this.tbxBookAuthor.TabIndex = 62;
            // 
            // tbxBookName
            // 
            this.tbxBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbxBookName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tbxBookName.ForeColor = System.Drawing.Color.White;
            this.tbxBookName.Location = new System.Drawing.Point(879, 186);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(277, 30);
            this.tbxBookName.TabIndex = 61;
            // 
            // btnLoanedBookDelete
            // 
            this.btnLoanedBookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanedBookDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoanedBookDelete.Location = new System.Drawing.Point(615, 644);
            this.btnLoanedBookDelete.Name = "btnLoanedBookDelete";
            this.btnLoanedBookDelete.Size = new System.Drawing.Size(487, 41);
            this.btnLoanedBookDelete.TabIndex = 14;
            this.btnLoanedBookDelete.Text = "Emanet Kitap Geri Al";
            this.btnLoanedBookDelete.UseVisualStyleBackColor = true;
            this.btnLoanedBookDelete.Click += new System.EventHandler(this.btnLoanedBookDelete_Click);
            // 
            // RetrieveBookInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1453, 762);
            this.Controls.Add(this.groupBoxLoanedBook);
            this.Name = "RetrieveBookInformations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap Geri Alma";
            this.groupBoxLoanedBook.ResumeLayout(false);
            this.groupBoxLoanedBook.PerformLayout();
            this.gruopBoxMemberSave.ResumeLayout(false);
            this.gruopBoxMemberSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoanedBook;
        private System.Windows.Forms.TextBox tbxLoanedBookId;
        private System.Windows.Forms.Label lblLoanedBookId;
        private System.Windows.Forms.GroupBox gruopBoxMemberSave;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblMemberNumber;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox tbxPhoneNo;
        private System.Windows.Forms.TextBox tbxMemberNo;
        private System.Windows.Forms.TextBox tbxMemberId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox tbxBookId;
        private System.Windows.Forms.TextBox tbxBookDescription;
        private System.Windows.Forms.TextBox tbxBookPublisher;
        private System.Windows.Forms.Label lblBookLanguage;
        private System.Windows.Forms.TextBox tbxBookLanguage;
        private System.Windows.Forms.Label lblNumberOfPage;
        private System.Windows.Forms.TextBox tbxNumberOfPage;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbxBookAuthor;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Button btnLoanedBookDelete;
        private System.Windows.Forms.TextBox tbxBookRetrieveOfDate;
        private System.Windows.Forms.TextBox tbxBookLendingOfDate;
        private System.Windows.Forms.TextBox tbxCategoryId;
    }
}