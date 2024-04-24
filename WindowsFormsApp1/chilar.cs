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
    public partial class chilar : Form
    {
        AddChilarReceive chilarReceive = new AddChilarReceive();
        CommonFunctionsClass commonFunctions = new CommonFunctionsClass();
        DashboardClass dashboard = new DashboardClass();

        public bool isFromOtherForm = false;
        public int chilarReceiveId;

        bool isTruePassword = false;

        public chilar()
        {
            InitializeComponent();
        }

        private void chilarBtn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chilar_Load(object sender, EventArgs e)
        {
            txt_tsStandard.Text = "13";
            txt_id.Text = chilarReceive.GetNextAvailableID().ToString();
            chilarReceive.showDataInGridView(dataGridView2,dtm_picker.Value.Date);
            lstDodhiSuggestions.Visible = false;
            dtm_picker.Value = DateTime.Today;
            getStats();
            DateTime currentTime = DateTime.Now;

            // Check if the current time is before 12 PM (noon)
            if (currentTime.Hour < 15)
            {
                // Set the Morning radio button as checked
                rdo_morning.Checked = true;
            }
            else
            {
                // Set the Evening radio button as checked
                rdo_evening.Checked = true;
            }

            if (isFromOtherForm)
            {
                chilarReceive.getPurchaseRecordDetail(chilarReceiveId, out DateTime date, out int dodhiId, out string dodhiName,
                    out decimal grossLiters, out decimal lr, out decimal fat, out string time, out int tsStandar, out decimal tsLiters);

                txt_id.Text = chilarReceiveId.ToString();
                dtm_picker.Value = date;
                txt_dodhiId.Text = dodhiId.ToString();
                txt_dodhiName.Text = dodhiName;
                txt_lr.Text = lr.ToString();
                txt_liters.Text = grossLiters.ToString();
                txt_fat.Text = fat.ToString();
                txt_tsStandard.Text = tsStandar.ToString();
                txt_tsLiters.Text= tsLiters.ToString();


                if (time == "Morning")
                {
                    rdo_morning.Checked = true;
                }
                else
                {
                    rdo_evening.Checked = true;
                }
            }


        }

        private void chilarBtn_save_Click(object sender, EventArgs e)
        {
            try
            {
                
                // assigning time according to radio button selected
                if(rdo_morning.Checked)
                {
                    chilarReceive.time = "Morning";
                }
                else if(rdo_evening.Checked)
                {
                    chilarReceive.time = "Evening";
                }
                else
                {
                    MessageBox.Show("Please select a time slot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // checking for not null
                if(!int.TryParse(txt_dodhiId.Text,out int dodhiId))
                {
                    MessageBox.Show("Invalid dodhi Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txt_dodhiName.Text))
                {
                    MessageBox.Show("Please add Dodhi name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txt_liters.Text, out decimal grossLiters))
                {
                    MessageBox.Show("Invalid gross liters value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and parsing the values
                if (!decimal.TryParse(txt_lr.Text, out decimal lr))
                {
                    MessageBox.Show("Invalid lr value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (lr > 35 || lr < 0)
                    {
                        MessageBox.Show("Lr value should between 0 to 35", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (!decimal.TryParse(txt_fat.Text, out decimal fat))
                {
                    MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!int.TryParse(txt_tsStandard.Text, out int tsStandard))
                {
                    MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                decimal ts = chilarReceive.tsCalculator(lr, fat, grossLiters, tsStandard);

                txt_tsLiters.Text = ts.ToString();


                // assigning values to emloyee object
                
                chilarReceive.id = int.Parse(txt_id.Text);
                chilarReceive.dodhiId = dodhiId;
                chilarReceive.receiveDate = dtm_picker.Value;
                chilarReceive.dodhiName = txt_dodhiName.Text;
                chilarReceive.grossLiters = grossLiters;
                chilarReceive.fat = fat;
                chilarReceive.lr = lr;
                chilarReceive.tsStandard = tsStandard;
                chilarReceive.tsLiters = ts;


                chilarReceive.saveChilarReceive(chilarReceive);

                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                getStats();
                txt_id.Text = chilarReceive.GetNextAvailableID().ToString();
                chilarReceive.showDataInGridView(dataGridView2,dtm_picker.Value.Date);
                txt_tsStandard.Text = "13";

                txt_dodhiId.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_liters_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

        }

        private void txt_lr_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_fat_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Prevent the beep sound
                e.SuppressKeyPress = true;

                // Move focus to the next control (text box)
                chilarBtn_save.Focus();
            }
        }

        private void lstDodhiSuggestions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstDodhiSuggestions.Visible && lstDodhiSuggestions.SelectedItem != null)
            {
                string selectedSuggestion = lstDodhiSuggestions.SelectedItem.ToString();
                string[] parts = selectedSuggestion.Split(new[] { " - " }, StringSplitOptions.None);

                // Transfer the selected suggestion to the TextBoxes
                txt_dodhiName.Text = parts[1]; // Name TextBox
                txt_dodhiId.Text = parts[0].Trim(); // ID TextBox

                // Hide the suggestion list
                lstDodhiSuggestions.Visible = false;

                // Move focus to the next control (ID TextBox)
                txt_liters.Focus();

                // Prevent the Enter key from being processed further

            }
            else
            {
                // Move focus to the next control (text box)
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_dodhiId_KeyDown(object sender, KeyEventArgs e)
        {
            commonFunctions.HandleAccountSuggestionKeyDown(txt_dodhiId, txt_dodhiName, lstDodhiSuggestions, e);
            if (e.KeyCode==Keys.Enter)
            {
                
                txt_liters.Focus();
            }
        }

        private void txt_dodhiId_Leave(object sender, EventArgs e)
        {
            // hide suggestion
            if(!lstDodhiSuggestions.Focused)
            {
                lstDodhiSuggestions.Visible = false;
            }
            
        }

        
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                DateTime.TryParse(row.Cells["Date"].Value.ToString(), out DateTime receiveDate);

                

                // Populate text boxes with data from the selected row
                txt_id.Text = row.Cells["Receive Id"].Value.ToString();
                dtm_picker.Value= receiveDate;

                // check the radio button according to time 
                if (row.Cells["Time"].Value.ToString().Trim() == "Morning")
                {
                    //rdo_evening.Checked = false;
                    rdo_morning.Checked = true;

                    
                }
                else
                {
                    //rdo_morning.Checked= false;
                    rdo_evening.Checked = true;
                }

                txt_dodhiId.Text = row.Cells["Dodhi Id"].Value.ToString();
                txt_dodhiName.Text = row.Cells["Dodhi Name"].Value.ToString();
                txt_liters.Text = row.Cells["Gross Liters"].Value.ToString();
                txt_lr.Text = row.Cells["LR"].Value.ToString();
                txt_fat.Text = row.Cells["Fat"].Value.ToString();
                txt_tsStandard.Text = row.Cells["Ts-Standard"].Value.ToString();
                txt_tsLiters.Text = row.Cells["Ts Liters"].Value.ToString();

            }
        }

        private void txt_fat_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_liters.Text, out decimal grossLiters))
            {
                MessageBox.Show("Invalid gross liters value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse rate
            if (!decimal.TryParse(txt_lr.Text, out decimal lr))
            {
                MessageBox.Show("Invalid lr value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lr > 35 || lr < 0)
                {
                    MessageBox.Show("Lr value should between 0 to 35", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            if (!decimal.TryParse(txt_fat.Text, out decimal fat))
            {
                MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(!int.TryParse(txt_tsStandard.Text, out int tsStandard))
            {
                MessageBox.Show("Invalid TS value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            decimal ts = chilarReceive.tsCalculator(lr, fat, grossLiters, tsStandard);

            txt_tsLiters.Text = ts.ToString();
        }

        private void txt_tsStandard_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_liters.Text, out decimal grossLiters))
            {
                MessageBox.Show("Invalid gross liters value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse rate
            if (!decimal.TryParse(txt_lr.Text, out decimal lr))
            {
                MessageBox.Show("Invalid lr value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lr > 35 || lr < 0)
                {
                    MessageBox.Show("Lr value should between 0 to 35", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            if (!decimal.TryParse(txt_fat.Text, out decimal fat))
            {
                MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!int.TryParse(txt_tsStandard.Text, out int tsStandard))
            {
                MessageBox.Show("Invalid TS value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            decimal ts = chilarReceive.tsCalculator(lr, fat, grossLiters, tsStandard);

            txt_tsLiters.Text = ts.ToString();

            
        }

        



        private void chlrBtn_deleteEntry_Click(object sender, EventArgs e)
        {
           Password password=new Password();

            if(password.ShowDialog()==DialogResult.OK)
            {
                string enteredPassword = password.enteredPassword;

                if (password.IsPasswordCorrect(enteredPassword))
                {
                    
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
                        chilarReceive.removeChilarReceive(id);

                        // Clear all the text boxes for new entries
                        commonFunctions.ClearAllTextBoxes(this);

                        // Refresh data in gridview after deletion
                        getStats();
                        chilarReceive.showDataInGridView(dataGridView2,dtm_picker.Value.Date);
                        txt_id.Text = chilarReceive.GetNextAvailableID().ToString();
                        txt_tsStandard.Text = "13";
                        txt_dodhiId.Focus();
                    }
                        
                    
                    
                }
                else
                {
                    MessageBox.Show("Incorrect password. Deletion aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
            



        }

        private void chilarBtn_addNew_Click(object sender, EventArgs e)
        {
            // clearing all the text boxes for new entries
            commonFunctions.ClearAllTextBoxes(this);

            getStats();
            txt_id.Text = chilarReceive.GetNextAvailableID().ToString();
            txt_tsStandard.Text = "13";
            dtm_picker.Value = DateTime.Today;

            txt_dodhiId.Focus();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                // assigning time according to radio button selected
                if (rdo_morning.Checked)
                {
                    chilarReceive.time = "Morning";
                }
                else if (rdo_evening.Checked)
                {
                    chilarReceive.time = "Evening";
                }
                else
                {
                    MessageBox.Show("Please select a time slot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(!int.TryParse(txt_dodhiId.Text,out int dodhiId))
                {
                    MessageBox.Show("Invalid dodhi Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // checking for not null
                if (string.IsNullOrEmpty(txt_dodhiName.Text))
                {
                    MessageBox.Show("Please add Dodhi name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txt_liters.Text, out decimal grossLiters))
                {
                    MessageBox.Show("Invalid gross liters value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate and parsing the values
                if (!decimal.TryParse(txt_lr.Text, out decimal lr))
                {
                    MessageBox.Show("Invalid lr value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (lr > 35 || lr < 0)
                    {
                        MessageBox.Show("Lr value should between 0 to 35", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }

                if (!decimal.TryParse(txt_fat.Text, out decimal fat))
                {
                    MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!int.TryParse(txt_tsStandard.Text, out int tsStandard))
                {
                    MessageBox.Show("Invalid fat value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                decimal ts = chilarReceive.tsCalculator(lr, fat, grossLiters, tsStandard);

                txt_tsLiters.Text = ts.ToString();


                // assigning values to emloyee object

                chilarReceive.id = int.Parse(txt_id.Text);
                chilarReceive.dodhiId = dodhiId;
                chilarReceive.receiveDate = dtm_picker.Value;
                chilarReceive.dodhiName = txt_dodhiName.Text;
                chilarReceive.grossLiters = grossLiters;
                chilarReceive.fat = fat;
                chilarReceive.lr = lr;
                chilarReceive.tsStandard = tsStandard;
                chilarReceive.tsLiters = ts;


                chilarReceive.updateChilarReceive(chilarReceive);

                // clearing all the text boxes for new entries
                commonFunctions.ClearAllTextBoxes(this);

                // Show updated data in grid view
                txt_id.Text = chilarReceive.GetNextAvailableID().ToString();
                chilarReceive.showDataInGridView(dataGridView2,dtm_picker.Value.Date);
                dtm_picker.Value = DateTime.Today;
                txt_tsStandard.Text = "13";
                getStats();

                txt_dodhiId.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in form code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_dodhiId_TextChanged(object sender, EventArgs e)
        {
            commonFunctions.ShowAccountSuggestions(txt_dodhiId, lstDodhiSuggestions, "employee");
        }

        private void getStats()
        {
            DateTime today = DateTime.Now;

            
            string grossReceive;
            string lr;
            string fat;

            dashboard.getAverageLrFat(out grossReceive, out lr, out fat, today.Date, today.Date);

            decimal avgLr=Math.Round(decimal.Parse(lr), 2);
            decimal avgFat=Math.Round(decimal.Parse(fat), 2);

            txt_averagefat.Text = avgFat.ToString();
            txt_averageLr.Text = avgLr.ToString();
            txt_grossReceive.Text = grossReceive + " Ltrs";
        }

        private void btn_goBack_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            id--;
            if (id != 0)
            {
                chilarReceive.getPurchaseRecordDetail(id, out DateTime date, out int dodhiId, out string dodhiName,
                    out decimal grossLiters, out decimal lr, out decimal fat, out string time, out int tsStandar, out decimal tsLiters);

                txt_id.Text = id.ToString();

                if (date.Date > DateTime.MinValue && date.Date < DateTime.MaxValue)
                {
                    dtm_picker.Value = date.Date;
                }

                txt_dodhiId.Text = dodhiId.ToString();
                txt_dodhiName.Text = dodhiName;
                txt_lr.Text = lr.ToString();
                txt_liters.Text = grossLiters.ToString();
                txt_fat.Text = fat.ToString();
                txt_tsStandard.Text = tsStandar.ToString();
                txt_tsLiters.Text = tsLiters.ToString();


                if (time == "Morning")
                {
                    rdo_morning.Checked = true;
                }
                else
                {
                    rdo_evening.Checked = true;
                }
            }
        }

        private void btn_goForward_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);
            id++;

            if (id <= chilarReceive.getLastRecordId())
            {
                chilarReceive.getPurchaseRecordDetail(id, out DateTime date, out int dodhiId, out string dodhiName,
                    out decimal grossLiters, out decimal lr, out decimal fat, out string time, out int tsStandar, out decimal tsLiters);

                txt_id.Text = id.ToString();

                if (date.Date > DateTime.MinValue && date.Date < DateTime.MaxValue)
                {
                    dtm_picker.Value = date.Date;
                }

                txt_dodhiId.Text = dodhiId.ToString();
                txt_dodhiName.Text = dodhiName;
                txt_lr.Text = lr.ToString();
                txt_liters.Text = grossLiters.ToString();
                txt_fat.Text = fat.ToString();
                txt_tsStandard.Text = tsStandar.ToString();
                txt_tsLiters.Text = tsLiters.ToString();


                if (time == "Morning")
                {
                    rdo_morning.Checked = true;
                }
                else
                {
                    rdo_evening.Checked = true;
                }
            }
        }

        private void dtm_picker_ValueChanged(object sender, EventArgs e)
        {
            chilarReceive.showDataInGridView(dataGridView2, dtm_picker.Value.Date);
        }
    }
}
