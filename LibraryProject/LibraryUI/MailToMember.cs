using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Concrete;
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
    public partial class MailToMember : Form
    {
        public MailToMember()
        {
            InitializeComponent();
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            LoanedBookDal loanedBookDal= new LoanedBookDal();
            loanedBookDal.SendMail(tbxMailHeader.Text,tbxSendMail.Text,tbxEmail.Text);
            MessageBox.Show("Gönderildi");
            this.Hide();
        }
    }
}
