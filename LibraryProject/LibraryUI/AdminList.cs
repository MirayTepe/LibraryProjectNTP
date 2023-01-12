using LibraryProject.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class AdminList : Form
    {
        public AdminList()
        {
            InitializeComponent();
            DgwSetAdmin();
        }
       
        public void DgwSetAdmin()
        {

            AdminDal adminDal = new AdminDal();
            dgwAdminList.DataSource = adminDal.GetAllAdminsAndUsers();



        }

        private void dgwAdminList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminList_Load(object sender, EventArgs e)
        {

        }

        private void tbxAdminId_TextChanged(object sender, EventArgs e)
        {
            DataTable table= new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId, Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where AdminId like'" + tbxAdminId.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();

        }

        private void dgwAdminList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxUserIdAdmin_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId, Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where Admins.UserId like'" + tbxUserIdAdmin.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxAdminUserName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId, Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where Admins.AdminUserName like'" + tbxAdminUserName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId, Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where Users.FirstName like'" + tbxFirstName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId, Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where Users.LastName like'" + tbxLastName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId, Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where Users.Email like'" + tbxEmail.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();
        }
    }
}
