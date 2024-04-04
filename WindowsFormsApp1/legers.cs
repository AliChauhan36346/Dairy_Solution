using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class legers : Form
    {
        AccountsLegersClass accounts = new AccountsLegersClass();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        DateTime startDate = new DateTime(1900, 1, 1);
        customer_balances customer_Balances = new customer_balances();
        public bool isFromOtherForm=false;

        public int accountId;
        public string accountName;

        public legers()
        {
            InitializeComponent();
        }

        private void btn_milkCard_Click(object sender, EventArgs e)
        {
            milk_card milk_Card = new milk_card();
            milk_Card.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void legers_Load(object sender, EventArgs e)
        {
            lstSuggestions.Visible = false;
            

            dtm_from.Enabled = false;
            dtm_to.Enabled = false;

            if(isFromOtherForm)
            {
                accounts.GetCustomerLedger(dataGridView1, accountId, startDate.Date, dtm_to.Value, txt_totalDebit, txt_totalCredit, txt_totalBalance, txt_status, lbl_forwardBalance);

                txt_accountId.Text = accountId.ToString();
                txt_accountName.Text = accountName.ToString();
            }

            txt_accountId.Focus();
            lstSuggestions.Visible = false;

        }

        private void txt_accountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAllAccountSuggestions(txt_accountId.Text, lstSuggestions);
        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_accountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_accountId, txt_accountName, lstSuggestions, e);
            if (e.KeyCode == Keys.Enter)
            {
                btn_display.Focus();
            }
        }

        private void txt_accountId_Leave(object sender, EventArgs e)
        {
            lstSuggestions.Visible = false;
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            //determining id belonging, wheather its customer,company,employee or account
            if (!int.TryParse(txt_accountId.Text, out accountId))
            {
                MessageBox.Show("Invalid Account Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            accounts.GetCustomerLedger(dataGridView1, accountId, startDate.Date, dtm_to.Value, txt_totalDebit,txt_totalCredit,txt_totalBalance, txt_status, lbl_forwardBalance);


        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void chkBox_fromDate_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkBox_fromDate.Checked)
            {
                dtm_from.Enabled = false;
                dtm_to.Enabled = false;
            }
            else
            {
                dtm_from.Enabled = true;
                dtm_to.Enabled = true;
            }
        }

        private void dtm_from_ValueChanged(object sender, EventArgs e)
        {
            startDate=dtm_from.Value;
        }
    }
}
