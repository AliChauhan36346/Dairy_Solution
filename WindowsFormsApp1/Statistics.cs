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
    public partial class Statistics : Form
    {
        StatisticsClass statisticsClass = new StatisticsClass();


        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            lbl_avgSaleRate.Text = statisticsClass.AverageRateCompany(dtm_start.Value.Date,dtm_end.Value.Date).ToString();
            lbl_avgSRate.Text = statisticsClass.AverageRateCompanyGrossLtrs(dtm_start.Value.Date, dtm_end.Value.Date).ToString();
            lbl_avgPurchaseRate.Text = statisticsClass.AverageRate(true).ToString();
        }

        private void dtm_start_ValueChanged(object sender, EventArgs e)
        {
            lbl_avgSaleRate.Text = statisticsClass.AverageRateCompany(dtm_start.Value.Date, dtm_end.Value.Date).ToString();
        }

        private void dtm_end_ValueChanged(object sender, EventArgs e)
        {
            lbl_avgSaleRate.Text = statisticsClass.AverageRateCompany(dtm_start.Value.Date, dtm_end.Value.Date).ToString();
        }
    }
}
