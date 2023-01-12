using Entities.Concrete;
using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Abstract;
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
    public partial class MemberDelete : Form
    {
        public MemberDelete()
        {
            InitializeComponent();
            DgwSetMember();
        }
        public void DgwSetMember()
        {

           MemberDal memberDal= new MemberDal();
            dgwMemberList.DataSource = memberDal.GetAllMembersAndUsers();



        }
      

        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            MemberDal memberDal = new MemberDal();
            UserDal userDal= new UserDal(); 
            DialogResult dResult;
            dResult = MessageBox.Show("Üye kaydı silinecektir onaylıyor musunuz?", "Dikkat ! ", MessageBoxButtons.YesNo);

            if (dResult == DialogResult.Yes)
            {
                userDal.UpdateActive(new User() { UserId = Convert.ToInt32(tbxUserIdMember.Text), Active = "Aktif Değil"});
                memberDal.Delete(new Member() { MemberId = Convert.ToInt32(tbxMemberId.Text) });
                MessageBox.Show("Kayıt Silindi");
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }

            DgwSetMember();
            foreach (Control item in groupBoxMember.Controls) if (item is TextBox) item.Text = "";

        }

        private void dgwMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMemberId.Text = dgwMemberList.CurrentRow.Cells[0].Value.ToString();
            tbxUserIdMember.Text = dgwMemberList.CurrentRow.Cells[1].Value.ToString(); 
            tbxMemberNumber.Text = dgwMemberList.CurrentRow.Cells[2].Value.ToString(); 
            tbxPhoneNumber.Text = dgwMemberList.CurrentRow.Cells[3].Value.ToString();
            tbxMemberAdres.Text = dgwMemberList.CurrentRow.Cells[4].Value.ToString();
            tbxFirstName.Text = dgwMemberList.CurrentRow.Cells[5].Value.ToString();
            tbxLastName.Text = dgwMemberList.CurrentRow.Cells[6].Value.ToString();
            tbxEmail.Text = dgwMemberList.CurrentRow.Cells[7].Value.ToString();
         

        }

        private void MemberDelete_Load(object sender, EventArgs e)
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
    }
}
