using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class RateAdjustments
    {
        Connection dbConnection;

        AddCustomers addCustomers=new AddCustomers();

        

        public RateAdjustments()
        {
            dbConnection = new Connection();
        }
        // increment,decriment,new   //filteration like dohdi  //to store accountid,d id etc  //changes   //tell from which table changes will made
        public void adjustRate(string increaseOrDecrease, string filter, int filterIdOrAccountId,string address, decimal rate, int accountBelongsTo)
        {
            string fromTable;
            string whereChange;

            // from which table the changes made
            fromTable = (accountBelongsTo == 0) ? "CustomersTbl" : "CompaniesTbl";

            // for filtration
            switch (filter)
            {
                case "dodhi":
                    whereChange = "WHERE dodhiId=@dodhiId";
                    break;
                case "address":
                    whereChange = "WHERE address LIKE @address";
                    break;
                case "single":
                    whereChange = (accountBelongsTo == 0) ? "WHERE customerId=@customerId" : "WHERE companyId=@companyId";
                    break;
                default:
                    whereChange = "";
                    break;
            }

            try
            {
                dbConnection.openConnection();

                string rateChangeQuery;

                if (increaseOrDecrease == "increment")
                {
                    rateChangeQuery = $"UPDATE {fromTable} SET rate=rate+@RateChange {whereChange}";
                }
                else if (increaseOrDecrease == "decrement")
                {
                    rateChangeQuery = $"UPDATE {fromTable} SET rate=rate-@RateChange {whereChange}";
                }
                else
                {
                    rateChangeQuery = $"UPDATE {fromTable} SET rate=@rateChange {whereChange}";
                }

                using (SqlCommand command = new SqlCommand(rateChangeQuery, dbConnection.connection))
                {
                    // Add parameters
                    command.Parameters.AddWithValue("@RateChange", rate);

                    if (filter == "dodhi")
                    {
                        command.Parameters.AddWithValue("@dodhiId", filterIdOrAccountId);
                    }
                    else if (filter == "address")
                    {
                        command.Parameters.AddWithValue("@address", "%" + filterIdOrAccountId + "%");

                    }
                    else if (filter == "single")
                    {
                        if (accountBelongsTo == 0)
                        {
                            command.Parameters.AddWithValue("@customerId", filterIdOrAccountId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@companyId", filterIdOrAccountId);
                        }
                    }
                    

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                if (address != "not")
                {
                    MessageBox.Show("Rate updated successfully for the selected accounts.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                

                MessageBox.Show("Error updating rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        

        public decimal GetCustomerPreviousMilk(int customerId, DateTime startDate, DateTime endDate)
        {
            decimal totalLiters = 0;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT ISNULL(SUM(liters), 0) FROM purchases WHERE customerId = @customerId AND date >= @startDate AND date <= @endDate";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    // Use ExecuteScalar to get the sum of liters
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        totalLiters = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in calculating milk for rate list: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return totalLiters;
        }


        public void generateRateList(int dodhiId, DateTime startDate, DateTime endDate, DataGridView dataGridView, out decimal averageRate)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Cus Id");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Rate");
            dataTable.Columns.Add("Previous volume");
            dataTable.Columns.Add("New Rate");

            int customerId= 0;
            string customerName = "";
            decimal customerRate = 0;
            decimal previousMilk = 0;

            //average rate
            decimal totalMilk = 0;
            decimal totalAmount = 0;

            averageRate= 0;

            Dictionary<int, string> customerIdName;

            if (dodhiId != -1)
            {
                customerIdName=addCustomers.GetCustomersIdsAndNamesByDodhi(dodhiId);
            }
            else
            {
                customerIdName = addCustomers.GetCustomersIdsAndNames();
            }

            foreach(var customer in customerIdName)
            {
                customerId = customer.Key;
                customerName= customer.Value;

                customerRate = addCustomers.getCustomerRate(customerId.ToString());

                previousMilk = GetCustomerPreviousMilk(customerId,startDate,endDate);

                dataTable.Rows.Add(customerId,customerName,customerRate,previousMilk,"");

                // calculating average purchase rate
                totalMilk += previousMilk;
                totalAmount += customerRate * previousMilk;


                customerId = 0;
                customerName = "";
                customerRate = 0;
                previousMilk= 0;
            }

            if(totalMilk != 0 && totalAmount!=0)
            {
                averageRate = totalAmount / totalMilk;
            }
            else
            {
                averageRate = 0;
            }
            

            dataGridView.DataSource = dataTable;

            dataGridView.Columns["Cus Id"].Width = 65;
            dataGridView.Columns["Customer Name"].Width = 200;
            dataGridView.Columns["Rate"].Width = 75;
            dataGridView.Columns["Previous Volume"].Width = 75;
            dataGridView.Columns["New Rate"].Width = 70;


            dataGridView.Columns["Cus Id"].HeaderCell.Style.BackColor = Color.Gainsboro;
            dataGridView.Columns["Customer Name"].HeaderCell.Style.BackColor = Color.Gainsboro;
            dataGridView.Columns["Rate"].HeaderCell.Style.BackColor = Color.Gainsboro;
            dataGridView.Columns["Previous Volume"].HeaderCell.Style.BackColor = Color.Gainsboro;
            dataGridView.Columns["New Rate"].HeaderCell.Style.BackColor = Color.Gainsboro;


            dataGridView.EnableHeadersVisualStyles = false;
        }

    }
}
