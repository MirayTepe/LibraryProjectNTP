using Entities.Concrete;
using LibraryProject.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class AdminUpdate : Form
    {
        public AdminUpdate()
        {
            InitializeComponent();
            DgwSetAdmin();
        }
        public void DgwSetAdmin()
        {

            AdminDal adminDal = new AdminDal();
            dgwAdminList.DataSource = adminDal.GetAllAdminsAndUsers();



        }
     

        private void btnAdminUpdate_Click(object sender, EventArgs e)
        {
            UserDal userDal= new UserDal(); 
            AdminDal adminDal = new AdminDal();

            try
            {
                userDal.Update(new User() { UserId = Convert.ToInt32(tbxUserIdAdmin.Text), FirstName = tbxFirstName.Text, LastName = tbxLastName.Text, Email = tbxEmail.Text});
                adminDal.Update(new Admin() { AdminId = Convert.ToInt32(tbxAdminId.Text), UserId = Convert.ToInt32(tbxUserIdAdmin.Text), Password = tbxPassword.Text, AdminUserName = tbxAdminUserName.Text });
                MessageBox.Show("Admin bilgileri güncellendi ");

            }
            catch (Exception exception)
            {
                bool result = userDal.CheckUserForMail(tbxEmail.Text);
                if (result == false)
                {
                    MessageBox.Show("Admin bilgileri güncellenemedi.");

                    MessageBox.Show("Bu email kullanılıyor farklı bir email adrasi girin");
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu!Tekrar deneyin.");
                }


               

                
            }
                
           
          
         

            DgwSetAdmin();
        }

        private void dgwAdminList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAdminId.Text = dgwAdminList.CurrentRow.Cells[0].Value.ToString();
            tbxUserIdAdmin.Text = dgwAdminList.CurrentRow.Cells[1].Value.ToString();
            tbxAdminUserName.Text = dgwAdminList.CurrentRow.Cells[2].Value.ToString();
            tbxPassword.Text = dgwAdminList.CurrentRow.Cells[3].Value.ToString();
            tbxFirstName.Text = dgwAdminList.CurrentRow.Cells[4].Value.ToString();
            tbxLastName.Text = dgwAdminList.CurrentRow.Cells[5].Value.ToString();
            tbxEmail.Text= dgwAdminList.CurrentRow.Cells[6].Value.ToString();
          

        }  

        private void tbxActivateStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminUpdate_Load(object sender, EventArgs e)
        {
           
        }

        private void tbxSearchByFirstName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId , Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where Users.FirstName like'" + tbxSearchByFirstName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxSearchByLastName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Admins.AdminId , Admins.UserId,Admins.AdminUserName,Admins.Password,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Admins INNER JOIN Users ON Admins.UserId = Users.UserId where Users.LastName like'" + tbxSearchByLastName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwAdminList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            Regex regex = new Regex(@"^[\w.+\-]+@gmail\.com$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                tbxEmail.ForeColor = Color.White;
            }
            else
            {
                tbxEmail.ForeColor = Color.Orange;
            }
        }
    }
}
