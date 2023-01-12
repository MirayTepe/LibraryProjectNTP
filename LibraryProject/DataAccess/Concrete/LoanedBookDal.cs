using Entities.Concrete;
using LibraryProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Concrete
{
    public class LoanedBookDal : ILoanedBookDal
    {
        SqlConnBase conn = new SqlConnBase();
        public void Add(LoanedBook loanedBook)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Insert into LoanedBooks (MemberId,BookId,CategoryId,BookLendingOfDate,BookRetrieveOfDate,LoanedBookDelivery) values ('{loanedBook.MemberId}','{loanedBook.BookId}','{loanedBook.CategoryId}','{loanedBook.BookLendingOfDate}','{loanedBook.BookRetrieveOfDate}','{loanedBook.LoanedBookDelivery}')", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }

        public void Delete(LoanedBook loanedBook)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Delete from LoanedBooks where LoanedBookId={loanedBook.LoanedBookId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
       


        public List<LoanedBook> GetAll()
        {


            SqlCommand command = new SqlCommand("Select l.LoanedBookId,l.MemberId,l.BookId,c.CategoryId,c.CategoryName,b.BookName,b.BookAuthor,b.BookNumberOfPage,b.BookLanguage,b.BookPublisher,b.BookDescription,l.BookLendingOfDate,l.BookRetrieveOfDate,l.LoanedBookDelivery from LoanedBooks As l Inner Join Members As m ON l.MemberId=m.MemberId Inner Join Books As b ON  l.BookId=b.BookId Inner Join Categories As c ON  l.CategoryId=c.CategoryId ", conn.sqlConnect());
            List<LoanedBook> loanedBooks = new List<LoanedBook>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                LoanedBook loanedBook = new LoanedBook();
                loanedBook.LoanedBookId = Convert.ToInt32(reader["LoanedBookId"]);
                loanedBook.MemberId = Convert.ToInt32(reader["MemberId"]);
                loanedBook.BookId = Convert.ToInt32(reader["BookId"]);
                loanedBook.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                loanedBook.BookLendingOfDate = Convert.ToString(reader["BookLendingOfDate"]);
                loanedBook.BookRetrieveOfDate = Convert.ToString(reader["BookRetrieveOfDate"]);
               
                loanedBook.LoanedBookDelivery = Convert.ToString(reader["LoanedBookDelivery"]);

                loanedBook.CategoryName = Convert.ToString(reader["CategoryName"]);
                loanedBook.BookName = Convert.ToString(reader["BookName"]);
                loanedBook.BookAuthor = Convert.ToString(reader["BookAuthor"]);
                loanedBook.BookNumberOfPage = Convert.ToString(reader["BookNumberOfPage"]);
                loanedBook.BookLanguage = Convert.ToString(reader["BookLanguage"]);
                loanedBook.BookPublisher = Convert.ToString(reader["BookPublisher"]);
                loanedBook.BookDescription = Convert.ToString(reader["BookDescription"]);
                loanedBooks.Add(loanedBook);
            }
            conn.sqlConnect().Close();
            return loanedBooks;
        }


        public void SendMail(string mailHeader, string mailBody,string email)
        {
         
           

            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("admntp748@gmail.com", "oxwdmwpjdwexccsl");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            message.To.Add(email);
            message.From = new MailAddress("admntp748@gmail.com");
            message.Subject =mailHeader;
            message.Body = mailBody;
            client.Send(message);
        }



        public void Update(LoanedBook loanedBook)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Update LoanedBooks set  MemberId='{loanedBook.MemberId}',BookId='{loanedBook.BookId}',BookLendingOfDate='{loanedBook.BookLendingOfDate}',BookRetrieveOfDate='{loanedBook.BookRetrieveOfDate}',LoanedBookDelivery='{loanedBook.LoanedBookDelivery}' where LoanedBookId={loanedBook.LoanedBookId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
    

        public List<LoanedBook> UndeliveredBooks()
        {


            SqlCommand command = new SqlCommand("Select l.LoanedBookId,l.MemberId,l.BookId,c.CategoryId,c.CategoryName,b.BookName,b.BookAuthor,b.BookNumberOfPage,b.BookLanguage,b.BookPublisher,b.BookDescription,b.IsLoanedBook,l.BookLendingOfDate,l.BookRetrieveOfDate,l.LoanedBookDelivery from LoanedBooks As l Inner Join Members As m ON l.MemberId=m.MemberId Inner Join Books As b ON  l.BookId=b.BookId Inner Join Categories As c ON  l.CategoryId=c.CategoryId Where l.LoanedBookDelivery='Teslim Edilmedi'  ", conn.sqlConnect());
            List<LoanedBook> loanedBooks = new List<LoanedBook>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                LoanedBook loanedBook = new LoanedBook();
                loanedBook.LoanedBookId = Convert.ToInt32(reader["LoanedBookId"]);
                loanedBook.MemberId = Convert.ToInt32(reader["MemberId"]);
                loanedBook.BookId = Convert.ToInt32(reader["BookId"]);
                loanedBook.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                loanedBook.BookLendingOfDate = Convert.ToString(reader["BookLendingOfDate"]);
                loanedBook.BookRetrieveOfDate = Convert.ToString(reader["BookRetrieveOfDate"]);
                
                loanedBook.LoanedBookDelivery = Convert.ToString(reader["LoanedBookDelivery"]);
                loanedBook.IsLoanedBook = Convert.ToString(reader["IsLoanedBook"]);
                loanedBook.CategoryName = Convert.ToString(reader["CategoryName"]);
                loanedBook.BookName = Convert.ToString(reader["BookName"]);
                loanedBook.BookAuthor = Convert.ToString(reader["BookAuthor"]);
                loanedBook.BookNumberOfPage = Convert.ToString(reader["BookNumberOfPage"]);
                loanedBook.BookLanguage = Convert.ToString(reader["BookLanguage"]);
                loanedBook.BookPublisher = Convert.ToString(reader["BookPublisher"]);
                loanedBook.BookDescription = Convert.ToString(reader["BookDescription"]);
                loanedBooks.Add(loanedBook);
            }
            conn.sqlConnect().Close();
            return loanedBooks;
        }

    }
}
