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
    public partial class Roznamcha : Form
    {
        ReportsClass reports = new ReportsClass();

        public Roznamcha()
        {
            InitializeComponent();
        }

        private void Roznamcha_Load(object sender, EventArgs e)
        {
            reports.GetCombinedReport(dataGridView1,dtm_start.Value.Date,dtm_end.Value.Date, out decimal morningReceive,
                out decimal totalSales, out decimal eveningReceive, out decimal tsSales,false,false);

            txt_tsSale.Text = tsSales.ToString();
            txt_sale.Text = totalSales.ToString();
            txt_evening.Text = eveningReceive.ToString();
            txt_morning.Text = morningReceive.ToString();

        }
        

        private void btn_roznamcha_Click(object sender, EventArgs e)
        {
            decimal morningReceive = 0;
            decimal totalSales = 0;
            decimal eveningReceive = 0;
            decimal tsSales = 0;



            if (chk_Morning.Checked && chkEvening.Checked)
            {
                reports.GetCombinedReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out morningReceive,
                out totalSales, out eveningReceive, out tsSales,true,true);
            }
            else if(chk_Morning.Checked && !chkEvening.Checked)
            {
                reports.GetCombinedReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out morningReceive,
                out totalSales, out eveningReceive, out tsSales,true,false);
            }
            else if(!chk_Morning.Checked && chkEvening.Checked)
            {
                reports.GetCombinedReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out morningReceive,
                out totalSales, out eveningReceive, out tsSales, false, true);
            }
            else
            {
                reports.GetCombinedReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out morningReceive,
                out totalSales, out eveningReceive, out tsSales,false,false);
            }


            txt_tsSale.Text=tsSales.ToString();
            txt_sale.Text = totalSales.ToString();
            txt_evening.Text = eveningReceive.ToString();
            txt_morning.Text = morningReceive.ToString();

            decimal tsDifference=totalSales-tsSales;
            decimal totalVolume = eveningReceive + morningReceive;
            decimal volumeDifference = totalVolume - totalSales;

            txt_tsDifference.Text=tsDifference.ToString();
            txt_totalVolume.Text = totalVolume.ToString();
            txt_volumeDifference.Text = volumeDifference.ToString();    
        }

        private void btn_purchaseReport_Click(object sender, EventArgs e)
        {
            ChilarReceiveReport chilarReceiveReport = new ChilarReceiveReport();
            chilarReceiveReport.ShowDialog();
        }

        private void btn_saleReport_Click(object sender, EventArgs e)
        {
            chilar chilar = new chilar();
            chilar.ShowDialog();
        }

        
    }
}
