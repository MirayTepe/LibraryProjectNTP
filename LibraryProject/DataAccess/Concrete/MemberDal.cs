using Entities.Concrete;
using LibraryProject.DataAccess.Abstract;
using LibraryProject.DataAccess.Concrete.Tools;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataAccess.Concrete
{
    public class MemberDal : IMemberDal
    {

        SqlConnBase conn=new SqlConnBase();
        public void Add(Member member)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Insert into Members (UserId,MemberNumber,MemberPhoneNumber,MemberAdress) values ('{member.UserId}','{member.MemberNumber}','{member.MemberPhoneNumber}','{member.MemberAdress}')", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }

        public void Delete(Member member)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Delete from Members where MemberId={member.MemberId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
      
     
        public bool CheckUserForPhoneNumber(string phoneNumber)
        {
            List<Member> members = GetAll();

            foreach (Member member in members)
            {
                if (member.MemberPhoneNumber.Trim() == phoneNumber)
                {
                    return false;
                }
            }
            return true;
        }


        public List<Member> GetAll()
        {
            SqlCommand command = new SqlCommand("Select * from Members", conn.sqlConnect());
            List<Member> members = new List<Member>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Member member = new Member();
                member.MemberId = Convert.ToInt32(reader["MembeId"]);
                member.UserId = Convert.ToInt32(reader["UserId"]);
                member.MemberNumber = Convert.ToString(reader["MemberNumber"]);
                member.MemberPhoneNumber = Convert.ToString(reader["MemberPhoneNumber"]);
                member.MemberAdress = Convert.ToString(reader["MemberAdress"]);
                members.Add(member);
            }
            conn.sqlConnect().Close();
            return members;
        }


        public List<Member> GetAllMembersAndUsers()
        {
            SqlCommand command = new SqlCommand("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId; ", conn.sqlConnect());
            List<Member> members = new List<Member>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Member member = new Member();
                member.MemberId = Convert.ToInt32(reader["MemberId"]);
                member.UserId = Convert.ToInt32(reader["UserId"]);
                member.MemberNumber = Convert.ToString(reader["MemberNumber"]);
                member.MemberPhoneNumber = Convert.ToString(reader["MemberPhoneNumber"]);
                member.MemberAdress = Convert.ToString(reader["MemberAdress"]);
                member.FirstName = Convert.ToString(reader["FirstName"]);
                member.LastName= Convert.ToString(reader["LastName"]);
                member.Email= Convert.ToString(reader["Email"]);
                member.Active = Convert.ToString(reader["ActiveStatus"]);

                members.Add(member);
            }
            conn.sqlConnect().Close();
            return members;
        }

        public void Update(Member member)
        {
            conn.sqlConnect();
            SqlCommand command = new SqlCommand($"Update Members set  MemberNumber='{member.MemberNumber}',MemberPhoneNumber='{member.MemberPhoneNumber}',MemberAdress='{member.MemberAdress}'  where MemberId={member.MemberId}", conn.sqlConnect());
            command.ExecuteNonQuery();
            conn.sqlConnect().Close();
        }
    }
}
