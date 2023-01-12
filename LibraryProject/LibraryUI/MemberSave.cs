using Entities.Concrete;
using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Abstract;
using LibraryProject.DataAccess.Concrete;
using LibraryProject.DataAccess.Concrete.Tools;
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
    public partial class MemberSave : Form
    {
        public MemberSave()
        {
            InitializeComponent();
            DgwSet();
        }
        public void DgwSet()
        {

            UserDal userDal = new UserDal();
            dgwUserList.DataSource = userDal.GetAll();
        }

        private void MemberSave_Load(object sender, EventArgs e)
        {
            
        }
       

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            try
            {
                userDal.Add(new Admin() { FirstName = tbxFirstName.Text, LastName = tbxLastName.Text, Email = tbxEmail.Text,Active="Aktif Değil" });
                MessageBox.Show("Kullanıcı Eklendi");
             

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
                    MessageBox.Show("Kullanıcı eklenemedi.Hata var");
                }

               

            }
            DgwSet();
            foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";
        }

        private void dgwUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {  
            tbxUserIdMember.Text = dgwUserList.CurrentRow.Cells[0].Value.ToString();
            tbxUserId.Text= dgwUserList.CurrentRow.Cells[0].Value.ToString();
            tbxFirstName.Text= dgwUserList.CurrentRow.Cells[1].Value.ToString();
            tbxLastName.Text= dgwUserList.CurrentRow.Cells[2].Value.ToString();
            tbxEmail.Text= dgwUserList.CurrentRow.Cells[3].Value.ToString(); 
           
        }

        private void btnMemberSave_Click(object sender, EventArgs e)
        {
            MemberDal memberDal = new MemberDal();
            UserDal userDal=new UserDal();
            try
            {
                userDal.UpdateActive(new User() { UserId = Convert.ToInt32(tbxUserIdMember.Text), Active = "Aktif" });
                memberDal.Add(new Member() { UserId = Convert.ToInt32(tbxUserIdMember.Text), MemberNumber = tbxMemberNo.Text, MemberPhoneNumber = tbxPhoneNo.Text ,MemberAdress=tbxAdress.Text});
                MessageBox.Show("Üye Eklendi");
                DgwSet();

            }
            catch (Exception ex)
            {
                bool result=memberDal.CheckUserForPhoneNumber(tbxPhoneNo.Text);
                if (result==false)
                { 
                    MessageBox.Show("Üye Eklenemedi");
                    MessageBox.Show("Farklı bir telefon numarası girin");

                }
                else
                {
                    MessageBox.Show("Üye Eklenemedi,Hata Var");
                }
               
            }
            foreach (Control item in gruopBoxMemberSave.Controls) if (item is TextBox) item.Text = "";

        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            try
            {
                userDal.Update(new User() { UserId = Convert.ToInt32(tbxUserId.Text), FirstName = tbxFirstName.Text, LastName = tbxLastName.Text, Email = tbxEmail.Text});
                MessageBox.Show("Kullanıcı Güncellendi.");

            }
            catch (Exception exeption)
            {

                MessageBox.Show("Kullanıcı Güncellenemedi.");
            }
            DgwSet();
            foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            DialogResult dialogResult;
            try
            {

                dialogResult = MessageBox.Show("Kullanıcı silinecek,Eğer Aktifse Silmemelisiniz. ", "Dikkat!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    userDal.Delete(new User() { UserId = Convert.ToInt32(tbxUserId.Text) });
                    MessageBox.Show("Kullanıcı Silindi");
                    DgwSet();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Kullanıcı silinemedi");
            }



            foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {

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

        private void mTbxPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBoxUserSave.Controls) if (item is TextBox) item.Text = "";
        }

        private void tbxPhoneNo_TextChanged(object sender, EventArgs e)
        {
            string no=tbxPhoneNo.Text;
            Regex regex=new Regex(@"^(05(\d{9}))$");
            Match match=regex.Match(no);
            if(match.Success) { 
              tbxPhoneNo.ForeColor= Color.White;
            }
            else
            {
                tbxPhoneNo.ForeColor = Color.Orange;
            }
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
