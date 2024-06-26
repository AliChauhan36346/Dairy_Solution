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
            reports.GetCombinedReport(dataGridView1,dtm_start.Value.Date,dtm_end.Value.Date,"", "", out decimal morningReceive,
                out decimal totalSales, out decimal eveningReceive, out decimal tsSales);

            txt_tsSale.Text = tsSales.ToString();
            txt_sale.Text = totalSales.ToString();
            txt_evening.Text = eveningReceive.ToString();
            txt_morning.Text = morningReceive.ToString();

        }

        

        

        private void btn_roznamcha_Click(object sender, EventArgs e)
        {
            string startTime="";
            string endTime="";

            if(chk_Morning.Checked)
            {
                startTime = "Evening";
            }
            if(chkEvening.Checked)
            {
                endTime = "Morning";
            }

            reports.GetCombinedReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, "", "", out decimal morningReceive,
                out decimal totalSales, out decimal eveningReceive, out decimal tsSales);

            txt_tsSale.Text=tsSales.ToString();
            txt_sale.Text = totalSales.ToString();
            txt_evening.Text = eveningReceive.ToString();
            txt_morning.Text = morningReceive.ToString();
        }
    }
}
