using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class AddPayments
    {
        Connection dbConnection;

        public int paymentId { get; set; }
        public DateTime date { get; set; }
        public int accountId { get; set; }
        public string accountName { get; set; }
        public decimal amount { get; set; }
        public int cashAccountId { get; set; }
        public string cashAccountName { get; set; }
        public string discription { get; set; }

        public AddPayments()
        {
            dbConnection = new Connection();
        }

        public void savePayments(AddPayments payments)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();
                // Check if the customer name already exists
                string checkQuery = "SELECT COUNT(*) FROM Payments WHERE PaymentId=@PaymentId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {

                    checkCommand.Parameters.AddWithValue("@PaymentId", payments.paymentId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Record with the same payment id already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string customerCheck = "SELECT COUNT(*) FROM CustomersTbl WHERE customerId=@customerId";

                using(SqlCommand  customerCheckCommand = new SqlCommand(customerCheck, dbConnection.connection))
                {
                    customerCheckCommand.Parameters.AddWithValue("@customerId", payments.accountId);

                    int count= (int)customerCheckCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Customer not found with the provided Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO Payments(date, accountId, accountName, amount, cashAccountId, cashAccountName, discription) " +
                                          "VALUES (@date, @accountId, @accountName, @amount, @cashAccountId, @cashAccountName, @discription)";
                    command.Parameters.AddWithValue("@date", payments.date);
                    command.Parameters.AddWithValue("@accountId", payments.accountId);
                    command.Parameters.AddWithValue("@accountName", payments.accountName);
                    command.Parameters.AddWithValue("@amount", payments.amount);
                    command.Parameters.AddWithValue("@cashAccountId", payments.cashAccountId);
                    command.Parameters.AddWithValue("@cashAccountName", payments.cashAccountName);
                    command.Parameters.AddWithValue("@discription", payments.discription);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "SELECT PaymentId, date, accountId, accountName, amount, cashAccountId, cashAccountName, discription FROM Payments";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["PaymentId"].ColumnName = "Id";
                        dataTable.Columns["date"].ColumnName = "Date";
                        dataTable.Columns["accountId"].ColumnName = "Customer Id";
                        dataTable.Columns["accountName"].ColumnName = "Customer Name";
                        dataTable.Columns["amount"].ColumnName = "Amount";
                        dataTable.Columns["cashAccountId"].ColumnName = "Account Id";
                        dataTable.Columns["cashAccountName"].ColumnName = "Account Name";
                        dataTable.Columns["discription"].ColumnName = "Discription";

                        // Sort the records in descending order by customer purchasepaymentId
                        dataTable.DefaultView.Sort = "Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        dataGridView.Columns["Id"].Width = 70;
                        dataGridView.Columns["Date"].Width = 100;
                        dataGridView.Columns["Customer Id"].Width = 115;
                        dataGridView.Columns["Customer Name"].Width = 160;
                        dataGridView.Columns["Amount"].Width = 110;
                        dataGridView.Columns["Account Id"].Width = 110;
                        dataGridView.Columns["Account Name"].Width = 140;
                        dataGridView.Columns["Discription"].Width = 190;
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
            // Logic to retrieve the next available purchasepaymentId from the database
            int nextpurchasepaymentId = 0;
            try
            {
                // Open connection to the database
                dbConnection.openConnection();

                // Execute a query to get the maximum purchasepaymentId value
                string query = "SELECT ISNULL(MAX(paymentId), 0) + 1 FROM Payments";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextpurchasepaymentId = Convert.ToInt32(result);
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
            return nextpurchasepaymentId;
        }

        public void removePayments(int PaymentId) // to delete the payments
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM Payments WHERE PaymentId=@PaymentId";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding purchasepaymentId parameter
                    deleteCommand.Parameters.AddWithValue("@PaymentId", PaymentId);

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

        public void updatepayments(AddPayments payments)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the customer purchasepaymentId exists
                string checkQuery = "SELECT COUNT(*) FROM payments WHERE paymentId = @paymentId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@paymentId", payments.paymentId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Purchase record with the purchase Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string customerCheck = "SELECT COUNT(*) FROM CustomersTbl WHERE customerId=@customerId";

                using (SqlCommand customerCheckCommand = new SqlCommand(customerCheck, dbConnection.connection))
                {
                    customerCheckCommand.Parameters.AddWithValue("@customerId", payments.accountId);

                    int count = (int)customerCheckCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Customer not found with the provided Id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE payments " +
                    "SET date=@date, accountId=@accountId, accountName=@accountName, amount=@amount, cashAccountId=@cashAccountId, cashAccountName=@cashAccountName, discription=@discription WHERE PaymentId = @PaymentId";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@date", payments.date);
                    updateCommand.Parameters.AddWithValue("@accountId", payments.accountId);
                    updateCommand.Parameters.AddWithValue("@accountName", payments.accountName);
                    updateCommand.Parameters.AddWithValue("@amount", payments.amount);
                    updateCommand.Parameters.AddWithValue("@cashAccountId", payments.cashAccountId);
                    updateCommand.Parameters.AddWithValue("@cashAccountName", payments.cashAccountName);
                    updateCommand.Parameters.AddWithValue("@discription", payments.discription);
                    updateCommand.Parameters.AddWithValue("@PaymentId", payments.paymentId);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Payment record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

    }
}
