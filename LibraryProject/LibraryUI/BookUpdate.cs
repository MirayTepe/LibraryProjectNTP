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
    public partial class BookUpdate : Form
    {
        public BookUpdate()
        {
            InitializeComponent();
            DgwSet();
        }
        private void DgwSet()
        {
            BookDal bookDal = new BookDal();
            dgwBookList.DataSource = bookDal.GetAll();
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
                comboBoxCategory.Items.Add(sqlDataReader["CategoryName"].ToString());
            }
            sqlConnBase.sqlConnect().Close();
  

        }

        private void BookUpdate_Load(object sender, EventArgs e)
        {
            ComboBoxSet();
        }



        private void dgwBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBookId.Text = dgwBookList.CurrentRow.Cells[0].Value.ToString();
            comboBoxCategory.Text = dgwBookList.CurrentRow.Cells[8].Value.ToString() ;
            tbxBookName.Text = dgwBookList.CurrentRow.Cells[1].Value.ToString();
            tbxBookAuthor.Text = dgwBookList.CurrentRow.Cells[2].Value.ToString();
            tbxNumberOfPage.Text = dgwBookList.CurrentRow.Cells[3].Value.ToString();
            tbxBookLanguage.Text = dgwBookList.CurrentRow.Cells[4].Value.ToString();
            tbxBookPublisher.Text = dgwBookList.CurrentRow.Cells[5].Value.ToString();
            tbxBookDescription.Text = dgwBookList.CurrentRow.Cells[6].Value.ToString();
    
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Categories categories= new Categories();
            categories.Show();
        }

        private void btnBookUpdate_Click_1(object sender, EventArgs e)
        {

            BookDal bookDal = new BookDal();
            
                bookDal.Update(new Book() { BookId = Convert.ToInt32(tbxBookId.Text), CategoryId = Convert.ToInt32(comboBoxCategory.Text), BookName = tbxBookName.Text, BookAuthor = tbxBookAuthor.Text, BookNumberOfPage = tbxNumberOfPage.Text, BookLanguage = tbxBookLanguage.Text, BookPublisher = tbxBookPublisher.Text, BookDescription = tbxBookDescription.Text });
                MessageBox.Show("Kitap bilgileri güncellendi");
                DgwSet();
        

        }

        private void tbxBookName_TextChanged(object sender, EventArgs e)
        {
           
        }

       

        private void tbxSearchByBookName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId  where Books.BookName like'" + tbxSearchByBookName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwBookList.DataSource = table;

            conn.sqlConnect().Close();
        }
    }
}
