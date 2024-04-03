using DairyAccounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Change_Rates : Form
    {
        AddEmployees employees = new AddEmployees();
        RateAdjustments rateAdjustments = new RateAdjustments();
        CommonFunctionsClass commonFunctions= new CommonFunctionsClass();
        AddCustomers customers = new AddCustomers();

        public Change_Rates()
        {
            InitializeComponent();
        }

        

        private void Change_Rates_Load(object sender, EventArgs e)
        {
            lst_accountSuggestions.Visible = false;

            if (rdo_companyRateChange.Checked)
            {
                rdo_byAddress.Enabled = false;
                rdo_dodhiWise.Enabled = false;

                rdo_singleCustomer.Checked = true;

                cmbo_byAddress.Enabled = false;
                cmbo_byDodhi.Enabled = false;
            }

            rdo_customerRateChange.Checked = true;
            rdo_incrementRate.Checked = true;
            rdo_singleCustomer.Checked = true;


            // loads dodhi in combo box
            List<string> dodhiNames = new List<string>();
            dodhiNames=employees.GetDodhiNames();

            foreach(string item in dodhiNames)
            {
                cmbo_byDodhi.Items.Add(item);
            }

            // loads address into the combo box
            List<string> addresses = new List<string>();
            addresses = customers.getCustomersAddress();

            foreach(string address in addresses)
            {
                cmbo_byAddress.Items.Add(address);
            }


            
        }

        private void rdo_customerRateChange_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_customerRateChange.Checked)
            {
                rdo_byAddress.Enabled = true;
                rdo_dodhiWise.Enabled = true;

                cmbo_byAddress.Enabled = false;
                cmbo_byDodhi.Enabled = false;
            }
            
        }

        private void rdo_companyRateChange_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_companyRateChange.Checked)
            {
                rdo_byAddress.Enabled = false;
                rdo_dodhiWise.Enabled = false;

                cmbo_byAddress.Enabled = false;
                cmbo_byDodhi.Enabled = false;
            }
        }

        private void btn_updateChanges_Click(object sender, EventArgs e)
        {
            int accountBelongsTo;// to store table name from which changes will be made
            int filterOrAccountId=-1;// to store id or key of filter 

            string increaseOrDecrease;// tells wheather the rate will increase decrease or new
            string filter;// store the filter like it done on dodhi basis or address basis etc
            

            decimal rate;

            

            // for database table selection
            if (rdo_customerRateChange.Checked)
            {
                accountBelongsTo = 0;
            }
            else
            {
                accountBelongsTo = 1;
            }


            // check if rate will increase, decrease or new
            if (rdo_incrementRate.Checked)
            {
                increaseOrDecrease = "increment";
            }
            else if(rdo_decrementRate.Checked)
            {
                increaseOrDecrease = "decrement";
            }
            else
            {
                increaseOrDecrease = "new";
            }
            

            // fo filters like dodhi,address,single
            if(rdo_dodhiWise.Checked)
            {
                filter = "dodhi";
                filterOrAccountId = employees.getDodhiIdByName(cmbo_byDodhi.SelectedItem.ToString());
                if(!decimal.TryParse(txt_newRate.Text, out rate))
                {
                    MessageBox.Show("Ivalid rate value! \nPlease insert a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                rateAdjustments.adjustRate(increaseOrDecrease, filter,filterOrAccountId, "", rate,accountBelongsTo);
            }
            else if(rdo_allCustomerRate.Checked)
            {
                filter = "all";

                if (!decimal.TryParse(txt_newRate.Text, out rate))
                {
                    MessageBox.Show("Ivalid rate value! \nPlease insert a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rateAdjustments.adjustRate(increaseOrDecrease, filter, -1, "", rate, accountBelongsTo);
            }
            else if(rdo_byAddress.Checked)
            {
                filter = "address";

                if (!decimal.TryParse(txt_newRate.Text, out rate))
                {
                    MessageBox.Show("Ivalid rate value! \nPlease insert a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!int.TryParse(cmbo_byAddress.SelectedItem.ToString(),out filterOrAccountId))
                {
                    MessageBox.Show("Ivalid address value! \nPlease insert a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rateAdjustments.adjustRate(increaseOrDecrease, filter, filterOrAccountId,"" , rate, accountBelongsTo);

            }
            else
            {
                
                filter = "single";

                if (!int.TryParse(txt_customerId.Text, out filterOrAccountId))
                {
                    MessageBox.Show("Ivalid customer or company Id! \nPlease insert a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!decimal.TryParse(txt_newRate.Text, out rate))
                {
                    MessageBox.Show("Ivalid rate value! \nPlease insert a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rateAdjustments.adjustRate(increaseOrDecrease, filter, filterOrAccountId,"", rate, accountBelongsTo);

            }

        }

        private void rdo_dodhiWise_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_dodhiWise.Checked)
            {
                cmbo_byDodhi.Enabled = true;
            }
            else
            {
                cmbo_byDodhi.Enabled = false;
            }
        }

        private void rdo_byAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_byAddress.Checked)
            {
                cmbo_byAddress.Enabled = true;
            }
            else
            {
                cmbo_byAddress.Enabled = false;
            }
        }

        private void rdo_singleCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if(rdo_singleCustomer.Checked)
            {
                txt_customerId.Enabled = true;
                txt_customerName.Enabled = false;
            }
            else
            {
                txt_customerName.Enabled = false;
                txt_customerId.Enabled = false;
            }
        }

        private void txt_customerId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAllAccountSuggestions(txt_customerId.Text, lst_accountSuggestions);
        }

        private void txt_customerId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_customerId, txt_customerName, lst_accountSuggestions, e);
            if(e.KeyCode==Keys.Enter)
            {
                btn_updateChanges.Focus();
            }
        }

        private void txt_customerId_Leave(object sender, EventArgs e)
        {
            lst_accountSuggestions.Visible = false;
        }
    }
}
