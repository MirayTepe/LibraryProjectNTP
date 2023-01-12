using Entities.Concrete;
using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
            DgwSet();
        }

        private void lblBookDescriptiom_Click(object sender, EventArgs e)
        {

        }
        private void DgwSet()
        {
            BookDal bookDal= new BookDal();
            dgwBookList.DataSource = bookDal.GetAll();
         
        }
        private void ComboBoxSet()
        {
            SqlConnBase sqlConnBase = new SqlConnBase();
            SqlCommand command = new SqlCommand();
            command.Connection= sqlConnBase.sqlConnect();

            comboBoxCategory.Items.Clear();
            SqlDataReader sqlDataReader;
            command.CommandText="select*from Categories";
            sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {

                comboBoxCategory.Items.Add(sqlDataReader["CategoryId"].ToString() + "-" + sqlDataReader["CategoryName"].ToString());
            }
            sqlConnBase.sqlConnect().Close();
        

        }

        private void BookAdd_Load(object sender, EventArgs e)
        {
            ComboBoxSet();


        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookDal bookDal= new BookDal();
            try
            {

                bookDal.Add(new Book() { CategoryId = Convert.ToInt32(comboBoxCategory.SelectedIndex+1), BookName = tbxBookName.Text.ToString(), BookAuthor = tbxBookAuthor.Text.ToString(), BookNumberOfPage = tbxNumberOfPage.Text.ToString(), BookLanguage = tbxBookLanguage.Text.ToString(), BookPublisher = tbxBookPublisher.Text.ToString(), BookDescription = tbxBookDescription.Text.ToString(),IsLoanedBook="Emanet Kitap Değil" });
                MessageBox.Show("Kitap eklendi."); 
                DgwSet();

            }
            catch
            { 
                MessageBox.Show("Kitap Eklenemedi");    

            }
           
               
              
          
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgwBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Categories categories= new Categories();
            categories.Show();
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
    }
}
