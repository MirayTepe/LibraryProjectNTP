using Entities.Concrete;
using LibraryProject.DataAccess;
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
    public partial class RetrieveBookInformations : Form
    {
        public RetrieveBookInformations()
        {
            InitializeComponent();
        }

        private void tbxLoanedBookId_TextChanged(object sender, EventArgs e)
        {
            SqlConnBase conn = new SqlConnBase();

            SqlCommand command = new SqlCommand("Select*from LoanedBooks where LoanedBookId like'" + tbxLoanedBookId.Text + "'", conn.sqlConnect());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tbxBookId.Text = reader["BookId"].ToString();
                tbxMemberId.Text = reader["MemberId"].ToString();
                tbxBookLendingOfDate.Text = reader["BookLendingOfDate"].ToString();
                tbxBookRetrieveOfDate.Text = reader["BookRetrieveOfDate"].ToString();





            }

            conn.sqlConnect().Close();

        }

        private void tbxMemberId_TextChanged(object sender, EventArgs e)
        {
            SqlConnBase conn = new SqlConnBase();

            SqlCommand command = new SqlCommand("Select*from Members where MemberId like'" + tbxMemberId.Text + "'", conn.sqlConnect());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tbxMemberNo.Text = reader["MemberNumber"].ToString();
                tbxPhoneNo.Text = reader["MemberPhoneNumber"].ToString();
                tbxAdress.Text = reader["MemberAdress"].ToString();
                



            }

            conn.sqlConnect().Close();
        }

        private void groupBoxLoanedBook_Enter(object sender, EventArgs e)
        {

        }

    

        private void tbxBookId_TextChanged(object sender, EventArgs e)
        {

            SqlConnBase conn = new SqlConnBase();

            SqlCommand command = new SqlCommand("Select*from Books where BookId like'" + tbxBookId.Text + "'", conn.sqlConnect());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tbxBookName.Text = reader["BookName"].ToString();
                tbxCategoryId.Text = reader["CategoryId"].ToString();
                tbxBookAuthor.Text = reader["BookAuthor"].ToString();
                tbxNumberOfPage.Text = reader["BookNumberOfPage"].ToString();
                tbxBookLanguage.Text = reader["BookLanguage"].ToString();
                tbxBookPublisher.Text = reader["BookPublisher"].ToString();
                tbxBookDescription.Text = reader["BookDescription"].ToString();



            }

            conn.sqlConnect().Close();
        }

        private void btnLoanedBookDelete_Click(object sender, EventArgs e)
        {
            BookDal bookDal = new BookDal();
            LoanedBookDal loanedBookDal = new LoanedBookDal();



            loanedBookDal.Delete(new LoanedBook() { LoanedBookId = Convert.ToInt32(tbxLoanedBookId.Text) });
            bookDal.UpdateIsLoaned(new Book() { BookId = Convert.ToInt32(tbxBookId.Text), IsLoanedBook = "Emanet Kitap Değil" });
            MessageBox.Show("Emanet Kitap Geri Alındı");

        }

      
    }
}
