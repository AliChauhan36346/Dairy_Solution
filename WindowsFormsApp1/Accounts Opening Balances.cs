using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Accounts_Opening_Balances : Form
    {
        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();

        OpeningBalances openingBalances=new OpeningBalances();

        public Accounts_Opening_Balances()
        {
            InitializeComponent();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                decimal debit=0;
                decimal credit=0;

                if(!int.TryParse(txt_accountId.Text,out int Id))
                {
                    MessageBox.Show("Invalid account Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txt_accountName.Text))
                {
                    MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(txt_debit.Enabled)
                {
                    if(!decimal.TryParse(txt_debit.Text,out debit))
                    {
                        MessageBox.Show("Invalid account Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    openingBalances.debit = debit;
                    //openingBalances.credit = 0;
                }
                else
                {
                    if (!decimal.TryParse(txt_credit.Text, out credit))
                    {
                        MessageBox.Show("Invalid account Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    openingBalances.credit = credit;
                    //openingBalances.debit = 0;
                }



                // assigning values to emloyee object

                openingBalances.accountId = Id;
                openingBalances.accountName = txt_accountName.Text;
                openingBalances.debit = debit;
                openingBalances.credit = credit;
                openingBalances.openingBalanceId = openingBalances.GetNextAvailableID();


                openingBalances.saveOpeningBalance(openingBalances);

                // clear all textboxes
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                openingBalances.showDataInGridView(dataGridView1);
                txt_openingBalanceId.Text = openingBalances.GetNextAvailableID().ToString();

                openingBalances.GetTotalDebitCredit(out decimal totalDebit, out decimal totalCredit);
                txt_totalDebit.Text = totalDebit.ToString();
                txt_totalCredit.Text = totalCredit.ToString();

                //move focus for smooth next record entry
                txt_accountId.Focus();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void txt_accountId_TextChanged(object sender, EventArgs e)
        {
            if(txt_accountId.Focused)
            {
                commonFunctions.ShowAllAccountSuggestions(txt_accountId.Text, lstAccountSuggestions);
            }
            
        }

        private void Accounts_Opening_Balances_Load(object sender, EventArgs e)
        {
            lstAccountSuggestions.Visible = false;

            txt_openingBalanceId.Text = openingBalances.GetNextAvailableID().ToString();

            openingBalances.showDataInGridView(dataGridView1);

            openingBalances.GetTotalDebitCredit(out decimal totalDebit, out decimal totalCredit);
            txt_totalDebit.Text = totalDebit.ToString();
            txt_totalCredit.Text = totalCredit.ToString();
        }

        private void txt_accountId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_accountId, txt_accountName, lstAccountSuggestions, e);
            if (e.KeyCode==Keys.Enter)
            {

                lstAccountSuggestions.Visible = false;

                txt_debit.Focus();

                e.SuppressKeyPress = true;
            }

            
        }

        private void txt_accountId_Leave(object sender, EventArgs e)
        {
            lstAccountSuggestions.Visible = false;
        }

        private void txt_debit_KeyDown(object sender, KeyEventArgs e)
        {

            
            if (e.KeyCode == Keys.Enter)
            {
                if(txt_credit.Enabled)
                {
                    txt_credit.Focus();

                    e.SuppressKeyPress = true;
                }
                else
                {
                    btn_save.Focus();

                    e.SuppressKeyPress = true;
                }
            }

            if(txt_debit.Text=="")
            {
                if (e.KeyCode == Keys.Right)
                {
                    txt_credit.Focus();
                    e.SuppressKeyPress = true;
                }
                else if(e.KeyCode==Keys.Up)
                {
                    txt_accountId.Focus();
                    e.SuppressKeyPress = true;
                }
            }

            

        }

        private void txt_credit_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
                e.SuppressKeyPress = true;
            }

            if (txt_credit.Text == "")
            {
                if (e.KeyCode == Keys.Left)
                {
                    txt_debit.Focus();
                    e.SuppressKeyPress = true;
                }
            }

            
        }

        private void txt_debit_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_debit.Text != "")
            {
                
                txt_credit.Enabled = false;
            }
            else
            {
                txt_credit.Enabled = true;
            }
        }

        private void txt_credit_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_credit.Text != "")
            {
                txt_debit.Enabled = false;
            }
            else
            {
                txt_debit.Enabled = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                decimal debit = 0;
                decimal credit = 0;

                if (!int.TryParse(txt_accountId.Text, out int Id))
                {
                    MessageBox.Show("Invalid account Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txt_accountName.Text))
                {
                    MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txt_debit.Enabled)
                {
                    if (!decimal.TryParse(txt_debit.Text, out debit))
                    {
                        MessageBox.Show("Invalid account Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    openingBalances.debit = debit;
                    //openingBalances.credit = 0;
                }
                else
                {
                    if (!decimal.TryParse(txt_credit.Text, out credit))
                    {
                        MessageBox.Show("Invalid account Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    openingBalances.credit = credit;
                    //openingBalances.debit = 0;
                }

                // assigning values to emloyee object

                openingBalances.accountId = Id;
                openingBalances.accountName = txt_accountName.Text;
                openingBalances.debit = debit;
                openingBalances.credit = credit;
                openingBalances.openingBalanceId = int.Parse(txt_openingBalanceId.Text);


                openingBalances.updateOpeningBalance(openingBalances);

                // Show updated data in grid view
                openingBalances.showDataInGridView(dataGridView1);
                txt_openingBalanceId.Text = openingBalances.GetNextAvailableID().ToString();
                openingBalances.GetTotalDebitCredit(out decimal totalDebit, out decimal totalCredit);
                txt_totalDebit.Text= totalDebit.ToString();
                txt_totalCredit.Text = totalCredit.ToString();
                txt_accountId.Focus();




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
            if (!int.TryParse(txt_openingBalanceId.Text, out id))
            {
                MessageBox.Show("Invalid  opening balance Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed with deletion
            if (result == DialogResult.Yes)
            {
                // Call the removeCustomer method with the ID
                openingBalances.removeOpeningBalance(id);

                // clears the textboxes for new entry

                commonFunctions.ClearAllTextBoxes(this);
                // refresh the id to new one 
                txt_openingBalanceId.Text = openingBalances.GetNextAvailableID().ToString();

                // for refreshing data in gridview after deletion
                openingBalances.showDataInGridView(dataGridView1 );

                openingBalances.GetTotalDebitCredit(out decimal totalDebit, out decimal totalCredit);
                txt_totalDebit.Text = totalDebit.ToString();
                txt_totalCredit.Text = totalCredit.ToString();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Check if the selected index is within the bounds of the data
                if (selectedIndex >= 0 && selectedIndex < dataGridView1.RowCount - 1)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Populate text boxes with data from the selected row
                    txt_openingBalanceId.Text = selectedRow.Cells["Id"].Value.ToString();
                    txt_accountId.Text = selectedRow.Cells["Account Id"].Value.ToString();
                    txt_accountName.Text = selectedRow.Cells["Account Name"].Value.ToString();
                    if (decimal.TryParse(selectedRow.Cells["Debit"].Value.ToString(),out decimal debit))
                    {
                        if(debit!=0)
                        {
                            txt_debit.Text = selectedRow.Cells["Debit"].Value.ToString();
                        }
                    }

                    if(decimal.TryParse(selectedRow.Cells["Credit"].Value.ToString(), out decimal credit))
                    {
                        if(credit!=0)
                        {
                            txt_credit.Text = selectedRow.Cells["Credit"].Value.ToString();
                        }
                    }
                    
                    
                }
            }
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            Companies company = new Companies();
            company.ShowDialog();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.ShowDialog();
        }
    }
}
