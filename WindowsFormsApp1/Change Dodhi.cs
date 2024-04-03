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
    public partial class Change_Dodhi : Form
    {
        AddEmployees employees = new AddEmployees();
        CommonFunctionsClass CommonFunctions = new CommonFunctionsClass();

        public Change_Dodhi()
        {
            InitializeComponent();
        }

        private void Change_Dodhi_Load(object sender, EventArgs e)
        {
            List<string> dodhi = new List<string>();

            dodhi = employees.GetDodhiNames();

            foreach(string dodhiName in dodhi)
            {
                cmbo_currentDodhi.Items.Add(dodhiName);
                cmbo_newDodhi.Items.Add(dodhiName);
            }
        }

        private void btn_updateDodhi_Click(object sender, EventArgs e)
        {
            if(cmbo_newDodhi.SelectedItem != null && cmbo_currentDodhi.SelectedItem != null)
            {
                bool allTables = false;

                if(chk_changeDodhiAll.Checked)
                {
                    allTables = true;
                }

                CommonFunctions.ChangeDodhi(cmbo_currentDodhi.SelectedItem.ToString(), cmbo_newDodhi.SelectedItem.ToString(), allTables);
            }
        }
    }
}
