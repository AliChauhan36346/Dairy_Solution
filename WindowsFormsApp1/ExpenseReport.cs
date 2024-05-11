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
    public partial class ExpenseReport : Form
    {
        ReportsClass reportClass=new ReportsClass();


        public ExpenseReport()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            string expensetype="";
            decimal totalAmount;
            if(chk_filter.Checked )
            {
                expensetype=cmbo_type.SelectedItem.ToString().Trim();
            }
            //reportClass.GetExpenseReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, expensetype);

            totalAmount=reportClass.GetExpenseReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, expensetype);

            txt_totalAmount.Text=totalAmount.ToString();

        }
    }
}
