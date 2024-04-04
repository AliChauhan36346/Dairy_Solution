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
    public partial class companies_balances : Form
    {
        ParchiClass parchi=new ParchiClass();

        public companies_balances()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            decimal grandTotalDebit = 0;
            decimal grandTotalCredit = 0;
            decimal grandBalance = 0;
            string grandStatus = "";

            parchi.getAllAccountsBalances(-1,true, dataGridView2, out grandTotalDebit, out grandTotalCredit);

            grandBalance = grandTotalCredit - grandTotalDebit;
            grandStatus = grandBalance > 0 ? "Credit" : "Debit";
            grandBalance = Math.Abs(grandBalance);

            txt_debit.Text = grandTotalDebit.ToString();
            txt_credit.Text = grandTotalCredit.ToString();
            txt_balance.Text = grandBalance.ToString() + " " + grandStatus;
        }

        private void companies_balances_Load(object sender, EventArgs e)
        {
            decimal grandTotalDebit = 0;
            decimal grandTotalCredit = 0;
            decimal grandBalance = 0;
            string grandStatus = "";

            parchi.getAllAccountsBalances(-1, true, dataGridView2, out grandTotalDebit, out grandTotalCredit);

            grandBalance = grandTotalCredit - grandTotalDebit;
            grandStatus = grandBalance > 0 ? "Credit" : "Debit";
            grandBalance = Math.Abs(grandBalance);

            txt_debit.Text = grandTotalDebit.ToString();
            txt_credit.Text = grandTotalCredit.ToString();
            txt_balance.Text = grandBalance.ToString() + " " + grandStatus;
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Check if there's at least one row in the DataGridView
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView2.SelectedRows[0].Index;

                // Check if the selected index is within the bounds of the data
                if (selectedIndex >= 0 && selectedIndex < dataGridView2.RowCount - 1)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                    // Populate text boxes with data from the selected row
                    int accountId = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                    string accountName = selectedRow.Cells["Account Name"].Value.ToString();

                    legers leger = new legers();
                    leger.isFromOtherForm = true;
                    leger.accountId = accountId;
                    leger.accountName = accountName;

                    leger.ShowDialog();

                }
            }
        }
    }
}
