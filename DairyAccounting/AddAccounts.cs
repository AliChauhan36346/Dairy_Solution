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
    public class AddAccounts
    {
        Connection dbConnection;

        public int id { get; set; }
        public string name { get; set; }
        public string accountType { get; set; }
        public decimal accountBalance { get; set; }

        public AddAccounts()
        {
            dbConnection = new Connection();
        }

        public void saveAccount(AddAccounts accounts)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();

                // Check if the Account name already exists
                string checkQuery = "SELECT COUNT(*) FROM cashBankAccount WHERE name = @name OR accountID=@accountId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", accounts.name);
                    checkCommand.Parameters.AddWithValue("@accountId", accounts.id);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Account with the same name OR Id already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO cashBankAccount(name, accountType) " +
                                          "VALUES (@name, @accountType)";
                    command.Parameters.AddWithValue("@name", accounts.name);
                    command.Parameters.AddWithValue("@accountType", accounts.accountType);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Account was not saved! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string query = "SELECT accountID, name, accountType FROM cashBankAccount";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["accountID"].ColumnName = "ID";
                        dataTable.Columns["name"].ColumnName = "Account Name";
                        dataTable.Columns["accountType"].ColumnName = "Account Type";

                        // Sort the records in descending order by Account ID
                        dataTable.DefaultView.Sort = "ID DESC";

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
                string query = "SELECT ISNULL(MAX(accountID), 0) + 1 FROM cashBankAccount";
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

        public void removeAccount(int id) // to delete the account
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM cashBankAccount WHERE accountID=@id";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Account removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updateAccount(AddAccounts account)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the Account ID exists
                string checkQuery = "SELECT COUNT(*) FROM cashBankAccount WHERE accountID = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", account.id);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Account with the provided ID does not exist بھرے گئے شناختی شناخت کے ساتھ اکاؤنٹ موجود نہیں ہے!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE cashBankAccount " +
                    "SET name = @name, accountType = @accountType WHERE accountID = @id";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@name", account.name);
                    updateCommand.Parameters.AddWithValue("@accountType", account.accountType);
                    updateCommand.Parameters.AddWithValue("@id", account.id);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public List<string> GetAccounts()
        {
            List<string> accounts = new List<string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT name FROM cashBankAccount";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string accountName = reader["name"].ToString();
                            accounts.Add(accountName);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error retrieving accounts names: " + ex.Message);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return accounts;

        }

        public Dictionary<int, string> GetAccountIdsAndNames()
        {
            Dictionary<int, string> accountIdsAndNames = new Dictionary<int, string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT accountID, name FROM cashBankAccount";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int accountId = Convert.ToInt32(reader["accountId"]);
                            string accountName = reader["name"].ToString();
                            accountIdsAndNames.Add(accountId, accountName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving account names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return accountIdsAndNames;
        }

        public int getAccountIdByName(string accountName)
        {
            int id = 0;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT accountID FROM cashBankAccount WHERE name=@accountName";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountName", accountName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["accountID"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving cash account id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return id;
        }



    }
}
