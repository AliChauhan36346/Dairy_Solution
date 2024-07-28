using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class legers : Form
    {
        AccountsLegersClass accounts = new AccountsLegersClass();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        milk_card milkCard= new milk_card();
        MilkCardCompany companyMilkCard=new MilkCardCompany();
      
        customer_balances customer_Balances = new customer_balances();
        public bool isFromOtherForm=false;

        // for out values from leger calculator
        decimal totalBalance;
        decimal totalDebit;
        decimal totalCredit;
        decimal balanceBroughtForward;
        string forwardString;
        string bStatus;

        public int accountId;
        public string accountName;

        public legers()
        {
            InitializeComponent();
        }

        private void btn_milkCard_Click(object sender, EventArgs e)
        {

            

            if(int.TryParse(txtAccountId.Text, out int id))
            {
                if(id>=20000 && id<25000)
                {
                    companyMilkCard.ShowDialog();
                }
                else
                {
                    milkCard.ShowDialog();
                }
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void legers_Load(object sender, EventArgs e)
        {
            lstSuggestions.Visible = false;
            

            dtm_startDate.Enabled = false;
            dtm_endDate.Enabled = false;

            if(isFromOtherForm)
            {
                accounts.GetCustomerLedger(dataGridView1, accountId, dtm_startDate.MinDate, dtm_endDate.MaxDate, out totalDebit, out totalCredit, out totalBalance, out bStatus, out balanceBroughtForward, out forwardString);

                txtAccountId.Text = accountId.ToString();
                txt_accountName.Text = accountName.ToString();

                // convenience round off
                totalBalance = Math.Round(totalBalance, 0);
                balanceBroughtForward = Math.Round(balanceBroughtForward, 0);
                balanceBroughtForward = Math.Abs(balanceBroughtForward);
                totalCredit = Math.Round(totalCredit, 0);
                totalDebit = Math.Round(totalDebit, 0);


                lbl_forwardBalance.Text = "Balance brought forward " + balanceBroughtForward.ToString() + " " + forwardString;
                txt_totalDebit.Text = totalDebit.ToString();
                txt_totalCredit.Text = totalCredit.ToString();
                txt_totalBalance.Text = totalBalance.ToString() + " " + bStatus;
            }

            txtAccountId.Focus();
            lstSuggestions.Visible = false;
            //txt_accountName.Focused = false;
            txtAccountId.Focus();

        }

        private void txt_accountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAllAccountSuggestions(txtAccountId.Text, lstSuggestions);

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_accountId_Leave(object sender, EventArgs e)
        {
            lstSuggestions.Visible = false;
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            //determining id belonging, wheather its customer,company,employee or account
            if (!int.TryParse(txtAccountId.Text, out accountId))
            {
                MessageBox.Show("Invalid Account Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // setting values for milk card
            // when the user open it already loaded
            milkCard.id=accountId;
            milkCard.name = txt_accountName.Text;
            milkCard.startDate = dtm_startDate.Value;
            milkCard.endDate = dtm_endDate.Value;

            // company milk card
            companyMilkCard.id = accountId;
            companyMilkCard.name= txt_accountName.Text;
            companyMilkCard.startDate=dtm_startDate.Value;
            companyMilkCard.endDate=dtm_endDate.Value;

            if (chkBox_fromDate.Checked)
            {
                accounts.GetCustomerLedger(dataGridView1, accountId, dtm_startDate.Value.Date, dtm_endDate.Value.Date, 
                    out totalDebit, out totalCredit, out totalBalance, out bStatus, out balanceBroughtForward, out forwardString);
            }
            else
            {
                accounts.GetCustomerLedger(dataGridView1, accountId, dtm_startDate.MinDate, dtm_endDate.MaxDate,
                    out totalDebit, out totalCredit, out totalBalance, out bStatus, out balanceBroughtForward, out forwardString);
            }

            

            // convenience round off
            totalBalance = Math.Round(totalBalance, 0);
            balanceBroughtForward=Math.Round(balanceBroughtForward,0);
            balanceBroughtForward = Math.Abs(balanceBroughtForward);
            totalCredit = Math.Round(totalCredit, 0);
            totalDebit=Math.Round(totalDebit,0);


            lbl_forwardBalance.Text="Balance brought forward " + balanceBroughtForward.ToString() + " " + forwardString;
            txt_totalDebit.Text = totalDebit.ToString();
            txt_totalCredit.Text = totalCredit.ToString();
            txt_totalBalance.Text=totalBalance.ToString() + " " + bStatus;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;

            // Show the print preview dialog
            DialogResult result = printPreviewDialog.ShowDialog();

            
            currrentRow = 0;
            forwardBalancePrinted= false;
            headerPrinted= false;
            

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        bool headerPrinted = false;
        int currrentRow = 0;
        bool forwardBalancePrinted = false;
        //decimal totalCredit = 0;
        //decimal totalDebit = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font heading1 = new Font("Segoe UI", 22, FontStyle.Bold);
            Font heading2 = new Font("Segoe UI", 18, FontStyle.Bold | FontStyle.Italic);
            Font heading3 = new Font("Times New Roman", 12, FontStyle.Bold | FontStyle.Italic);
            Font detail = new Font("Times New Roman", 10, FontStyle.Regular);

            Pen pen = new Pen(Color.Black, 2);
            Brush brush = Brushes.Black;

            string date;

            if (chkBox_fromDate.Checked)
            {
                date = "Leger for the date started on " + dtm_startDate.Value.Date.ToString("dd-MM-yyyy") + " To " + dtm_endDate.Value.Date.ToString("dd-MM-yyyy");
            }
            else
            {
                date = "Leger for the date ended on " + dtm_endDate.Value.Date.ToString("dd-MM-yyyy");
            }


            int xAxis = 50;
            int yAxis = 25;

            if(!headerPrinted)
            {
                e.Graphics.DrawString("Chauhan Dairy Farms", heading1, brush, xAxis, yAxis);
                yAxis += 45;
                e.Graphics.DrawString(txtAccountId.Text + "   " + txt_accountName.Text, heading2, brush, xAxis, yAxis);
                yAxis += 30;
                e.Graphics.DrawString(date, heading2, brush, xAxis, yAxis);
                yAxis += 55;

                int rectHeight = heading3.Height;
                e.Graphics.DrawRectangle(pen, xAxis, yAxis, e.PageBounds.Width - 100, rectHeight+1);

                e.Graphics.DrawString("تاریخ", heading3,brush,xAxis+15, yAxis);
                xAxis += 90;
                e.Graphics.DrawString("ٹرانزیکشن نمبر", heading3,brush,xAxis-20, yAxis+2);
                xAxis += 100;
                e.Graphics.DrawString("وضاحت", heading3,brush,xAxis, yAxis+2);
                xAxis += 250;
                e.Graphics.DrawString("بنام", heading3,brush,xAxis, yAxis + 2);
                xAxis += 100;
                e.Graphics.DrawString("جمع", heading3,brush,xAxis, yAxis + 2);
                xAxis += 100;
                e.Graphics.DrawString("بقیہ", heading3,brush,xAxis+ 10, yAxis + 2);

                //setting the axis for the rows 
                xAxis = 50;
                yAxis = 190;

                //header printed
                headerPrinted = true;
            }
            else
            {
                // for the new page without header
                xAxis = 50;
                yAxis = 50;
            }


            if(balanceBroughtForward!=0 && !forwardBalancePrinted)
            {
                e.Graphics.DrawString("آگے لایا گیا بیلنس", detail, brush, 240, yAxis);

                if (forwardString=="Credit")
                    e.Graphics.DrawString(balanceBroughtForward.ToString()+ "  جمع", detail, brush, 690, yAxis);
                else if(forwardString=="Debit")
                    e.Graphics.DrawString(balanceBroughtForward.ToString() + "  بنام", detail, brush, 690, yAxis);

                yAxis += 30;
                xAxis = 50;

                forwardBalancePrinted = true;

            }

            //printing rows 
            while(currrentRow<dataGridView1.Rows.Count)
            {
                DataGridViewRow row = new DataGridViewRow();

                // giving the current row to print
                row = dataGridView1.Rows[currrentRow];

                e.Graphics.DrawString(row.Cells["Date"].Value.ToString(), detail, brush, xAxis+5, yAxis);
                xAxis += 90;
                e.Graphics.DrawString(row.Cells["Tran.No"].Value.ToString(), detail, brush, xAxis+10, yAxis);
                xAxis += 100;
                e.Graphics.DrawString(row.Cells["Description"].Value.ToString(), detail, brush, xAxis, yAxis);
                xAxis += 250;
                e.Graphics.DrawString(row.Cells["Debit"].Value.ToString(), detail, brush, xAxis, yAxis);
                xAxis += 100;
                e.Graphics.DrawString(row.Cells["Credit"].Value.ToString(), detail, brush, xAxis, yAxis);
                xAxis += 100;

                
                

                if (row.Cells["Status"].Value.ToString().Trim()=="credit")
                {
                    e.Graphics.DrawString(row.Cells["Balance"].Value.ToString() + "  " + "جمع", detail, brush, xAxis, yAxis);


                }
                else
                {
                    e.Graphics.DrawString(row.Cells["Balance"].Value.ToString() + "  " + "بنام", detail, brush, xAxis, yAxis);
                }
                

                xAxis = 50;
                yAxis += 30;

                currrentRow++;

                if (yAxis + 25 >e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            xAxis = 50;
            int recHeight = heading3.Height;
            e.Graphics.DrawRectangle(pen, xAxis, yAxis, e.PageBounds.Width - 100, recHeight + 1);
            xAxis += 300;
            e.Graphics.DrawString("Total Rs",heading3,brush, xAxis, yAxis);
            xAxis += 140;
            e.Graphics.DrawString(totalDebit.ToString(),heading3,brush, xAxis, yAxis);
            xAxis += 100;
            e.Graphics.DrawString(totalCredit.ToString(),heading3,brush, xAxis, yAxis);
            xAxis += 100;
            if(bStatus=="credit")
                e.Graphics.DrawString(totalBalance.ToString()+ "  جمع", heading3, brush, xAxis, yAxis);
            else if(bStatus=="debit")
                e.Graphics.DrawString(totalBalance.ToString() + "  بنام", heading3, brush, xAxis, yAxis);

        }

        private void chkBox_fromDate_CheckedChanged(object sender, EventArgs e)
        {
            if(!chkBox_fromDate.Checked)
            {
                dtm_startDate.Enabled = false;
                dtm_endDate.Enabled = false;
            }
            else
            {
                dtm_startDate.Enabled = true;
                dtm_endDate.Enabled = true;
            }
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Check if the selected index is within the bounds of the data
                if (selectedIndex >= 0 && selectedIndex < dataGridView1.RowCount)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Populate text boxes with data from the selected row
                    string transactionId = selectedRow.Cells["Tran.No"].Value.ToString();

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

                    int id= int.Parse(numberPart);

                    if(formCode=="PV")
                    {
                        Purchases purchases = new Purchases();
                        purchases.isfromOtherForm = true;
                        purchases.purchaseId= id;
                        purchases.ShowDialog();
                    }
                    else if(formCode=="CPV")
                    {
                        Payments payments = new Payments();
                        payments.isFromOtherForm = true;
                        payments.paymentId= id;
                        payments.ShowDialog();
                    }
                    else if(formCode=="CRV")
                    {
                        Receipts_Form receipts = new Receipts_Form();
                        receipts.isFromOtherForm= true;
                        receipts.receiptId= id;
                        receipts.ShowDialog();
                    }
                    else if(formCode=="SV")
                    {
                        Sales sales = new Sales();
                        sales.isFromOtherForm = true;
                        sales.salesId = id;
                        sales.ShowDialog();
                    }

                    

                }
            }
        }

        private void txtAccountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAllAccountSuggestions(txtAccountId.Text, lstSuggestions);
        }

        private void txtAccountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txtAccountId, txt_accountName, lstSuggestions, e);
            if (e.KeyCode == Keys.Enter)
            {
                btn_display.Focus();
            }
        }

        private void txtAccountId_Leave(object sender, EventArgs e)
        {
            lstSuggestions.Visible = false;
        }

        private void btn_cashPayment_Click(object sender, EventArgs e)
        {
            Payments payments= new Payments();
            payments.ShowDialog();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Purchases purchases= new Purchases();
            purchases.ShowDialog();
        }
    }
}
