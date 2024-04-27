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
    public partial class GeneralJournal : Form
    {
        CommonFunctionsClass commonFunctions=new CommonFunctionsClass();
        JournalVoucherClass journalVoucher = new JournalVoucherClass();

        public GeneralJournal()
        {
            InitializeComponent();
        }

        private void GeneralJournal_Load(object sender, EventArgs e)
        {
            lstAccountSeggestions.Visible = false;

            txt_JournalId.Text = journalVoucher.GetNextAvailableID().ToString();

            journalVoucher.showDataInGridView(dataGridView1);
        }

        private void txt_accountId1_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAllAccountSuggestions(txt_accountId1.Text, lstAccountSeggestions);
        }

        private void txt_accountId2_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAllAccountSuggestions(txt_accountId2.Text, lstAccountSeggestions);
        }

        private void txt_accountId1_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_accountId1, txt_accountName1,lstAccountSeggestions,e);
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txt_debit1.Focus();
            }
        }

        private void txt_accountId2_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_accountId2, txt_accountName2, lstAccountSeggestions, e);
            if (e.KeyCode==Keys.Enter)
            {
                e.SuppressKeyPress = true;

                txt_debit2.Focus();
            }
        }

        private void txt_debit1_TextChanged(object sender, EventArgs e)
        {
            if (txt_debit1.Text != "")
            {

                txt_credit1.Enabled = false;
            }
            else
            {
                txt_credit1.Enabled = true;
            }
        }

        private void txt_credit1_TextChanged(object sender, EventArgs e)
        {
            if (txt_credit1.Text != "")
            {
                txt_debit1.Enabled = false;
            }
            else
            {
                txt_debit1.Enabled = true;
            }
        }

        private void txt_debit2_TextChanged(object sender, EventArgs e)
        {
            if (txt_debit2.Text != "")
            {

                txt_credit2.Enabled = false;
            }
            else
            {
                txt_credit2.Enabled = true;
            }
        }

        private void txt_credit2_TextChanged(object sender, EventArgs e)
        {
            if (txt_credit2.Text != "")
            {
                txt_debit2.Enabled = false;
            }
            else
            {
                txt_debit2.Enabled = true;
            }
        }

        private void txt_debit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_credit1.Enabled)
                {
                    txt_credit1.Focus();

                    e.SuppressKeyPress = true;
                }
                else
                {
                    txt_accountId2.Focus();

                    e.SuppressKeyPress = true;
                }
            }

            if (txt_debit1.Text == "")
            {
                if (e.KeyCode == Keys.Right)
                {
                    txt_credit1.Focus();
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    txt_accountId1.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txt_credit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_accountId2.Focus();
                e.SuppressKeyPress = true;
            }

            if (txt_credit1.Text == "")
            {
                if (e.KeyCode == Keys.Left)
                {
                    txt_debit1.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txt_debit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_credit2.Enabled)
                {
                    txt_credit2.Focus();

                    e.SuppressKeyPress = true;
                }
                else
                {
                    btn_save.Focus();

                    e.SuppressKeyPress = true;
                }
            }

            if (txt_debit2.Text == "")
            {
                if (e.KeyCode == Keys.Right)
                {
                    txt_credit2.Focus();
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    txt_accountId2.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void txt_credit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_save.Focus();
                e.SuppressKeyPress = true;
            }

            if (txt_credit2.Text == "")
            {
                if (e.KeyCode == Keys.Left)
                {
                    txt_debit2.Focus();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            decimal debit1 = 0;
            decimal debit2 = 0;
            decimal credit1 = 0;
            decimal credit2 = 0;

            //validating that both debit and credit are equal
            decimal amount1=0,amount2=0;
            bool isDebit = true;

            // first account
            if(txt_debit1.Text!="")
            {
                if(!decimal.TryParse(txt_debit1.Text, out amount1))
                {
                    MessageBox.Show("Invalid amount for account 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                isDebit = true;
            }
            else if(txt_credit1.Text!="")
            {
                if (!decimal.TryParse(txt_credit1.Text, out amount1))
                {
                    MessageBox.Show("Invalid amount for account 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                isDebit = false;
            }

            //second account
            if (txt_debit2.Text != "")
            {
                if(!isDebit)
                {
                    if (!decimal.TryParse(txt_debit2.Text, out amount2))
                    {
                        MessageBox.Show("Invalid amount for account 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Amount cannot be debited for both accounts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else if (txt_credit2.Text != "")
            {
                if(isDebit)
                {
                    if (!decimal.TryParse(txt_credit2.Text, out amount2))
                    {
                        MessageBox.Show("Invalid amount for account 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Amount cannot be credited for both accounts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

            }

            // validating

            if(amount1!=amount2)
            {
                MessageBox.Show("Total Debit and Credit must be equall!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txt_accountId1.Text, out int Id1))
            {
                MessageBox.Show("Invalid account Id1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_accountId1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_accountName1.Text))
            {
                MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_debit1.Enabled)
            {
                if (!decimal.TryParse(txt_debit1.Text, out debit1))
                {
                    MessageBox.Show("Invalid debit1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_debit1.Focus();
                    return;
                }
                journalVoucher.debit = debit1;
                //openingBalances.credit = 0;
            }
            else
            {
                if (!decimal.TryParse(txt_credit1.Text, out credit1))
                {
                    MessageBox.Show("Invalid credit1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_credit1.Focus();
                    return;
                }
                journalVoucher.credit = credit1;
                //openingBalances.debit = 0;
            }

            journalVoucher.date = dtm_picker.Value.Date;
            journalVoucher.discription = txt_discription.Text;
            journalVoucher.journalId = int.Parse(txt_JournalId.Text);
            journalVoucher.accountId = Id1;
            journalVoucher.accountName = txt_accountName1.Text;

            journalVoucher.saveJournalVoucher(journalVoucher);

            journalVoucher.debit = 0;
            journalVoucher.credit = 0;

            //for second account


            

            if (!int.TryParse(txt_accountId2.Text, out int Id2))
            {
                MessageBox.Show("Invalid account Id2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txt_accountName2.Text))
            {
                MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_debit2.Enabled)
            {
                if (!decimal.TryParse(txt_debit2.Text, out debit2))
                {
                    MessageBox.Show("Invalid debit2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_debit2.Focus();
                    return;
                }
                journalVoucher.debit = debit2;
                //openingBalances.credit = 0;
            }
            else
            {
                if (!decimal.TryParse(txt_credit2.Text, out credit2))
                {
                    MessageBox.Show("Invalid credit2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_credit2.Focus();
                    return;
                }
                journalVoucher.credit = credit2;
                //openingBalances.debit = 0;
            }
            journalVoucher.accountName = txt_accountName2.Text;
            journalVoucher.accountId = Id2;

            //saving the records

            journalVoucher.saveJournalVoucher(journalVoucher);

            commonFunctions.ClearAllTextBoxes(this);

            txt_JournalId.Text = journalVoucher.GetNextAvailableID().ToString();
            journalVoucher.showDataInGridView(dataGridView1);
            txt_accountId1.Focus();
        }

        private void btn_previousRec_Click(object sender, EventArgs e)
        {
            

            if (!int.TryParse(txt_JournalId.Text, out int id))
            {
                return;
            }

            id--;

            if (id >= journalVoucher.GetMiniAvailableID())
            {
                journalVoucher.GetVoucherDetailByID(id, out DateTime date, out string discription, out List<(int accountId, string accountName, decimal debit, decimal credit)> accounts);

                
                txt_JournalId.Text = id.ToString();
                if (date.Date > DateTime.MinValue && date.Date < DateTime.MaxValue)
                {
                    dtm_picker.Value = date.Date;
                }
                
                txt_discription.Text = discription;

                if (accounts.Count >= 1)
                {
                    txt_accountId1.Text = accounts[0].accountId.ToString();
                    txt_accountName1.Text = accounts[0].accountName;
                    decimal debit1 = accounts[0].debit;
                    decimal credit1 = accounts[0].credit;

                    txt_debit1.Text = debit1.ToString();
                    txt_credit1.Text=credit1.ToString();

                    if(debit1==0)
                    {
                        txt_debit1.Text = "";
                    }
                    else if(credit1==0)
                    {
                        txt_credit1.Text = "";
                    }

                }

                if (accounts.Count >= 2)
                {
                    txt_accountId2.Text = accounts[1].accountId.ToString();
                    txt_accountName2.Text = accounts[1].accountName;
                    decimal debit2 = accounts[1].debit;
                    decimal credit2 = accounts[1].credit;

                    txt_debit2.Text = debit2.ToString();
                    txt_credit2.Text = credit2.ToString();

                    if (debit2 == 0)
                    {
                        txt_debit2.Text = "";
                    }
                    else if (credit2 == 0)
                    {
                        txt_credit2.Text = "";
                    }
                }

                // Repeat the pattern for additional accounts if needed
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txt_JournalId.Text, out id))
            {
                MessageBox.Show("Invalid journal voucher Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed with deletion
            if (result == DialogResult.Yes)
            {
                // Call the removeCustomer method with the ID
                journalVoucher.removeJournalVoucher(id);

                // clears the textboxes for new entry

                commonFunctions.ClearAllTextBoxes(this);

                // refresh the id to new one 
                txt_JournalId.Text = journalVoucher.GetNextAvailableID().ToString();
                journalVoucher.showDataInGridView(dataGridView1);
            }
        }

        private void btn_forwardRec_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_JournalId.Text, out int id))
            {
                return;
            }

            id++;

            if (id <= journalVoucher.GetNextAvailableID() - 1)
            {
                journalVoucher.GetVoucherDetailByID(id, out DateTime date, out string discription, out List<(int accountId, string accountName, decimal debit, decimal credit)> accounts);


                txt_JournalId.Text = id.ToString();
                if (date.Date > DateTime.MinValue && date.Date < DateTime.MaxValue)
                {
                    dtm_picker.Value = date.Date;
                }

                txt_discription.Text = discription;

                if (accounts.Count >= 1)
                {
                    txt_accountId1.Text = accounts[0].accountId.ToString();
                    txt_accountName1.Text = accounts[0].accountName;
                    decimal debit1 = accounts[0].debit;
                    decimal credit1 = accounts[0].credit;

                    txt_debit1.Text = debit1.ToString();
                    txt_credit1.Text = credit1.ToString();

                    if (debit1 == 0)
                    {
                        txt_debit1.Text = "";
                    }
                    else if (credit1 == 0)
                    {
                        txt_credit1.Text = "";
                    }

                }

                if (accounts.Count >= 2)
                {
                    txt_accountId2.Text = accounts[1].accountId.ToString();
                    txt_accountName2.Text = accounts[1].accountName;
                    decimal debit2 = accounts[1].debit;
                    decimal credit2 = accounts[1].credit;

                    txt_debit2.Text = debit2.ToString();
                    txt_credit2.Text = credit2.ToString();

                    if (debit2 == 0)
                    {
                        txt_debit2.Text = "";
                    }
                    else if (credit2 == 0)
                    {
                        txt_credit2.Text = "";
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            decimal debit1 = 0;
            decimal debit2 = 0;
            decimal credit1 = 0;
            decimal credit2 = 0;

            //validating that both debit and credit are equal
            decimal amount1 = -1, amount2 = 0;
            bool isDebit = true;

            // first account
            if (txt_debit1.Text != "")
            {
                if (!decimal.TryParse(txt_debit1.Text, out amount1))
                {

                }
            }
            else if (txt_credit1.Text != "")
            {
                if (!decimal.TryParse(txt_credit1.Text, out amount1))
                {
                    isDebit = false;
                }
            }

            //second account
            if (txt_debit2.Text != "")
            {
                if (!isDebit)
                {
                    if (!decimal.TryParse(txt_debit2.Text, out amount2))
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Total Debit and Credit must be equall!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (txt_credit2.Text != "")
            {
                if (!decimal.TryParse(txt_credit2.Text, out amount2))
                {

                }
            }

            // validating

            if (amount1 != amount2)
            {
                MessageBox.Show("Total Debit and Credit must be equall!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txt_accountId1.Text, out int Id1))
            {
                MessageBox.Show("Invalid account Id1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_accountId1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txt_accountName1.Text))
            {
                MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_debit1.Enabled)
            {
                if (!decimal.TryParse(txt_debit1.Text, out debit1))
                {
                    MessageBox.Show("Invalid debit1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_debit1.Focus();
                    return;
                }
                journalVoucher.debit = debit1;
                //openingBalances.credit = 0;
            }
            else
            {
                if (!decimal.TryParse(txt_credit1.Text, out credit1))
                {
                    MessageBox.Show("Invalid credit1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_credit1.Focus();
                    return;
                }
                journalVoucher.credit = credit1;
                //openingBalances.debit = 0;
            }

            journalVoucher.date = dtm_picker.Value.Date;
            journalVoucher.discription = txt_discription.Text;
            journalVoucher.journalId = int.Parse(txt_JournalId.Text);
            journalVoucher.accountId = Id1;
            journalVoucher.accountName = txt_accountName1.Text;

            journalVoucher.updateJournalVoucher(journalVoucher);

            //for second account




            if (!int.TryParse(txt_accountId2.Text, out int Id2))
            {
                MessageBox.Show("Invalid account Id2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txt_accountName2.Text))
            {
                MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_debit2.Enabled)
            {
                if (!decimal.TryParse(txt_debit2.Text, out debit2))
                {
                    MessageBox.Show("Invalid debit2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_debit2.Focus();
                    return;
                }
                journalVoucher.debit = debit2;
                //openingBalances.credit = 0;
            }
            else
            {
                if (!decimal.TryParse(txt_credit2.Text, out credit2))
                {
                    MessageBox.Show("Invalid credit2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_credit2.Focus();
                    return;
                }
                journalVoucher.credit = credit2;
                //openingBalances.debit = 0;
            }
            journalVoucher.accountName = txt_accountName2.Text;
            journalVoucher.accountId = Id2;

            //saving the records

            journalVoucher.updateJournalVoucher(journalVoucher);

            commonFunctions.ClearAllTextBoxes(this);

            txt_JournalId.Text = journalVoucher.GetNextAvailableID().ToString();
            journalVoucher.showDataInGridView(dataGridView1);
            txt_accountId1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commonFunctions.ClearAllTextBoxes(this);

            txt_JournalId.Text = journalVoucher.GetNextAvailableID().ToString();
        }
    }
}
