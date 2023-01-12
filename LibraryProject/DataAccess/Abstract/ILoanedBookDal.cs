using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Abstract
{
    public interface ILoanedBookDal
    {
        void Add(LoanedBook loanedBook);
        void Update(LoanedBook loanedBook);
        void Delete(LoanedBook loanedBook);
        List<LoanedBook> GetAll();
        void SendMail(string mailHeader, string mailBody, string email);
        List<LoanedBook> UndeliveredBooks();


    }
}
