﻿using DairyAccounting;
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

            decimal avgSale = commonFunctions.AverageRate(false);
            decimal avgpurchase = commonFunctions.AverageRate(true);

            avgSale = Math.Round(avgSale, 2);
            avgpurchase = Math.Round(avgpurchase, 2);

            lbl_avgPurchaseRate.Text = avgpurchase.ToString();
            lbl_avgSalesRate.Text = avgSale.ToString();
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
    }
}
