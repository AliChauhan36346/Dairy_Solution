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

        public bool isfromOtherForm = false;
        public int purchaseId;

        public Purchases()
        {
            InitializeComponent();
        }

        

        private void btn_cashPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.ShowDialog();
            this.Close();
        }

        private void btn_newCustomer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
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

            decimal accountBalance;
            string status;

            if (!int.TryParse(txt_id.Text, out int id))
            {

            }

            commonFunctions.GetAccountSummary(out decimal totalDebit, out decimal totalCredit, out accountBalance, out status, id);

            txt_accountBalance.Text = accountBalance.ToString() + " " + status;



        }

        private void Purchases_Load(object sender, EventArgs e)
        {
            txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
            purchases.showDataInGridView(dataGridView1);
            lstCustomersSuggestion.Visible = false;
            dtm_picker.Value = DateTime.Today;

            getStats();

            // selecting radio button according to time for more convenience
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Check if the current time is before 12 PM (noon)
            if (currentTime.Hour < 15)
            {
                // Set the Morning radio button as checked
                rdo_morning.Checked = true;
            }
            else
            {
                // Set the Evening radio button as checked
                rdo_evening.Checked = true;
            }

            if(isfromOtherForm)
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
                txt_liters.Text= liters.ToString();
                txt_totalAmount.Text= totalAmount.ToString();

                if(time=="Morning")
                {
                    rdo_morning.Checked = true;
                }
                else
                {
                    rdo_evening.Checked = true;
                }
            }
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_id,txt_customerName,lstCustomersSuggestion,e);
            if (e.KeyCode == Keys.Enter)
            {
                txt_liters.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_liters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Move focus to the next control (text box)
                txt_rate.Focus();

                // Prevent the Enter key from being processed further
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
                txt_id.Text = parts[0].Substring(3); // ID TextBox

                // Hide the suggestion list
                lstCustomersSuggestion.Visible = false;

                // Move focus to the next control (ID TextBox)
                txt_liters.Focus();

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
                if(!int.TryParse(txt_id.Text, out int Id))
                {
                    
                    MessageBox.Show("Invalid customer Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!decimal.TryParse(txt_liters.Text, out decimal Liters))
                {
                    MessageBox.Show("Invalid Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!decimal.TryParse(txt_rate.Text, out decimal Rate))
                {
                    MessageBox.Show("Invalid rate value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                decimal amount = Rate * Liters;


                // assigning time according to radio button selected
                if (rdo_morning.Checked)
                {
                    purchases.time = "Morning";
                }
                else if (rdo_evening.Checked)
                {
                    purchases.time = "Evening";
                }
                else
                {
                    MessageBox.Show("Please select a time slot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // checking for not null
                if (string.IsNullOrEmpty(txt_customerName.Text))
                {
                    MessageBox.Show("Please add Dodhi name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // assigning values to emloyee object
                purchases.purchaseId=int.Parse(txt_purchaseId.Text);
                purchases.customerId = Id;
                purchases.customerName = txt_customerName.Text.Trim();
                purchases.date = dtm_picker.Value;
                purchases.liters = Liters;
                purchases.rate = Rate;
                purchases.dodhi = txt_dodhiName.Text;
                purchases.dodhiId = int.Parse(txt_dodhiId.Text);
                purchases.amount = amount;


                purchases.savepurchase(purchases);


                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
                purchases.showDataInGridView(dataGridView1);
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
                purchases.showDataInGridView(dataGridView1);
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
                        //rdo_evening.Checked = false;
                        rdo_morning.Checked = true;


                    }
                    else
                    {
                        //rdo_morning.Checked= false;
                        rdo_evening.Checked = true;
                    }

                    // populating text box 
                    txt_purchaseId.Text = row.Cells["Id"].Value.ToString();
                    txt_customerName.Text = row.Cells["Customer Name"].Value.ToString();
                    txt_id.Text = row.Cells["Customer Id"].Value.ToString();
                    txt_liters.Text = row.Cells["Gross Liters"].Value.ToString();
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

                if (!decimal.TryParse(txt_liters.Text, out decimal Liters))
                {
                    MessageBox.Show("Invalid Liters value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txt_rate.Text, out decimal Rate))
                {
                    MessageBox.Show("Invalid rate value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                decimal amount = Liters* Rate;


                // assigning time according to radio button selected
                if (rdo_morning.Checked)
                {
                    purchases.time = "Morning";
                }
                else if (rdo_evening.Checked)
                {
                    purchases.time = "Evening";
                }
                else
                {
                    MessageBox.Show("Please select a time slot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // checking for not null
                if (string.IsNullOrEmpty(txt_customerName.Text))
                {
                    MessageBox.Show("Please add Dodhi name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txt_liters.Text, out decimal grossLiters))
                {
                    MessageBox.Show("Invalid gross liters value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // assigning values to purchases object
                purchases.purchaseId = int.Parse(txt_purchaseId.Text);
                purchases.customerId = Id;
                purchases.customerName = txt_customerName.Text.Trim();
                purchases.date = dtm_picker.Value;
                purchases.dodhiId = int.Parse(txt_dodhiId.Text);
                purchases.dodhi = txt_dodhiName.Text;
                purchases.liters = Liters;
                purchases.rate = Rate;
                purchases.amount = amount;


                purchases.updatepurchases(purchases);


                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_purchaseId.Text = purchases.GetNextAvailableId().ToString();
                purchases.showDataInGridView(dataGridView1);

                dtm_picker.Value = DateTime.Today;
                getStats();
                txt_id.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_liters_Leave(object sender, EventArgs e)
        {
            decimal rate = 0;
            decimal liters = 0;

            if (!decimal.TryParse(txt_liters.Text, out liters))
            {

            }
            if (!decimal.TryParse(txt_rate.Text, out rate))
            {

            }

            decimal totalAmount = rate * liters;
            txt_totalAmount.Text = totalAmount.ToString();

        }

        private void txt_rate_Leave(object sender, EventArgs e)
        {
            decimal rate = 0;
            decimal liters = 0;

            if(!decimal.TryParse(txt_liters.Text, out liters))
            {

            }
            if(!decimal.TryParse(txt_rate.Text, out rate))
            {

            }

            decimal totalAmount = rate * liters;
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
            DateTime today = DateTime.Now;

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
                txt_liters.Text = liters.ToString();
                txt_totalAmount.Text = totalAmount.ToString();

                if (time.Equals("Morning", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Morning radio button as checked
                    rdo_morning.Checked = true;
                    rdo_evening.Checked = false;
                }
                else if (time.Equals("Evening", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Evening radio button as checked
                    rdo_evening.Checked = true;
                    rdo_morning.Checked = false;
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
                txt_liters.Text = liters.ToString();
                txt_totalAmount.Text = totalAmount.ToString();

                if (time.Equals("Morning", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Morning radio button as checked
                    rdo_morning.Checked = true;
                    rdo_evening.Checked = false;
                }
                else if (time.Equals("Evening", StringComparison.OrdinalIgnoreCase))
                {
                    // Set the Evening radio button as checked
                    rdo_evening.Checked = true;
                    rdo_morning.Checked = false;
                }
            }

            
        }
    }
}
