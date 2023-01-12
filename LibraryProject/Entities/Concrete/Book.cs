
using LibraryProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
     public  class Book:Category,IEntity
     {
        public int BookId { get; set; }

        public string BookName { get; set; }    
        
        public string BookAuthor { get; set; }
        public string BookNumberOfPage { get; set; }
        public string BookLanguage { get; set; }

        public string BookPublisher { get; set; }
        public string BookDescription { get; set; }

        public string IsLoanedBook { get; set; }
    

    }
}
