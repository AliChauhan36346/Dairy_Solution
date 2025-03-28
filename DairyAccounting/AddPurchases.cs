﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class AddPurchases
    {
        Connection dbConnection;

        public int purchaseId {  get; set; }
        public DateTime date {  get; set; }
        public int customerId {  get; set; }
        public string customerName {  get; set; }
        public int dodhiId {  get; set; }
        public string dodhi {  get; set; }
        public string time {  get; set; }
        public decimal rate {  get; set; }
        public decimal liters {  get; set; }
        public decimal amount {  get; set; }

        public AddPurchases()
        {
            dbConnection = new Connection();
        }

        

        public void savepurchase(AddPurchases purchases)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();
                // Check if the customer name already exists
                string checkQuery = "SELECT COUNT(*) FROM Purchases WHERE purchaseId=@purchaseId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {

                    checkCommand.Parameters.AddWithValue("@purchaseId", purchases.purchaseId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Record with the same purchase id already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO purchases(date, customerId, customerName, dodhiId, dodhi, time, rate, liters, amount) " +
                                          "VALUES (@date, @customerId, @customerName, @dodhiId, @dodhi, @time, @rate, @liters, @amount)";
                    command.Parameters.AddWithValue("@date", purchases.date);
                    command.Parameters.AddWithValue("@customerId", purchases.customerId);
                    command.Parameters.AddWithValue("@customerName", purchases.customerName);
                    command.Parameters.AddWithValue("@dodhiId", purchases.dodhiId);
                    command.Parameters.AddWithValue("@dodhi", purchases.dodhi);
                    command.Parameters.AddWithValue("@time", purchases.time);
                    command.Parameters.AddWithValue("@rate", purchases.rate);
                    command.Parameters.AddWithValue("@liters", purchases.liters);
                    command.Parameters.AddWithValue("@amount", purchases.amount);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "SELECT purchaseID, date, customerID, customerName, dodhiId, dodhi, time, rate, liters, amount FROM Purchases WHERE date=@date";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["purchaseID"].ColumnName = "Id";
                        dataTable.Columns["date"].ColumnName = "Date";
                        dataTable.Columns["time"].ColumnName = "Time";
                        dataTable.Columns["customerId"].ColumnName = "Customer Id";
                        dataTable.Columns["customerName"].ColumnName = "Customer Name";
                        dataTable.Columns["dodhiId"].ColumnName = "Dodhi Id";
                        dataTable.Columns["dodhi"].ColumnName = "Dodhi Name";
                        dataTable.Columns["liters"].ColumnName = "Gross Liters";
                        dataTable.Columns["rate"].ColumnName = "Rate";
                        dataTable.Columns["amount"].ColumnName = "Amount";

                        // Sort the records in descending order by customer purchasepurchaseId
                        dataTable.DefaultView.Sort = "Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        dataGridView.Columns["Id"].Width = 60;
                        dataGridView.Columns["Date"].Width = 80;
                        dataGridView.Columns["Time"].Width = 85;
                        dataGridView.Columns["Customer Id"].Width = 80;
                        dataGridView.Columns["Customer Name"].Width = 280;
                        dataGridView.Columns["Dodhi Id"].Width = 75;
                        dataGridView.Columns["Dodhi Name"].Width = 232;
                        dataGridView.Columns["Gross Liters"].Width = 100;
                        dataGridView.Columns["Rate"].Width = 75;
                        dataGridView.Columns["Amount"].Width = 100;
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

        public int getLastRecordId()
        {
            int lastRecordId = 0;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT TOP 1 PurchaseId FROM Purchases ORDER BY PurchaseId DESC";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        lastRecordId = Convert.ToInt32(result);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retrieving Purchase Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return lastRecordId;
        }

        public void getPurchaseRecordDetail(int  purchaseId, out DateTime date, out int customerid, out string customerName,
            out decimal liters, out decimal rate, out string time, out int dodhiId, out string dodhiName, out decimal totalAmount)
        {

            date = DateTime.MinValue;
            customerid = 0;
            customerName = "";
            liters = 0;
            rate = 0;
            time = "";
            dodhiId = 0;
            dodhiName = "";
            totalAmount = 0;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT date, customerID, customerName, dodhiId, dodhi, time, rate, liters, amount FROM Purchases WHERE purchaseID=@purchaseID";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@purchaseID", purchaseId);

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            date = DateTime.Parse(reader["date"].ToString());
                            customerid = int.Parse(reader["customerID"].ToString());
                            customerName = reader["customerName"].ToString();
                            liters = decimal.Parse(reader["liters"].ToString());
                            rate = decimal.Parse(reader["rate"].ToString());
                            time = reader["time"].ToString().Trim();
                            dodhiId = int.Parse(reader["dodhiId"].ToString());
                            dodhiName = reader["dodhi"].ToString();
                            totalAmount = decimal.Parse(reader["amount"].ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retrieving purchase record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

        }

        public int GetNextAvailableId()
        {
            // Logic to retrieve the next available purchasepurchaseId from the database
            int nextpurchasepurchaseId = 0;
            try
            {
                // Open connection to the database
                dbConnection.openConnection();

                // Execute a query to get the maximum purchasepurchaseId value
                string query = "SELECT ISNULL(MAX(purchaseId), 0) + 1 FROM Purchases";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextpurchasepurchaseId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving next available purchase Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection to the database
                dbConnection.closeConnection();
            }
            return nextpurchasepurchaseId;
        }

        public void removepurchases(int purchasepurchaseId) // to delete the purchases
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM purchases WHERE purchaseId=@purchaseId";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding purchasepurchaseId parameter
                    deleteCommand.Parameters.AddWithValue("@purchaseId", purchasepurchaseId);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Purchase record removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting purchase record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updatepurchases(AddPurchases purchases)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the customer purchasepurchaseId exists
                string checkQuery = "SELECT COUNT(*) FROM Purchases WHERE purchaseID = @purchaseId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@purchaseId", purchases.purchaseId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Purchase record with the purchase Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                // Update SQL statement
                string updateQuery = "UPDATE Purchases " +
                    "SET date=@date, customerId=@customerId, customerName=@customerName, dodhiId=@dodhiId, dodhi=@dodhi, time=@time, rate=@rate, liters=@liters, amount=@amount WHERE purchaseId = @purchaseId";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@date", purchases.date);
                    updateCommand.Parameters.AddWithValue("@customerId", purchases.customerId);
                    updateCommand.Parameters.AddWithValue("@customerName", purchases.customerName);
                    updateCommand.Parameters.AddWithValue("@dodhiId", purchases.dodhiId);
                    updateCommand.Parameters.AddWithValue("@dodhi", purchases.dodhi);
                    updateCommand.Parameters.AddWithValue("@time", purchases.time);
                    updateCommand.Parameters.AddWithValue("@rate", purchases.rate);
                    updateCommand.Parameters.AddWithValue("@liters", purchases.liters);
                    updateCommand.Parameters.AddWithValue("@amount", purchases.amount);
                    updateCommand.Parameters.AddWithValue("@purchaseId", purchases.purchaseId);

                    

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Purchase record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating purchases: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

       







    }
}
