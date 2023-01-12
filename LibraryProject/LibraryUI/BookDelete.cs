using Entities.Concrete;
using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Abstract;
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
    public partial class BookDelete : Form
    {
        public BookDelete()
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
                comboBoxCategory.Items.Add(sqlDataReader["CategoryId"]+"-"+ sqlDataReader["CategoryName"].ToString());
            }
            sqlConnBase.sqlConnect().Close();
       
        }
        private void btnBookDelete_Click(object sender, EventArgs e)
        {
          
            BookDal bookDal=new BookDal();
             DialogResult dResult;
            dResult=  MessageBox.Show("Kitabı Silmek İstediğinize emin misiniz?","Dikkat!",MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                bookDal.Delete(new Book() { BookId = Convert.ToInt32(tbxBookId.Text) });
                MessageBox.Show("Kitap Silindi");   
                DgwSet();
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
         
        }

        private void BookDelete_Load(object sender, EventArgs e)
        {
            ComboBoxSet();
        
        }

        private void dgwBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBookId.Text = dgwBookList.CurrentRow.Cells[0].Value.ToString();
            comboBoxCategory.Text = dgwBookList.CurrentRow.Cells[8].Value.ToString()+"-"+dgwBookList.CurrentRow.Cells[9].Value.ToString();
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
