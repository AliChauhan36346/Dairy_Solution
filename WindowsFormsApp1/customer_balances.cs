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
    public partial class customer_balances : Form
    {
        AddEmployees employees = new AddEmployees();
        AddCustomers customers = new AddCustomers();
        ParchiClass parchi = new ParchiClass();


        decimal grandTotalDebit = 0;
        decimal grandTotalCredit = 0;
        decimal grandBalance = 0;
        string grandStatus = "";

        decimal grandOpeningBalance = 0;
        string grandOpeningStatus = "";

        public customer_balances()
        {
            InitializeComponent();
        }

       

        private void Btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customer_balances_Load(object sender, EventArgs e)
        {
            cmbo_addressWise.Enabled = false;
            cmbo_dodhiWise.Enabled = false;

            //populating dodhi combo box with dodhi names
            List<string> employee=new List<string>();

            employee=employees.GetDodhiNames();

            foreach(string employeeName in employee)
            {
                cmbo_dodhiWise.Items.Add(employeeName);
            }

            //populating address combo box with customers addresses
            List<string> addresses=new List<string>();
            addresses = customers.getCustomersAddress();

            foreach(string address in addresses)
            {
                cmbo_addressWise.Items.Add(address);
            }


            parchi.getAllAccountsBalances(-1, false, dataGridView2, out grandTotalDebit, out grandTotalCredit, out grandOpeningBalance, out grandOpeningStatus);

            grandBalance = grandTotalCredit - grandTotalDebit;
            grandBalance += grandOpeningBalance;
            grandStatus = grandBalance > 0 ? "Credit" : "Debit";
            grandBalance = Math.Abs(grandBalance);
            grandOpeningBalance = Math.Abs(grandOpeningBalance);

            txt_debit.Text = grandTotalDebit.ToString();
            txt_credit.Text = grandTotalCredit.ToString();
            txt_balance.Text = grandBalance.ToString() + "  " + grandStatus;
            txt_grandOpeningBalance.Text = grandOpeningBalance.ToString() + "  " + grandOpeningStatus.ToString();
        }

        private void chk_dodhiWise_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_dodhiWise.Checked)
            {
                cmbo_dodhiWise.Enabled=true;
                chk_addressWise.Checked = false;
            }
            else
            {
                cmbo_dodhiWise.Enabled = false;
            }
        }

        private void chk_addressWise_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_addressWise.Checked)
            {
                cmbo_addressWise.Enabled = true;
                chk_dodhiWise.Checked = false;
            }
            else
            {
                cmbo_addressWise.Enabled = false;
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            

            if(chk_dodhiWise.Checked)
            {
                if(cmbo_dodhiWise.SelectedItem!= null)
                {
                    int dohdiId=employees.getDodhiIdByName(cmbo_dodhiWise.SelectedItem.ToString());

                    parchi.getAllAccountsBalances(dohdiId,false, dataGridView2, out grandTotalDebit, out grandTotalCredit, out grandOpeningBalance, out grandOpeningStatus);
                }
                else
                {
                    MessageBox.Show("Please select a dodhi from list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(chk_addressWise.Checked)
            {
                // for future use
                parchi.getAllAccountsBalances(-1, false, dataGridView2, out grandTotalDebit, out grandTotalCredit, out grandOpeningBalance, out grandOpeningStatus);
            }
            else
            {
                parchi.getAllAccountsBalances(-1, false, dataGridView2, out grandTotalDebit, out grandTotalCredit, out grandOpeningBalance, out grandOpeningStatus);
            }

            grandBalance = grandTotalCredit - grandTotalDebit;
            grandBalance += grandOpeningBalance;
            grandStatus = grandBalance > 0 ? "Credit" : "Debit";
            grandBalance = Math.Abs(grandBalance);
            grandOpeningBalance = Math.Abs(grandOpeningBalance);

            txt_debit.Text=grandTotalDebit.ToString();
            txt_credit.Text=grandTotalCredit.ToString();
            txt_grandOpeningBalance.Text=grandOpeningBalance.ToString()+"  "+grandOpeningStatus.ToString();
            txt_balance.Text=grandBalance.ToString()+"  "+grandStatus;


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
                    int accountId = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                    string accountName = selectedRow.Cells["Account Name"].Value.ToString();

                    legers leger = new legers();
                    leger.isFromOtherForm= true;
                    leger.accountId = accountId;
                    leger.accountName = accountName;

                    leger.ShowDialog();
                   
                }
            }
        }

        bool headerPrinted = false;
        int currentRow = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headingFont = new Font("Segoe UI", 28, FontStyle.Bold | FontStyle.Underline);
            Font subHeading = new Font("Segoe UI", 24, FontStyle.Bold);
            Font heading4 = new Font("Segoe UI", 12, FontStyle.Bold | FontStyle.Italic);
            Font detail = new Font("Segoe UI Semibold", 10, FontStyle.Regular);
            Font name = new Font("Segoe UI Semibold", 9, FontStyle.Regular);

            Pen pen = new Pen(Color.Black, 1);
            Brush brush = Brushes.Black;

            // Heading
            string headingText = "Customers Balance";
            string dodhi;

            // Dodhi
            if (chk_dodhiWise.Checked)
            {
                if (cmbo_dodhiWise.SelectedItem != null)
                {
                    dodhi = (cmbo_dodhiWise.SelectedItem.ToString().Trim());
                }
                else
                {
                    return;
                }
            }
            else
            {
                dodhi = "(ALL DODHI)";
            }

            int xAxis = 50;
            int yAxis = 215;

            if (!headerPrinted)
            {
                // Calculate the width of the heading text
                SizeF headingSize = e.Graphics.MeasureString(headingText, headingFont);
                SizeF dodhiSize = e.Graphics.MeasureString(dodhi, subHeading);

                // Calculate the X coordinate to center the heading
                float xCenter = (e.PageBounds.Width - headingSize.Width) / 2;
                float dodhiCenter = (e.PageBounds.Width - dodhiSize.Width) / 2;

                // Y coordinate for the heading
                float y = 40;

                // Draw the heading centered horizontally
                e.Graphics.DrawString(headingText, headingFont, brush, xCenter, y);
                y += 60;
                e.Graphics.DrawString(dodhi, subHeading, brush, dodhiCenter, y);

                y += 70;
                e.Graphics.DrawString("Document Printed on " + DateTime.Today.ToString(), heading4, brush, 50, y);

                y += 25;
                e.Graphics.DrawLine(pen, 50, y, e.PageBounds.Width - 50, y);

                // Draw the rectangle and headers
                int rectWidth = 230;
                int totalWidth = 3 * rectWidth + 2 * 30; // Total width of all text and spacing
                int rectHeight = (int)heading4.Height; // Height of the text

                // Draw the rectangle around all text
                e.Graphics.DrawRectangle(pen, xAxis, yAxis, totalWidth, rectHeight);

                // Draw the text within the rectangle
                e.Graphics.DrawString("Acc Id", heading4, brush, xAxis, yAxis);
                xAxis += 65;
                e.Graphics.DrawString("Customer Name", heading4, brush, xAxis, yAxis);
                xAxis += 190;
                e.Graphics.DrawString("Opening Balance", heading4, brush, xAxis, yAxis);
                xAxis += 180;
                e.Graphics.DrawString("Debit", heading4, brush, xAxis, yAxis);
                xAxis += 90;
                e.Graphics.DrawString("Credit", heading4, brush, xAxis, yAxis);
                xAxis += 90;
                e.Graphics.DrawString("Closing Balance", heading4, brush, xAxis, yAxis);

                yAxis = 250;
                xAxis = 50;

                headerPrinted = true;
            }
            else
            {
                xAxis = 50;
                yAxis = 50;
            }

            while (currentRow < dataGridView2.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView2.Rows[currentRow];

                e.Graphics.DrawString(row.Cells["Id"].Value.ToString(), detail, brush, xAxis, yAxis);
                xAxis += 65;
                e.Graphics.DrawString(row.Cells["Account Name"].Value.ToString(), name, brush, xAxis, yAxis);
                xAxis += 190;

                // Measure the widths and adjust positions for right alignment
                string openingBalanceText = row.Cells["Opening Balance"].Value.ToString() + " " + row.Cells["oStatus"].Value.ToString();
                float openingBalanceWidth = e.Graphics.MeasureString(openingBalanceText, detail).Width;
                e.Graphics.DrawString(openingBalanceText, name, brush, xAxis + 150 - openingBalanceWidth, yAxis);
                xAxis += 180;

                string debitText = row.Cells["Debit"].Value.ToString();
                float debitWidth = e.Graphics.MeasureString(debitText, detail).Width;
                e.Graphics.DrawString(debitText, name, brush, xAxis + 55 - debitWidth, yAxis);
                xAxis += 90;

                string creditText = row.Cells["Credit"].Value.ToString();
                float creditWidth = e.Graphics.MeasureString(creditText, detail).Width;
                e.Graphics.DrawString(creditText, name, brush, xAxis + 60 - creditWidth, yAxis);
                xAxis += 90;

                string closingBalanceText = row.Cells["Closing Balance"].Value.ToString() + " " + row.Cells["Status"].Value.ToString();
                float closingBalanceWidth = e.Graphics.MeasureString(closingBalanceText, detail).Width;
                e.Graphics.DrawString(closingBalanceText, name, brush, xAxis + 140 - closingBalanceWidth, yAxis);
                yAxis += 20;

                e.Graphics.DrawLine(pen, 50, yAxis, e.PageBounds.Width - 50, yAxis);

                xAxis = 50;
                yAxis += 10;

                currentRow++;

                if (yAxis + 25 > e.MarginBounds.Bottom + 80)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            xAxis = 200;
            yAxis += 1;
            e.Graphics.DrawLine(pen, 220, yAxis, e.PageBounds.Width - 50, yAxis);
            yAxis += 6;
            // Totals section
            e.Graphics.DrawString("TOTALS:", heading4, brush, xAxis+30, yAxis);
            xAxis += 125;

            string grandOpeningBalanceText = txt_grandOpeningBalance.Text;
            float grandOpeningBalanceWidth = e.Graphics.MeasureString(grandOpeningBalanceText, heading4).Width;
            e.Graphics.DrawString(grandOpeningBalanceText, detail, brush, xAxis + 150 - grandOpeningBalanceWidth, yAxis);
            xAxis += 180;

            string debitTotalText = txt_debit.Text;
            float debitTotalWidth = e.Graphics.MeasureString(debitTotalText, heading4).Width;
            e.Graphics.DrawString(debitTotalText, detail, brush, xAxis + 55 - debitTotalWidth, yAxis);
            xAxis += 90;

            string creditTotalText = txt_credit.Text;
            float creditTotalWidth = e.Graphics.MeasureString(creditTotalText, heading4).Width;
            e.Graphics.DrawString(creditTotalText, detail, brush, xAxis + 60 - creditTotalWidth, yAxis);
            xAxis += 90;

            string balanceTotalText = txt_balance.Text;
            float balanceTotalWidth = e.Graphics.MeasureString(balanceTotalText, heading4).Width;
            e.Graphics.DrawString(balanceTotalText, detail, brush, xAxis + 150 - balanceTotalWidth, yAxis);

            yAxis += 22;
            e.Graphics.DrawLine(pen, 220, yAxis, e.PageBounds.Width - 50, yAxis);

            headerPrinted = false;
            e.HasMorePages = false;
        }


        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument1;

            // Show the print preview dialog
            DialogResult result = printPreviewDialog.ShowDialog();

            currentRow = 0; // Reset rowIndex before printing

            

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
