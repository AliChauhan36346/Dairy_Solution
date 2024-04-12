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
    public partial class expenseGeneral : Form
    {
        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();
        AddExpenses expense = new AddExpenses();

        public expenseGeneral()
        {
            InitializeComponent();
        }

        private void btn_cashPayment_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.ShowDialog();
            this.Close();
        }

        private void btn_addPurchase_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.ShowDialog();
            this.Close();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expenseGeneral_Load(object sender, EventArgs e)
        {
            txt_employeeId.Enabled= false;
            txt_employeeName.Enabled= false;

            lstCashAccountSuggestions.Visible= false;
            lstEmployeeSuggestions.Visible = false;
            txt_expenseId.Text = expense.GetNextAvailableId().ToString();
            expense.showDataInGridView(dataGridView2,dtTm_date.Value.Date);
        }

        private void combo_expenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combo_expenseType.Text=="Labour")
            {
                txt_employeeName.Enabled = true;
                txt_employeeId.Enabled = true;
            }
            else
            {
                txt_employeeName.Enabled = false;
                txt_employeeId.Enabled = false;
            }
        }

        private void txt_cashAccountId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_cashAccountId, lstCashAccountSuggestions, "cash");

        }

        private void txt_cashAccountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_cashAccountId, txt_cashAccountName,lstCashAccountSuggestions, e);

            if(e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;

                combo_expenseType.Focus();
            }
        }

        private void txt_cashAccountId_Leave(object sender, EventArgs e)
        {
            if (!lstCashAccountSuggestions.Focused)
            {
                lstCashAccountSuggestions.Visible = false;
            }
            
        }

        private void combo_expenseType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress=true;

                txt_amount.Focus();
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txt_discription.Focus();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txt_cashAccountId.Text, out int cashAccountId))
                {

                    MessageBox.Show("Invalid customer Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_cashAccountId.Focus();
                    return;
                }

                if (!decimal.TryParse(txt_amount.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid amount value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_amount.Focus();
                    return;
                }

                string expenseType;
                // checking for not null
                if (combo_expenseType.SelectedItem != null)
                {
                    expenseType=combo_expenseType.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Please select expense type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    combo_expenseType.Focus();
                    return;
                }

                int employeeId = 0;
                if(combo_expenseType.Text=="Labour")
                {
                    if (!int.TryParse(txt_employeeId.Text, out employeeId))
                    {
                        MessageBox.Show("Invalid employee Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_employeeId.Focus();
                        return;
                    }
                }

                




                // assigning values to emloyee object
                expense.expenseId = int.Parse(txt_expenseId.Text);
                expense.date = dtTm_date.Value;
                expense.cashAccountId = cashAccountId;
                expense.cashAccountName = txt_cashAccountName.Text;
                expense.expenseType = expenseType;
                expense.amount = amount;
                expense.discription=txt_discription.Text;
                expense.employeeId = employeeId;
                expense.employeeName = txt_employeeName.Text;



                expense.saveExpense(expense);

                // clears the text boxes
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_expenseId.Text = expense.GetNextAvailableId().ToString();
                expense.showDataInGridView(dataGridView2,dtTm_date.Value.Date);

                txt_cashAccountId.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_employeeId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_employeeId, lstEmployeeSuggestions, "employee");
        }

        private void txt_employeeId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_employeeId, txt_employeeName, lstEmployeeSuggestions, e);

            if(e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
            }
        }

        private void dtTm_date_ValueChanged(object sender, EventArgs e)
        {
            expense.showDataInGridView(dataGridView2, dtTm_date.Value.Date);
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            commonFunctions.ClearAllTextBoxes(this);

            txt_cashAccountId.Focus();
        }

        private void btn_deleteRecord_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_expenseId.Text, out id))
            {
                MessageBox.Show("Invalid expense Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed with deletion
            if (result == DialogResult.Yes)
            {
                // Call the removeCustomer method with the ID
                expense.removeExpenses(id);

                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);



                // for refreshing data in gridview after deletion
                expense.showDataInGridView(dataGridView2,dtTm_date.Value.Date);
                txt_expenseId.Text = expense.GetNextAvailableId().ToString();
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView2.SelectedRows[0].Index;

                // Check if the selected index is within the bounds of the data
                if (selectedIndex >= 0 && selectedIndex < dataGridView2.RowCount)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                    // Populate text boxes with data from the selected row
                    txt_expenseId.Text = selectedRow.Cells["Id"].Value.ToString();
                    dtTm_date.Value = DateTime.Parse(selectedRow.Cells["Date"].Value.ToString());
                    txt_cashAccountId.Text = selectedRow.Cells["Cash Id"].Value.ToString();
                    txt_cashAccountName.Text = selectedRow.Cells["Cash Account Name"].Value.ToString();
                    txt_amount.Text = selectedRow.Cells["Amount"].Value.ToString();
                    txt_discription.Text = selectedRow.Cells["Description"].Value.ToString();
                    txt_employeeId.Text = selectedRow.Cells["Employee Id"].Value.ToString();
                    txt_employeeName.Text = selectedRow.Cells["Employee Name"].Value.ToString();

                    string expenseT = selectedRow.Cells["Expense Type"].Value.ToString().Trim();
                    int index = 0;
                    foreach (string type in combo_expenseType.Items)
                    {
                        if (type.Trim().Equals(expenseT, StringComparison.OrdinalIgnoreCase))
                        {
                            combo_expenseType.SelectedIndex = index;
                            break; // Exit the loop once a match is found
                        }
                        index++; // Increment index after each iteration
                    }

                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_cashAccountId.Text, out int cashAccountId))
            {

                MessageBox.Show("Invalid customer Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cashAccountId.Focus();
                return;
            }

            if (!decimal.TryParse(txt_amount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_amount.Focus();
                return;
            }

            string expenseType;
            // checking for not null
            if (combo_expenseType.SelectedItem != null)
            {
                expenseType = combo_expenseType.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select expense type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_expenseType.Focus();
                return;
            }

            int employeeId = 0;
            if (combo_expenseType.Text == "Labour")
            {
                if (!int.TryParse(txt_employeeId.Text, out employeeId))
                {
                    MessageBox.Show("Invalid employee Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_employeeId.Focus();
                    return;
                }
            }






            // assigning values to emloyee object
            expense.expenseId = int.Parse(txt_expenseId.Text);
            expense.date = dtTm_date.Value;
            expense.cashAccountId = cashAccountId;
            expense.cashAccountName = txt_cashAccountName.Text;
            expense.expenseType = expenseType;
            expense.amount = amount;
            expense.discription = txt_discription.Text;
            expense.employeeId = employeeId;
            expense.employeeName = txt_employeeName.Text;



            expense.updateExpense(expense);

            // clears the text boxes
            commonFunctions.ClearAllTextBoxes(this);

            // Show updated data in grid view
            txt_expenseId.Text = expense.GetNextAvailableId().ToString();
            expense.showDataInGridView(dataGridView2, dtTm_date.Value.Date);

            txt_cashAccountId.Focus();
        }
    }
}
