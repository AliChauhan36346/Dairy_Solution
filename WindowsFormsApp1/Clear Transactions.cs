using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Clear_Transactions : Form
    {
        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();

        public Clear_Transactions()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_clearAllTransactions_Click(object sender, EventArgs e)
        {
            int isEntityAlso;

            if (chk_clearEntities.Checked)
            {
                isEntityAlso = 1;
            }
            else
            {
                isEntityAlso = 0;
            }

            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to clear all transactions?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with clearing transactions
                commonFunctions.ClearAllTransactions(isEntityAlso);
            }
            else
            {
                // User clicked No, do nothing
            }
        }

    }
}
