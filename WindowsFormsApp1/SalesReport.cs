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
    public partial class SalesReport : Form
    {
        ReportsClass salesR=new ReportsClass();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();

        DateTime startDate;
        DateTime endDate;

        decimal volume;
        decimal tsVolume;
        decimal tAmount;

        public SalesReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            startDate = dtm_start.Value;
            endDate=dtm_end.Value;

            salesR.GetSalesReport(dataGridView2, startDate.Date, endDate.Date, out volume, out tsVolume, out tAmount);

            txt_totalAmount.Text = tAmount.ToString();
            txt_volume.Text=volume.ToString();
            txt_tsVolume.Text=tsVolume.ToString();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            startDate = dtm_start.Value;
            endDate = dtm_end.Value;

            salesR.GetSalesReport(dataGridView2, startDate.Date, endDate.Date, out volume, out tsVolume, out tAmount);

            txt_totalAmount.Text = tAmount.ToString();
            txt_volume.Text = volume.ToString();
            txt_tsVolume.Text = tsVolume.ToString();

            decimal avgSale = commonFunctions.AverageRate(false);
            decimal avgpurchase = commonFunctions.AverageRate(true);

            avgSale=Math.Round(avgSale, 2);
            avgpurchase = Math.Round(avgpurchase, 2);

            lbl_avgPurchaseRate.Text = avgpurchase.ToString();
            lbl_avgSalesRate.Text = avgSale.ToString();
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
                    int accountId = int.Parse(selectedRow.Cells["Sales Id"].Value.ToString());
                    //string accountName = selectedRow.Cells["Account Name"].Value.ToString();

                    Sales sales = new Sales();
                    sales.isFromOtherForm = true;
                    sales.salesId = accountId;

                    sales.ShowDialog();

                }
            }
        }
    }
}
