using Entities.DTOs;
using LibraryProject.DataAccess;
using LibraryProject.LibraryUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class AdminLoginPage : Form
    {
        
        public AdminLoginPage()
        {
            InitializeComponent();
              
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginDto loginDto = new LoginDto();
            loginDto.AdminUserName = tbxUserName.Text;
            loginDto.Password = tbxPassword.Text;
             AdminDal adminDal = new AdminDal();
            bool result = adminDal.CheckUser(loginDto);
            if (result==true)
            {
                MessageBox.Show("Giriş Başarılı");
                frmHomePage homePage = new frmHomePage();
                this.Hide();
                homePage.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da parola hatalı.");
            }
        }

        private void AdminLoginPage_Load(object sender, EventArgs e)
        {

        }

        private void tbxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordPage forgotPasswordPage= new ForgotPasswordPage();    
            forgotPasswordPage.Show();
        }
    }
}
