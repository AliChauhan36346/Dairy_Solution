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
    public partial class Accounts : Form
    {
        AddAccounts account = new AddAccounts();

        public Accounts()
        {
            InitializeComponent();
        }

        

        private void chilarBtn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate
                if (string.IsNullOrEmpty(cmbo_accountType.Text))
                {
                    MessageBox.Show("Please add an account type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // assigning values to emloyee object
                account.id = int.Parse(txt_id.Text);
                account.name = txt_name.Text;
                account.accountType = cmbo_accountType.Text;


                account.saveAccount(account);


                txt_name.Text = "";
                cmbo_accountType.Text = "";

                // Show updated data in grid view
                txt_id.Text = account.GetNextAvailableID().ToString();
                account.showDataInGridView(dataGridView1);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            // Show updated data in grid view
            txt_id.Text = account.GetNextAvailableID().ToString();
            account.showDataInGridView(dataGridView1);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (string.IsNullOrEmpty(txt_name.Text))
                {
                    MessageBox.Show("Please add account name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(string.IsNullOrEmpty(cmbo_accountType.Text))
                {
                    MessageBox.Show("Please add account Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
     

                account.id = int.Parse(txt_id.Text);
                account.name = txt_name.Text;
                account.accountType=cmbo_accountType.Text;

                // Save account
                account.updateAccount(account);

                // Show updated data in grid view
                account.showDataInGridView(dataGridView1);

                // clears the textboxes for new entry
                txt_name.Text = "";


                // updates the id text box to new one 
                txt_id.Text = account.GetNextAvailableID().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate text boxes with data from the selected row
                txt_id.Text = row.Cells["ID"].Value.ToString();
                txt_name.Text = row.Cells["Account Name"].Value.ToString();

                string AccountType = row.Cells["Account Type"].Value.ToString().Trim(); // Trim leading and trailing spaces

                // Set the SelectedValue property of the ComboBox to the value from the DataGridView
                foreach (var item in cmbo_accountType.Items)
                {
                    if (item.ToString().Trim().Equals(AccountType, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbo_accountType.SelectedItem = item;
                        break;
                    }
                }

                
            }
        }

        private void chilarBtn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";



            // updates the id text box to new one 
            txt_id.Text = account.GetNextAvailableID().ToString();
        }

        private void tn_deleteEntry_Click(object sender, EventArgs e)
        {
            // Get the ID from the textbox
            int id;
            if (!int.TryParse(txt_id.Text, out id))
            {
                MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed with deletion
            if (result == DialogResult.Yes)
            {
                // Call the removeCustomer method with the ID
                account.removeAccount(id);

                // clears the textboxes for new entry
                txt_name.Text = "";

                // refresh the id to new one 
                txt_id.Text = account.GetNextAvailableID().ToString();

                // for refreshing data in gridview after deletion
                account.showDataInGridView(dataGridView1);
            }

        }


    }
}
