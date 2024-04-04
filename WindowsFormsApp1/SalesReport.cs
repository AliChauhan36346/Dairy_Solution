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
    }
}
