using Entities.Concrete;
using LibraryProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Concrete
{
    public class BookDal : IBookDal
    {
        SqlConnBase conn = new SqlConnBase();
        public void Add(Book book)
        {

            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Insert into Books (CategoryId,BookName,BookAuthor,BookNumberOfPage,BookLanguage,BookPublisher,BookDescription,IsLoanedBook) values ('{book.CategoryId}','{book.BookName}','{book.BookAuthor}','{book.BookNumberOfPage}','{book.BookLanguage}','{book.BookPublisher}','{book.BookDescription}','{book.IsLoanedBook}')", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }

        public void Delete(Book book)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Delete from Books where BookId={book.BookId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }

        public List<Book> GetAll()
        {
            conn.sqlConnect();

            SqlCommand command = new SqlCommand("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId ", conn.sqlConnect());
            List<Book> books = new List<Book>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book();
                Category category = new Category();
                book.BookId = Convert.ToInt32(reader["BookId"]);
                book.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                book.CategoryName = Convert.ToString(reader["CategoryName"]);
                book.BookName = Convert.ToString(reader["BookName"]);
                book.BookAuthor = Convert.ToString(reader["BookAuthor"]);
                book.BookNumberOfPage = Convert.ToString(reader["BookNumberOfPage"]);
                book.BookLanguage = Convert.ToString(reader["BookLanguage"]);
                book.BookPublisher = Convert.ToString(reader["BookPublisher"]);
                book.BookDescription = Convert.ToString(reader["BookDescription"]);
                book.IsLoanedBook = Convert.ToString(reader["IsLoanedBook"]);
                books.Add(book);
            }
            conn.sqlConnect().Close();
            return books;
        }
        public List<Book> GetAllNonBorrowedBooks()
        {
            conn.sqlConnect();

            SqlCommand command = new SqlCommand("Select Books.BookId ,Categories.CategoryId ,Categories.CategoryName ,Books.BookName,Books.BookAuthor,Books.BookNumberOfPage,Books.BookLanguage,Books.BookPublisher,Books.BookDescription,Books.IsLoanedBook from Books Inner join Categories ON Books.CategoryId=Categories.CategoryId where Books.IsLoanedBook='Emanet Kitap Değil' ", conn.sqlConnect());
            List<Book> books = new List<Book>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Book book = new Book();
                Category category = new Category();
                book.BookId = Convert.ToInt32(reader["BookId"]);
                book.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                book.CategoryName = Convert.ToString(reader["CategoryName"]);
                book.BookName = Convert.ToString(reader["BookName"]);
                book.BookAuthor = Convert.ToString(reader["BookAuthor"]);
                book.BookNumberOfPage = Convert.ToString(reader["BookNumberOfPage"]);
                book.BookLanguage = Convert.ToString(reader["BookLanguage"]);
                book.BookPublisher = Convert.ToString(reader["BookPublisher"]);
                book.BookDescription = Convert.ToString(reader["BookDescription"]);
                book.IsLoanedBook = Convert.ToString(reader["IsLoanedBook"]);
                books.Add(book);
            }
            conn.sqlConnect().Close();
            return books;
        }
       


        public void Update(Book book)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Update Books set  CategoryId='{book.CategoryId}',BookName='{book.BookName}',BookAuthor='{book.BookAuthor}',BookNumberOfPage='{book.BookNumberOfPage}',BookLanguage='{book.BookLanguage}',BookPublisher='{book.BookPublisher}',BookDescription='{book.BookDescription}' where BookId={book.BookId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
        public void UpdateIsLoaned(Book book)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Update Books set  IsLoanedBook='{book.IsLoanedBook}' where BookId={book.BookId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }   

    }
}
