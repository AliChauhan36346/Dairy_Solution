using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DairyAccounting;

namespace WindowsFormsApp1
{
    public partial class Employees : Form
    {
        AddEmployees employee = new AddEmployees();

        

        public Employees()
        {
            InitializeComponent();
        }

        

        private void empBtn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empBtn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_employeeName.Text))
                {
                    MessageBox.Show("Please add Employee name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(cmbo_designation.Text))
                {
                    MessageBox.Show("Please add Employee Designation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long phNo;

                // Validate and parse phone number
                if(!string.IsNullOrEmpty(txt_phNo.Text))
                {
                    if (long.TryParse(txt_phNo.Text, out phNo))
                    {
                        employee.phNO = phNo;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                

                // Validate and parse salary
                if (!int.TryParse(txt_salary.Text, out int salary))
                {
                    MessageBox.Show("Invalid Salary value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string status;
                if(chkBx_jobLeft.Checked)
                {
                    status = "resigned";
                    employee.resignDate = dtTm_resignDate.Value;
                }
                else
                {
                    status = "active";
                    employee.resignDate = dtTm_resignDate.Value;
                }

                // assigning values to emloyee object
                employee.id=int.Parse(txt_employeeId.Text);
                employee.name = txt_employeeName.Text;
                employee.address = txt_address.Text;
                employee.designation = cmbo_designation.Text;
                employee.salary = salary;
                employee.hireDate = dtTm_hireDate.Value;
                employee.status=status;

                
               

                // Save employee
                int result=employee.saveEmployee(employee);
                if (result == 0)
                {
                    MessageBox.Show("Employee was not saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txt_employeeName.Text = "";
                txt_address.Text = "";
                txt_phNo.Text = "";
                txt_salary.Text = "";
                cmbo_designation.ValueMember = "";
                chkBx_jobLeft.CheckState.Equals(false);

                // Show updated data in grid view
                employee.showDataInGridView(dataGridView2);
                txt_employeeId.Text = employee.GetNextAvailableID().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            employee.showDataInGridView(dataGridView2);
            txt_employeeId.Text = employee.GetNextAvailableID().ToString();
            dtTm_resignDate.Enabled = false;



        }

        private void chkBx_jobLeft_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBx_jobLeft.Checked)
            {
                dtTm_resignDate.Enabled = true;
                dtTm_resignDate.Value = DateTime.Today;
            }
            else
            {
                dtTm_resignDate.Enabled=false;
            }
            
        }

        private void empBtn_deleteEmployee_Click(object sender, EventArgs e)
        {
            // Get the ID from the textbox
            int id;
            if (!int.TryParse(txt_employeeId.Text, out id))
            {
                MessageBox.Show("Invalid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, proceed with deletion
            if (result == DialogResult.Yes)
            {
                // Call the removeCustomer method with the ID
                employee.removeEmployee(id);

                // clears the textboxes for new entry
                txt_employeeName.Text = "";
                txt_address.Text = "";
                txt_phNo.Text = "";
                txt_salary.Text = "";
                cmbo_designation.ValueMember = "";
                chkBx_jobLeft.CheckState.Equals(false);

                // refresh the id to new one 
                txt_employeeId.Text = employee.GetNextAvailableID().ToString();

                // for refreshing data in gridview after deletion
                employee.showDataInGridView(dataGridView2);
            }


        }

        private void btn_updateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_employeeName.Text))
                {
                    MessageBox.Show("Please add Employee name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(cmbo_designation.Text))
                {
                    MessageBox.Show("Please add Employee Designation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long phNo;

                // Validate and parse phone number
                if (!string.IsNullOrEmpty(txt_phNo.Text))
                {
                    if (long.TryParse(txt_phNo.Text, out phNo))
                    {
                        employee.phNO = phNo;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                // Validate and parse salary
                if (!int.TryParse(txt_salary.Text, out int salary))
                {
                    MessageBox.Show("Invalid Salary value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                employee.id = int.Parse(txt_employeeId.Text);
                employee.name = txt_employeeName.Text;
                employee.address = txt_address.Text;

                employee.designation = cmbo_designation.Text;
                employee.salary = salary;
                employee.hireDate = dtTm_hireDate.Value;


                // Parse resignation date if job left
                if (chkBx_jobLeft.Checked)
                {
                    employee.resignDate = dtTm_resignDate.Value;
                    employee.status = "resigned";
                }
                else
                {
                    employee.status = "Active";
                    employee.resignDate= dtTm_resignDate.Value;
                }

                // Save employee
                employee.updateEmployee(employee);

                // Show updated data in grid view
                employee.showDataInGridView(dataGridView2);

                // clears the textboxes for new entry
                txt_employeeName.Text = "";
                txt_address.Text = "";
                txt_phNo.Text = "";
                txt_salary.Text = "";
                cmbo_designation.ValueMember = "";
                chkBx_jobLeft.CheckState.Equals(false);

                // updates the id text box to new one 
                txt_employeeId.Text = employee.GetNextAvailableID().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Populate text boxes with data from the selected row
                txt_employeeId.Text = row.Cells["ID"].Value.ToString();
                txt_employeeName.Text = row.Cells["Employee Name"].Value.ToString();
                txt_address.Text = row.Cells[" Address "].Value.ToString();
                txt_phNo.Text = row.Cells["Employee PhNo."].Value.ToString();
                txt_salary.Text = row.Cells["Salary"].Value.ToString();
                string designation = row.Cells["Designation"].Value.ToString().Trim(); // Trim leading and trailing spaces

                // Set the SelectedValue property of the ComboBox to the value from the DataGridView
                foreach (var item in cmbo_designation.Items)
                {
                    if (item.ToString().Trim().Equals(designation, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbo_designation.SelectedItem = item;
                        break;
                    }
                }

                // Get the value from the "Status" column to determine if the employee resigned
                string status = row.Cells["Status"].Value.ToString().Trim(); // Trim leading and trailing spaces

                if (status.Equals("resigned", StringComparison.OrdinalIgnoreCase))
                {
                    chkBx_jobLeft.Checked = true;
                    dtTm_resignDate.Enabled = true;
                    DateTime.TryParse(row.Cells["Resign Date"].Value.ToString(), out DateTime resignDate);
                    dtTm_resignDate.Value = resignDate;
                }
                else
                {
                    chkBx_jobLeft.Checked = false;
                    dtTm_resignDate.Enabled = false;
                }

                // Convert cell date value into DateTime format to assign value to DateTime pickers on form
                DateTime.TryParse(row.Cells["Hire Date"].Value.ToString(), out DateTime hireDate);

                // Assign the hire date value to datetime box
                dtTm_hireDate.Value = hireDate;
            }
        }

        private void empBtn_addNew_Click(object sender, EventArgs e)
        {
            txt_employeeName.Text = "";
            txt_address.Text = "";  
            txt_phNo.Text = "";
            txt_salary.Text = "";
            cmbo_designation.ValueMember = "";
            chkBx_jobLeft.Checked = false;

            // Show updated data in grid view
            employee.showDataInGridView(dataGridView2);
            txt_employeeId.Text = employee.GetNextAvailableID().ToString();
        }
    }

}
