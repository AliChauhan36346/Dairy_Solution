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
    public partial class Rate_List : Form
    {
        RateAdjustments rateAdjustments=new RateAdjustments();
        AddEmployees addEmployees= new AddEmployees(); 

        public Rate_List()
        {
            InitializeComponent();
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
        }



        private void Rate_List_Load(object sender, EventArgs e)
        {
            lbl_status.Visible = false;
            List<string> employees=new List<string>();

            employees = addEmployees.GetDodhiNames();

            foreach(var item in employees)
            {
                cmbo_dodhi.Items.Add(item);
            }

            dtm_start.Value=dtm_start.Value.Date.AddDays(-15);

            rateAdjustments.generateRateList(-1, dtm_start.Value.Date, dtm_end.Value.Date, dataGridView1, out decimal averageRate);

            lbl_averageRate.Text = "Average rate is " + averageRate.ToString();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                // Show loading message
                lbl_status.Text = "Updating rates...";
                lbl_status.Visible = true;

                decimal newRate = 0;
                int customerId = 0;
                int customersNumber = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Check if the "New Rate" cell is not empty or null
                    if (row.Cells["New Rate"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["New Rate"].Value.ToString()))
                    {
                        if (decimal.TryParse(row.Cells["New Rate"].Value.ToString(), out decimal rate))
                        {
                            newRate = rate;
                        }
                        else
                        {
                            // Focus on the cell with the invalid value
                            dataGridView1.CurrentCell = row.Cells["New Rate"];
                            dataGridView1.BeginEdit(true);

                            MessageBox.Show("Invalid rate value in the cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lbl_status.Visible = false;

                            return;
                        }
                    }
                    else
                    {
                        // Skip the row if "New Rate" is empty
                        continue;
                    }

                    // Check if the "Cus Id" cell is not empty or null
                    if (row.Cells["Cus Id"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Cus Id"].Value.ToString()))
                    {
                        customerId = Convert.ToInt32(row.Cells["Cus Id"].Value);
                    }
                    else
                    {
                        // Skip the row if "Cus Id" is empty
                        continue;
                    }

                    await Task.Run(() => rateAdjustments.adjustRate("", "single", customerId, "not", newRate, 0));

                    customersNumber++;

                    newRate = 0;
                    customerId = 0;
                }

                lbl_status.Hide();

                // Display success message with total amount added
                if (customersNumber > 0)
                {
                    MessageBox.Show($"Total {customersNumber} customers rate updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("None of the customers rate changes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < (e.RowIndex + e.RowCount); i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void cmbo_dodhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dodhiId=addEmployees.getDodhiIdByName(cmbo_dodhi.Text.Trim());

            rateAdjustments.generateRateList(dodhiId, dtm_start.Value.Date, dtm_end.Value.Date, dataGridView1, out decimal averageRate);

            lbl_averageRate.Text = "Average rate is " + averageRate.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
