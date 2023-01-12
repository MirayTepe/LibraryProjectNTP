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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
            DgwSet();
        }
        private void DgwSet()
        {
            BookDal bookDal = new BookDal();
            dgwBookList.DataSource = bookDal.GetAll();
        }

        private void dgwBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void tbxCategoryId_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId  where Categories.CategoryName like'" + tbxCategoryName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();

        }

        private void tbxBookId_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId  where Books.BookId like'" + tbxBookId.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();

        }

        private void tbxBookName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId  where Books.BookName like'" + tbxBookName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxBookAuthor_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId  where Books.BookAuthor like'" + tbxBookAuthor.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();
        }

      

        private void tbxBookLanguage_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId  where Books.BookLanguage like'" + tbxBookLanguage.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxBookPublisher_TextChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId  where Books.BookPublisher like'" + tbxBookPublisher.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void lblBookLanguage_Click(object sender, EventArgs e)
        {

        }

        private void lblBookPublisher_Click(object sender, EventArgs e)
        {

        }
    }
}
