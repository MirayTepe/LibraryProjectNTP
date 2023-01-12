using System;

namespace LibraryProject.LibraryUI
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.btnUserProcess = new System.Windows.Forms.Button();
            this.pnlAdminMenu = new System.Windows.Forms.Panel();
            this.pnlLoanedBookSubMenu = new System.Windows.Forms.Panel();
            this.btnLoanedBookList = new System.Windows.Forms.Button();
            this.btnLoanedBookAdd = new System.Windows.Forms.Button();
            this.btnDeleteLoanedBook = new System.Windows.Forms.Button();
            this.pnlBookSubMenu = new System.Windows.Forms.Panel();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnListBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.pnlUserProcessSubMenu = new System.Windows.Forms.Panel();
            this.pnlMemberSubMenu = new System.Windows.Forms.Panel();
            this.btnListMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.pnlSubMenuAdmin = new System.Windows.Forms.Panel();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.btnListAdmin = new System.Windows.Forms.Button();
            this.btnLoanedBooks = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.panelDestopPane = new System.Windows.Forms.Panel();
            this.pnlAdminMenu.SuspendLayout();
            this.pnlLoanedBookSubMenu.SuspendLayout();
            this.pnlBookSubMenu.SuspendLayout();
            this.pnlUserProcessSubMenu.SuspendLayout();
            this.pnlMemberSubMenu.SuspendLayout();
            this.pnlSubMenuAdmin.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserProcess
            // 
            this.btnUserProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnUserProcess, "btnUserProcess");
            this.btnUserProcess.ForeColor = System.Drawing.Color.White;
            this.btnUserProcess.Name = "btnUserProcess";
            this.btnUserProcess.UseVisualStyleBackColor = false;
            this.btnUserProcess.Click += new System.EventHandler(this.btnUserProcess_Click);
            // 
            // pnlAdminMenu
            // 
            resources.ApplyResources(this.pnlAdminMenu, "pnlAdminMenu");
            this.pnlAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlAdminMenu.Controls.Add(this.pnlLoanedBookSubMenu);
            this.pnlAdminMenu.Controls.Add(this.pnlBookSubMenu);
            this.pnlAdminMenu.Controls.Add(this.pnlUserProcessSubMenu);
            this.pnlAdminMenu.Controls.Add(this.btnUserProcess);
            this.pnlAdminMenu.Controls.Add(this.btnLoanedBooks);
            this.pnlAdminMenu.Controls.Add(this.btnBooks);
            this.pnlAdminMenu.Name = "pnlAdminMenu";
            this.pnlAdminMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminMenu_Paint);
            // 
            // pnlLoanedBookSubMenu
            // 
            this.pnlLoanedBookSubMenu.Controls.Add(this.btnLoanedBookList);
            this.pnlLoanedBookSubMenu.Controls.Add(this.btnLoanedBookAdd);
            this.pnlLoanedBookSubMenu.Controls.Add(this.btnDeleteLoanedBook);
            resources.ApplyResources(this.pnlLoanedBookSubMenu, "pnlLoanedBookSubMenu");
            this.pnlLoanedBookSubMenu.Name = "pnlLoanedBookSubMenu";
            // 
            // btnLoanedBookList
            // 
            this.btnLoanedBookList.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnLoanedBookList, "btnLoanedBookList");
            this.btnLoanedBookList.ForeColor = System.Drawing.Color.White;
            this.btnLoanedBookList.Name = "btnLoanedBookList";
            this.btnLoanedBookList.UseVisualStyleBackColor = false;
            this.btnLoanedBookList.Click += new System.EventHandler(this.btnLoanedBookList_Click);
            // 
            // btnLoanedBookAdd
            // 
            this.btnLoanedBookAdd.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnLoanedBookAdd, "btnLoanedBookAdd");
            this.btnLoanedBookAdd.ForeColor = System.Drawing.Color.White;
            this.btnLoanedBookAdd.Name = "btnLoanedBookAdd";
            this.btnLoanedBookAdd.UseVisualStyleBackColor = false;
            this.btnLoanedBookAdd.Click += new System.EventHandler(this.btnLoanedBookAdd_Click);
            // 
            // btnDeleteLoanedBook
            // 
            this.btnDeleteLoanedBook.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnDeleteLoanedBook, "btnDeleteLoanedBook");
            this.btnDeleteLoanedBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLoanedBook.Name = "btnDeleteLoanedBook";
            this.btnDeleteLoanedBook.UseVisualStyleBackColor = false;
            this.btnDeleteLoanedBook.Click += new System.EventHandler(this.btnDeleteLoanedBook_Click);
            // 
            // pnlBookSubMenu
            // 
            this.pnlBookSubMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlBookSubMenu.Controls.Add(this.btnDeleteBook);
            this.pnlBookSubMenu.Controls.Add(this.btnListBook);
            this.pnlBookSubMenu.Controls.Add(this.btnUpdateBook);
            this.pnlBookSubMenu.Controls.Add(this.btnAddBook);
            resources.ApplyResources(this.pnlBookSubMenu, "pnlBookSubMenu");
            this.pnlBookSubMenu.Name = "pnlBookSubMenu";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnDeleteBook, "btnDeleteBook");
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnListBook
            // 
            this.btnListBook.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnListBook, "btnListBook");
            this.btnListBook.ForeColor = System.Drawing.Color.White;
            this.btnListBook.Name = "btnListBook";
            this.btnListBook.UseVisualStyleBackColor = false;
            this.btnListBook.Click += new System.EventHandler(this.btnListBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnUpdateBook, "btnUpdateBook");
            this.btnUpdateBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnAddBook, "btnAddBook");
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // pnlUserProcessSubMenu
            // 
            this.pnlUserProcessSubMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlUserProcessSubMenu.Controls.Add(this.pnlMemberSubMenu);
            this.pnlUserProcessSubMenu.Controls.Add(this.pnlSubMenuAdmin);
            resources.ApplyResources(this.pnlUserProcessSubMenu, "pnlUserProcessSubMenu");
            this.pnlUserProcessSubMenu.Name = "pnlUserProcessSubMenu";
            this.pnlUserProcessSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUserProcessSubMenu_Paint);
            // 
            // pnlMemberSubMenu
            // 
            this.pnlMemberSubMenu.Controls.Add(this.btnListMember);
            this.pnlMemberSubMenu.Controls.Add(this.btnUpdateMember);
            this.pnlMemberSubMenu.Controls.Add(this.btnDeleteMember);
            this.pnlMemberSubMenu.Controls.Add(this.btnAddMember);
            resources.ApplyResources(this.pnlMemberSubMenu, "pnlMemberSubMenu");
            this.pnlMemberSubMenu.Name = "pnlMemberSubMenu";
            // 
            // btnListMember
            // 
            this.btnListMember.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnListMember, "btnListMember");
            this.btnListMember.ForeColor = System.Drawing.Color.White;
            this.btnListMember.Name = "btnListMember";
            this.btnListMember.UseVisualStyleBackColor = false;
            this.btnListMember.Click += new System.EventHandler(this.btnListMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnUpdateMember, "btnUpdateMember");
            this.btnUpdateMember.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnDeleteMember, "btnDeleteMember");
            this.btnDeleteMember.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnAddMember, "btnAddMember");
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // pnlSubMenuAdmin
            // 
            this.pnlSubMenuAdmin.Controls.Add(this.btnAddAdmin);
            this.pnlSubMenuAdmin.Controls.Add(this.btnUpdateAdmin);
            this.pnlSubMenuAdmin.Controls.Add(this.btnDeleteAdmin);
            this.pnlSubMenuAdmin.Controls.Add(this.btnListAdmin);
            resources.ApplyResources(this.pnlSubMenuAdmin, "pnlSubMenuAdmin");
            this.pnlSubMenuAdmin.Name = "pnlSubMenuAdmin";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnAddAdmin, "btnAddAdmin");
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnUpdateAdmin, "btnUpdateAdmin");
            this.btnUpdateAdmin.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnDeleteAdmin, "btnDeleteAdmin");
            this.btnDeleteAdmin.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.UseVisualStyleBackColor = false;
            this.btnDeleteAdmin.Click += new System.EventHandler(this.btnDeleteAdmin_Click);
            // 
            // btnListAdmin
            // 
            this.btnListAdmin.BackColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.btnListAdmin, "btnListAdmin");
            this.btnListAdmin.ForeColor = System.Drawing.Color.White;
            this.btnListAdmin.Name = "btnListAdmin";
            this.btnListAdmin.UseVisualStyleBackColor = false;
            this.btnListAdmin.Click += new System.EventHandler(this.btnListAdmin_Click);
            // 
            // btnLoanedBooks
            // 
            this.btnLoanedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnLoanedBooks, "btnLoanedBooks");
            this.btnLoanedBooks.ForeColor = System.Drawing.Color.White;
            this.btnLoanedBooks.Name = "btnLoanedBooks";
            this.btnLoanedBooks.UseVisualStyleBackColor = false;
            this.btnLoanedBooks.Click += new System.EventHandler(this.btnLoanedBooks_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnBooks, "btnBooks");
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlTitleBar.Controls.Add(this.lblHome);
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.ForeColor = System.Drawing.Color.White;
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            // 
            // lblHome
            // 
            resources.ApplyResources(this.lblHome, "lblHome");
            this.lblHome.Name = "lblHome";
            // 
            // panelDestopPane
            // 
            resources.ApplyResources(this.panelDestopPane, "panelDestopPane");
            this.panelDestopPane.BackColor = System.Drawing.Color.White;
            this.panelDestopPane.Name = "panelDestopPane";
            this.panelDestopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDestopPane_Paint);
            // 
            // frmHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.panelDestopPane);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlAdminMenu);
            this.Name = "frmHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.pnlAdminMenu.ResumeLayout(false);
            this.pnlLoanedBookSubMenu.ResumeLayout(false);
            this.pnlBookSubMenu.ResumeLayout(false);
            this.pnlUserProcessSubMenu.ResumeLayout(false);
            this.pnlMemberSubMenu.ResumeLayout(false);
            this.pnlSubMenuAdmin.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

   

        #endregion
        private System.Windows.Forms.Button btnUserProcess;
        private System.Windows.Forms.Panel pnlAdminMenu;
        private System.Windows.Forms.Button btnLoanedBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelDestopPane;
        private System.Windows.Forms.Panel pnlUserProcessSubMenu;
        private System.Windows.Forms.Panel pnlMemberSubMenu;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Panel pnlBookSubMenu;
        private System.Windows.Forms.Button btnListBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Panel pnlLoanedBookSubMenu;
        private System.Windows.Forms.Button btnLoanedBookAdd;
        private System.Windows.Forms.Button btnDeleteLoanedBook;
        private System.Windows.Forms.Button btnListMember;
        private System.Windows.Forms.Panel pnlSubMenuAdmin;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Button btnListAdmin;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnLoanedBookList;
    }
}