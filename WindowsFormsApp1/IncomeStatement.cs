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
    public partial class IncomeStatement : Form
    {
        profitLoss profitLoss  = new profitLoss();
        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();

        public IncomeStatement()
        {
            InitializeComponent();
        }

        private void IncomeStatement_Load(object sender, EventArgs e)
        {
            dtm_endDate.Enabled = false;
            dtm_startDate.Enabled = false;
            dtm_uptoDate.Enabled = false;
        }

        private void rdo_uptoDate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_uptoDate.Checked)
            {
                dtm_uptoDate.Enabled=true;
            }
            else
            {
                dtm_uptoDate.Enabled=false;
            }
        }

        private void rdo_fromDate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_fromDate.Checked)
            {
                dtm_startDate.Enabled=true;
                dtm_endDate.Enabled = true;
            }
            else
            {
                dtm_endDate.Enabled=false;
                dtm_startDate.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtm_startDate.Value;
            DateTime endDate = dtm_endDate.Value;

            decimal salesLiters;
            decimal avgSalesRate;
            decimal totalSalesAmount;

            decimal purchaseLiters;
            decimal avgPurchaseRate;
            decimal totalPurchaseAmount;

            decimal totalExpeses;

            decimal netProfiLoss;
            string profitLossStatus;

            profitLoss.totalSales(startDate.Date, endDate.Date, out salesLiters, out totalSalesAmount);
            profitLoss.totalPurchases(startDate.Date, endDate.Date, out purchaseLiters, out totalPurchaseAmount);
            profitLoss.totalExpenses(startDate.Date, endDate.Date, out totalExpeses);


            // calculating profit or loss
            netProfiLoss = totalSalesAmount - (totalPurchaseAmount+totalExpeses);

            profitLossStatus = netProfiLoss > 0 ? "Profit" : "Loss";

            netProfiLoss = Math.Abs(netProfiLoss);


            // sales
            lbl_salesLtr.Text = salesLiters.ToString();
            lbl_salesAmount.Text= totalSalesAmount.ToString();

            //purchases
            lbl_purchasedLtr.Text = purchaseLiters.ToString();
            lbl_purchaseAmount.Text = totalPurchaseAmount.ToString();

            // expenses
            lbl_expenses.Text=totalExpeses.ToString();

            // profit losss
            lbl_netProfitLoss.Text = netProfiLoss.ToString();
            lbl_profitOrLoss.Text= profitLossStatus;

            // averages
            avgSalesRate = commonFunctions.AverageRate(false);
            avgPurchaseRate = commonFunctions.AverageRate(true);

            avgSalesRate = Math.Round(avgSalesRate,2);
            avgPurchaseRate = Math.Round(avgPurchaseRate,2);

            lbl_averagePurchasedRate.Text=avgPurchaseRate.ToString();
            lbl_averageSalesRate.Text= avgSalesRate.ToString();
        }

        
    }
}
