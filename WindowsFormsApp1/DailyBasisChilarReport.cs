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
    public partial class DailyBasisChilarReport : Form
    {
        ReportsClass reports=new ReportsClass();
        Roznamcha Roznamcha=new Roznamcha();

        public DailyBasisChilarReport()
        {
            InitializeComponent();
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
        }

        private void DailyBasisChilarReport_Load(object sender, EventArgs e)
        {

        }

        private void btn_roznamcha_Click(object sender, EventArgs e)
        {
            reports.GetDateWiseChilarReport(dataGridView1,dtm_start.Value.Date,dtm_end.Value.Date,out decimal totalSaleVolume,
                out decimal totalReceiveVolume, out decimal totalBalance);

            txt_balance.Text = totalBalance.ToString();
            txt_totalReceive.Text=totalReceiveVolume.ToString();
            txt_totalSale.Text=totalSaleVolume.ToString();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if(selectedIndex >= 0 && selectedIndex<dataGridView1.RowCount-1)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];

                    Roznamcha.startDate= Convert.ToDateTime(row.Cells["Date"].Value).AddDays(-1);
                    Roznamcha.endDate= Convert.ToDateTime(row.Cells["Date"].Value);
                    Roznamcha.fromOtherForm = true;
                    Roznamcha.ShowDialog();

                }
            }

        }
    }
}
