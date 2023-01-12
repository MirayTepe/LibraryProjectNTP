﻿using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class RetrieveLoanedBooks : Form
    {
        public RetrieveLoanedBooks()
        {
            InitializeComponent();
            DgwSet();
            dtpBookLendingOfDate.Format = DateTimePickerFormat.Custom;
            dtpBookRetrieveOfDate.Format = DateTimePickerFormat.Custom;

            dtpBookLendingOfDate.CustomFormat = " dd/MMMM/yyyy";

            dtpBookRetrieveOfDate.CustomFormat = " dd/MMMM/yyyy";
        }
        public void DgwSet()
        {
            LoanedBookDal loanedBookDal = new LoanedBookDal();
            dgwLoanedBookList.DataSource = loanedBookDal.UndeliveredBooks();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailToMember mailToMembers=new MailToMember();
            mailToMembers.Show();
        }

        private void btnRetrieveLoanedBook_Click(object sender, EventArgs e)
        {
            RetrieveBookInformations retrieveBookInformations= new RetrieveBookInformations();
            retrieveBookInformations.Show();

        }

        private void btnDgwLoanedBookNew_Click(object sender, EventArgs e)
        {
            DgwSet();
        }

        private void dtpBookLendingOfDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select l.LoanedBookId,l.MemberId,l.BookId,c.CategoryId,c.CategoryName,b.BookName,b.BookAuthor,b.BookNumberOfPage,b.BookLanguage,b.BookPublisher,b.BookDescription,l.BookLendingOfDate,l.BookRetrieveOfDate,l.LoanedBookDelivery from LoanedBooks As l Inner Join Members As m ON l.MemberId=m.MemberId Inner Join Books As b ON  l.BookId=b.BookId Inner Join Categories As c ON  l.CategoryId=c.CategoryId   where l.BookLendingOfDate like '" + dtpBookLendingOfDate.Text.ToString() + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwLoanedBookList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void dtpBookRetrieveOfDate_ValueChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select l.LoanedBookId,l.MemberId,l.BookId,c.CategoryId,c.CategoryName,b.BookName,b.BookAuthor,b.BookNumberOfPage,b.BookLanguage,b.BookPublisher,b.BookDescription,l.BookLendingOfDate,l.BookRetrieveOfDate,l.LoanedBookDelivery from LoanedBooks As l Inner Join Members As m ON l.MemberId=m.MemberId Inner Join Books As b ON  l.BookId=b.BookId Inner Join Categories As c ON  l.CategoryId=c.CategoryId   where l.BookRetrieveOfDate like '" + dtpBookRetrieveOfDate.Text.ToString() + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwLoanedBookList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void btnPunishmentProcess_Click(object sender, EventArgs e)
        {
            PunishmentProcess punishmentProcess= new PunishmentProcess();
            punishmentProcess.Show();
        }

        private void RetrieveLoanedBooks_Load(object sender, EventArgs e)
        {





        }

      
    }
}
