using Entities.Concrete;
using Entities.DTOs;
using LibraryProject.DataAccess.Abstract;
using LibraryProject.DataAccess.Concrete.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess
{
    public class UserDal:IUserDal
    {
        SqlConnBase conn = new SqlConnBase();
        public List<User> GetAll()
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand("Select * from Users", conn.sqlConnect());
            List<User> users = new List<User>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user= new User();
                user.UserId = Convert.ToInt32(reader["UserId"]);
                user.FirstName = Convert.ToString(reader["FirstName"]);
                user.LastName = Convert.ToString(reader["LastName"]);
                user.Email= Convert.ToString(reader["Email"]);
                user.Active = Convert.ToString(reader["ActiveStatus"]);
                users.Add(user);
            }
            conn.sqlConnect().Close();
            return users;

        }
  
        public void Add(User user)
        {
       
            SqlCommand command=new SqlCommand($"Insert into Users (FirstName,LastName,Email,ActiveStatus) values ('{user.FirstName}','{user.LastName}','{user.Email}','{user.Active}')",conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
        public bool CheckUserForMail (string email)
        {
            List<User> users = GetAll();
           
            foreach (User user in users)
            {
                if (user.Email.Trim() == email)
                {
                  return false ;
                }
            }
           return true ;
        }
        public void Update(User user)
        {
            
            SqlCommand command = new SqlCommand($"Update Users set   FirstName='{user.FirstName}',LastName='{user.LastName}',Email='{user.Email}' where UserId={user.UserId} ",conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
        public void Delete(User user)
        {
          
            SqlCommand command = new SqlCommand($"Delete from Users where UserId={user.UserId} ",conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
        public void UpdateActive(User user)
        {
           
            SqlCommand command = new SqlCommand($"Update Users set ActiveStatus='{user.Active}' where UserId={user.UserId} ", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
    }
}
    

