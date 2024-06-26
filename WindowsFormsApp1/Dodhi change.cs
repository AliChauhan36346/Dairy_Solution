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
    public partial class Dodhi_change : Form
    {
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        AddEmployees addEmployees = new AddEmployees();
        public Dodhi_change()
        {
            InitializeComponent();
        }

        private void cmbo_currentDodhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dodhiName = cmbo_currentDodhi.SelectedItem.ToString().Trim();
            int dodhiId = addEmployees.getDodhiIdByName(dodhiName);

            Dictionary<int, string> customerIdsNames = commonFunctions.changeSelectedCustomerDodhi(dodhiId);

            // Clear the existing items in the CheckedListBox
            checkedListBox1.Items.Clear();

            // Add each customer name (with ID) to the CheckedListBox
            foreach (var entry in customerIdsNames)
            {
                // You can create a custom object or simply add the customer name
                // Here we add customer name for simplicity
                checkedListBox1.Items.Add(new ListItem(entry.Key, entry.Value));
            }
        }

        private void Dodhi_change_Load(object sender, EventArgs e)
        {
            List<string> dodhi = new List<string>();

            dodhi = addEmployees.GetDodhiNames();

            foreach (string dodhiName in dodhi)
            {
                cmbo_currentDodhi.Items.Add(dodhiName);
                cmbo_newDodhi.Items.Add(dodhiName);
            }
        }

        private void btn_updateDodhi_Click(object sender, EventArgs e)
        {
            int totalSelectedCustomers = 0;
            int changedCustomers = 0;
            foreach(var item in checkedListBox1.CheckedItems)
            {
                totalSelectedCustomers++;
            }

            foreach (var item in checkedListBox1.CheckedItems)
            {
                // Extract the number part (ID) from the checked item
                string checkedItem = item.ToString();
                string[] parts = checkedItem.Split(' ');
                int customerID;

                if (parts.Length > 0 && int.TryParse(parts[0], out customerID))
                {
                    if (cmbo_newDodhi.SelectedItem != null && cmbo_currentDodhi.SelectedItem != null)
                    {
                        changedCustomers++;

                        commonFunctions.ChangeDodhiSelectedCustomers(
                            cmbo_currentDodhi.SelectedItem.ToString(),
                            cmbo_newDodhi.SelectedItem.ToString(),
                            customerID,totalSelectedCustomers,changedCustomers
                        );

                    }
                }
                else
                {
                    MessageBox.Show("Error changing dodhi: " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int currentDodhiId = addEmployees.getDodhiIdByName(cmbo_currentDodhi.SelectedItem.ToString().Trim());

            commonFunctions.ShowAccountSuggestionsDodhiWise(textBox1, checkedListBox1, currentDodhiId);
        }

        private void chk_changeDodhiAll_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_changeDodhiAll.Checked)
            {
                for(int i=0; i<checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i,CheckState.Checked);
                }
            }
            else if(!chk_changeDodhiAll.Checked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
    }

    // Helper class to hold the name and ID
    public class ListItem
    {
        public string Name { get; }
        public int ID { get; }

        public ListItem(int id, string name)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return $"{ID} {Name}"; // This ensures the CheckedListBox displays the customer name
        }

    }
}
