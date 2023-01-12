using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class ConnClass
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\ConnClass\Test.txt");
    }
}
