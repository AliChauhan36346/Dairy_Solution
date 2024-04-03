using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class AddSales
    {

        Connection dbConnection;

        public int salesId {  get; set; }
        public int id { get; set; }
        public DateTime Date { get; set; }
        public int companyId { get; set; }
        public string companyName { get; set; }
        public decimal rate { get; set; }
        public decimal liters { get; set; }
        public decimal lr { get; set; }
        public decimal fat { get; set; }
        public int tsStandard { get; set; }
        public decimal tsLiters { get; set; }
        public int cashAccountId { get; set; }
        public string cashAccountName { get; set; }
        public int amountReceived { get; set; }
        public decimal salesAmount { get; set; }
        public decimal salesBalance { get; set; }

        public AddSales()
        {
            dbConnection = new Connection();
        }

        public decimal tsCalculator(decimal lr, decimal fat, decimal volume, int tsStandard)
        {
            decimal fatOperations;// for storing calculation with fat
            decimal lrOperations;// for storing calculation with lr
            decimal volumeOperations;// for volume calculations
            decimal snf; // for storing snf 
            decimal ts; // for storing ts

            fatOperations = .22m * fat + .72m;

            lrOperations = lr / 4m;

            snf = fatOperations + lrOperations;

            volumeOperations = (snf + fat) * volume;

            ts = volumeOperations / tsStandard;

            ts = Math.Round(ts, 2);

            return ts;

        }

        public void saveSales(AddSales sales)
        {
            try
            {
                // Opening connection with database
                dbConnection.openConnection();

                // Check if the sales ID already exists
                string checkQuery = "SELECT COUNT(*) FROM sales WHERE salesId = @salesId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@salesId", sales.id);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Sales ID already exists. Please add a new one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string companyCheck = "SELECT COUNT(*) FROM CompaniesTbl where companyId=@companyId";
                using (SqlCommand checkCommand = new SqlCommand(companyCheck, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@companyId", sales.companyId);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Company not found with the provided id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert sales record into the database
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO sales (date, companyId, company, liters, rate, lr, fat, tsStandard, tsLiters, amount, amountReceived, accountId, accountName, balance) " +
                                          "VALUES (@date, @companyId, @companyName, @liters, @rate, @lr, @fat, @tsStandard, @tsLiters, @amount, @amountReceived, @accountId, @accountName, @balance)";
                    command.Parameters.AddWithValue("@date", sales.Date);
                    command.Parameters.AddWithValue("@companyId", sales.companyId);
                    command.Parameters.AddWithValue("@companyName", sales.companyName);
                    command.Parameters.AddWithValue("@liters", sales.liters);
                    command.Parameters.AddWithValue("@rate", sales.rate);
                    command.Parameters.AddWithValue("@lr", sales.lr);
                    command.Parameters.AddWithValue("@fat", sales.fat);
                    command.Parameters.AddWithValue("@tsStandard", sales.tsStandard);
                    command.Parameters.AddWithValue("@tsLiters", sales.tsLiters);
                    command.Parameters.AddWithValue("@amount", sales.salesAmount);
                    command.Parameters.AddWithValue("@amountReceived", sales.amountReceived);
                    command.Parameters.AddWithValue("@accountId", sales.cashAccountId);
                    command.Parameters.AddWithValue("@accountName", sales.cashAccountName);
                    command.Parameters.AddWithValue("@balance", sales.salesBalance);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Record was not saved! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                // Close the database connection
                dbConnection.closeConnection();
            }
        }


        public void showDataInGridView(DataGridView dataGridView)
        {
            DateTime today = DateTime.Today;
            try
            {
                dbConnection.openConnection();

                // Initialize query to select all records 
                string query = $"SELECT salesId, date, companyId, company, liters, rate, lr, fat, tsStandard, tsLiters, amount, amountReceived, accountId, accountName, balance FROM sales";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["salesId"].ColumnName = "Sales Id";
                        dataTable.Columns["date"].ColumnName = "Date";
                        dataTable.Columns["companyId"].ColumnName = "Company Id";
                        dataTable.Columns["company"].ColumnName = "Company Name";
                        dataTable.Columns["rate"].ColumnName = "Rate";
                        dataTable.Columns["liters"].ColumnName = "Gross Liters";

                        dataTable.Columns["lr"].ColumnName = "LR";
                        dataTable.Columns["fat"].ColumnName = "Fat";
                        dataTable.Columns["tsStandard"].ColumnName = "Ts Standard";
                        dataTable.Columns["tsLiters"].ColumnName = "Ts Liters";
                        dataTable.Columns["amount"].ColumnName = "Amount";
                        dataTable.Columns["amountReceived"].ColumnName = "Amount Received";
                        dataTable.Columns["accountId"].ColumnName = "Account Id";
                        dataTable.Columns["accountName"].ColumnName = "Account Name";
                        dataTable.Columns["balance"].ColumnName = "Balance";

                        // Sort the records in descending order by sales ID
                        dataTable.DefaultView.Sort = "Sales Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        // Set width of each column individually
                        dataGridView.Columns["Sales Id"].Width = 70;
                        dataGridView.Columns["Date"].Width = 100;
                        dataGridView.Columns["Company Id"].Width = 70;
                        dataGridView.Columns["Company Name"].Width = 160;
                        dataGridView.Columns["Rate"].Width = 85;
                        dataGridView.Columns["Gross Liters"].Width = 90;
                        dataGridView.Columns["LR"].Width = 50;
                        dataGridView.Columns["Fat"].Width = 50;
                        dataGridView.Columns["Ts Standard"].Width = 80;
                        dataGridView.Columns["Ts Liters"].Width = 90;
                        dataGridView.Columns["Amount"].Width = 90;
                        dataGridView.Columns["Amount Received"].Width = 110;
                        dataGridView.Columns["Account Id"].Width = 70;
                        dataGridView.Columns["Account Name"].Width = 120;
                        dataGridView.Columns["Balance"].Width = 110;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally // Close database connection
            {
                dbConnection.closeConnection();
            }
        }



        public int GetNextAvailableID()
        {
            // Logic to retrieve the next available ID from the database
            int nextID = 0;
            try
            {
                // Open connection to the database
                dbConnection.openConnection();

                // Execute a query to get the maximum ID value
                string query = "SELECT ISNULL(MAX(salesId), 0) + 1 FROM Sales";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving next available ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection to the database
                dbConnection.closeConnection();
            }
            return nextID;
        }

        public void removeSales(int id) // to delete the sales
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM Sales WHERE salesId=@id";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Sales with id "+id+" removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting chilar receive record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updatesales(AddSales sales)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the sales ID exists
                string checkQuery = "SELECT COUNT(*) FROM sales WHERE salesId = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", sales.id);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Sales record with the provided ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE sales " +
                    "SET date = @date, companyId = @companyId, company = @company, liters = @liters, lr = @lr, fat=@fat, rate=@rate, tsStandard=@tsStandard, tsLiters=@tsLiters, amount = @amount, amountReceived = @amountReceived, accountId = @accountId, accountName = @accountName,  balance = @balance WHERE salesId = @id";

                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@date", sales.Date);
                    updateCommand.Parameters.AddWithValue("@companyId", sales.companyId);
                    updateCommand.Parameters.AddWithValue("@company", sales.companyName);
                    updateCommand.Parameters.AddWithValue("@liters", sales.liters);
                    updateCommand.Parameters.AddWithValue("@lr", sales.lr);
                    updateCommand.Parameters.AddWithValue("@fat", sales.fat);
                    updateCommand.Parameters.AddWithValue("@rate", sales.rate);
                    updateCommand.Parameters.AddWithValue("@tsStandard", sales.tsStandard);
                    updateCommand.Parameters.AddWithValue("@tsLiters", sales.tsLiters);
                    updateCommand.Parameters.AddWithValue("@amount", sales.salesAmount);
                    updateCommand.Parameters.AddWithValue("@amountReceived", sales.amountReceived);
                    updateCommand.Parameters.AddWithValue("@accountId", sales.cashAccountId);
                    updateCommand.Parameters.AddWithValue("@accountName", sales.cashAccountName);
                    updateCommand.Parameters.AddWithValue("@balance", sales.salesBalance);
                    updateCommand.Parameters.AddWithValue("@id", sales.id);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Sales updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


    }
}
