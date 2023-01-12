using Entities.Concrete;
using Entities.DTOs;
using LibraryProject.DataAccess.Abstract;
using LibraryProject.DataAccess.Concrete.Tools;
using LibraryProject.LibraryUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace LibraryProject.DataAccess
{
    public class AdminDal :IAdminDal
    {
        SqlConnBase conn = new SqlConnBase();
        public List<Admin> GetAll()
        {
        

        SqlCommand command = new SqlCommand("Select * from Admins", conn.sqlConnect());
        List<Admin> admins = new List<Admin>();
        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Admin admin = new Admin();
            admin.AdminId = Convert.ToInt32(reader["AdminId"]);
            admin.UserId = Convert.ToInt32(reader["UserId"]);
           
            admin.AdminUserName = Convert.ToString(reader["AdminUserName"]);
            admin.Password = Convert.ToString(reader["Password"]);
            admins.Add(admin);
        }
        conn.sqlConnect().Close();
        return admins;

        }
  

        public Mail CheckUserForMail(string username, string email)
        {
            List<Admin> admins = GetAllAdminsAndUsers();
            User user=new User();
            foreach (Admin admin in admins)
            {
                if (admin.Email.Trim() == email && admin.AdminUserName.Trim() == username)
                {
                    return new Mail() { Success = true, Password = admin.Password.Trim() };
                }
            }
            return new Mail() { Success = false };
        }
        public bool SendMail(string username, string email)
        {
            Mail bilgi = CheckUserForMail(username, email);
            if (bilgi.Success)
            {



                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("admntp748@gmail.com", "oxwdmwpjdwexccsl");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                message.To.Add(email);
                message.From = new MailAddress("admntp748@gmail.com");
                message.Subject = "Parolanız";
                message.Body = "Parolanız: " + bilgi.Password;
                client.Send(message);


                return true;
            }
            else   
            {
                return false;
            }
        }

        public List<Admin> GetAllAdminsAndUsers()
        {


            SqlCommand command = new SqlCommand("SELECT Admins.AdminId , Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId;", conn.sqlConnect());
            List<Admin> admins = new List<Admin>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Admin admin = new Admin();
       
                admin.AdminId = Convert.ToInt32(reader["AdminId"]);
                admin.UserId = Convert.ToInt32(reader["UserId"]);
                admin.AdminUserName = Convert.ToString(reader["AdminUserName"]);
                admin.Password = Convert.ToString(reader["Password"]);
                admin.FirstName = Convert.ToString(reader["FirstName"]);
                admin.LastName= Convert.ToString(reader["LastName"]);
                admin.Email = Convert.ToString(reader["Email"]);
                admin.Active = Convert.ToString(reader["ActiveStatus"]);
                admins.Add(admin);
            }
            conn.sqlConnect().Close();
            return admins;

        }
        public bool CheckUser(LoginDto loginDto)
        {
        var data = GetAll();
        foreach (var admin in data)
        {
            if (admin.Password.Trim() == loginDto.Password && admin.AdminUserName.Trim() == loginDto.AdminUserName)
            {
                return true;
            }

        }
        return false;
       }
       public void Add(Admin admin)
       {
        conn.sqlConnect();
        SqlCommand command = new SqlCommand($"Insert into Admins (UserId,AdminUserName,Password) values ('{admin.UserId}','{admin.AdminUserName}','{admin.Password}')", conn.sqlConnect());
        command.ExecuteNonQuery();
        conn.sqlConnect().Close();
       }
      public void Update(Admin admin)
      {

        conn.sqlConnect();
        SqlCommand command = new SqlCommand($"Update Admins set   AdminUserName='{admin.AdminUserName}',Password='{admin.Password}' where AdminId={admin.AdminId}", conn.sqlConnect());
        command.ExecuteNonQuery();
        conn.sqlConnect().Close();
      }
      public void Delete(Admin admin)
      {
        conn.sqlConnect();
        SqlCommand command = new SqlCommand($"Delete from Admins where AdminId={admin.AdminId}", conn.sqlConnect());
        command.ExecuteNonQuery();
        conn.sqlConnect().Close();
      }
        

    }

}
