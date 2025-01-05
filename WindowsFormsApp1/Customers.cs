using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DairyAccounting;


namespace WindowsFormsApp1
{
    public partial class Customers : Form
    {
        AddCustomers customers = new AddCustomers();
        CommonFunctionsClass CommonFunctions = new CommonFunctionsClass(); 
        public Customers()
        {
            InitializeComponent();
        }

        

        private void cusBtn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateCustomerDetails(out AddCustomers customer)
        {
            customer = new AddCustomers();

            // Validate Customer Name
            if (string.IsNullOrEmpty(txt_customerName.Text))
            {
                MessageBox.Show("Please add Customer name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            customer.name = txt_customerName.Text;

            // Validate Credit Limit
            if (!int.TryParse(txt_creditLimit.Text, out int creditLimit))
            {
                MessageBox.Show("Invalid credit limit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            customer.creditLimit = creditLimit;

            // Validate Dodhi ID
            if (!int.TryParse(txt_dodhiId.Text, out int dodhiId))
            {
                MessageBox.Show("Invalid dodhi ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            customer.dodhiId = dodhiId;
            customer.dodhi = txt_dodhiName.Text;

            // Validate Rate
            if (!decimal.TryParse(txt_rate.Text, out decimal rate))
            {
                MessageBox.Show("Invalid rate value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            customer.rate = rate;

            // Validate Address
            customer.address = txt_address.Text;

            // Validate Phone Number
            if (!int.TryParse(txt_phNo.Text, out int phno))
            {
                MessageBox.Show("Invalid installment amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            customer.installmentAdjustment = phno;

            // validate page no 

            if (!int.TryParse(txt_pgNo.Text, out int pgno))
            {
                MessageBox.Show("Invalid khata number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            customer.registerPageNo = pgno;

            // Validate Checkboxes
            if (chk_credit.Checked)
            {
                customer.giveCreditOnParchi = true;
            }
            else
            {
                customer.giveCreditOnParchi=false;
            }

            if (chk_inactiveCus.Checked)
            {
                customer.isActive = false;
            }
            else
            {
                customer.isActive=true;
            }

            


            // Generate ID
            if (!int.TryParse(txt_Id.Text, out int customerId))
            {
                MessageBox.Show("Invalid Customer ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            customer.id = customerId;

            return true; // Validation successful
        }


        private void cusBtn_save_Click(object sender, EventArgs e)
        {
            // Validate customer details
            if (!ValidateCustomerDetails(out AddCustomers customer))
            {
                return; // Exit if validation fails
            }

            // Save customer to the database
            customers.saveCustomer(customer);

            // Update the DataGridView
            customers.showDataInGridView(dataGridView2);

            // Clear input fields
            CommonFunctions.ClearAllTextBoxes(this);

            // Generate the next available ID
            txt_Id.Text = customers.GetNextAvailableID().ToString();

            // Set focus on the name field
            txt_customerName.Focus();
        }



        private void Customers_Load(object sender, EventArgs e)
        {
            lstDodhiSuggestions.Visible = false;

            customers.showDataInGridView(dataGridView2);

            txt_Id.Text = customers.GetNextAvailableID().ToString();

            lstCustomerSuggestions.Visible = false;

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Populate text boxes with data from the selected row
                txt_Id.Text = row.Cells["Id"].Value.ToString();
                txt_customerName.Text = row.Cells["Customer Name"].Value.ToString();
                txt_address.Text = row.Cells["Customer Address"].Value.ToString();
                txt_dodhiId.Text = row.Cells["Dodhi Id"].Value.ToString();
                txt_dodhiName.Text = row.Cells["Dodhi Name"].Value.ToString();
                txt_creditLimit.Text = row.Cells["Credit Limit"].Value.ToString();
                txt_rate.Text = row.Cells["Purchase Rate"].Value.ToString();

                // Populate extra fields
                txt_phNo.Text = row.Cells["Installment Amount"].Value.ToString();
                txt_pgNo.Text = row.Cells["Khata No"].Value.ToString();
                if (row.Cells["Give Credit"].Value != null &&
                    int.TryParse(row.Cells["Give Credit"].Value.ToString(), out int giveCredit))
                {
                    
                    if (giveCredit == 1)
                    {
                        chk_credit.Checked = true;
                    }
                    else
                    {
                        chk_credit.Checked = false;
                    }
                }
                else
                {
                    chk_credit.Checked = false; // Default if invalid or null
                }

                // Safely handle "Is Active" checkbox
                if (row.Cells["IsActive"].Value != null &&
                    int.TryParse(row.Cells["IsActive"].Value.ToString(), out int isActive))
                {
                    if (isActive == 1)
                    {
                        chk_inactiveCus.Checked = false;
                    }
                    else
                    {
                        chk_inactiveCus.Checked=true;
                    }
                }
                else
                {
                    MessageBox.Show("unable to load active or inactive");
                }
            }
        }


        private void cusBtn_addNew_Click(object sender, EventArgs e)
        {
            txt_customerName.Text = "";
            txt_address.Text = "";
            txt_creditLimit.Text = "";
            txt_rate.Text = "";
            txt_dodhiName.Text = "";
            txt_dodhiId.Text = "";

            txt_Id.Text = customers.GetNextAvailableID().ToString();
        }

        private void cusBtn_deleteCustomer_Click(object sender, EventArgs e)
        {
            // Get the ID from the textbox
            int id;
            if (!int.TryParse(txt_Id.Text, out id))
            {
                MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed with deletion
            if (result == DialogResult.Yes)
            {
                // Call the removeCustomer method with the ID
                customers.removeCustomer(id);

                // for refreshing data in gridview after deletion
                customers.showDataInGridView(dataGridView2);
            }


        }

        private void btn_updateRecord_Click(object sender, EventArgs e)
        {
            // Validate customer details
            if (!ValidateCustomerDetails(out AddCustomers customer))
            {
                return; // Exit if validation fails
            }

            // Update the customer record in the database
            customers.updateCustomer(customer);

            // Clear the input fields
            CommonFunctions.ClearAllTextBoxes(this);

            // Generate the next available ID
            txt_Id.Text = customers.GetNextAvailableID().ToString();

            // Refresh the DataGridView
            customers.showDataInGridView(dataGridView2);

            // Set focus back to the name field
            txt_customerName.Focus();
        }


        private void txt_customerName_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_creditLimit_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_dodhiId_TextChanged(object sender, EventArgs e)
        {
            CommonFunctions.ShowAccountSuggestions(txt_dodhiId, lstDodhiSuggestions, "employee");
        }

        private void txt_dodhiId_Leave(object sender, EventArgs e)
        {
            // Hide the suggestion list
            if (!lstDodhiSuggestions.Focused)
            {
                lstDodhiSuggestions.Visible = false;
            }
        }

        private void txt_dodhiId_KeyDown(object sender, KeyEventArgs e)
        {
            CommonFunctions.HandleAccountSuggestionKeyDown(txt_dodhiId, txt_dodhiName, lstDodhiSuggestions, e);
            if(e.KeyCode==Keys.Enter)
            {
                txt_address.Focus();
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {

            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                cusBtn_save.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.ShowDialog();
        }

        private void txt_cusId_TextChanged(object sender, EventArgs e)
        {
            CommonFunctions.ShowAccountSuggestions(txt_cusId, lstCustomerSuggestions, "customer");
        }

        private void txt_cusId_KeyDown(object sender, KeyEventArgs e)
        {
            CommonFunctions.HandleAccountSuggestionKeyDown(txt_cusId, txt_cusName, lstCustomerSuggestions, e);

            if(e.KeyCode==Keys.Enter)
            {
                lstCustomerSuggestions.Visible = false;

                cusBtn_find.Focus();
            }
        }

        private void cusBtn_find_Click(object sender, EventArgs e)
        {
            // Validate the input ID
            if (!int.TryParse(txt_cusId.Text, out int id))
            {
                MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Access the method from another class
            AddCustomers customer = customers.GetCustomerDetail(id);

            // Check if the customer exists
            if (customer != null)
            {
                // Populate the fields with customer details
                txt_Id.Text = customer.id.ToString();
                txt_customerName.Text = customer.name;
                txt_rate.Text = customer.rate.ToString();
                txt_creditLimit.Text = customer.creditLimit.ToString();
                txt_dodhiId.Text = customer.dodhiId.ToString();
                txt_dodhiName.Text = customer.dodhi;
                txt_address.Text = customer.address;
                txt_phNo.Text=customer.installmentAdjustment.ToString();
                if (customer.giveCreditOnParchi)
                {
                    chk_credit.Checked = true;
                }
                else
                {
                    chk_credit.Checked = false;
                }

                if (customer.isActive)
                {
                    chk_inactiveCus.Checked = false;
                }
                else
                {
                    chk_inactiveCus.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_pgNo_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_phNo_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_creditLimit_KeyDown_1(object sender, KeyEventArgs e)
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
    }
}
