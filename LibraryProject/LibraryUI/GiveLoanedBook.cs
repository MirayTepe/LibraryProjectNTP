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
    public partial class GiveLoanedBook : Form
    {
        public GiveLoanedBook()
        {
            InitializeComponent();
            DgwSet();
        }


        public void DgwSet()
        {
          BookDal bookDal = new BookDal();
            dgwBookList.DataSource = bookDal.GetAllNonBorrowedBooks();
        }
        private void GiveLoanedBook_Load(object sender, EventArgs e)
        {
            DgwSet();
        }
      
        private void dgwLoanedBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void btnGiveLoanedBook_Click(object sender, EventArgs e)
        {  
            LoanedBookInformations loanedBookInformations= new LoanedBookInformations();    
            loanedBookInformations.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgwSet();
        }

        private void dgwLoanedBookList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxBookName_TextChanged(object sender, EventArgs e)
        {
          
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId where Books.IsLoanedBook='Emanet Kitap Değil' and Books.BookName like'" + tbxBookName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();
        }
    }
}
