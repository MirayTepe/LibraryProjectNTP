using Entities.Concrete;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class MemberUpdate : Form
    {
        public MemberUpdate()
        {
            InitializeComponent();
            DgwSetMember();
        }
        public void DgwSetMember()
        {

            MemberDal memberDal = new MemberDal();
            dgwMemberList.DataSource = memberDal.GetAllMembersAndUsers();



        }

        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            UserDal userDal = new UserDal();
            MemberDal memberDal = new MemberDal();

            try
            { 
                userDal.Update(new User() { UserId = Convert.ToInt32(tbxUserIdMember.Text), FirstName = tbxFirstName.Text, LastName = tbxLastName.Text, Email = tbxEmail.Text});
                memberDal.Update(new Member() { MemberId = Convert.ToInt32(tbxMemberId.Text), UserId = Convert.ToInt32(tbxUserIdMember.Text), MemberNumber = tbxMemberNumber.Text, MemberPhoneNumber = tbxPhoneNo.Text,MemberAdress= tbxMemberAdres.Text });
                MessageBox.Show("Üye bilgileri güncellendi ");

            }
            catch (Exception exception)
            {
                bool result = userDal.CheckUserForMail(tbxEmail.Text);

                if (result == false)
                {
                    MessageBox.Show("Üye güncellenemedi.");
                    MessageBox.Show("Bu email kullanılıyor farklı bir email adrasi girin");
                }
                else
                {
                    MessageBox.Show("Hata ! Üye bilgileri güncellenemedi .");
                }
                
            }
 
            DgwSetMember();
        }

        private void dgwMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMemberId.Text = dgwMemberList.CurrentRow.Cells[0].Value.ToString();
            tbxUserIdMember.Text = dgwMemberList.CurrentRow.Cells[1].Value.ToString();
            tbxMemberNumber.Text = dgwMemberList.CurrentRow.Cells[2].Value.ToString();
            tbxPhoneNo.Text = dgwMemberList.CurrentRow.Cells[3].Value.ToString();
            tbxMemberAdres.Text = dgwMemberList.CurrentRow.Cells[4].Value.ToString();
            tbxFirstName.Text = dgwMemberList.CurrentRow.Cells[5].Value.ToString();
            tbxLastName.Text = dgwMemberList.CurrentRow.Cells[6].Value.ToString();
            tbxEmail.Text = dgwMemberList.CurrentRow.Cells[7].Value.ToString();
      
        }

        private void MemberUpdate_Load(object sender, EventArgs e)
        {
           
        }

        private void tbxSearchByFirstName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Users.FirstName like'" + tbxSearchByFirstName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void tbxSearchByLastName_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlConnBase conn = new SqlConnBase();
            table.Clear();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Members.MemberId, Members.UserId,Members.MemberNumber,Members.MemberPhoneNumber,Members.MemberAdress,Users.FirstName,Users.LastName,Users.Email,Users.ActiveStatus FROM Members INNER JOIN Users ON Members.UserId = Users.UserId where Users.LastName like'" + tbxSearchByLastName.Text + "%'", conn.sqlConnect());
            sqlDataAdapter.Fill(table);
            dgwMemberList.DataSource = table;

            conn.sqlConnect().Close();
        }

        private void mTbxPhoneNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbxMemberNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPhoneNo_TextChanged(object sender, EventArgs e)
        {
            string no = tbxPhoneNo.Text;
            Regex regex = new Regex(@"^(05(\d{9}))$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                tbxPhoneNo.ForeColor = Color.White;
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
