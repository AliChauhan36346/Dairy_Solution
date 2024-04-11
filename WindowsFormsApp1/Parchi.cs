using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Parchi : Form
    {
        ParchiClass parchi=new ParchiClass();
        AddEmployees employees = new AddEmployees();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        AddPayments payments = new AddPayments();
        cashAccountSelectionForm cashAccountSelection = new cashAccountSelectionForm();
        AddAccounts accounts = new AddAccounts();


        public Parchi()
        {
            InitializeComponent();
            
        }

        
        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Parchi_Load(object sender, EventArgs e)
        {
            cmbo_dodhi.Enabled = false;
            txt_accountId.Enabled = false;
            txt_accountName.Enabled = false;

            List<string> dodhiName;
            dodhiName= new List<string>();
            dodhiName=employees.GetDodhiNames();

            foreach(var item in dodhiName)
            {
                cmbo_dodhi.Items.Add(item);
            }

            lstAccountSuggestions.Visible = false;

            lbl_status.Visible = false;
        }

        private void chk_dodhiWise_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_dodhiWise.Checked)
            {
                cmbo_dodhi.Enabled = true;

                // uncheck single customer checkbox
                if (chk_singleCustomer.Checked)
                {
                    chk_singleCustomer.Checked = false;
                }
            }

            else
            {
                cmbo_dodhi.Enabled=false;
            }
        }

        private void chk_singleCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_singleCustomer.Checked)
            {
                txt_accountId.Enabled = true;
                txt_accountName.Enabled = true;

                // uncheck dodhiwise check box
                if (chk_dodhiWise.Checked)
                {
                    chk_dodhiWise.Checked = false;
                }
            }

            else
            {
                txt_accountId.Enabled = false;
                txt_accountName.Enabled = false;
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            int customerId;

            decimal grandTotalLiters;
            decimal grandTotalParchiAmount;
            decimal grandTotalMilkAmount;
            
            DateTime startDate = dtm_start.Value;
            DateTime endDate = dtm_end.Value;

            if (chk_dodhiWise.Checked)
            {
                string dodhi=cmbo_dodhi.Text;
                int dodhiId=employees.getDodhiIdByName(dodhi.Trim());
                //int dodhiId = 25002;

                parchi.getCustomersParchi(out grandTotalLiters, out grandTotalMilkAmount,
                    out grandTotalParchiAmount, dodhiId,-1, startDate.Date, endDate.Date, dataGridView2);
            }
            else if(chk_singleCustomer.Checked)
            {
                if(!int.TryParse(txt_accountId.Text,out customerId))
                {
                    MessageBox.Show("Please add company name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                parchi.getCustomersParchi(out grandTotalLiters, out grandTotalMilkAmount,
                    out grandTotalParchiAmount,-1,customerId, startDate.Date, endDate.Date, dataGridView2);

            }
            else
            {
                parchi.getCustomersParchi(out grandTotalLiters, out grandTotalMilkAmount,
                    out grandTotalParchiAmount, -1, -1, startDate.Date, endDate.Date, dataGridView2);
            }

            grandTotalMilkAmount = Math.Round(grandTotalMilkAmount, 1);
            grandTotalParchiAmount=Math.Round(grandTotalParchiAmount,1);

            txt_totalLiters.Text= grandTotalLiters.ToString();
            txt_totalLitersAmount.Text= grandTotalMilkAmount.ToString();
            txt_totalParchiAmount.Text=grandTotalParchiAmount.ToString();

        }

        private void txt_accountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_accountId, txt_accountName, lstAccountSuggestions, e);
            if (e.KeyCode == Keys.Enter)
            {
                btn_display.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_accountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_accountId, lstAccountSuggestions, "customer");
        }

        private void lstAccountSuggestions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAccountSuggestions.Visible && lstAccountSuggestions.SelectedItem != null)
            {
                string selectedSuggestion = lstAccountSuggestions.SelectedItem.ToString();
                string[] parts = selectedSuggestion.Split(new[] { " - " }, StringSplitOptions.None);

                // Transfer the selected suggestion to the TextBoxes
                txt_accountName.Text = parts[1]; // Name TextBox
                txt_accountId.Text = parts[0].Trim(); // ID TextBox

                // Hide the suggestion list
                lstAccountSuggestions.Visible = false;

                // Move focus to the next control (ID TextBox)
                btn_display.Focus();

            }
            else
            {
                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_accountId_Leave(object sender, EventArgs e)
        {
            if (!lstAccountSuggestions.Focused)
            {
                lstAccountSuggestions.Visible = false;
            }
        }

        private async void btn_printAndAddPayments_Click(object sender, EventArgs e)
        {

            DateTime startDate = dtm_start.Value;
            DateTime endDate = dtm_end.Value;

            if (dataGridView2.Rows.Count > 0)
            {
                if (cashAccountSelection.ShowDialog() == DialogResult.OK)
                {
                    string cashAccountName = cashAccountSelection.SelectedCashAccount;
                    int cashAccountId = accounts.getAccountIdByName(cashAccountName);

                    // Show loading message
                    lbl_status.Text = "Adding payments...";
                    lbl_status.Visible = true;

                    decimal totalAmountAdded = 0;

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            payments.amount = Convert.ToDecimal(row.Cells["Parchi Amount"].Value);

                            if (payments.amount != 0)
                            {
                                payments.accountId = Convert.ToInt32(row.Cells["Id"].Value);
                                payments.accountName = Convert.ToString(row.Cells["Customer Name"].Value);
                                payments.discription = "Parchi  " + startDate.Date.ToString() + " to " + endDate.Date.ToString();
                                payments.date = DateTime.Now.Date;
                                payments.cashAccountId = cashAccountId;
                                payments.cashAccountName = cashAccountName;

                                // Add payments (asynchronously)
                                await Task.Run(() => payments.savePayments(payments));

                                totalAmountAdded += payments.amount;
                            }
                        }
                    }

                    // Hide loading message
                    lbl_status.Visible = false;

                    // Display success message with total amount added
                    if (totalAmountAdded > 0)
                    {
                        MessageBox.Show($"Payments added successfully for the accounts. Total amount added: {totalAmountAdded}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No payments added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private int currentRow = 0;
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.HasMorePages = false;

            string companyName = "چوہان ڈیری فارمز"; // Your company name

            DateTime startDate = dtm_start.Value.Date;
            DateTime endDate = dtm_end.Value.Date;


            // Set font and brush for drawing
            Font headingfont = new Font("Times New Roman", 18, FontStyle.Bold);
            Font font = new Font("Times New Roman", 13, FontStyle.Regular);
            Font linefont = new Font("Jameel Noori Nastaleeq", 12, FontStyle.Regular);
            Font infofont = new Font("Times New Roman", 11, FontStyle.Regular);
            Font nofont = new Font("Jameel Noori Nastaleeq", 9, FontStyle.Regular);

            Brush brush = Brushes.Black;

            Pen pen = new Pen(Color.Black, 2);

            
            int xAxis = 190;
            
            if(currentRow<dataGridView2.Rows.Count-1)
            {

                DataGridViewRow row = dataGridView2.Rows[currentRow];
                

                e.Graphics.DrawString(companyName, headingfont, brush, 70, 17); // Adjust the Y coordinate as needed
                e.Graphics.DrawString("--------------------------------------------", linefont, brush, 20, 30); // Adjust the Y coordinate as needed

                e.Graphics.DrawString(":اکاؤنٹ نمبر", font, brush, xAxis, 60);
                //e.Graphics.DrawString(":نام", font, brush, xAxis, 90);

                e.Graphics.DrawString("--------------------------------------------", linefont, brush, 20, 100);

                e.Graphics.DrawString(":تاریخ", font, brush, 225, 125);
                e.Graphics.DrawString(startDate.ToString("dd/MM/yyyy"), font, brush, 135, 125);
                e.Graphics.DrawString("تا", font, brush, 115, 125);

                e.Graphics.DrawString(endDate.ToString("dd/MM/yyyy"), font, brush, 20, 125);

                e.Graphics.DrawString("--------------------------------------------", linefont, brush, 20, 140);

                e.Graphics.DrawString(":سابقہ بیلنس", font, brush, xAxis, 170);
                e.Graphics.DrawString(":ٹوٹل لیٹر", font, brush, xAxis, 200);
                e.Graphics.DrawString(":دودھ رقم", font, brush, xAxis, 230);
                e.Graphics.DrawString(":ادائیگی رقم", font, brush, xAxis, 290);
                e.Graphics.DrawString(":بیلنس", font, brush, xAxis, 260);

                //e.Graphics.DrawString(startDate.Date.ToString(), font, brush, 160, 130);

                if (row.Cells["Id"].Value != null)
                    e.Graphics.DrawString(row.Cells["Id"].Value.ToString(), font, brush, 150, 60);
                if (row.Cells["Customer Name"].Value != null)
                    e.Graphics.DrawString(row.Cells["Customer Name"].Value.ToString(), font, brush, 20, 90);
                if (row.Cells["Previous Balance"].Value != null)
                    e.Graphics.DrawString(row.Cells["Previous Balance"].Value.ToString(), font, brush, 70, 170);

                // write status in urdu for previous balance
                if (row.Cells["pStatus"].Value != null)
                {
                    string pStatus = row.Cells["pStatus"].Value.ToString();
                    if (pStatus == "Credit")
                    {
                        e.Graphics.DrawString("جمع", font, brush, 40, 170);
                    }
                    else
                    {
                        e.Graphics.DrawString("بنام", font, brush, 40, 170);
                    }
                }

                if (row.Cells["Total Liters"].Value != null)
                    e.Graphics.DrawString(row.Cells["Total Liters"].Value.ToString(), font, brush, 70, 200);
                if (row.Cells["Milk Amount"].Value != null)
                    e.Graphics.DrawString(row.Cells["Milk Amount"].Value.ToString(), font, brush, 70, 230);

                // Calculate the position and size of the text
                float xCoordinate = 70;
                float yCoordinate = 290;

                float textWidth = 0;
                float textHeight = 0;
                if (row.Cells["Parchi Amount"].Value != null)
                {
                    textWidth = e.Graphics.MeasureString(row.Cells["Parchi Amount"].Value.ToString(), font).Width;
                }
                if (row.Cells["Total Liters"].Value != null)
                {
                    textHeight = e.Graphics.MeasureString(row.Cells["Parchi Amount"].Value.ToString(), font).Height;
                }
                    

                // Draw a rectangle around the text
                e.Graphics.DrawRectangle(pen, xCoordinate, yCoordinate, textWidth, textHeight);

                // Draw the text
                if (row.Cells["Parchi Amount"].Value != null)
                    e.Graphics.DrawString(row.Cells["Parchi Amount"].Value.ToString(), font, brush, xCoordinate, yCoordinate);
                if (row.Cells["Closing Balance"].Value != null)
                    e.Graphics.DrawString(row.Cells["Closing Balance"].Value.ToString(), font, brush, 70, 260);

                if (row.Cells["Status"].Value != null)
                {
                    string cStatus = row.Cells["Status"].Value.ToString();
                    if (cStatus == "Credit")
                    {
                        e.Graphics.DrawString("جمع", font, brush, 40, 260);
                    }
                    else
                    {
                        e.Graphics.DrawString("بنام", font, brush, 40, 260);
                    }
                }

                e.Graphics.DrawString("--------------------------------------------", linefont, brush, 20, 310);

                e.Graphics.DrawString("کسی بھی غلط حساب کی صورت میں جلد از جلد", infofont, brush, 16, 340);
                e.Graphics.DrawString("ہم سے رابطہ کریں۔ شکریہ", infofont, brush, 125, 365);

                e.Graphics.DrawString("03346565189 :فون نمبر" + " ", infofont, brush, 125, 395);
                e.Graphics.DrawString("آپ کے تعاون کا شکریہ", infofont, brush, 80, 425);

                currentRow++;

                e.HasMorePages = true;
            }
            else
            {
                currentRow = 0;
                e.HasMorePages=false;
            }



            
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            //printDialog1.Document = printDocument2;

            // Set up event handler only once
            //printDocument2.PrintPage += printDocument2_PrintPage;

            printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 455);//455

            // Create PrintPreviewDialog and assign the document
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument2;

            // Show the print preview dialog
            DialogResult result = printPreviewDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentRow = 0; // Reset rowIndex before printing
                printDocument2.Print();
            }
        }

    }

}
