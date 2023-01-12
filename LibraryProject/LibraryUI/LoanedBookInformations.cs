using Entities.Concrete;
using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Concrete;
using System;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class LoanedBookInformations : Form
    {
      
        public LoanedBookInformations()
        {
            InitializeComponent();
            ComboBoxSet();
            dtpBookLendingOfDate.Format = DateTimePickerFormat.Custom;
            dtpBookRetrieveOfDate.Format = DateTimePickerFormat.Custom;
          
            dtpBookLendingOfDate.CustomFormat = " dd/MMMM/yyyy";

            dtpBookRetrieveOfDate.CustomFormat = " dd/MMMM/yyyy";
         


        }

        private void ComboBoxSet()
        {


            SqlConnBase sqlConnBase = new SqlConnBase();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnBase.sqlConnect();

            comboBoxCategory.Items.Clear();
            SqlDataReader sqlDataReader;
            command.CommandText = "select*from Categories";
            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {

                comboBoxCategory.Items.Add(sqlDataReader["CategoryId"].ToString() + "-" + sqlDataReader["CategoryName"].ToString());
            }
            sqlConnBase.sqlConnect().Close();
        }

        private void LoanedBookInformations_Load(object sender, EventArgs e)
        {


        }

        private void btnLoanedBookAdd_Click(object sender, EventArgs e)
        {
                LoanedBookDal loanedBookDal = new LoanedBookDal();
               
                GiveLoanedBook giveLoanedBook=new GiveLoanedBook();
                BookDal bookDal= new BookDal();


                loanedBookDal.Add(new LoanedBook() { MemberId = Convert.ToInt32(tbxMemberId.Text), BookId = Convert.ToInt32(tbxBookId.Text), CategoryId =Convert.ToInt32(comboBoxCategory.Text), BookLendingOfDate =dtpBookLendingOfDate.Text.ToString(), BookRetrieveOfDate = dtpBookRetrieveOfDate.Text.ToString(), LoanedBookDelivery = "Teslim edilmedi"});
                bookDal.UpdateIsLoaned(new Book() { BookId = Convert.ToInt32(tbxBookId.Text), IsLoanedBook = "Emanet Kitap " });
                MessageBox.Show("Emanet Kitap Verildi");

     

               giveLoanedBook.DgwSet();
              
               
           

        }

        private void tbxBookId_TextChanged(object sender, EventArgs e)
        {

            SqlConnBase conn = new SqlConnBase();

            SqlCommand command = new SqlCommand("Select*from Books where BookId like'" + tbxBookId.Text + "'", conn.sqlConnect());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tbxBookName.Text = reader["BookName"].ToString();
                comboBoxCategory.Text = reader["CategoryId"].ToString();
                tbxBookAuthor.Text = reader["BookAuthor"].ToString();
                tbxNumberOfPage.Text = reader["BookNumberOfPage"].ToString();
                tbxBookLanguage.Text = reader["BookLanguage"].ToString();
                tbxBookPublisher.Text = reader["BookPublisher"].ToString();
                tbxBookDescription.Text = reader["BookDescription"].ToString();



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

        private void tbxMemberNo_TextChanged(object sender, EventArgs e)
        {
            SqlConnBase conn = new SqlConnBase();

            SqlCommand command = new SqlCommand("Select*from Members where MemberNumber like'" + tbxMemberNo.Text + "'", conn.sqlConnect());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tbxMemberId.Text = reader["MemberId"].ToString();
                tbxPhoneNo.Text = reader["MemberPhoneNumber"].ToString();
                tbxAdress.Text = reader["MemberAdress"].ToString();



            }

            conn.sqlConnect().Close();

        }

        private void btnLoanedBookUpdate_Click(object sender, EventArgs e)
        {
            LoanedBookDal loanedBookDal = new LoanedBookDal();
            loanedBookDal.Update(new LoanedBook() { LoanedBookId = Convert.ToInt32(tbxLoanedBookId.Text), MemberId = Convert.ToInt32(tbxMemberId.Text), BookId = Convert.ToInt32(tbxBookId.Text), BookLendingOfDate =dtpBookLendingOfDate.Text.ToString(),BookRetrieveOfDate=dtpBookRetrieveOfDate.Text.ToString(),LoanedBookDelivery="Teslim Edilmedi"});
            MessageBox.Show(" İşlem Başarılı! Emanet Kitap Kaydı Güncellendi");
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
                dtpBookLendingOfDate.Text = reader["BookLendingOfDate"].ToString();
                dtpBookRetrieveOfDate.Text = reader["BookRetrieveOfDate"].ToString();





            }

            conn.sqlConnect().Close();
        }

        private void dtpBookLendingOfDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBookRetrieveOfDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblBookRetrieveOfDate_Click(object sender, EventArgs e)
        {

        }

        private void lblBookLendingOfDate_Click(object sender, EventArgs e)
        {

        }
    }
}
