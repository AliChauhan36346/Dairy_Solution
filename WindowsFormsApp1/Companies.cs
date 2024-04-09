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
    public partial class Companies : Form
    {
        AddCompanies company=new AddCompanies();

        public Companies()
        {
            InitializeComponent();
        }

        private void comBtn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comBtn_cashReceipt_Click(object sender, EventArgs e)
        {
            Receipts_Form receipts_Form = new Receipts_Form();
            receipts_Form.ShowDialog();
            this.Close();
        }

        private void comBtn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_companyName.Text))
                {
                    MessageBox.Show("Please add company name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and parse rate
                if (!decimal.TryParse(txt_rate.Text, out decimal rate))
                {
                    MessageBox.Show("Invalid rate value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // assigning values to emloyee object
                company.id = int.Parse(txt_id.Text);
                company.name = txt_companyName.Text;
                company.address = txt_address.Text.ToString();
                company.rate = rate;


                company.savecompany(company);
                

                txt_companyName.Text = "";
                txt_address.Text = "";
                txt_rate.Text = "";

                // Show updated data in grid view
                txt_id.Text = company.GetNextAvailableID().ToString();
                company.showDataInGridView(dataGridView1);
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Companies_Load(object sender, EventArgs e)
        {
            txt_id.Text = company.GetNextAvailableID().ToString();
            company.showDataInGridView(dataGridView1);
        }

        private void comBtn_addNew_Click(object sender, EventArgs e)
        {
            // refresh id
            txt_id.Text = company.GetNextAvailableID().ToString();

            // clearing textboxes for new company
            txt_companyName.Text = "";
            txt_address.Text = "";
            txt_rate.Text = "";
        }

        private void btn_updateCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_companyName.Text))
                {
                    MessageBox.Show("Please add company name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                // Validate and parse salary
                if (!decimal.TryParse(txt_rate.Text, out decimal rate))
                {
                    MessageBox.Show("Invalid Salary value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                company.id = int.Parse(txt_id.Text);
                company.name = txt_companyName.Text;
                company.address = txt_address.Text;           
                company.rate = rate;
                


               

                // Save company
                company.updateCompany(company);

                // Show updated data in grid view
                company.showDataInGridView(dataGridView1);

                // clears the textboxes for new entry
                txt_companyName.Text = "";
                txt_address.Text = "";
                txt_rate.Text = "";
               

                // updates the id text box to new one 
                txt_id.Text = company.GetNextAvailableID().ToString();


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
                txt_companyName.Text = row.Cells["company Name"].Value.ToString();
                txt_address.Text = row.Cells["Address"].Value.ToString();
                txt_rate.Text = row.Cells["Rate"].Value.ToString();
                    
            }
            
        }

        private void comBtn_deleteEntry_Click(object sender, EventArgs e)
        {
            // Get the ID from the textbox
            int id;
            if (!int.TryParse(txt_id.Text, out id))
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
                company.removeCompany(id);

                txt_companyName.Text = "";
                txt_address.Text = "";
                txt_rate.Text = "";

                // for refreshing data in gridview after deletion
                company.showDataInGridView(dataGridView1);
                txt_id.Text = company.GetNextAvailableID().ToString();
            }

        }

        private void txt_companyName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_rate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                comBtn_Save.Focus();
            }
        }
    }
    
}
