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
    public class AddReceipts
    {
        Connection dbConnection;

        public int receiptId { get; set; }
        public DateTime date { get; set; }
        public int accountId { get; set; }
        public string accountName { get; set; }
        public decimal amount { get; set; }
        public int cashAccountId { get; set; }
        public string cashAccountName { get; set; }
        public string discription { get; set; }

        public AddReceipts()
        {
            dbConnection = new Connection();
        }

        public void saveReceipts(AddReceipts Receipts)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();
                // Check if the Company name already exists
                string checkQuery = "SELECT COUNT(*) FROM Receipts WHERE receiptId=@receiptId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {

                    checkCommand.Parameters.AddWithValue("@receiptId", Receipts.receiptId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Record with the same payment id already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO Receipts(date, accountId, accountName, amount, cashAccountId, cashAccountName, discription) " +
                                          "VALUES (@date, @accountId, @accountName, @amount, @cashAccountId, @cashAccountName, @discription)";
                    command.Parameters.AddWithValue("@date", Receipts.date);
                    command.Parameters.AddWithValue("@accountId", Receipts.accountId);
                    command.Parameters.AddWithValue("@accountName", Receipts.accountName);
                    command.Parameters.AddWithValue("@amount", Receipts.amount);
                    command.Parameters.AddWithValue("@cashAccountId", Receipts.cashAccountId);
                    command.Parameters.AddWithValue("@cashAccountName", Receipts.cashAccountName);
                    command.Parameters.AddWithValue("@discription", Receipts.discription);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving Receipts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Record was not saved! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void showDataInGridView(DataGridView dataGridView)
        {
            try
            {
                dbConnection.openConnection();

                // Initialize query to select all records 
                string query = "SELECT receiptId, date, accountId, accountName, amount, cashAccountId, cashAccountName, discription FROM Receipts";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["receiptId"].ColumnName = "Id";
                        dataTable.Columns["date"].ColumnName = "Date";
                        dataTable.Columns["accountId"].ColumnName = "Company Id";
                        dataTable.Columns["accountName"].ColumnName = "Company Name";
                        dataTable.Columns["amount"].ColumnName = "Amount";
                        dataTable.Columns["cashAccountId"].ColumnName = "Account Id";
                        dataTable.Columns["cashAccountName"].ColumnName = "Account Name";
                        dataTable.Columns["discription"].ColumnName = "Discription";

                        // Sort the records in descending order by Company purchasereceiptId
                        dataTable.DefaultView.Sort = "Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        dataGridView.Columns["Id"].Width = 60;
                        dataGridView.Columns["Date"].Width = 100;
                        dataGridView.Columns["Company Id"].Width = 80;
                        dataGridView.Columns["Company Name"].Width = 150;
                        dataGridView.Columns["Amount"].Width = 110;
                        dataGridView.Columns["Account Id"].Width = 80;
                        dataGridView.Columns["Account Name"].Width = 120;
                        dataGridView.Columns["Discription"].Width = 150;
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

        public int GetNextAvailableId()
        {
            // Logic to retrieve the next available purchasereceiptId from the database
            int nextpurchasereceiptId = 0;
            try
            {
                // Open connection to the database
                dbConnection.openConnection();

                // Execute a query to get the maximum purchasereceiptId value
                string query = "SELECT ISNULL(MAX(receiptId), 0) + 1 FROM Receipts";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextpurchasereceiptId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving next available receipt Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection to the database
                dbConnection.closeConnection();
            }
            return nextpurchasereceiptId;
        }

        public void removeReceipts(int receiptId) // to delete the Receipts
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM Receipts WHERE receiptId=@receiptId";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding purchasereceiptId parameter
                    deleteCommand.Parameters.AddWithValue("@receiptId", receiptId);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Payment record removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting payment record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updateReceipts(AddReceipts Receipts)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the Company purchasereceiptId exists
                string checkQuery = "SELECT COUNT(*) FROM Receipts WHERE receiptId = @receiptId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@receiptId", Receipts.receiptId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Purchase record with the purchase Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE Receipts " +
                    "SET date=@date, accountId=@accountId, accountName=@accountName, amount=@amount, cashAccountId=@cashAccountName, discription=@discription WHERE receiptId = @receiptId";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@date", Receipts.date);
                    updateCommand.Parameters.AddWithValue("@accountId", Receipts.accountId);
                    updateCommand.Parameters.AddWithValue("@accountName", Receipts.accountName);
                    updateCommand.Parameters.AddWithValue("@amount", Receipts.amount);
                    updateCommand.Parameters.AddWithValue("@cashAccountId", Receipts.cashAccountId);
                    updateCommand.Parameters.AddWithValue("@cashAccountName", Receipts.cashAccountName);
                    updateCommand.Parameters.AddWithValue("@discription", Receipts.discription);
                    updateCommand.Parameters.AddWithValue("@receiptId", Receipts.receiptId);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Payment record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Receipts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string query = "SELECT TOP 1 receiptId FROM Receipts ORDER BY receiptId DESC";

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
                MessageBox.Show("Error retrieving last receipt Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return lastRecordId;
        }

        public void getPurchaseRecordDetail(int receId, out DateTime date, out int accountId, out string accountName, out decimal amount,
            out int cashAccountId, out string cashAccountName, out string discription)
        {

            date = DateTime.MinValue;
            accountId = 0;
            accountName = "";
            amount = 0;
            cashAccountId = 0;
            cashAccountName = "";
            discription = "";

            try
            {
                dbConnection.openConnection();

                string query = "SELECT date, accountId, accountName, amount, cashAccountId, cashAccountName, discription FROM Receipts WHERE receiptId=@receiptId";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@receiptId", receId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            date = DateTime.Parse(reader["date"].ToString());
                            accountId = int.Parse(reader["accountId"].ToString());
                            accountName = reader["accountName"].ToString();
                            amount = decimal.Parse(reader["amount"].ToString());
                            cashAccountId = int.Parse(reader["cashAccountId"].ToString());
                            cashAccountName = reader["cashAccountName"].ToString();
                            discription = reader["discription"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving payment record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }


        }
    }
}
