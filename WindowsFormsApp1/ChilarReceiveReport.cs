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
    public partial class ChilarReceiveReport : Form
    {
        ReportsClass receiveR = new ReportsClass();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        AddEmployees employees = new AddEmployees();

        DateTime startDate;
        DateTime endDate;

        // for receive report
        decimal volume;
        decimal tsVolume;

        // for dodhi loss report
        decimal grandTotalPurchase;
        decimal grandTotalReceive;
        decimal grandTotalLoss;
        string grandGainOrLoss;

        public ChilarReceiveReport()
        {
            InitializeComponent();
        }

        private void ChilarReceiveReport_Load(object sender, EventArgs e)
        {
            startDate = dtm_start.Value;
            endDate = dtm_end.Value;

            List<string> dodhi = new List<string>();
            dodhi = employees.GetDodhiNames();

            foreach (string dodhiName in dodhi)
            {
                cmbo_dodhi.Items.Add(dodhiName);
            }

            cmbo_dodhi.Enabled = false;
            cmbo_time.Enabled = false;

            // receive roport pupulating
            receiveR.GetReceiveReport(dataGridView2, startDate.Date, endDate.Date, -1, "",
                out volume, out tsVolume);

            txt_Volume.Text = volume.ToString();
            txt_tsVolume.Text = tsVolume.ToString();

            // dodhi loss report filling 
            receiveR.GetAllDodhiLossReport(dataGridView1, startDate.Date, endDate.Date, -1, "", out grandTotalPurchase
                , out grandTotalReceive, out grandTotalLoss, out grandGainOrLoss);

            txt_totalPurchased.Text = grandTotalPurchase.ToString();
            txt_totalReive.Text = grandTotalReceive.ToString();
            txt_lossAndStatus.Text = grandTotalLoss.ToString() + " " + grandGainOrLoss;
        }

        private void chk_time_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_time.Checked)
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
            if (chk_dodhi.Checked)
            {
                cmbo_dodhi.Enabled = true;
            }
            else
            {
                cmbo_dodhi.Enabled = false;
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            int dodhiId = -1;
            string time = "";

            startDate = dtm_start.Value;
            endDate = dtm_end.Value;

            if (chk_dodhi.Checked)
            {
                if (cmbo_dodhi.SelectedItem != null)
                {
                    dodhiId = employees.getDodhiIdByName(cmbo_dodhi.SelectedItem.ToString().Trim());
                }

            }

            if (chk_time.Checked)
            {
                if (cmbo_time.SelectedItem != null)
                {
                    time = cmbo_time.SelectedItem.ToString().Trim();
                }

            }

            receiveR.GetReceiveReport(dataGridView2, startDate.Date, endDate.Date, dodhiId, time, out volume, out tsVolume);

            txt_Volume.Text = volume.ToString();
            txt_tsVolume.Text = tsVolume.ToString();

            receiveR.GetAllDodhiLossReport(dataGridView1, startDate.Date, endDate.Date, dodhiId, time, out grandTotalPurchase
                , out grandTotalReceive, out grandTotalLoss, out grandGainOrLoss);

            txt_totalPurchased.Text = grandTotalPurchase.ToString();
            txt_totalReive.Text = grandTotalReceive.ToString();
            txt_lossAndStatus.Text = grandTotalLoss.ToString() +" "+ grandGainOrLoss;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
