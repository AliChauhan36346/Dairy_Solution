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
    public partial class expenseGeneral : Form
    {
        public expenseGeneral()
        {
            InitializeComponent();
        }

        private void btn_cashPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.ShowDialog();
            this.Close();
        }

        private void btn_addPurchase_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.ShowDialog();
            this.Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expenseGeneral_Load(object sender, EventArgs e)
        {
            txt_employeeId.Enabled= false;
            txt_employeeName.Enabled= false;
        }

        private void combo_expenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_expenseType.Text=="Labour")
            {
                txt_employeeName.Enabled = true;
                txt_employeeId.Enabled = true;
            }
            else
            {
                txt_employeeName.Enabled = false;
                txt_employeeId.Enabled = false;
            }
        }
    }
}
