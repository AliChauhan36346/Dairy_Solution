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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Sales : Form
    {
        AddCompanies company = new AddCompanies();
        AddSales sales = new AddSales();
        CommonFunctionsClass commonFunctions= new CommonFunctionsClass();
        DashboardClass dashboard = new DashboardClass();

        public Sales()
        {
            InitializeComponent();
        }

        

        private void salesBtn_newCompany_Click(object sender, EventArgs e)
        {
            Companies companies = new Companies();
            companies.ShowDialog();
        }

        

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            txt_salesId.Text = sales.GetNextAvailableID().ToString();
            sales.showDataInGridView(dataGridView1);
            lstCompanySuggestions.Visible = false;
            lstAccountSuggestions.Visible = false;
            dtm_picker.Value = DateTime.Today;

            txt_cashAccountId.Enabled = false;

            txt_tsStandard.Text = "13";


            getStats();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_id, lstCompanySuggestions, "company");
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            // Hide the suggestion list
            if(!lstCompanySuggestions.Focused)
            {
                lstCompanySuggestions.Visible = false;
            }
            

            txt_rate.Text = company.getcompanyRate(txt_id.Text.ToString()).ToString();
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_id, txt_companyName, lstCompanySuggestions, e);
            if (e.KeyCode == Keys.Enter)
            {
                txt_liters.Focus();
            }
        }

        private void lstCompanySuggestions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstCompanySuggestions.Visible && lstCompanySuggestions.SelectedItem != null)
            {
                string selectedSuggestion = lstCompanySuggestions.SelectedItem.ToString();
                string[] parts = selectedSuggestion.Split(new[] { " - " }, StringSplitOptions.None);

                // Transfer the selected suggestion to the TextBoxes
                txt_companyName.Text = parts[1]; // Name TextBox
                txt_id.Text = parts[0].Trim(); // ID TextBox

                // Hide the suggestion list
                lstCompanySuggestions.Visible = false;

                // Move focus to the next control (Rate TextBox)
                txt_rate.Focus();

                // Prevent the Enter key from being processed further
                
            }
            else
            {
                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_rate_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_liters_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_lr_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_fat_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                txt_amountReceived.Focus();
            }
        }

        private void txt_amountReceived_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;
                if(txt_amountReceived.Text=="")
                {
                    btn_save.Focus();
                }
                else
                {
                    txt_cashAccountId.Focus();
                }
                
                
            }
        }

        private void txt_amountReceived_TextChanged(object sender, EventArgs e)
        {
            // for balance calculation
            txt_cashAccountId.Enabled = true;
            if (!decimal.TryParse(txt_totalAmount.Text, out decimal totalAmount))
            {
                return;
            }

            if (!int.TryParse(txt_amountReceived.Text, out int amountReceived))
            {
                if(txt_amountReceived.Text!="")
                {
                    MessageBox.Show("Invalid amount receive value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_amountReceived.Focus();
                }
                
                return;
            }
            

            decimal balance=totalAmount-amountReceived;

            if(balance<0)
            {
                balance = balance * -1;
            }

            balance=Math.Round(balance,2);

            txt_balance.Text=balance.ToString();
        }

        private void txt_balance_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_totalAmount.Text, out decimal totalAmount))
            {
                return;
            }

            int amountReceived;
            if (!int.TryParse(txt_amountReceived.Text, out amountReceived))
            {
                if (string.IsNullOrEmpty(txt_amountReceived.Text))
                {
                    amountReceived = 0;
                }
                else
                {
                    MessageBox.Show("Invalid amount received value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_amountReceived.Focus();
                    return;
                }
            }

            // Set the text color based on the condition
            if (totalAmount > amountReceived)
            {
                txt_status.Text = "Debit";
                txt_status.ForeColor = Color.Red;
            }
            else
            {
                txt_status.Text = "Credit";
                txt_status.ForeColor = Color.Blue;
            }

            // Make the textbox readonly
            txt_status.ReadOnly = true;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                

                int companyId;
                if (!int.TryParse(txt_id.Text, out companyId))
                {
                    MessageBox.Show("Invalid company ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_companyName.Text))
                {
                    MessageBox.Show("Company name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txt_rate.Text) || !decimal.TryParse(txt_rate.Text, out decimal rate))
                {
                    MessageBox.Show("Invalid rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_rate.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_liters.Text) || !decimal.TryParse(txt_liters.Text, out decimal liters))
                {
                    MessageBox.Show("Invalid liters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_liters.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_lr.Text) || !decimal.TryParse(txt_lr.Text, out decimal lr))
                {
                    MessageBox.Show("Invalid LR value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_lr.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_fat.Text) || !decimal.TryParse(txt_fat.Text, out decimal fat))
                {
                    MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_fat.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_tsStandard.Text) || !int.TryParse(txt_tsStandard.Text, out int tsStandard))
                {
                    MessageBox.Show("Invalid ts standard value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_tsStandard.Focus();
                    return;
                }

                decimal ts = sales.tsCalculator(lr, fat, liters, tsStandard);

                int amountReceived;

                if(txt_amountReceived.Text!="")
                {
                    if (!int.TryParse(txt_amountReceived.Text, out amountReceived))
                    {
                        MessageBox.Show("Invalid amount received value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_amountReceived.Focus();
                        return;
                    }
                }
                else
                {
                    amountReceived = 0;
                }

                int cashAccountId=0;
                if(txt_cashAccountId.Text!="")
                {
                    if (!int.TryParse(txt_cashAccountId.Text, out cashAccountId))
                    {
                        MessageBox.Show("Invalid value. Please enter correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                

                decimal totalAmount = rate * ts;
                decimal balance = totalAmount - amountReceived;

                // Assigning values to sales object
                sales.id = int.Parse(txt_salesId.Text);
                sales.Date = dtm_picker.Value;
                sales.companyId = companyId;
                sales.companyName = txt_companyName.Text;
                sales.rate = rate;
                sales.liters = liters;
                sales.fat = fat;
                sales.lr = lr;
                sales.tsStandard = tsStandard;
                sales.tsLiters = ts;
                sales.salesAmount = totalAmount;
                sales.amountReceived = amountReceived;
                sales.cashAccountId = cashAccountId;
                sales.cashAccountName = txt_cashAccountName.Text;
                sales.salesBalance = balance;

                sales.saveSales(sales);

                // Clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_salesId.Text = sales.GetNextAvailableID().ToString();
                sales.showDataInGridView(dataGridView1);
                txt_id.Focus();
                getStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Get the ID from the textbox
            int id;
            if (!int.TryParse(txt_salesId.Text, out id))
            {
                MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this company?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed with deletion
            if (result == DialogResult.Yes)
            {
                // Call the removeCustomer method with the ID
                sales.removeSales(id);

                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);



                // for refreshing data in gridview after deletion
                sales.showDataInGridView(dataGridView1);
                txt_salesId.Text = sales.GetNextAvailableID().ToString();
                getStats();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Check if there's at least one row in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Check if the selected index is within the bounds of the data
                if (selectedIndex >= 0 && selectedIndex < dataGridView1.RowCount - 1)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Populate text boxes with data from the selected row
                    txt_salesId.Text = selectedRow.Cells["Sales Id"].Value.ToString();
                    txt_id.Text = selectedRow.Cells["Company Id"].Value.ToString();
                    txt_companyName.Text = selectedRow.Cells["Company Name"].Value.ToString();
                    dtm_picker.Value = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                    txt_rate.Text = selectedRow.Cells["Rate"].Value.ToString();
                    txt_liters.Text = selectedRow.Cells["Gross Liters"].Value.ToString();
                    txt_lr.Text = selectedRow.Cells["LR"].Value.ToString();
                    txt_fat.Text = selectedRow.Cells["Fat"].Value.ToString();
                    txt_tsStandard.Text = selectedRow.Cells["Ts Standard"].Value.ToString();
                    txt_tsLiters.Text = selectedRow.Cells["Ts Liters"].Value.ToString();
                    txt_totalAmount.Text = selectedRow.Cells["Amount"].Value.ToString();
                    txt_amountReceived.Text = selectedRow.Cells["Amount Received"].Value.ToString();
                    txt_cashAccountId.Text = selectedRow.Cells["Account Id"].Value.ToString();
                    txt_cashAccountName.Text = selectedRow.Cells["Account Name"].Value.ToString();
                    txt_balance.Text = selectedRow.Cells["Balance"].Value.ToString();
                }
            }
        }

        private void txt_cashAccountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_cashAccountId, lstAccountSuggestions, "cash");
            
        }

        private void txt_cashAccountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_cashAccountId, txt_cashAccountName, lstAccountSuggestions, e);
            if(e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void lstAccountSuggestions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAccountSuggestions.Visible && lstAccountSuggestions.SelectedItem != null)
            {
                string selectedSuggestion = lstAccountSuggestions.SelectedItem.ToString();
                string[] parts = selectedSuggestion.Split(new[] { " - " }, StringSplitOptions.None);

                // Transfer the selected suggestion to the TextBoxes
                txt_cashAccountName.Text = parts[1]; // Name TextBox
                txt_cashAccountId.Text = parts[0].Trim(); // ID TextBox

                // Hide the suggestion list
                lstAccountSuggestions.Visible = false;

                // Move focus to the next control (ID TextBox)
                btn_save.Focus();

            }
            else
            {
                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_cashAccountId_Leave(object sender, EventArgs e)
        {
            if(!lstAccountSuggestions.Focused)
            {
                lstAccountSuggestions.Visible = false;
            }
        }

        private void txt_fat_Leave(object sender, EventArgs e)
        {
            txtFiller(txt_liters, txt_lr, txt_fat, txt_tsStandard, txt_tsLiters);
        }

        private void txt_tsLiters_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_rate.Text) || !decimal.TryParse(txt_rate.Text, out decimal rate))
            {
                MessageBox.Show("Invalid rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_rate.Focus();
                return;
            }
            if(!decimal.TryParse(txt_tsLiters.Text,out decimal tsLiters))
            {
                return;
            }

            decimal totalAmount = tsLiters * rate;

            txt_totalAmount.Text=totalAmount.ToString();
        }

        // for filling and calculating ts liters by validating text boxes
        public void txtFiller(TextBox txtLiters, TextBox txtLr, TextBox txtFat, TextBox txtTs, TextBox txtTsLiters)
        {
            if (string.IsNullOrEmpty(txtLiters.Text) || !decimal.TryParse(txtLiters.Text, out decimal liters))
            {
                
                return;
            }

            if (string.IsNullOrEmpty(txtLr.Text) || !decimal.TryParse(txtLr.Text, out decimal lr))
            {
                
                return;
            }

            if (string.IsNullOrEmpty(txtFat.Text) || !decimal.TryParse(txtFat.Text, out decimal fat))
            {
                
                return;
            }

            if (string.IsNullOrEmpty(txtTs.Text) || !int.TryParse(txtTs.Text, out int tsStandard))
            {
                
                return;
            }

            decimal ts = sales.tsCalculator(lr, fat, liters, tsStandard);

            txtTsLiters.Text = ts.ToString();
        }

        private void txt_liters_Leave(object sender, EventArgs e)
        {
            txtFiller(txt_liters, txt_lr, txt_fat, txt_tsStandard, txt_tsLiters);
        }

        private void txt_lr_Leave(object sender, EventArgs e)
        {
            txtFiller(txt_liters, txt_lr, txt_fat, txt_tsStandard, txt_tsLiters);
        }

        private void txt_tsStandard_Leave(object sender, EventArgs e)
        {
            txtFiller(txt_liters, txt_lr, txt_fat, txt_tsStandard, txt_tsLiters);
        }

        private void btn_newAccount_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.ShowDialog();
        }

        private void txt_amountReceived_Leave(object sender, EventArgs e)
        {
            if(txt_amountReceived.Text!="")
            {
                txt_cashAccountId.Enabled = true;
            }
            else
            {
                txt_cashAccountId.Enabled = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                int companyId;
                if (!int.TryParse(txt_id.Text, out companyId))
                {
                    MessageBox.Show("Invalid company ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_companyName.Text))
                {
                    MessageBox.Show("Company name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txt_rate.Text) || !decimal.TryParse(txt_rate.Text, out decimal rate))
                {
                    MessageBox.Show("Invalid rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_rate.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_liters.Text) || !decimal.TryParse(txt_liters.Text, out decimal liters))
                {
                    MessageBox.Show("Invalid liters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_liters.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_lr.Text) || !decimal.TryParse(txt_lr.Text, out decimal lr))
                {
                    MessageBox.Show("Invalid LR value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_lr.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_fat.Text) || !decimal.TryParse(txt_fat.Text, out decimal fat))
                {
                    MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_fat.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txt_tsStandard.Text) || !int.TryParse(txt_tsStandard.Text, out int tsStandard))
                {
                    MessageBox.Show("Invalid ts standard value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_tsStandard.Focus();
                    return;
                }

                decimal ts = sales.tsCalculator(lr, fat, liters, tsStandard);

                int amountReceived;

                if (txt_amountReceived.Text != "")
                {
                    if (!int.TryParse(txt_amountReceived.Text, out amountReceived))
                    {
                        MessageBox.Show("Invalid amount received value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_amountReceived.Focus();
                        return;
                    }
                }
                else
                {
                    amountReceived = 0;
                }

                int cashAccountId = 0;
                if (txt_cashAccountId.Text != "")
                {
                    if (!int.TryParse(txt_cashAccountId.Text, out cashAccountId))
                    {
                        MessageBox.Show("Invalid value. Please enter correct information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                decimal totalAmount = rate * ts;
                decimal balance = totalAmount - amountReceived;

                // Assigning values to sales object
                sales.id = int.Parse(txt_salesId.Text);
                sales.Date = dtm_picker.Value;
                sales.companyId = companyId;
                sales.companyName = txt_companyName.Text;
                sales.rate = rate;
                sales.liters = liters;
                sales.fat = fat;
                sales.lr = lr;
                sales.tsStandard = tsStandard;
                sales.tsLiters = ts;
                sales.salesAmount = totalAmount;
                sales.amountReceived = amountReceived;
                sales.cashAccountId = cashAccountId;
                sales.cashAccountName = txt_cashAccountName.Text;
                sales.salesBalance = balance;

                sales.updatesales(sales);

                // Clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_salesId.Text = sales.GetNextAvailableID().ToString();
                sales.showDataInGridView(dataGridView1);
                getStats();
                txt_id.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // get the basic info like gross sales and ts sales and stock
        private void getStats()
        {
            DateTime today = DateTime.Now;

            string grosSales;
            string tsSales;
            string grossReceive;
            string lr;
            string fat;

            dashboard.getGrossAndTsSales(out grosSales, out tsSales, today.Date, today.Date);

            dashboard.getAverageLrFat(out grossReceive, out lr, out fat, today.Date, today.Date);

            decimal stock = decimal.Parse(grossReceive) - decimal.Parse(grosSales);
            stock = Math.Round(stock, 2);
            txt_tsSales.Text = tsSales + " Ltrs";
            txt_grossSales.Text = grosSales + " Ltrs";
            txt_stockVolume.Text = stock.ToString() + " Ltrs";
        }
    }


}
