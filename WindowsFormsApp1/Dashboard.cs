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
    public partial class Dashboard : Form
    {
        DashboardClass dashboard=new DashboardClass();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashBtn_addSales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void dashBtn_addPurchase_Click(object sender, EventArgs e)
        {
            Purchases purchases = new Purchases();
            purchases.ShowDialog();
        }

        private void dashBtn_chilarReceive_Click(object sender, EventArgs e)
        {
            chilar chilar = new chilar();
            chilar.ShowDialog();
        }

        private void dashBtn_cashPayment_Click(object sender, EventArgs e)
        {
            Payments payments  = new Payments();
            payments.ShowDialog();
        }

        private void dashBtn_cashReceipt_Click(object sender, EventArgs e)
        {
            Receipts_Form receipts_Form = new Receipts_Form();
            receipts_Form.ShowDialog();
        }

        private void dashBtn_accountsLeger_Click(object sender, EventArgs e)
        {
            legers legers = new legers();
            legers.ShowDialog();
        }

        private void dashBtn_expense_Click(object sender, EventArgs e)
        {
            expenseGeneral expenseGeneral = new expenseGeneral();
            expenseGeneral.ShowDialog();
        }

        private void dashBtn_companiesBalances_Click(object sender, EventArgs e)
        {
            companies_balances companies_balances = new companies_balances();
            companies_balances.ShowDialog();
        }

        private void dashBtn_customerBalance_Click(object sender, EventArgs e)
        {
            customer_balances customer_Balances = new customer_balances();
            customer_Balances.ShowDialog();
        }

        private void dashBtn_parchi_Click(object sender, EventArgs e)
        {
            Parchi parchi = new Parchi();
            parchi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TsCalculator tsCalculator = new TsCalculator();
            tsCalculator.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            DateTime startDate = dtm_start.Value;
            DateTime endDate = dtm_end.Value;

            // for average lr fat card

            string avgLr;
            string avgFat;
            string grossReceive;

            // geth the average fat and lr
            dashboard.getAverageLrFat(out grossReceive,out avgLr, out avgFat, startDate.Date, endDate.Date);

            // calculating average ts volume base on chilar receive data like lr fat and gross volume
            int ts = 13;
            decimal averageTsVolume = commonFunctions.tsCalculator(decimal.Parse(avgLr), decimal.Parse(avgFat), decimal.Parse(grossReceive), ts);

            // parsing for 2 decimal place percesion
            decimal averageLr = decimal.Parse(avgLr);
            decimal averageFat = decimal.Parse(avgFat);

            averageFat = Math.Round(averageFat, 2);
            averageLr=Math.Round(averageLr,2);

            // assigningn values to the labels
            lbl_avgFat.Text = averageFat.ToString();
            lbl_avgLr.Text = averageLr.ToString();
            lbl_avgTsVolume.Text = averageTsVolume.ToString();



            //for sales card

            string grossSale;
            string tsSale;

            // get the gross sales and ts-sales volume
            dashboard.getGrossAndTsSales(out grossSale, out tsSale, startDate.Date, startDate.Date);

            // assignes the values to the text
            lbl_grossVolume.Text = grossSale;
            lbl_tsVolume.Text = tsSale ;

            // calculates the ts loss
            decimal tsLoss = decimal.Parse(grossSale) - decimal.Parse(tsSale);

            // assigning value to ts loss lable
            lbl_tsLoss.Text = tsLoss.ToString();





            // for purchases card
            string purchaseVolume;

            dashboard.getPurchaseVolume(out purchaseVolume,startDate.Date,endDate.Date);
            decimal dodhiLoss = decimal.Parse(purchaseVolume) - decimal.Parse(grossReceive);
            dodhiLoss = Math.Round(dodhiLoss, 2);

            lbl_purchases.Text= purchaseVolume;
            lbl_grossReceive.Text= grossReceive;
            lbl_PdodhiLoss.Text = dodhiLoss.ToString();

            


            // for stock/loss card

            lbl_stockCReceive.Text=grossReceive;
            lbl_stockSales.Text = grossSale;

            decimal stockOrLoss=decimal.Parse(grossReceive) - decimal.Parse(grossSale);
            stockOrLoss = Math.Round(stockOrLoss, 2);

            lbl_stockOrLoss.Text= stockOrLoss.ToString();


            // for bank/cash card





        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbl_grossVolume_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tsVolume_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password password = new Password();

            if (password.ShowDialog() == DialogResult.OK)
            {
                string enteredPassword = password.enteredPassword;

                if (password.IsPasswordCorrect(enteredPassword))
                {
                    Change_Rates change_Rates = new Change_Rates();
                    change_Rates.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect password. Deletion aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password password = new Password();

            if (password.ShowDialog() == DialogResult.OK)
            {
                string enteredPassword = password.enteredPassword;

                if (password.IsPasswordCorrect(enteredPassword))
                {
                    Clear_Transactions clear_Transactions = new Clear_Transactions();
                    clear_Transactions.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect password. Deletion aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void customersDodhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Password password = new Password();

            if (password.ShowDialog() == DialogResult.OK)
            {
                string enteredPassword = password.enteredPassword;

                if (password.IsPasswordCorrect(enteredPassword))
                {
                    Change_Dodhi change_Dodhi = new Change_Dodhi();
                    change_Dodhi.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect password. Deletion aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport salesReport = new SalesReport();

            salesReport.ShowDialog();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReport purchaseReport = new PurchaseReport();
            purchaseReport.ShowDialog();
        }

        private void chilarReceiveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilarReceiveReport chilarReceive=new ChilarReceiveReport();
            chilarReceive.ShowDialog();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save backup before closing?", "Backup", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (backupData BackupForm = new backupData())
                {
                    if (BackupForm.ShowDialog() == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupData backupData= new backupData();
            backupData.ShowDialog();
            this.Close();
        }

        private void incomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeStatement incomeStatement=new IncomeStatement();
            incomeStatement.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Accounts_Opening_Balances opening_Balances = new Accounts_Opening_Balances();
            opening_Balances.ShowDialog();
        }

        private void btn_journalVoucher_Click(object sender, EventArgs e)
        {
            GeneralJournal generalJournal=new GeneralJournal();
            generalJournal.ShowDialog();
        }
    }
}
