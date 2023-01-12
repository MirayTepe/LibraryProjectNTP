using Entities.Concrete;
using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Abstract;
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
    public partial class AdminDelete : Form
    {
        public AdminDelete()
        {
            InitializeComponent();
           
            DgwSetAdmin();
        }
     
        public void DgwSetAdmin()
        {
            
            AdminDal adminDal = new AdminDal();
            dgwAdminList.DataSource = adminDal.GetAllAdminsAndUsers();
     
            
         
        }
   

        private void AdminDelete_Load(object sender, EventArgs e)
        {
           
        }

   

        private void dgwAdminList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAdminId.Text = dgwAdminList.CurrentRow.Cells[0].Value.ToString();
            tbxUserIdAdmin.Text = dgwAdminList.CurrentRow.Cells[1].Value.ToString();
            tbxAdminUserName.Text = dgwAdminList.CurrentRow.Cells[2].Value.ToString();
            tbxPassword.Text = dgwAdminList.CurrentRow.Cells[3].Value.ToString();
            tbxFirstName.Text= dgwAdminList.CurrentRow.Cells[4].Value.ToString();
            tbxLastName.Text= dgwAdminList.CurrentRow.Cells[5].Value.ToString();
            tbxEmail.Text= dgwAdminList.CurrentRow.Cells[6].Value.ToString();
          
        }


        
        private void btnAdminDelete_Click(object sender, EventArgs e)
        {
            AdminDal adminDal = new AdminDal();
          
            UserDal userDal= new UserDal();
                
                DialogResult dResult;
                dResult=MessageBox.Show("Admin kaydı silinecektir onaylıyor musunuz?","Dikkat ! ",MessageBoxButtons.YesNo);
                if (dResult == DialogResult.Yes)
                {

                   userDal.UpdateActive(new User() { UserId = Convert.ToInt32(tbxUserIdAdmin.Text), Active = "Aktif Değil" });
                   adminDal.Delete(new Admin() { AdminId = Convert.ToInt32(tbxAdminId.Text) });
                    MessageBox.Show("Kayıt Silindi");
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }

                DgwSetAdmin();
             foreach (Control item in groupBoxAdmin.Controls) if (item is TextBox) item.Text = "";



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
    }
}
