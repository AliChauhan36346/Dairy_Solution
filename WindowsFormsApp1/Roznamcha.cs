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

        public bool fromOtherForm = false;
        public DateTime startDate;
        public DateTime endDate;

        private void Roznamcha_Load(object sender, EventArgs e)
        {
            if(fromOtherForm)
            {
                dtm_start.Value= startDate;
                dtm_end.Value= endDate;
                chkEvening.Checked = true;
                chk_Morning.Checked = true;

                reports.GetCombinedReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out decimal morningReceive,
                out decimal totalSales, out decimal eveningReceive, out decimal tsSales, true, true);

                txt_tsSale.Text = tsSales.ToString();
                txt_sale.Text = totalSales.ToString();
                txt_evening.Text = eveningReceive.ToString();
                txt_morning.Text = morningReceive.ToString();

                decimal tsDifference = totalSales - tsSales;
                decimal totalVolume = eveningReceive + morningReceive;
                decimal volumeDifference = totalVolume - totalSales;

                txt_tsDifference.Text = tsDifference.ToString();
                txt_totalVolume.Text = totalVolume.ToString();
                txt_volumeDifference.Text = volumeDifference.ToString();

            }
            else
            {
                chk_Morning.Checked = true;
                chkEvening.Checked = true;

                reports.GetCombinedReport(dataGridView1, dtm_start.Value.Date, dtm_end.Value.Date, out decimal morningReceive,
                out decimal totalSales, out decimal eveningReceive, out decimal tsSales, true, true);

                txt_tsSale.Text = tsSales.ToString();
                txt_sale.Text = totalSales.ToString();
                txt_evening.Text = eveningReceive.ToString();
                txt_morning.Text = morningReceive.ToString();

                decimal tsDifference = totalSales - tsSales;
                decimal totalVolume = eveningReceive + morningReceive;
                decimal volumeDifference = totalVolume - totalSales;

                txt_tsDifference.Text = tsDifference.ToString();
                txt_totalVolume.Text = totalVolume.ToString();
                txt_volumeDifference.Text = volumeDifference.ToString();
            }

            

            

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

        private void txt_datagridId_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Company/Dodhi Name] LIKE '%" + txt_datagridId.Text.Trim() + "%'");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Populate text boxes with data from the selected row
                    string transactionId = selectedRow.Cells["Id"].Value.ToString();

                    // Find the index where the digits start
                    int index = 0;
                    for (int i = 0; i < transactionId.Length; i++)
                    {
                        if (char.IsDigit(transactionId[i]))
                        {
                            index = i;
                            break;
                        }
                    }

                    // Separate the number part and the other part
                    string formCode = transactionId.Substring(0, index); // "pv"
                    string numberPart = transactionId.Substring(index); // "12"

                    int id = int.Parse(numberPart);


                    if (formCode == "CR")
                    {
                        chilar chilar = new chilar();
                        chilar.isFromOtherForm = true;
                        chilar.chilarReceiveId = id;
                        chilar.ShowDialog();
                    }
                    
                    else if (formCode == "SV")
                    {
                        Sales sales = new Sales();
                        sales.isFromOtherForm = true;
                        sales.salesId = id;
                        sales.ShowDialog();
                    }
                }
            }
        }
    }
}
