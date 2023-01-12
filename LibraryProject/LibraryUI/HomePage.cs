using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class frmHomePage : Form
    {
      

        public frmHomePage()
        {
            InitializeComponent();
            
           
        }

     

       



        private void HomePage_Load(object sender, EventArgs e)
        {
          
        }





        private void btnLoanedBooks_Click(object sender, EventArgs e)
        {
           
        }


        private void btnUserProcess_Click(object sender, EventArgs e)
        {


        }

       

        private void btnBooks_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMemberProcess_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            MemberUpdate memberUpdate = new MemberUpdate();
            memberUpdate.TopLevel = false;
            panelDestopPane.Controls.Add(memberUpdate);
            memberUpdate.Show();
            memberUpdate.Dock = DockStyle.Fill;
            memberUpdate.BringToFront();
            lblHome.Text = "Üye Bilgilerini Güncelle";

        }

        private void pnlUserProcessSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnListAdmin_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            AdminList adminListed = new AdminList();
            adminListed.TopLevel = false;
            panelDestopPane.Controls.Add(adminListed);
            adminListed.Show();
            adminListed.Dock = DockStyle.Fill;
            adminListed.BringToFront();
            lblHome.Text = "Adminleri Listeleme";
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            AdminSave adminSave= new AdminSave();
            adminSave.TopLevel = false;
            panelDestopPane.Controls.Add(adminSave);
            adminSave.Show();
            adminSave.Dock= DockStyle.Fill;
            adminSave.BringToFront();
            lblHome.Text = "Admin Ekle";

        }

        private void btnAdminProcess_Click(object sender, EventArgs e)
        {
              
           
          
         
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            AdminDelete adminDelete = new AdminDelete();
            adminDelete.TopLevel = false;
            panelDestopPane.Controls.Add(adminDelete);
            adminDelete.Show();
            adminDelete.Dock = DockStyle.Fill;
            adminDelete.BringToFront();
            lblHome.Text = "Admin Sil";

        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            AdminUpdate adminUpdate = new AdminUpdate();
            adminUpdate.TopLevel = false;
            panelDestopPane.Controls.Add(adminUpdate);
            adminUpdate.Show();
            adminUpdate.Dock = DockStyle.Fill;
            adminUpdate.BringToFront();
            lblHome.Text = "Admin Bilgilerini Güncelle";

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            panelDestopPane.Controls.Clear();
            MemberSave memberSave = new MemberSave();
            memberSave.TopLevel = false;
            panelDestopPane.Controls.Add(memberSave);
            memberSave.Show();
            memberSave.Dock = DockStyle.Fill;
            memberSave.BringToFront();
            lblHome.Text = "Üye Ekle";
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            MemberDelete memberDelete = new MemberDelete();
            memberDelete.TopLevel = false;
            panelDestopPane.Controls.Add(memberDelete);
            memberDelete.Show();
            memberDelete.Dock = DockStyle.Fill;
            memberDelete.BringToFront();
            lblHome.Text = "Üye Sil";
        }
        private void btnListMember_Click(object sender, EventArgs e)
        {

            panelDestopPane.Controls.Clear();
            MemberList memberList = new MemberList();
            memberList.TopLevel = false;
            panelDestopPane.Controls.Add(memberList);
            memberList.Show();
            memberList.Dock = DockStyle.Fill;
            memberList.BringToFront();
            lblHome.Text = "Üyeleri Listele";

        }

        private void pnlAdminMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            BookDelete bookDelete = new BookDelete();
            bookDelete.TopLevel = false;
            panelDestopPane.Controls.Add(bookDelete);
            bookDelete.Show();
            bookDelete.Dock = DockStyle.Fill;
            bookDelete.BringToFront();
            lblHome.Text = "Kitap Sil";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            BookAdd bookAdd = new BookAdd();
            bookAdd.TopLevel = false;
            panelDestopPane.Controls.Add(bookAdd);
            bookAdd.Show();
            bookAdd.Dock = DockStyle.Fill;
            bookAdd.BringToFront();
            lblHome.Text = "Kitap Ekle";
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            BookUpdate bookUpdate = new BookUpdate();
            bookUpdate.TopLevel = false;
            panelDestopPane.Controls.Add(bookUpdate);
            bookUpdate.Show();
            bookUpdate.Dock = DockStyle.Fill;
            bookUpdate.BringToFront();
            lblHome.Text = "Kitap Bilgilerini Güncelle";
        }

        private void btnListBook_Click(object sender, EventArgs e)
        {

            panelDestopPane.Controls.Clear();
            BookList bookList = new BookList();
            bookList.TopLevel = false;
            panelDestopPane.Controls.Add(bookList);
            bookList.Show();
            bookList.Dock = DockStyle.Fill;
            bookList.BringToFront();
            lblHome.Text = "Kitapları Listele";
        }

        private void btnLoanedBookAdd_Click(object sender, EventArgs e)
        {
            panelDestopPane.Controls.Clear();
            GiveLoanedBook giveLoanedBook = new GiveLoanedBook();
            giveLoanedBook.TopLevel = false;
            panelDestopPane.Controls.Add(giveLoanedBook);
            giveLoanedBook.Show();
            giveLoanedBook.Dock = DockStyle.Fill;
            giveLoanedBook.BringToFront();
            lblHome.Text = "Emanet Kitap Ver";
        }

        private void btnDeleteLoanedBook_Click(object sender, EventArgs e)
        {

            panelDestopPane.Controls.Clear();
            RetrieveLoanedBooks retrieveLoanedBook = new RetrieveLoanedBooks();
            retrieveLoanedBook.TopLevel = false;
            panelDestopPane.Controls.Add(retrieveLoanedBook);
            retrieveLoanedBook.Show();
            retrieveLoanedBook.Dock = DockStyle.Fill;
            retrieveLoanedBook.BringToFront();
            lblHome.Text = "Emanet Kitabı Geri Al";

        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDestopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoanedBookList_Click(object sender, EventArgs e)
        {
            
            panelDestopPane.Controls.Clear();
            LoanedBookList loanedBookList = new LoanedBookList();
            loanedBookList.TopLevel = false;
            panelDestopPane.Controls.Add(loanedBookList);
            loanedBookList.Show();
            loanedBookList.Dock = DockStyle.Fill;
            loanedBookList.BringToFront();
            lblHome.Text = "Emanet Kitapları Listele";
        }
    }
}
