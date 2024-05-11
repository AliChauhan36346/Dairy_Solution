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
    public partial class PurchaseReport : Form
    {
        ReportsClass purchaseR = new ReportsClass();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        AddEmployees employees = new AddEmployees();

        DateTime startDate;
        DateTime endDate;

        decimal volume;
        decimal tsVolume;
        decimal tAmount;

        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            startDate = dtm_start.Value;
            endDate=dtm_end.Value;

            List<string> dodhi= new List<string>();
            dodhi = employees.GetDodhiNames();

            foreach(string dodhiName in dodhi)
            {
                cmbo_dodhi.Items.Add(dodhiName);
            }

            cmbo_dodhi.Enabled = false;
            cmbo_time.Enabled = false;

            purchaseR.GetPurchaseReport(dataGridView2, startDate.Date, endDate.Date, -1, "", out volume, out tAmount);

            txt_totalAmount.Text=tAmount.ToString();
            txt_Volume.Text=volume.ToString();

            
        }

        private void chk_time_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_time.Checked)
            {
                cmbo_time.Enabled = true;
            }
            else
            {
                cmbo_time.Enabled = false;
            }
        }

        private void chk_dodhi_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_dodhi.Checked)
            {
                cmbo_dodhi.Enabled=true;
            }
            else
            {
                cmbo_dodhi.Enabled = false;
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            int dodhiId =- 1;
            string time = "";

            startDate = dtm_start.Value;
            endDate = dtm_end.Value;

            if (chk_dodhi.Checked)
            {
                if(cmbo_dodhi.SelectedItem!=null)
                {
                    dodhiId = employees.getDodhiIdByName(cmbo_dodhi.SelectedItem.ToString().Trim());
                }
                
            }
            
            if(chk_time.Checked)
            {
                if( cmbo_time.SelectedItem!=null)
                {
                    time = cmbo_time.SelectedItem.ToString().Trim();
                }
                
            }

            purchaseR.GetPurchaseReport(dataGridView2, startDate.Date, endDate.Date, dodhiId, time, out volume, out tAmount);

            txt_totalAmount.Text = tAmount.ToString();
            txt_Volume.Text = volume.ToString();
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
                    int accountId = int.Parse(selectedRow.Cells["Purchase Id"].Value.ToString());
                    //string accountName = selectedRow.Cells["Account Name"].Value.ToString();

                    Purchases purchases = new Purchases();
                    purchases.isfromOtherForm = true;
                    purchases.purchaseId = accountId;

                    purchases.ShowDialog();

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
