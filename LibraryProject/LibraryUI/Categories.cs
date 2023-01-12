using Entities.Concrete;
using LibraryProject.DataAccess;
using LibraryProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.LibraryUI
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            DgwSet();
        }
        public void DgwSet()
        {
            CategoryDal categoryDal= new CategoryDal();
            dgwCategroyList.DataSource= categoryDal.GetAll();
        }
        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void dgwCategroyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            CategoryDal categoryDal = new CategoryDal();
            try
            {
                categoryDal.Update(new Category() { CategoryId = Convert.ToInt32(tbxCategoryId.Text) , CategoryName = tbxCategoryName.Text });
                MessageBox.Show("Kategori güncellendi");        

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kategori güncellenemedi");
            }

            DgwSet();


        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            CategoryDal categoryDal = new CategoryDal();
            DialogResult dialogResult;
            try
            {
                 
                dialogResult=MessageBox.Show("Kategori Silinecek emin misiniz?" ,"Dikkat",MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {

                    categoryDal.Delete(new Category() { CategoryId = Convert.ToInt32(tbxCategoryId.Text) });
                    MessageBox.Show("Kayıt Silindi");
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori Silinemedi");
            }
            DgwSet();
        }
        private void btnCategorySave_Click(object sender, EventArgs e)
        {
           CategoryDal categoryDal = new CategoryDal();
            try
            {
                categoryDal.Add(new Category() {     CategoryId = Convert.ToInt32(tbxCategoryId.Text), CategoryName = tbxCategoryName.Text });
                MessageBox.Show("Kategori eklendi"); 
                DgwSet();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Kategori eklenemedi");
            }
           
        }

        private void dgwCategroyList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCategoryId.Text = dgwCategroyList.CurrentRow.Cells[0].Value.ToString();
            tbxCategoryName.Text = dgwCategroyList.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
