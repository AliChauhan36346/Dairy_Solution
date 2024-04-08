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
    public partial class Payments : Form
    {
        AddCustomers customers = new AddCustomers();
        AddPayments payments = new AddPayments();
        AddAccounts accounts = new AddAccounts();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        ParchiClass ParchiClass = new ParchiClass();

        public Payments()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_accountId_TextChanged(object sender, EventArgs e)
        {
            //commonFunctions.ShowAccountSuggestions(txt_accountId, lstAccountsSuggestion, "customer");
            commonFunctions.ShowAllAccountSuggestions(txt_accountId.Text, lstAccountsSuggestion);
        }

        private void txt_accountId_Leave(object sender, EventArgs e)
        {
            if (!lstAccountsSuggestion.Focused)
            {
                lstAccountsSuggestion.Visible = false;
            }

            decimal accountBalance;
            string status;

            if(!int.TryParse(txt_accountId.Text, out int id))
            {

            }

            ParchiClass.GetAccountSummary(out decimal totalDebit,out decimal totalCredit,out accountBalance,out status,id);

            txt_accountBalance.Text=accountBalance.ToString() + " " + status;
        }

        private void txt_accountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_accountId,txt_accountName,lstAccountsSuggestion,e);
            if (e.KeyCode == Keys.Enter)
            {
                txt_amount.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void lstCustomersSuggestion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAccountsSuggestion.Visible && lstAccountsSuggestion.SelectedItem != null)
            {
                string selectedSuggestion = lstAccountsSuggestion.SelectedItem.ToString();
                string[] parts = selectedSuggestion.Split(new[] { " - " }, StringSplitOptions.None);

                // Transfer the selected suggestion to the TextBoxes
                txt_accountName.Text = parts[1]; // Name TextBox
                txt_accountId.Text = parts[0].Trim(); // ID TextBox

                // Hide the suggestion list
                lstAccountsSuggestion.Visible = false;

                // Move focus to the next control (ID TextBox)
                txt_amount.Focus();

            }
            else
            {
                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            txt_paymentId.Text = payments.GetNextAvailableId().ToString();
            payments.showDataInGridView(dataGridView1);
            dtm_picker.Value = DateTime.Today;

            lstAccountsSuggestion.Visible = false;
            lstAccountSuggestion.Visible = false;
            txt_accountId.Focus();
        }

        private void txt_cashAccountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_cashAccountId, lstAccountSuggestion, "cash");

        }

        private void txt_cashAccountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_cashAccountId,txt_cashAccountName, lstAccountSuggestion, e);

            if(e.KeyCode == Keys.Enter)
            {
                txt_discription.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txt_cashAccountId_Leave(object sender, EventArgs e)
        {
            if (!lstAccountsSuggestion.Focused)
            {
                lstAccountSuggestion.Visible = false;
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cashAccountId.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_accountId.Text, out int accountId))
                {

                    MessageBox.Show("Invalid customer Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_accountId.Focus();
                    return;
                }

                if (!decimal.TryParse(txt_amount.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid amount value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_amount.Focus();
                    return;
                }

                if (!int.TryParse(txt_cashAccountId.Text, out int cashAccountId))
                {
                    MessageBox.Show("Invalid cash account Id value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cashAccountId.Focus();
                    return;
                }


                // checking for not null
                if (string.IsNullOrEmpty(txt_accountName.Text))
                {
                    MessageBox.Show("Customer name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // assigning values to emloyee object

                payments.accountId = accountId;
                payments.accountName = txt_accountName.Text.Trim();
                payments.date = dtm_picker.Value;
                payments.amount = amount;
                payments.discription = txt_discription.Text;
                payments.cashAccountId = cashAccountId;
                payments.cashAccountName = txt_cashAccountName.Text;



                payments.savePayments(payments);

                // clears the text boxes
                commonFunctions.ClearAllTextBoxes(this);                

                // Show updated data in grid view
                txt_paymentId.Text = payments.GetNextAvailableId().ToString();
                payments.showDataInGridView(dataGridView1);

                txt_accountId.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_accountId.Text, out int accountId))
                {

                    MessageBox.Show("Invalid customer Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_accountId.Focus();
                    return;
                }

                if (!decimal.TryParse(txt_amount.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid amount value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_amount.Focus();
                    return;
                }

                if (!int.TryParse(txt_cashAccountId.Text, out int cashAccountId))
                {
                    MessageBox.Show("Invalid cash account Id value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cashAccountId.Focus();
                    return;
                }


                // checking for not null
                if (string.IsNullOrEmpty(txt_accountName.Text))
                {
                    MessageBox.Show("Customer name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!int.TryParse(txt_paymentId.Text,out int paymentId))
                {
                    MessageBox.Show("Invalid Payment Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // assigning values to emloyee object
                payments.paymentId = paymentId;
                payments.accountId = accountId;
                payments.accountName = txt_accountName.Text.Trim();
                payments.date = dtm_picker.Value;
                payments.amount = amount;
                payments.discription = txt_discription.Text;
                payments.cashAccountId = cashAccountId;
                payments.cashAccountName = txt_cashAccountName.Text;

                payments.updatepayments(payments);

                // clears the text boxes
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_paymentId.Text = payments.GetNextAvailableId().ToString();
                payments.showDataInGridView(dataGridView1);

                txt_accountId.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txt_paymentId.Text = selectedRow.Cells["Id"].Value.ToString();
                    txt_accountId.Text = selectedRow.Cells["Customer Id"].Value.ToString();
                    txt_accountName.Text = selectedRow.Cells["Customer Name"].Value.ToString();
                    dtm_picker.Value = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                    txt_amount.Text = selectedRow.Cells["Amount"].Value.ToString();
                    txt_discription.Text = selectedRow.Cells["Discription"].Value.ToString();
                    txt_cashAccountId.Text = selectedRow.Cells["Account Id"].Value.ToString();
                    txt_cashAccountName.Text = selectedRow.Cells["Account Name"].Value.ToString();
                }
            }
        }

        private void btn_deleteRecord_Click(object sender, EventArgs e)
        {
            Password password = new Password();

            if (password.ShowDialog() == DialogResult.OK)
            {
                string enteredPassword = password.enteredPassword;

                if (password.IsPasswordCorrect(enteredPassword))
                {

                    int id;
                    if (!int.TryParse(txt_paymentId.Text, out id))
                    {
                        MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Prompt the user for confirmation
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // If the user clicks Yes, proceed with deletion
                    if (result == DialogResult.Yes)
                    {
                        // Call the removeCustomer method with the ID
                        payments.removePayments(id);

                        // clearing all the text boxes for new entries
                        commonFunctions.ClearAllTextBoxes(this);



                        // for refreshing data in gridview after deletion
                        payments.showDataInGridView(dataGridView1);
                        txt_paymentId.Text = payments.GetNextAvailableId().ToString();
                    }



                }
                else
                {
                    MessageBox.Show("Incorrect password. Deletion aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            commonFunctions.ClearAllTextBoxes(this);

            // for refreshing data in gridview after deletion
            txt_paymentId.Text = payments.GetNextAvailableId().ToString();
        }

        private void btn_newAccount_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.ShowDialog();
        }

        private void btn_newCustomer_Click(object sender, EventArgs e)
        {
            Customers customers=new Customers();
            customers.ShowDialog();
        }
    }

}
