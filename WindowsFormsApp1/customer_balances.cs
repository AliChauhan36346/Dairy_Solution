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
    public partial class customer_balances : Form
    {
        AddEmployees employees = new AddEmployees();
        AddCustomers customers = new AddCustomers();
        ParchiClass parchi = new ParchiClass();

        public customer_balances()
        {
            InitializeComponent();
        }

       

        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customer_balances_Load(object sender, EventArgs e)
        {
            cmbo_addressWise.Enabled = false;
            cmbo_dodhiWise.Enabled = false;

            //populating dodhi combo box with dodhi names
            List<string> employee=new List<string>();

            employee=employees.GetDodhiNames();

            foreach(string employeeName in employee)
            {
                cmbo_dodhiWise.Items.Add(employeeName);
            }

            //populating address combo box with customers addresses
            List<string> addresses=new List<string>();
            addresses = customers.getCustomersAddress();

            foreach(string address in addresses)
            {
                cmbo_addressWise.Items.Add(address);
            }
        }

        private void chk_dodhiWise_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_dodhiWise.Checked)
            {
                cmbo_dodhiWise.Enabled=true;
                chk_addressWise.Checked = false;
            }
            else
            {
                cmbo_dodhiWise.Enabled = false;
            }
        }

        private void chk_addressWise_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_addressWise.Checked)
            {
                cmbo_addressWise.Enabled = true;
                chk_dodhiWise.Checked = false;
            }
            else
            {
                cmbo_addressWise.Enabled = false;
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            decimal grandTotalDebit=0;
            decimal grandTotalCredit=0;
            decimal grandBalance = 0;
            string grandStatus="";

            if(chk_dodhiWise.Checked)
            {
                if(cmbo_dodhiWise.SelectedItem!= null)
                {
                    int dohdiId=employees.getDodhiIdByName(cmbo_dodhiWise.SelectedItem.ToString());

                    parchi.getAllAccountsBalances(dohdiId, dataGridView2, out grandTotalDebit, out grandTotalCredit);
                }
                else
                {
                    MessageBox.Show("Please select a dodhi from list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(chk_addressWise.Checked)
            {
                // for future use
            }
            else
            {
                parchi.getAllAccountsBalances(-1, dataGridView2, out grandTotalDebit,out grandTotalCredit);
            }

            grandBalance = grandTotalCredit - grandTotalDebit;
            grandStatus = grandBalance > 0 ? "Credit" : "Debit";
            grandBalance = Math.Abs(grandBalance);

            txt_debit.Text=grandTotalDebit.ToString();
            txt_credit.Text=grandTotalCredit.ToString();
            txt_balance.Text=grandBalance.ToString()+" "+grandStatus;


        }
    }
}
