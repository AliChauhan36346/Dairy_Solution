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
    public partial class ProfitLoss : Form
    {
        profitLoss profitLosss=new profitLoss();

        public ProfitLoss()
        {
            InitializeComponent();
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {


            profitLosss.profitLossInRow(dtm_start.Value.Date, dtm_end.Value.Date, dataGridView1, out decimal totalPurchase,
                out decimal purchaseAmount, out decimal totalExpense, out decimal totalSales, out decimal salesAmount, out decimal profitLoss);

            txt_totalPurchase.Text=totalPurchase.ToString();
            txt_purchaseAmount.Text=purchaseAmount.ToString();
            txt_totalExpense.Text=totalExpense.ToString();
            txt_totalSales.Text=totalSales.ToString();
            txt_salesAmount.Text=salesAmount.ToString();

            txt_profitLoss.Text = profitLoss > 0 ? profitLoss + " Profit" : profitLoss + " Loss";

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < (e.RowIndex + e.RowCount); i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                }
            }
        }
    }
}
