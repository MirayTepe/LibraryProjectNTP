using LibraryProject.DataAccess;
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
    public partial class ForgotPasswordPage : Form
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void ForgorPasswordPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            AdminDal adminDal = new AdminDal();
            if (adminDal.SendMail(tbxUserName.Text, tbxEmail.Text))
            {
                MessageBox.Show("Şifreniz mail kutunuza gönderilmiştir");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi doğru girerek tekrar deneyiniz");
            }
        }
    }
}
