using LibraryProject.DataAccess;
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
    public partial class PunishmentProcess : Form
    {
        public PunishmentProcess()
        {
            InitializeComponent();
     
        }

        private void tbxLoanedBookId_TextChanged(object sender, EventArgs e)
        {

            SqlConnBase conn = new SqlConnBase();

            SqlCommand command = new SqlCommand("Select*from LoanedBooks where LoanedBookId like'" + tbxLoanedBookId.Text + "'", conn.sqlConnect());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               
                dtpBookRetrieveOfDate.Text = reader["BookRetrieveOfDate"].ToString();





            }

            conn.sqlConnect().Close();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnLoanedBookPunishmentProcess_Click(object sender, EventArgs e)
        {
            TimeSpan result;
            int punishment;
            DateTime bookLendingOfDate;

            bookLendingOfDate =DateTime.Parse( dtpBookRetrieveOfDate.Text);
            result = DateTime.Today- bookLendingOfDate;
            punishment = Convert.ToInt32(result.TotalDays) * 20;

            if (punishment<= 0)
            {
                lblResult.Text = "Ceza " + 0 + " TL'dir";


            }
            else if (punishment > 0)
            {
                lblResult.Text = "Ceza " + punishment + "TL'dir";
            }
           
          
        }

        private void dtpBookRetrieveOfDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBookLendingOfDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
