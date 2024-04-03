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
    public partial class Receipts_Form : Form
    {

        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();
        AddReceipts receipts=new AddReceipts();


        public Receipts_Form()
        {
            InitializeComponent();
        }

        

        

        private void btn_newCompany_Click(object sender, EventArgs e)
        {
            Companies companies = new Companies();
            companies.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_accountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAllAccountSuggestions(txt_accountId.Text, lstAccountsSuggestion);
        }

        private void txt_accountId_Leave(object sender, EventArgs e)
        {
            if (!lstAccountsSuggestion.Focused)
            {
                lstAccountsSuggestion.Visible = false;
            }
        }

        private void txt_accountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_accountId, txt_accountName, lstAccountsSuggestion, e);
            if (e.KeyCode == Keys.Enter)
            {
                txt_amount.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void lstAccountsSuggestion_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void Receipts_Form_Load(object sender, EventArgs e)
        {
            txt_receiptId.Text = receipts.GetNextAvailableId().ToString();
            receipts.showDataInGridView(dataGridView1);
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
            commonFunctions.HandleAccountSuggestionKeyDown(txt_cashAccountId, txt_cashAccountName, lstAccountSuggestion, e);

            if (e.KeyCode == Keys.Enter)
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

                receipts.accountId = accountId;
                receipts.accountName = txt_accountName.Text.Trim();
                receipts.date = dtm_picker.Value;
                receipts.amount = amount;
                receipts.discription = txt_discription.Text;
                receipts.cashAccountId = cashAccountId;
                receipts.cashAccountName = txt_cashAccountName.Text;



                receipts.saveReceipts(receipts);

                // clears the text boxes
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_receiptId.Text = receipts.GetNextAvailableId().ToString();
                receipts.showDataInGridView(dataGridView1);

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
                    txt_receiptId.Text = selectedRow.Cells["Id"].Value.ToString();
                    txt_accountId.Text = selectedRow.Cells["Company Id"].Value.ToString();
                    txt_accountName.Text = selectedRow.Cells["Company Name"].Value.ToString();
                    dtm_picker.Value = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                    txt_amount.Text = selectedRow.Cells["Amount"].Value.ToString();
                    txt_discription.Text = selectedRow.Cells["Discription"].Value.ToString();
                    txt_cashAccountId.Text = selectedRow.Cells["Account Id"].Value.ToString();
                    txt_cashAccountName.Text = selectedRow.Cells["Account Name"].Value.ToString();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Get the ID from the textbox
            int id;
            if (!int.TryParse(txt_receiptId.Text, out id))
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
                receipts.removeReceipts(id);

                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);



                // for refreshing data in gridview after deletion
                receipts.showDataInGridView(dataGridView1);
                txt_receiptId.Text = receipts.GetNextAvailableId().ToString();
            }
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            commonFunctions.ClearAllTextBoxes(this);

            // for refreshing data in gridview after deletion
            txt_receiptId.Text = receipts.GetNextAvailableId().ToString();
        }

        private void btn_newAccount_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.ShowDialog();
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

                if (!int.TryParse(txt_receiptId.Text, out int paymentId))
                {
                    MessageBox.Show("Invalid Payment Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // assigning values to emloyee object
                receipts.receiptId = paymentId;
                receipts.accountId = accountId;
                receipts.accountName = txt_accountName.Text.Trim();
                receipts.date = dtm_picker.Value;
                receipts.amount = amount;
                receipts.discription = txt_discription.Text;
                receipts.cashAccountId = cashAccountId;
                receipts.cashAccountName = txt_cashAccountName.Text;

                receipts.updateReceipts(receipts);

                // clears the text boxes
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_receiptId.Text = receipts.GetNextAvailableId().ToString();
                receipts.showDataInGridView(dataGridView1);

                txt_accountId.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
