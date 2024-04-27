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
    public class JournalVoucherClass
    {
        Connection dbConnection;

        public int journalId {  get; set; }

        public DateTime date { get; set; }

        public string discription { get; set; }

        public int accountId { get; set; }

        public string accountName { get; set; }

        public decimal debit { get; set; }

        public decimal credit { get; set; }

        public JournalVoucherClass()
        {
            dbConnection=new Connection();
        }

        public void saveJournalVoucher(JournalVoucherClass journalVoucher)
        {
            try
            {
                dbConnection.openConnection();

                string query = "INSERT INTO JournalVoucher(journalId, date, discription, accountId, accountName, debit, credit)" +
                    " VALUES (@journalId, @date, @discription, @accountId, @accountName, @debit, @credit)";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@journalId", journalVoucher.journalId);
                    command.Parameters.AddWithValue("@date", journalVoucher.date);
                    command.Parameters.AddWithValue("@discription", journalVoucher.discription);
                    command.Parameters.AddWithValue("@accountId", journalVoucher.accountId);
                    command.Parameters.AddWithValue("@accountName", journalVoucher.accountName);
                    command.Parameters.AddWithValue("@debit", journalVoucher.debit);
                    command.Parameters.AddWithValue("@credit", journalVoucher.credit);

                    command.ExecuteNonQuery();
                }

                //MessageBox.Show("Journal voucher saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving journal voucher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Journal voucher was not saved! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void updateJournalVoucher(JournalVoucherClass journalVoucher)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the OpeningBalance ID exists
                string checkQuery = "SELECT COUNT(*) FROM JournalVoucher WHERE journalId = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", journalVoucher.journalId);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Journal voucher with the provided ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE JournalVoucher " +
                    "SET date=@date, discription=@discription, accountId = @accountId, accountName = @accountName, debit = @debit, credit=@credit WHERE journalId = @journalId";

                using (SqlCommand command = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@journalId", journalVoucher.journalId);
                    command.Parameters.AddWithValue("@date", journalVoucher.date);
                    command.Parameters.AddWithValue("@discription", journalVoucher.discription);
                    command.Parameters.AddWithValue("@accountId", journalVoucher.accountId);
                    command.Parameters.AddWithValue("@accountName", journalVoucher.accountName);
                    command.Parameters.AddWithValue("@debit", journalVoucher.debit);
                    command.Parameters.AddWithValue("@credit", journalVoucher.credit);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Journal voucher updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating journal voucher: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Journal voucher was not updated! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
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
                string query = "SELECT ISNULL(MAX(journalId), 0) + 1 FROM JournalVoucher";
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

        public int GetMiniAvailableID()
        {
            
            // Logic to retrieve the next available ID from the database
            int nextID = 0;
            try
            {
                // Open connection to the database
                dbConnection.openConnection();

                // Execute a query to get the maximum ID 
                string minQuery = "SELECT ISNULL(MIN(journalId), 0) FROM JournalVoucher";
                

                using (SqlCommand command = new SqlCommand(minQuery, dbConnection.connection))
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
                MessageBox.Show("Error retrieving mini available ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection to the database
                dbConnection.closeConnection();
            }
            return nextID;
        }

        public void GetVoucherDetailByID(int voucherID, out DateTime date, out string discription,
            out List<(int accountId, string accountName, decimal debit, decimal credit)> accounts)
        {
            date = DateTime.MinValue;
            discription = "";
            accounts = new List<(int accountId, string accountName, decimal debit, decimal credit)>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT date, discription, accountId, accountName, debit, credit " +
                               "FROM JournalVoucher WHERE journalId=@journalId";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@journalId", voucherID);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (date == DateTime.MinValue)
                        {
                            date = DateTime.Parse(reader["date"].ToString());
                            discription = reader["discription"].ToString();
                        }

                        int accountId = int.Parse(reader["accountId"].ToString());
                        string accountName = reader["accountName"].ToString();
                        decimal debit = decimal.Parse(reader["debit"].ToString());
                        decimal credit = decimal.Parse(reader["credit"].ToString());

                        accounts.Add((accountId, accountName, debit, credit));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting record detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


        public void removeJournalVoucher(int id) // to delete the sales
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM JournalVoucher WHERE journalId=@id";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Journal Voucher with id " + id + " removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        public void showDataInGridView(DataGridView dataGridView)
        {
            try
            {
                dbConnection.openConnection();

                // Initialize query to select all records 
                string query = $"SELECT journalId, date, discription, accountId, accountName, debit, credit FROM JournalVoucher";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.DefaultView.Sort = "journalId DESC";

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
    }
}
