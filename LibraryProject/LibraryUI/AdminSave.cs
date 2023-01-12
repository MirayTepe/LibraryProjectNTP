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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LibraryProject.LibraryUI
{
    public partial class AdminSave : Form
    {


        public AdminSave()
        {
            InitializeComponent();
            DgwSet();
        }
        public void DgwSet()
        {

            UserDal userDal = new UserDal();
            dgwUserList.DataSource = userDal.GetAll();

        }
      

     

        private void groupBoxUserSave_Enter(object sender, EventArgs e)
        {

        }



        private void lblPassword_Click(object sender, EventArgs e)
        {

        }



        private void btnAdminSave_Click(object sender, EventArgs e)
        {
            AdminDal adminDal = new AdminDal();
            UserDal userDal = new UserDal();
            try
            {
                adminDal.Add(new Admin() { UserId = Convert.ToInt32(tbxUserIdAdmin.Text), AdminUserName = tbxAdminUserName.Text, Password = tbxPassword.Text });
                userDal.UpdateActive(new User() { UserId = Convert.ToInt32(tbxUserIdAdmin.Text), Active="Aktif"});
                MessageBox.Show("Admin Eklendi");
                DgwSet();

            }
            catch (Exception ex)
            {
               

                MessageBox.Show("Admin Eklenemedi");
            }
            foreach (Control item in groupBoxAdmin.Controls) if (item is TextBox) item.Text = "";


        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            try
            {

                userDal.Add(new Admin() { FirstName = tbxFirstName.Text, LastName = tbxLastName.Text, Email = tbxEmail.Text, Active ="Aktif Değil" });

                 MessageBox.Show("Kullanıcı Eklendi");
   
               
                DgwSet();

            }
            catch (Exception exception)
            {
                bool result = userDal.CheckUserForMail(tbxEmail.Text);
                if (result == false)
                {
                    MessageBox.Show("Kullanıcı eklenemedi.");

                    MessageBox.Show("Bu email kullanılıyor farklı bir email adrasi girin");
                }
                else
                {
                    MessageBox.Show("Kullanıcı eklenemedi.Hata Var !");
                }

                

            }
            foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";

        }

        private void dgwUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUserId.Text = dgwUserList.CurrentRow.Cells[0].Value.ToString();
            tbxUserIdAdmin.Text = dgwUserList.CurrentRow.Cells[0].Value.ToString();
            tbxFirstName.Text = dgwUserList.CurrentRow.Cells[1].Value.ToString();
            tbxLastName.Text = dgwUserList.CurrentRow.Cells[2].Value.ToString();
            tbxEmail.Text = dgwUserList.CurrentRow.Cells[3].Value.ToString();
        
        }

        private void dgwUserList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            try
            {
                userDal.Update(new User() { UserId = Convert.ToInt32(tbxUserId.Text), FirstName = tbxFirstName.Text, LastName = tbxLastName.Text, Email = tbxEmail.Text });
                MessageBox.Show("Kullanıcı Güncellendi.");

            }
            catch (Exception exeption)
            {

                MessageBox.Show("Kullanıcı Güncellenemedi.");
            }
            DgwSet();
            foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";

        }

        private void AdminSave_Load(object sender, EventArgs e)
        {
            

        }

        private void dgwUserList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgwUserList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }

        private void groupBoxAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            DialogResult dialogResult;
            try
            {
               
               dialogResult= MessageBox.Show("Kullanıcı silinecek,Eğer Aktifse Silmemelisiniz. ","Dikkat!",MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    userDal.Delete(new User() { UserId = Convert.ToInt32(tbxUserId.Text) });
                   
                    MessageBox.Show("Kullanıcı Silindi");
                       DgwSet();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }

                
            }catch(Exception ex) {

                MessageBox.Show("Kullanıcı silinemedi");
            }
              


                foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";

            
        }

        private void tbxSearchByFirstName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select*from Users where FirstName like'" + tbxSearchByFirstName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwUserList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxSearchByLastName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select*from Users where LastName like'" + tbxSearchByLastName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwUserList.DataSource = table;

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";
        }
    }
}
