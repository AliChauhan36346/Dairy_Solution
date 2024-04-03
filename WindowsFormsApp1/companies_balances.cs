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

            parchi.getAllAccountsBalances(-1, dataGridView2, out grandTotalDebit, out grandTotalCredit);

            grandBalance = grandTotalCredit - grandTotalDebit;
            grandStatus = grandBalance > 0 ? "Credit" : "Debit";
            grandBalance = Math.Abs(grandBalance);

            txt_debit.Text = grandTotalDebit.ToString();
            txt_credit.Text = grandTotalCredit.ToString();
            txt_balance.Text = grandBalance.ToString() + " " + grandStatus;
        }
    }
}
