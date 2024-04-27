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
    public class OpeningBalances
    {
        Connection dbConnection;


        public int openingBalanceId {  get; set; }
        public int accountId {  get; set; }
        public string accountName { get; set; }

        public decimal debit {  get; set; }

        public decimal credit { get; set; }

        public OpeningBalances()
        {
            dbConnection = new Connection();
        }

        public void saveOpeningBalance(OpeningBalances openningBalance)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();

                // Check if the OpeningBalance name already exists
                

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO OpeningBalances(accountId, accountName, debit, credit) " +
                                          "VALUES (@accountId, @accountName, @debit, @credit)";
                    command.Parameters.AddWithValue("@accountId", openningBalance.accountId);
                    command.Parameters.AddWithValue("@accountName", openningBalance.accountName);
                    command.Parameters.AddWithValue("@debit", openningBalance.debit);
                    command.Parameters.AddWithValue("@credit", openningBalance.credit);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving opening balance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Opening balance was not saved! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string query = "SELECT OpeningBalanceId, accountId, accountName, debit, credit FROM OpeningBalances";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["OpeningBalanceId"].ColumnName = "Id";
                        dataTable.Columns["accountId"].ColumnName = "Account Id";
                        dataTable.Columns["accountName"].ColumnName = "Account Name";
                        dataTable.Columns["debit"].ColumnName = "Debit";
                        dataTable.Columns["credit"].ColumnName = "Credit";

                        // Sort the records in descending order by OpeningBalance ID
                        dataTable.DefaultView.Sort = "ID DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        dataGridView.Columns["Id"].Width = 80;
                        dataGridView.Columns["Account Id"].Width = 150;
                        dataGridView.Columns["Account Name"].Width = 300;
                        dataGridView.Columns["Debit"].Width = 150;
                        dataGridView.Columns["Credit"].Width = 150;
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
                string query = "SELECT ISNULL(MAX(OpeningBalanceId), 0) + 1 FROM OpeningBalances";
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

        public void removeOpeningBalance(int id) // to delete the OpeningBalance
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM OpeningBalances WHERE OpeningBalanceId=@id";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("OpeningBalance removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting OpeningBalance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updateOpeningBalance(OpeningBalances OpeningBalance)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the OpeningBalance ID exists
                string checkQuery = "SELECT COUNT(*) FROM OpeningBalances WHERE OpeningBalanceId = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", OpeningBalance.openingBalanceId);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("OpeningBalance with the provided ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE OpeningBalances " +
                    "SET accountId = @accountId, accountName = @accountName, debit = @debit, credit=@credit WHERE OpeningBalanceId = @id";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@accountId", OpeningBalance.accountId);
                    updateCommand.Parameters.AddWithValue("@accountName", OpeningBalance.accountName);
                    updateCommand.Parameters.AddWithValue("@debit", OpeningBalance.debit);
                    updateCommand.Parameters.AddWithValue("@credit", OpeningBalance.credit);
                    updateCommand.Parameters.AddWithValue("@id", OpeningBalance.openingBalanceId);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("OpeningBalance updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating OpeningBalance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void GetTotalDebitCredit(out decimal totalDebit, out decimal totalCredit)
        {
            totalCredit=0;
            totalDebit = 0;

            try
            {
                dbConnection.openConnection();

                string debitSum = "SELECT debit, credit FROM OpeningBalances";


                using (SqlCommand command = new SqlCommand(debitSum, dbConnection.connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        decimal debit = decimal.Parse(reader["debit"].ToString());
                        decimal credit = decimal.Parse(reader["credit"].ToString());

                        totalDebit += debit;
                        totalCredit += credit;
                    }
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error retrieving next available ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

    }
}
