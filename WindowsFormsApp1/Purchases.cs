using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class Purchases : Form
    {
        AddCustomers customers = new AddCustomers();// to get customer dodhi and other stuff
        AddPurchases purchases = new AddPurchases(); // to use fucntions like save delete etc
        AddEmployees employees = new AddEmployees();// to get employee name by id
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();// common function accross all forms like search suggestions
        DashboardClass dashboard = new DashboardClass();
        ParchiClass parchi = new ParchiClass();
        private DataTable dataTable = new DataTable();

        public bool isfromOtherForm = false;
        public int purchaseId;

        public Purchases()
        {
            InitializeComponent();
        }

        

        private void btn_newCustomer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            if(!lstCustomersSuggestion.Focused)
            {
                lstCustomersSuggestion.Visible = false;
            }
            

            txt_rate.Text = customers.getCustomerRate(txt_id.Text).ToString();

            txt_dodhiId.Text=customers.GetCustomerDodhiId(txt_id.Text).ToString();


            if (!int.TryParse(txt_id.Text, out int id))
            {
                return;
            }

            parchi.GetAccountSummary(out decimal op, out string os, out decimal td, out decimal tc, out decimal closingBalnce, out string closingStatus, id);
            closingBalnce = Math.Round(closingBalnce, 0);
            textBox1.Text = closingBalnce.ToString() + " " + closingStatus.ToString();

        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
            purchases.showDataInGridView(dataGridView1, dtm_picker.Value.Date);
            lstCustomersSuggestion.Visible = false;
            dtm_picker.Value = DateTime.Today;

            getStats();

            // selecting radio button according to time for more convenience
            // Get the current time
            DateTime currentTime = DateTime.Now;

            
            // disabling morning ltrs, label
            txt_morningLtrs.Enabled = false;
            label8.Enabled = false;

            // envening ltrs and lable
            label16.Enabled = false;
            txt_eveningLtrs.Enabled = false;

            if (isfromOtherForm)
            {
                purchases.getPurchaseRecordDetail(purchaseId, out DateTime date, out int customerId,
                    out string customerName, out decimal liters, out decimal rate, out string time, out int dodhiId,
                    out string dodhiName, out decimal totalAmount);

                txt_purchaseId.Text= purchaseId.ToString();
                dtm_picker.Value= date;
                txt_id.Text=customerId.ToString();
                txt_customerName.Text= customerName.ToString();
                txt_dodhiId.Text= dodhiId.ToString();
                txt_dodhiName.Text = dodhiName;
                txt_rate.Text= rate.ToString();
                txt_totalAmount.Text= totalAmount.ToString();

                if(time=="Morning")
                {
                    // enable morning ltrs 
                    chk_morning.Checked = true;
                    chk_evening.Checked = false;

                    
                    txt_morningLtrs.Text = liters.ToString();
                    
                }
                else
                {

                    chk_evening.Checked = true;
                    chk_morning.Checked = false;

                    // populating evening textbox with liters
                    txt_eveningLtrs.Text = liters.ToString();

                }
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_id,txt_customerName,lstCustomersSuggestion,e);
            if (e.KeyCode == Keys.Enter)
            {

                if(txt_morningLtrs.Enabled)
                {
                    txt_morningLtrs.Focus();
                }
                else
                {
                    txt_eveningLtrs.Focus();
                }

                e.SuppressKeyPress = true;
            }
        }

        private void txt_rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the next control (text box)
                btn_save.Focus();

                // Prevent the Enter key from being processed further
                e.SuppressKeyPress = true;
            }
        }

        private void lstCustomersSuggestion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstCustomersSuggestion.Visible && lstCustomersSuggestion.SelectedItem != null)
            {
                string selectedSuggestion = lstCustomersSuggestion.SelectedItem.ToString();
                string[] parts = selectedSuggestion.Split(new[] { " - " }, StringSplitOptions.None);

                // Transfer the selected suggestion to the TextBoxes
                txt_customerName.Text = parts[1]; // Name TextBox
                txt_id.Text = parts[0].Trim(); // ID TextBox

                // Hide the suggestion list
                lstCustomersSuggestion.Visible = false;

            }
            else
            {
                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_id, lstCustomersSuggestion, "customer");
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_id.Text, out int Id))
                {

                    MessageBox.Show("Invalid customer Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal morningLtrs = 0;
                decimal eveningLtrs = 0;

                // validating morning and evening liters
                if (chk_morning.Checked && chk_evening.Checked)// if both checks are checked
                {
                    // parsing morning liters
                    if (!decimal.TryParse(txt_morningLtrs.Text, out morningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_morningLtrs.Focus();
                        return;
                    }

                    // parsing evening liters
                    if (!decimal.TryParse(txt_eveningLtrs.Text, out eveningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_eveningLtrs.Focus();
                        return;
                    }
                }
                else if (chk_morning.Checked) // if only morning
                {
                    // parsing morning liters
                    if (!decimal.TryParse(txt_morningLtrs.Text, out morningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_morningLtrs.Focus();
                        return;
                    }
                }
                else if (chk_evening.Checked) // if only evening
                {
                    // parsing evening liters
                    if (!decimal.TryParse(txt_eveningLtrs.Text, out eveningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_eveningLtrs.Focus();
                        return;
                    }
                }
                else // if none of the checked
                {
                    MessageBox.Show("Please check morning or evening check box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // parsing rate
                if (!decimal.TryParse(txt_rate.Text, out decimal Rate))
                {
                    MessageBox.Show("Invalid rate value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal morningAmount;
                decimal eveningAmount;

                // checking for not null
                if (string.IsNullOrEmpty(txt_customerName.Text))
                {
                    MessageBox.Show("Please add Dodhi name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string morning = "Morning";
                string evening = "Evening";


                // assigning values to emloyee object
                purchases.purchaseId = int.Parse(txt_purchaseId.Text);
                purchases.customerId = Id;
                purchases.customerName = txt_customerName.Text.Trim();
                purchases.date = dtm_picker.Value;
                purchases.rate = Rate;
                purchases.dodhi = txt_dodhiName.Text;
                purchases.dodhiId = int.Parse(txt_dodhiId.Text);


                if (chk_evening.Checked && chk_morning.Checked)// for both morning evening save
                {
                    morningAmount = morningLtrs * Rate;
                    eveningAmount = eveningLtrs * Rate;

                    if(morningLtrs!=0)
                    {
                        purchases.liters = morningLtrs;
                        purchases.amount = morningAmount;
                        purchases.time = morning;

                        purchases.savepurchase(purchases);
                    }


                    if(eveningLtrs!=0)
                    {
                        purchases.liters = eveningLtrs;
                        purchases.amount = eveningAmount;
                        purchases.time = evening;
                        purchases.purchaseId = purchases.GetNextAvailableId();

                        purchases.savepurchase(purchases);
                    }

                    
                }
                else if (chk_morning.Checked) // for only morning save
                {
                    morningAmount = morningLtrs * Rate;

                    purchases.liters = morningLtrs;
                    purchases.amount = morningAmount;
                    purchases.time = morning;

                    purchases.savepurchase(purchases);
                }
                else // for only evening save
                {
                    eveningAmount = eveningLtrs * Rate;

                    purchases.liters = eveningLtrs;
                    purchases.amount = eveningAmount;
                    purchases.time = evening;

                    purchases.savepurchase(purchases);
                }


                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
                purchases.showDataInGridView(dataGridView1, dtm_picker.Value.Date);
                getStats();
                txt_id.Focus();

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
            if (!int.TryParse(txt_purchaseId.Text, out id))
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
                purchases.removepurchases(id);

                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                getStats();

                // for refreshing data in gridview after deletion
                purchases.showDataInGridView(dataGridView1,dtm_picker.Value.Date);
                txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Check if the selected index is within the bounds of the data
                if (selectedIndex >= 0 && selectedIndex < dataGridView1.RowCount - 1)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    DateTime.TryParse(row.Cells["Date"].Value.ToString(), out DateTime purchaseDate);

                    // Populate text boxes with data from the selected row
                    txt_id.Text = row.Cells["Id"].Value.ToString();
                    dtm_picker.Value = purchaseDate;

                    // check the radio button according to time 
                    if (row.Cells["Time"].Value.ToString().Trim() == "Morning")
                    {
                        chk_morning.Checked = true;
                        chk_evening.Checked = false;

                        txt_morningLtrs.Text = row.Cells["Gross Liters"].Value.ToString();
                    }
                    else
                    {
                        chk_evening.Checked = true;
                        chk_morning.Checked = false;

                        txt_eveningLtrs.Text= row.Cells["Gross Liters"].Value.ToString();
                    }

                    // populating text box 
                    txt_purchaseId.Text = row.Cells["Id"].Value.ToString();
                    txt_customerName.Text = row.Cells["Customer Name"].Value.ToString();
                    txt_id.Text = row.Cells["Customer Id"].Value.ToString();
                    txt_rate.Text = row.Cells["Rate"].Value.ToString();
                    txt_totalAmount.Text = row.Cells["Amount"].Value.ToString();
                    txt_dodhiId.Text = row.Cells["Dodhi Id"].Value.ToString();
                    txt_dodhiName.Text = row.Cells["Dodhi Name"].Value.ToString();
                    dtm_picker.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
                }

            }
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            // clearing all the text boxes for new entries
            commonFunctions.ClearAllTextBoxes(this);

            dtm_picker.Value = DateTime.Today;
            txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_id.Text, out int Id))
                {

                    MessageBox.Show("Invalid customer Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal morningLtrs = 0;
                decimal eveningLtrs = 0;

                // validating morning and evening liters
                if (chk_morning.Checked && chk_evening.Checked)// if both checks are checked
                {
                    // parsing morning liters
                    if (!decimal.TryParse(txt_morningLtrs.Text, out morningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_morningLtrs.Focus();
                        return;
                    }

                    // parsing evening liters
                    if (!decimal.TryParse(txt_eveningLtrs.Text, out eveningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_eveningLtrs.Focus();
                        return;
                    }
                }
                else if (chk_morning.Checked) // if only morning
                {
                    // parsing morning liters
                    if (!decimal.TryParse(txt_morningLtrs.Text, out morningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_morningLtrs.Focus();
                        return;
                    }
                }
                else if (chk_evening.Checked) // if only evening
                {
                    // parsing evening liters
                    if (!decimal.TryParse(txt_eveningLtrs.Text, out eveningLtrs))
                    {
                        MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_eveningLtrs.Focus();
                        return;
                    }
                }
                else // if none of the checked
                {
                    MessageBox.Show("Please check morning or evening check box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




                // parsing rate
                if (!decimal.TryParse(txt_rate.Text, out decimal Rate))
                {
                    MessageBox.Show("Invalid rate value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal morningAmount;
                decimal eveningAmount;

                // checking for not null
                if (string.IsNullOrEmpty(txt_customerName.Text))
                {
                    MessageBox.Show("Please add Dodhi name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string morning = "Morning";
                string evening = "Evening";


                // assigning values to emloyee object
                purchases.purchaseId = int.Parse(txt_purchaseId.Text);
                purchases.customerId = Id;
                purchases.customerName = txt_customerName.Text.Trim();
                purchases.date = dtm_picker.Value;
                purchases.rate = Rate;
                purchases.dodhi = txt_dodhiName.Text;
                purchases.dodhiId = int.Parse(txt_dodhiId.Text);


                if (chk_evening.Checked && chk_morning.Checked)// for both morning evening save
                {
                    MessageBox.Show("Cannot update both morning and evening at same time. Please select one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (chk_morning.Checked) // for only morning save
                {
                    morningAmount = morningLtrs * Rate;

                    purchases.liters = morningLtrs;
                    purchases.amount = morningAmount;
                    purchases.time = morning;

                    purchases.updatepurchases(purchases);
                }
                else // for only evening save
                {
                    eveningAmount = eveningLtrs * Rate;

                    purchases.liters = eveningLtrs;
                    purchases.amount = eveningAmount;
                    purchases.time = evening;

                    purchases.updatepurchases(purchases);
                }


                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
                purchases.showDataInGridView(dataGridView1, dtm_picker.Value.Date);
                getStats();
                txt_id.Focus();

                dtm_picker.Value = DateTime.Today;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_rate_Leave(object sender, EventArgs e)
        {
            decimal rate = 0;
            decimal morningLtrs = 0;
            decimal eveningLtrs = 0;
            decimal totalAmount = 0;
            
            if(!decimal.TryParse(txt_rate.Text, out rate))
            {
                return;
            }

            // validating morning and evening liters
            if (chk_morning.Checked && chk_evening.Checked)// if both checks are checked
            {
                // parsing morning liters
                if (!decimal.TryParse(txt_morningLtrs.Text, out morningLtrs))
                {
                    return;
                }

                // parsing evening liters
                if (!decimal.TryParse(txt_eveningLtrs.Text, out eveningLtrs))
                {
                    return;
                }

                totalAmount = rate * morningLtrs + eveningLtrs;

            }
            else if (chk_morning.Checked) // if only morning
            {
                // parsing morning liters
                if (!decimal.TryParse(txt_morningLtrs.Text, out morningLtrs))
                {
                    MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_morningLtrs.Focus();
                    return;
                }

                totalAmount = rate * morningLtrs;

            }
            else if (chk_evening.Checked) // if only evening
            {
                // parsing evening liters
                if (!decimal.TryParse(txt_eveningLtrs.Text, out eveningLtrs))
                {
                    MessageBox.Show("Invalid Morning Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_eveningLtrs.Focus();
                    return;
                }

                totalAmount = rate * eveningLtrs;
            }

            txt_totalAmount.Text=totalAmount.ToString();
        }

        private void txt_dodhiId_TextChanged(object sender, EventArgs e)
        {
            if(txt_id.Text!="")
            {
                txt_dodhiName.Text = employees.GetDodhiNameById(txt_dodhiId.Text);
            }
            
        }


        private void getStats()
        {
            DateTime today = dtm_picker.Value.Date;

            string grossReceive;
            string totalPurchase;
            string lr;
            string fat;

            dashboard.getAverageLrFat(out grossReceive, out lr, out fat, today.Date, today.Date);
            dashboard.getPurchaseVolume(out totalPurchase, today.Date, today.Date);

            decimal difference = decimal.Parse(grossReceive) - decimal.Parse(totalPurchase);

            txt_totalReceive.Text = grossReceive + " Ltrs";
            txt_totalPurchase.Text = totalPurchase + " Ltrs";
            txt_difference.Text=difference.ToString() + " Ltrs";
            
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txt_purchaseId.Text);
            id--;
            if(id!=0)
            {
                purchases.getPurchaseRecordDetail(id, out DateTime date, out int customerId,
                    out string customerName, out decimal liters, out decimal rate, out string time, out int dodhiId,
                    out string dodhiName, out decimal totalAmount);

                txt_purchaseId.Text = id.ToString();
                if(date.Date>DateTime.MinValue && date.Date<DateTime.MaxValue)
                {
                    dtm_picker.Value = date.Date;
                }
               
                txt_id.Text = customerId.ToString();
                txt_customerName.Text = customerName.ToString();
                txt_dodhiId.Text = dodhiId.ToString();
                txt_dodhiName.Text = dodhiName;
                txt_rate.Text = rate.ToString();
                txt_totalAmount.Text = totalAmount.ToString();

                if (time.Equals("Morning", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Morning radio button as checked
                    chk_morning.Checked = true;
                    chk_evening.Checked = false;

                    txt_morningLtrs.Text = liters.ToString();
                    txt_eveningLtrs.Clear();
                }
                else if (time.Equals("Evening", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Evening radio button as checked
                    chk_morning.Checked = false;
                    chk_evening.Checked = true;

                    txt_eveningLtrs.Text = liters.ToString();
                    txt_morningLtrs.Clear();
                }
            }
            
        }

        private void btn_goForward_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_purchaseId.Text);
            id++;

            if(id<=purchases.getLastRecordId())
            {
                purchases.getPurchaseRecordDetail(id, out DateTime date, out int customerId,
                    out string customerName, out decimal liters, out decimal rate, out string time, out int dodhiId,
                    out string dodhiName, out decimal totalAmount);

                txt_purchaseId.Text = id.ToString();
                if (date.Date > DateTime.MinValue && date.Date < DateTime.MaxValue)
                {
                    dtm_picker.Value = date.Date;
                }
                txt_id.Text = customerId.ToString();
                txt_customerName.Text = customerName.ToString();
                txt_dodhiId.Text = dodhiId.ToString();
                txt_dodhiName.Text = dodhiName;
                txt_rate.Text = rate.ToString();
                txt_totalAmount.Text = totalAmount.ToString();

                if (time.Equals("Morning", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Morning radio button as checked
                    chk_morning.Checked = true;
                    chk_evening.Checked = false;

                    txt_morningLtrs.Text = liters.ToString();
                    txt_eveningLtrs.Clear();
                }
                else if (time.Equals("Evening", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Evening radio button as checked
                    chk_morning.Checked = false;
                    chk_evening.Checked = true;

                    txt_eveningLtrs.Text = liters.ToString();
                    txt_morningLtrs.Clear();
                }
            }

            
        }

        private void dtm_picker_ValueChanged(object sender, EventArgs e)
        {
            purchases.showDataInGridView(dataGridView1, dtm_picker.Value.Date);
            getStats();
        }

        private void chk_morning_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_morning.Checked)
            {
                label8.Enabled = true;
                txt_morningLtrs.Enabled = true;
            }
            else
            {
                txt_morningLtrs.Enabled = false;
                label8.Enabled = false;
            }
        }

        private void chk_evening_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_evening.Checked)
            {
                txt_eveningLtrs.Enabled=true;
                label16.Enabled= true;
            }
            else
            {
                label16.Enabled = false;
                txt_eveningLtrs.Enabled = false;
            }
        }

        private void txt_morningLtrs_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(txt_eveningLtrs.Enabled)
                {
                    txt_eveningLtrs.Focus();
                }
                else
                {
                    btn_save.Focus();
                }

                e.SuppressKeyPress = true;
            }
        }

        private void txt_eveningLtrs_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                btn_save.Focus();

                e.SuppressKeyPress = true;
            }
        }

        decimal totalAmount = 0;

        private void txt_morningLtrs_Leave(object sender, EventArgs e)
        {
            decimal rate = 0;
            decimal morningLtrs = 0;
            

            if (!decimal.TryParse(txt_rate.Text, out rate))
            {
                return;
            }

            // validating morning and evening liters
            
            // parsing morning liters
            if (!decimal.TryParse(txt_morningLtrs.Text, out morningLtrs))
            {
                return;
            }

            totalAmount += rate * morningLtrs;

            txt_totalAmount.Text = totalAmount.ToString();
        }

        private void txt_eveningLtrs_Leave(object sender, EventArgs e)
        {
            decimal rate = 0;
            decimal eveningLtrs = 0;


            if (!decimal.TryParse(txt_rate.Text, out rate))
            {
                return;
            }

            // parsing morning liters
            if (!decimal.TryParse(txt_eveningLtrs.Text, out eveningLtrs))
            {
                return;
            }

            totalAmount += rate * eveningLtrs;

            txt_totalAmount.Text = totalAmount.ToString();
        }

        private void txt_datagridId_TextChanged(object sender, EventArgs e)
        {
            //commonFunctions.ShowAccountSuggestions(txt_datagridId, lstCustomersSuggestion, "customer");

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Customer Name] LIKE '%" + txt_datagridId.Text.Trim() + "%'");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
