using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Abstract
{
    public interface IBookDal
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);

        List<Book> GetAll();
        List<Book> GetAllNonBorrowedBooks();

        void UpdateIsLoaned(Book book);


    }
}
