using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class AddChilarReceive
    {
        Connection dbConnection;

        public int id {  get; set; }
        public DateTime receiveDate { get; set; }
        public string time { get; set; }
        public int dodhiId {  get; set; }
        public string dodhiName { get; set; }
        public decimal grossLiters {  get; set; }
        public decimal lr {  get; set; }
        public decimal fat {  get; set; }
        public int tsStandard { get; set; }
        public decimal tsLiters { get; set; }

        public AddChilarReceive()
        {
            dbConnection = new Connection();
        }

        public decimal tsCalculator(decimal lr, decimal fat, decimal volume, int tsStandard)
        {
            decimal fatOperations;// for storing calculation with fat
            decimal lrOperations;// for storing calculation with lr
            decimal volumeOperations;// for volume calculations
            decimal snf; // for storing snf 
            decimal ts=13; // for storing ts

            fatOperations = .22m * fat + .72m;

            lrOperations = lr / 4m;

            snf = fatOperations + lrOperations;

            volumeOperations = (snf + fat) * volume;

            ts = volumeOperations / tsStandard;

            ts = Math.Round(ts, 2);

            return ts;

        }

        public void saveChilarReceive(AddChilarReceive chilarReceive)
        {


            try
            {
                // opening connection with database
                dbConnection.openConnection();
                // Check if the customer name already exists
                string checkQuery = "SELECT COUNT(*) FROM ChilarReceive WHERE chilarReceiveId=@chilarReceiveId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    
                    checkCommand.Parameters.AddWithValue("@chilarReceiveId", chilarReceive.id);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Milk has been received with the same Receive ID earlier. Please add new one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO ChilarReceive(date, time, dodhiId, dodhi, grossLiters, lr, fat, tsStandard, tsLiters) " +
                                          "VALUES (@date, @time, @dodhiId, @dodhiName, @grossLiters, @lr, @fat, @tsStandard, @tsLiters)";
                    command.Parameters.AddWithValue("@date", chilarReceive.receiveDate);
                    command.Parameters.AddWithValue("@time", chilarReceive.time);
                    command.Parameters.AddWithValue("@dodhiId", chilarReceive.dodhiId);
                    command.Parameters.AddWithValue("@dodhiName", chilarReceive.dodhiName);
                    command.Parameters.AddWithValue("@grossLiters", chilarReceive.grossLiters);
                    command.Parameters.AddWithValue("@lr", chilarReceive.lr);
                    command.Parameters.AddWithValue("@fat", chilarReceive.fat);
                    command.Parameters.AddWithValue("@tsStandard", chilarReceive.tsStandard);
                    command.Parameters.AddWithValue("@tsLiters", chilarReceive.tsLiters);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving chilar receive: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Record was not saved! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void showDataInGridView(DataGridView dataGridView, DateTime date)
        {
            try
            {
                dbConnection.openConnection();

                // Initialize query to select all records 
                string query = "SELECT chilarReceiveId, date, time, dodhiId, dodhi, grossLiters, lr, fat, tsStandard, tsLiters FROM ChilarReceive WHERE date=@date";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@date", date.Date);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["chilarReceiveId"].ColumnName = "Receive Id";
                        dataTable.Columns["date"].ColumnName = "Date";
                        dataTable.Columns["time"].ColumnName = "Time";
                        dataTable.Columns["dodhiId"].ColumnName = "Dodhi Id";
                        dataTable.Columns["dodhi"].ColumnName = "Dodhi Name";
                        dataTable.Columns["grossLiters"].ColumnName = "Gross Liters";
                        dataTable.Columns["lr"].ColumnName = "LR";
                        dataTable.Columns["fat"].ColumnName = "Fat";
                        dataTable.Columns["tsStandard"].ColumnName = "Ts-Standard";
                        dataTable.Columns["tsLiters"].ColumnName = "Ts Liters";

                        // Sort the records in descending order by customer ID
                        dataTable.DefaultView.Sort = "Receive Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;
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
                string query = "SELECT ISNULL(MAX(ChilarReceiveId), 0) + 1 FROM ChilarReceive";
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

        public void removeChilarReceive(int id) // to delete the chilarReceive
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM ChilarReceive WHERE chilarReceiveId=@id";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Chilar receive record removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void updateChilarReceive(AddChilarReceive chilarReceive)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the customer ID exists
                string checkQuery = "SELECT COUNT(*) FROM ChilarReceive WHERE ChilarReceiveId = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", chilarReceive.id);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Chilar receive record with the provided ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE ChilarReceive " +
                    "SET date = @date, time = @time, dodhiId = @dodhiId, dodhi = @dodhi, grossLiters = @grossLiters, lr = @lr, fat=@fat, tsStandard=@tsStandard, tsLiters=@tsLiters WHERE ChilarReceiveId = @id";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@date", chilarReceive.receiveDate);
                    updateCommand.Parameters.AddWithValue("@time", chilarReceive.time);
                    updateCommand.Parameters.AddWithValue("@dodhiId", chilarReceive.dodhiId);
                    updateCommand.Parameters.AddWithValue("@dodhi", chilarReceive.dodhiName);
                    updateCommand.Parameters.AddWithValue("@grossLiters", chilarReceive.grossLiters);
                    updateCommand.Parameters.AddWithValue("@lr", chilarReceive.lr);
                    updateCommand.Parameters.AddWithValue("@fat", chilarReceive.fat);
                    updateCommand.Parameters.AddWithValue("@tsStandard", chilarReceive.tsStandard);
                    updateCommand.Parameters.AddWithValue("@tsLiters", chilarReceive.tsLiters);
                    updateCommand.Parameters.AddWithValue("@id", chilarReceive.id);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("chilarReceive updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating chilarReceive: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public int getLastRecordId()
        {
            int lastRecordId = 0;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT TOP 1 chilarReceiveId FROM ChilarReceive ORDER BY chilarReceiveId DESC";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        lastRecordId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving last chilar receive Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return lastRecordId;
        }

        public void getPurchaseRecordDetail(int chilarId, out DateTime date, out int dodhiId, out string dodhiName,
            out decimal grossliters, out decimal lr, out decimal fat, out string time, out int tsStandar, out decimal tsLiters)
        {

            date = DateTime.MinValue;
            dodhiId = 0;
            dodhiName = "";
            grossliters = 0;
            lr = 0;
            fat = 0;
            time = "";
            dodhiId = 0;
            dodhiName = "";
            tsLiters = 0;
            tsStandar = 0;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT date, time, dodhiId, dodhi, lr, grossLiters, fat, tsStandard, tsLiters FROM ChilarReceive WHERE chilarReceiveId=@chilarReceiveId";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@chilarReceiveId", chilarId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            date = DateTime.Parse(reader["date"].ToString());
                            grossliters = decimal.Parse(reader["grossLiters"].ToString());
                            lr = decimal.Parse(reader["lr"].ToString());
                            time = reader["time"].ToString().Trim();
                            dodhiId = int.Parse(reader["dodhiId"].ToString());
                            dodhiName = reader["dodhi"].ToString();
                            fat = decimal.Parse(reader["fat"].ToString());
                            tsStandar = int.Parse(reader["tsStandard"].ToString());
                            tsLiters = decimal.Parse(reader["tsLiters"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving chilar receive record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

        }

    }
}
