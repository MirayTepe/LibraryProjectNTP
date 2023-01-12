
using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
     public class LoanedBook:Book,IEntity
    {
        public int LoanedBookId { get; set; }
        public int MemberId { get; set; }
        public string BookLendingOfDate { get; set; }

        public string BookRetrieveOfDate { get; set; }

        public string LoanedBookDelivery { get; set; }


    }
}
