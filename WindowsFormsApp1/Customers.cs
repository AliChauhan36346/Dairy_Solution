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

        private void cusBtn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_customerName.Text))
            {
                MessageBox.Show("Please add Customer name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txt_creditLimit.Text))
            {
                MessageBox.Show("Please add credit limit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!int.TryParse(txt_dodhiId.Text,out int dodhiId))
            {
                MessageBox.Show("Invalid dodhi Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customers.id = int.Parse(txt_Id.Text.ToString());
            customers.name = txt_customerName.Text;
            customers.address = txt_address.Text;
            customers.dodhiId = dodhiId;
            customers.dodhi = txt_dodhiName.Text;

            decimal rate;
            int creditLimit;

            // for conversion of .text to decimal
            if (decimal.TryParse(txt_rate.Text, out rate))
            {
                customers.rate = rate;
            }
            else
            {
                // Handle the case where the rate textbox contains invalid input
                MessageBox.Show("Invalid rate value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;// for exit
            }

            if (int.TryParse(txt_creditLimit.Text, out creditLimit))
            {
                customers.creditLimit = creditLimit;
            }
            else
            {
                // Handle the case where the credit limit textbox contains invalid input
                MessageBox.Show("Invalid credit limit value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method or handle the error as needed
            }

            customers.saveCustomer(customers);

            customers.showDataInGridView(dataGridView2);

            txt_customerName.Text = "";
            txt_address.Text = "";
            txt_creditLimit.Text = "";
            txt_rate.Text = "";
            txt_dodhiId.Text = "";
            txt_dodhiName.Text = "";

            txt_Id.Text = customers.GetNextAvailableID().ToString();

            txt_customerName.Focus();
        }


        private void Customers_Load(object sender, EventArgs e)
        {
            lstDodhiSuggestions.Visible = false;

            customers.showDataInGridView(dataGridView2);

            txt_Id.Text = customers.GetNextAvailableID().ToString();

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
            if(!int.TryParse(txt_dodhiId.Text,out int dodhiId))
            {
                MessageBox.Show("Invalid dodhi Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customers.id = int.Parse(txt_Id.Text);
            customers.name=txt_customerName.Text;
            customers.address=txt_address.Text;
            customers.dodhiId = dodhiId;
            customers.dodhi = txt_dodhiName.Text;

            decimal rate;
            int creditLimit;

            // for conversion of .text to decimal
            if (decimal.TryParse(txt_rate.Text, out rate))
            {
                customers.rate = rate;
            }
            else
            {
                // Handle the case where the rate textbox contains invalid input
                MessageBox.Show("Invalid rate value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;// for exit
            }

            if (int.TryParse(txt_creditLimit.Text, out creditLimit))
            {
                customers.creditLimit = creditLimit;
            }
            else
            {
                // Handle the case where the credit limit textbox contains invalid input
                MessageBox.Show("Invalid credit limit value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method or handle the error as needed
            }
            // call funtion to update
            customers.updateCustomer(customers);

            //clears the text boxes
            txt_customerName.Text = "";
            txt_address.Text = "";
            txt_dodhiId.Text = "";
            txt_dodhiName.Text = "";
            txt_creditLimit.Text = "";
            txt_rate.Text = "";

            // refresh the id
            txt_Id.Text = customers.GetNextAvailableID().ToString();

            //to update datagridview also
            customers.showDataInGridView(dataGridView2);

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

        
    }
}
