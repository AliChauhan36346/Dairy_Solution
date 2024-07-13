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
    public partial class RoznamchaCash : Form
    {
        ReportsClass reportsClass=new ReportsClass();

        public RoznamchaCash()
        {
            InitializeComponent();
        }

        decimal paymentTotal = 0;
        decimal receiptTotal = 0;

        private void btn_roznamcha_Click(object sender, EventArgs e)
        {
            if (chk_expense.Checked)
            {
                reportsClass.RoznamchaCash(dataGridView1, dtm_start.Value, dtm_end.Value, out paymentTotal, out receiptTotal, true);
            }
            else
            {
                reportsClass.RoznamchaCash(dataGridView1, dtm_start.Value, dtm_end.Value, out paymentTotal, out receiptTotal, false);
            }

            
        }

        private void RoznamchaCash_Load(object sender, EventArgs e)
        {
            reportsClass.RoznamchaCash(dataGridView1, dtm_start.Value, dtm_end.Value, out paymentTotal, out receiptTotal, false);

        }
    }
}
