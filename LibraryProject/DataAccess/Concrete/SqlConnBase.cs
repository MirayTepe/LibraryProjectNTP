using LibraryProject.DataAccess.Abstract;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;

namespace LibraryProject.DataAccess
{
    public class SqlConnBase:ISqlConnBase
    {
     
       
        public SqlConnection sqlConnect()
        {
          SqlConnection sqlConnection=new SqlConnection(@"Data Source = (localdb)\mssqllocaldb; Initial Catalog = DbLibrary; Integrated Security = True");
                
            sqlConnection.Open();  
            
 
            return sqlConnection;   
        }
        
    }
 }
