using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
            DgwSetMember();
        }
        public void DgwSetMember()
        {

            MemberDal memberDal = new MemberDal();
            dgwMemberList.DataSource = memberDal.GetAllMembersAndUsers();



        }

        private void tbxMemberId_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Members.MemberId like'" + tbxMemberId.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxUserIdMember_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Users.UserId like'" + tbxUserIdMember.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxMemberNumber_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Members.MemberNumber like'" + tbxMemberNumber.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Members.MemberPhoneNumber like'" + tbxPhoneNumber.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxMemberAdres_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Members.MemberAdress like'" + tbxMemberAdres.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Users.FirstName like'" + tbxFirstName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Users.LastName like'" + tbxLastName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Users.Email like'" + tbxEmail.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }
    }
}
