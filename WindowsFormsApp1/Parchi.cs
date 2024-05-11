using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

            rdo_printPreview.Checked = true;

            
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
                                payments.discription = "Parchi   " + startDate.Date.ToString("dd/MM/yyyy") + "  to  " + endDate.Date.ToString("dd/MM/yyyy");
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
            string addres = "چک نمبر 189 گ ب پتلی، ٹوبہ ٹیک سنگھ";

            DateTime startDate = dtm_start.Value.Date;
            DateTime endDate = dtm_end.Value.Date;


            // Set font and brush for drawing
            Font headingfont = new Font("Times New Roman", 18, FontStyle.Bold);
            Font font = new Font("Times New Roman", 13, FontStyle.Regular);
            Font address = new Font("Times New Roman", 12, FontStyle.Regular);
            Font linefont = new Font("Jameel Noori Nastaleeq", 12, FontStyle.Regular);
            Font infofont = new Font("Times New Roman", 11, FontStyle.Regular);
            Font nofont = new Font("Jameel Noori Nastaleeq", 9, FontStyle.Regular);

            Brush brush = Brushes.Black;

            Pen pen = new Pen(Color.Black, 2);

            int horizotalElement = 60;
            
            int xAxis = 60;
            int yAxis = 50;
            
            if(currentRow<dataGridView2.Rows.Count-1)
            {

                //DataGridViewRow row = dataGridView2.Rows[currentRow];
                DataGridViewRow row = new DataGridViewRow();

                // for horizontal printing
                for(int i = 0; i < 3; i++)
                {
                    row = dataGridView2.Rows[currentRow];
                    

                    e.Graphics.DrawString(companyName, headingfont, brush, xAxis, yAxis); // Adjust the Y coordinate as needed
                    yAxis += 35;
                    xAxis -= 40;//15
                    e.Graphics.DrawString(addres, address, brush, xAxis, yAxis);
                    
                    yAxis += 5;//30
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis); // Adjust the Y coordinate as needed
                    xAxis += 160;//175
                    yAxis += 30;//60
                    e.Graphics.DrawString(":اکاؤنٹ نمبر", font, brush, xAxis, yAxis);

                    xAxis -= 50;//125
                    if (row.Cells["Id"].Value != null)
                        e.Graphics.DrawString(row.Cells["Id"].Value.ToString(), font, brush, xAxis, yAxis);

                    xAxis -= 110;//15
                    yAxis += 30;//90
                                //e.Graphics.DrawString(":نام", font, brush, xeAxis, yAxis);
                    if (row.Cells["Customer Name"].Value != null)
                        e.Graphics.DrawString(row.Cells["Customer Name"].Value.ToString(), font, brush, xAxis, yAxis);

                    yAxis += 10;// 100
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis);

                    xAxis += 205;//220
                    yAxis += 25;//125
                    e.Graphics.DrawString(":تاریخ", font, brush, xAxis, yAxis);
                    xAxis -= 90;//115
                    e.Graphics.DrawString(startDate.ToString("dd/MM/yyyy"), font, brush, xAxis, yAxis);
                    xAxis -= 20;//115
                    e.Graphics.DrawString("تا", font, brush, xAxis, yAxis);
                    xAxis -= 95;//20
                    e.Graphics.DrawString(endDate.ToString("dd/MM/yyyy"), font, brush, xAxis, yAxis);

                    yAxis += 15;//140
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis);

                    xAxis += 160;//190
                    yAxis += 30;//170
                    e.Graphics.DrawString(":سابقہ بیلنس", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Previous Balance"].Value != null)
                        e.Graphics.DrawString(row.Cells["Previous Balance"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis -= 30;//40
                    if (row.Cells["pStatus"].Value != null)
                    {
                        string pStatus = row.Cells["pStatus"].Value.ToString();
                        if (pStatus == "Credit")
                        {
                            e.Graphics.DrawString("جمع", font, brush, xAxis, yAxis);
                        }
                        else
                        {
                            e.Graphics.DrawString("بنام", font, brush, xAxis, yAxis);
                        }
                    }

                    xAxis += 150;//190
                    yAxis += 30;//200
                    e.Graphics.DrawString(":ٹوٹل لیٹر", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Total Liters"].Value != null)
                        e.Graphics.DrawString(row.Cells["Total Liters"].Value.ToString(), font, brush, xAxis, yAxis);

                    xAxis += 120;//190
                    yAxis += 30;//230
                    e.Graphics.DrawString(":دودھ رقم", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Milk Amount"].Value != null)
                        e.Graphics.DrawString(row.Cells["Milk Amount"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis += 120;//190
                    yAxis += 30;//260
                    e.Graphics.DrawString(":بیلنس", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Closing Balance"].Value != null)
                        e.Graphics.DrawString(row.Cells["Closing Balance"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis -= 30;//40
                    if (row.Cells["Status"].Value != null)
                    {
                        string cStatus = row.Cells["Status"].Value.ToString();
                        if (cStatus == "Credit")
                        {
                            e.Graphics.DrawString("جمع", font, brush, xAxis, yAxis);
                        }
                        else
                        {
                            e.Graphics.DrawString("بنام", font, brush, xAxis, yAxis);
                        }
                    }
                    xAxis += 150;//190
                    yAxis += 30;//290
                    e.Graphics.DrawString(":ادائیگی رقم", font, brush, xAxis, yAxis);

                    xAxis -= 120;//70
                    float textWidth = 0;
                    float textHeight = 0;
                    if (row.Cells["Parchi Amount"].Value != null)
                    {
                        textWidth = e.Graphics.MeasureString(row.Cells["Parchi Amount"].Value.ToString(), font).Width;
                        textHeight = e.Graphics.MeasureString(row.Cells["Parchi Amount"].Value.ToString(), font).Height;
                    }

                    // Draw a rectangle around the text
                    e.Graphics.DrawRectangle(pen, xAxis, yAxis, textWidth, textHeight);

                    // Draw the text

                    if (row.Cells["Parchi Amount"].Value != null)
                        e.Graphics.DrawString(row.Cells["Parchi Amount"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis -= 40;//20
                    yAxis += 20;//310
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis);
                    xAxis += 5;//25
                    yAxis += 30;//340
                    e.Graphics.DrawString("کسی بھی غلط حساب کی صورت میں جلد از ", infofont, brush, xAxis, yAxis);
                    xAxis += 70;//115
                    yAxis += 25;//365
                    e.Graphics.DrawString("جلد ہم سے رابطہ کریں۔ شکریہ", infofont, brush, xAxis, yAxis);
                    xAxis += 15;//120
                    yAxis += 30;//395
                    e.Graphics.DrawString("03346565189 :فون نمبر" + " ", infofont, brush, xAxis, yAxis);
                    xAxis -= 40;//80
                    yAxis += 30;//425
                    e.Graphics.DrawString("آپ کے تعاون کا شکریہ", infofont, brush, xAxis, yAxis);

                    if(currentRow<dataGridView2.RowCount-1)
                    {
                        currentRow++;
                    }
                    else
                    {
                        break;
                    }    
                    



                    row = dataGridView2.Rows[currentRow];

                    // for vertical
                    yAxis = 585;
                    xAxis = horizotalElement;

                    e.Graphics.DrawString(companyName, headingfont, brush, xAxis, yAxis); // Adjust the Y coordinate as needed
                    yAxis += 35;
                    xAxis -= 40;//15
                    e.Graphics.DrawString(addres, address, brush, xAxis, yAxis);
                    yAxis += 5;//30
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis); // Adjust the Y coordinate as needed
                    xAxis += 160;//175
                    yAxis += 30;//60
                    e.Graphics.DrawString(":اکاؤنٹ نمبر", font, brush, xAxis, yAxis);

                    xAxis -= 50;//125
                    if (row.Cells["Id"].Value != null)
                        e.Graphics.DrawString(row.Cells["Id"].Value.ToString(), font, brush, xAxis, yAxis);

                    xAxis -= 110;//15
                    yAxis += 30;//90
                                //e.Graphics.DrawString(":نام", font, brush, xeAxis, yAxis);
                    if (row.Cells["Customer Name"].Value != null)
                        e.Graphics.DrawString(row.Cells["Customer Name"].Value.ToString(), font, brush, xAxis, yAxis);

                    yAxis += 10;// 100
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis);

                    xAxis += 205;//220
                    yAxis += 25;//125
                    e.Graphics.DrawString(":تاریخ", font, brush, xAxis, yAxis);
                    xAxis -= 90;//115
                    e.Graphics.DrawString(startDate.ToString("dd/MM/yyyy"), font, brush, xAxis, yAxis);
                    xAxis -= 20;//115
                    e.Graphics.DrawString("تا", font, brush, xAxis, yAxis);
                    xAxis -= 95;//20
                    e.Graphics.DrawString(endDate.ToString("dd/MM/yyyy"), font, brush, xAxis, yAxis);

                    yAxis += 15;//140
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis);

                    xAxis += 160;//190
                    yAxis += 30;//170
                    e.Graphics.DrawString(":سابقہ بیلنس", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Previous Balance"].Value != null)
                        e.Graphics.DrawString(row.Cells["Previous Balance"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis -= 30;//40
                    if (row.Cells["pStatus"].Value != null)
                    {
                        string pStatus = row.Cells["pStatus"].Value.ToString();
                        if (pStatus == "Credit")
                        {
                            e.Graphics.DrawString("جمع", font, brush, xAxis, yAxis);
                        }
                        else
                        {
                            e.Graphics.DrawString("بنام", font, brush, xAxis, yAxis);
                        }
                    }

                    xAxis += 150;//190
                    yAxis += 30;//200
                    e.Graphics.DrawString(":ٹوٹل لیٹر", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Total Liters"].Value != null)
                        e.Graphics.DrawString(row.Cells["Total Liters"].Value.ToString(), font, brush, xAxis, yAxis);

                    xAxis += 120;//190
                    yAxis += 30;//230
                    e.Graphics.DrawString(":دودھ رقم", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Milk Amount"].Value != null)
                        e.Graphics.DrawString(row.Cells["Milk Amount"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis += 120;//190
                    yAxis += 30;//260
                    e.Graphics.DrawString(":بیلنس", font, brush, xAxis, yAxis);
                    xAxis -= 120;//70
                    if (row.Cells["Closing Balance"].Value != null)
                        e.Graphics.DrawString(row.Cells["Closing Balance"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis -= 30;//40
                    if (row.Cells["Status"].Value != null)
                    {
                        string cStatus = row.Cells["Status"].Value.ToString();
                        if (cStatus == "Credit")
                        {
                            e.Graphics.DrawString("جمع", font, brush, xAxis, yAxis);
                        }
                        else
                        {
                            e.Graphics.DrawString("بنام", font, brush, xAxis, yAxis);
                        }
                    }
                    xAxis += 150;//190
                    yAxis += 30;//290
                    e.Graphics.DrawString(":ادائیگی رقم", font, brush, xAxis, yAxis);

                    xAxis -= 120;//70
                    textWidth = 0;
                    textHeight = 0;
                    if (row.Cells["Parchi Amount"].Value != null)
                    {
                        textWidth = e.Graphics.MeasureString(row.Cells["Parchi Amount"].Value.ToString(), font).Width;
                        textHeight = e.Graphics.MeasureString(row.Cells["Parchi Amount"].Value.ToString(), font).Height;
                    }

                    // Draw a rectangle around the text
                    e.Graphics.DrawRectangle(pen, xAxis, yAxis, textWidth, textHeight);

                    // Draw the text

                    if (row.Cells["Parchi Amount"].Value != null)
                        e.Graphics.DrawString(row.Cells["Parchi Amount"].Value.ToString(), font, brush, xAxis, yAxis);
                    xAxis -= 40;//20
                    yAxis += 20;//310
                    e.Graphics.DrawString("--------------------------------------------", linefont, brush, xAxis, yAxis);
                    xAxis += 5;//25
                    yAxis += 30;//340
                    e.Graphics.DrawString("کسی بھی غلط حساب کی صورت میں جلد از ", infofont, brush, xAxis, yAxis);
                    xAxis += 70;//115
                    yAxis += 25;//365
                    e.Graphics.DrawString("جلد ہم سے رابطہ کریں۔ شکریہ", infofont, brush, xAxis, yAxis);
                    xAxis += 15;//120
                    yAxis += 30;//395
                    e.Graphics.DrawString("03346565189 :فون نمبر" + " ", infofont, brush, xAxis, yAxis);
                    xAxis -= 40;//80
                    yAxis += 30;//425
                    e.Graphics.DrawString("آپ کے تعاون کا شکریہ", infofont, brush, xAxis, yAxis);

                    if (currentRow < dataGridView2.RowCount - 1)
                    {
                        currentRow++;
                    }
                    else
                    {
                        break;
                    }


                    horizotalElement += 275; // stores the location of colum
                    xAxis = horizotalElement;// moves the row to right side
                    yAxis = 50;
                }

                
                

                

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
            //

            // Set up event handler only once
            //printDocument2.PrintPage += printDocument2_PrintPage;

            //printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 455);//455

            

            if(rdo_printPreview.Checked)
            {
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
            if(rdo_pringDialog.Checked)
            {
                printDialog1.Document = printDocument2;

                // Show the print preview dialog
                DialogResult result = printDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    currentRow = 0; // Reset rowIndex before printing
                    printDocument2.Print();
                }
            }
        }

        private void btn_paymentList_Click(object sender, EventArgs e)
        {
            if(rdo_pringDialog.Checked)
            {
                printDialog2.Document = printDocument1;
                DialogResult result = printDialog2.ShowDialog();

                currentRow = 0; // Reset rowIndex before printing

                totalCredit = 0;
                totalDebit = 0;

                if (result==DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else if(rdo_printPreview.Checked)
            {
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument1;

                // Show the print preview dialog
                DialogResult result = printPreviewDialog.ShowDialog();

                currentRow = 0; // Reset rowIndex before printing

                totalCredit = 0;
                totalDebit = 0;

                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }

            
        }


        bool headerPrinted = false;
        decimal totalCredit=0;
        decimal totalDebit=0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headingFont = new Font("Segoe UI", 28, FontStyle.Bold | FontStyle.Underline);
            Font subHeading = new Font("Segoe UI", 24, FontStyle.Bold);
            Font heading3 = new Font("Segoe UI", 16, FontStyle.Bold | FontStyle.Italic); 
            Font heading4 = new Font("Segoe UI", 12, FontStyle.Bold | FontStyle.Italic); 
            Font detail = new Font("Segoe UI Semibold", 11, FontStyle.Regular); 

            Pen pen = new Pen(Color.Black, 2);
            Brush brush = Brushes.Black;

            


            //heading
            string headingText = "PARCHI PAYMENTS LIST";
            string dodhi;

            //dodhi
            if(chk_dodhiWise.Checked)
            {
                dodhi=(cmbo_dodhi.SelectedItem.ToString().Trim());
            }
            else
            {
                dodhi = "(ALL DODHI)";
            }

            //date
            DateTime startDate = dtm_start.Value.Date;
            DateTime endDate = dtm_end.Value.Date;

            string date = "From Date " + startDate.ToString("dd/MM/yyyy") + "  to  " + endDate.ToString("dd/MM/yyyy");

            int xAxis = 50;
            int yAxis = 215;


            if (!headerPrinted)
            {
                // Calculate the width of the heading text
                SizeF headingSize = e.Graphics.MeasureString(headingText, headingFont);
                SizeF dodhiSize = e.Graphics.MeasureString(dodhi, subHeading);
                SizeF dateSize = e.Graphics.MeasureString(date, heading3);


                // Calculate the X coordinate to center the heading
                float xCenter = (e.PageBounds.Width - headingSize.Width) / 2;
                float dodhiCenter = (e.PageBounds.Width - dodhiSize.Width) / 2;
                float dateCenter = (e.PageBounds.Width - dateSize.Width) / 2;
                // Y coordinate for the heading
                float y = 40;

                // Draw the heading centered horizontally
                e.Graphics.DrawString(headingText, headingFont, brush, xCenter, y);
                y += 60;
                e.Graphics.DrawString(dodhi, subHeading, brush, dodhiCenter, y);
                y += 60;
                e.Graphics.DrawString(date, heading3, brush, dateCenter, y);
                y += 35;
                e.Graphics.DrawLine(pen, 50, y, e.PageBounds.Width - 50, y);

                // Draw a single rectangle around all the text
                
                int rectWidth = 230; // Adjust this as needed

                //int maxWidth = (int)Math.Max(e.Graphics.MeasureString("Account Id", heading4).Width,
                                              //Math.Max(e.Graphics.MeasureString("Account Name", heading4).Width,
                                                      // e.Graphics.MeasureString("Payment Amount", heading4).Width));


                int totalWidth = 3 * rectWidth + 2 * 30; // Total width of all text and spacing
                int rectHeight = (int)heading4.Height; // Height of the text

                // Draw the rectangle around all text
                e.Graphics.DrawRectangle(pen, xAxis, yAxis, totalWidth, rectHeight);

                // Draw the text within the rectangle
                e.Graphics.DrawString("Acc Id", heading4, brush, xAxis, yAxis);
                xAxis += 70;//170
                e.Graphics.DrawString("Name", heading4, brush, xAxis, yAxis);
                xAxis += 190;//570
                e.Graphics.DrawString("pBalance", heading4,brush, xAxis, yAxis);
                xAxis += 125;
                e.Graphics.DrawString("Liters", heading4, brush, xAxis, yAxis);
                xAxis += 80;
                e.Graphics.DrawString("Amount", heading4, brush, xAxis, yAxis);
                xAxis += 90;
                e.Graphics.DrawString("Parchi", heading4, brush, xAxis, yAxis);
                xAxis += 90;
                e.Graphics.DrawString("Balance", heading4, brush, xAxis, yAxis);

                yAxis = 250;//260   
                xAxis = 50;//50

                headerPrinted = true;
            }
            else
            {
                xAxis = 50;
                yAxis = 50;
            }
            

            while (currentRow<dataGridView2.Rows.Count-1)
            {
                DataGridViewRow row = new DataGridViewRow();

                row = dataGridView2.Rows[currentRow];

                e.Graphics.DrawString(row.Cells["Id"].Value.ToString(),detail,brush, xAxis, yAxis);
                xAxis += 70;
                e.Graphics.DrawString(row.Cells["Customer Name"].Value.ToString(),detail,brush, xAxis, yAxis);
                xAxis += 190;
                e.Graphics.DrawString(row.Cells["Previous Balance"].Value.ToString() + " " + row.Cells["pStatus"].Value.ToString(), detail, brush, xAxis, yAxis);
                xAxis += 125;
                e.Graphics.DrawString(row.Cells["Total Liters"].Value.ToString(), detail, brush, xAxis, yAxis);
                xAxis += 80;
                e.Graphics.DrawString(row.Cells["Milk Amount"].Value.ToString(), detail, brush, xAxis, yAxis);
                xAxis += 90;
                e.Graphics.DrawString(row.Cells["Parchi Amount"].Value.ToString(), heading4, brush, xAxis, yAxis);
                xAxis += 90;
                e.Graphics.DrawString(row.Cells["Closing Balance"].Value.ToString()+ " "+ row.Cells["Status"].Value.ToString(), detail, brush, xAxis, yAxis);
                yAxis += 20;

                e.Graphics.DrawLine(pen, 50, yAxis, e.PageBounds.Width - 50, yAxis);


                if (row.Cells["Status"].Value.ToString()=="Credit")
                {
                    totalCredit += decimal.Parse(row.Cells["Closing Balance"].Value.ToString());

                }
                else
                {
                    totalDebit += decimal.Parse(row.Cells["Closing Balance"].Value.ToString());
                }

                xAxis = 50;
                yAxis += 10;

                currentRow++;

                if(yAxis+25>e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    
                    //currentRow++;

                    return;
                }
            }

            xAxis = 300;

            //e.Graphics.DrawLine(pen, 50, yAxis, e.PageBounds.Width - 50, yAxis);
            //yAxis += 5;

            decimal balance = totalCredit - totalDebit;
            string status = balance > 0 ? "Credit" : "Debit";
            balance = Math.Abs(balance);
            balance = Math.Round(balance, 0);

            e.Graphics.DrawString("TOTALS:", heading4, brush, xAxis, yAxis);
            xAxis += 135;
            e.Graphics.DrawString(txt_totalLiters.Text, heading4, brush, xAxis, yAxis);
            xAxis += 80;
            e.Graphics.DrawString(txt_totalLitersAmount.Text, heading4, brush, xAxis, yAxis);
            xAxis += 90;
            e.Graphics.DrawString(txt_totalParchiAmount.Text, heading4, brush, xAxis, yAxis);
            xAxis += 90;
            e.Graphics.DrawString(balance.ToString()+" "+status,heading4,brush, xAxis, yAxis);
            yAxis += 30;
            e.Graphics.DrawLine(pen, 300, yAxis, e.PageBounds.Width - 50, yAxis);

            headerPrinted = false;
            e.HasMorePages = false;
        }
    }

}
