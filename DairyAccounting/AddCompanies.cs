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
    public class AddCompanies
    {
        Connection dbConnection;

        public int id {  get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public decimal rate { get; set; }

        public AddCompanies() 
        {
            dbConnection = new Connection();
        }

        public void savecompany(AddCompanies company)
        {


            try
            {
                // opening connection with database
                dbConnection.openConnection();

                // Check if the company name already exists
                string checkQuery = "SELECT COUNT(*) FROM companiesTbl WHERE name = @name OR companyId=@companyId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", company.name);
                    checkCommand.Parameters.AddWithValue("@companyId", company.id);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Company with the same name OR Id already exists! اسی نام یا شناخت کی ساتھ اکاؤنٹ پہلے ہی موجودہ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO CompaniesTbl(name, address, rate) " +
                                          "VALUES (@name, @address, @rate)";
                    command.Parameters.AddWithValue("@name", company.name);
                    command.Parameters.AddWithValue("@address", company.address);
                    command.Parameters.AddWithValue("@rate", company.rate);
                    
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving company: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Company was not saved! Please try again.","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string query = "SELECT companyId, name, address, rate FROM CompaniesTbl";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["companyId"].ColumnName = "ID";
                        dataTable.Columns["name"].ColumnName = "company Name";
                        dataTable.Columns["address"].ColumnName = "Address";
                        dataTable.Columns["rate"].ColumnName = "Rate";

                        // Sort the records in descending order by company ID
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
                string query = "SELECT ISNULL(MAX(companyId), 0) + 1 FROM companiesTbl";
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

        public void removeCompany(int id) // to delete the company
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM companiesTbl WHERE companyId=@id";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("company removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting Company: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updateCompany(AddCompanies company)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the company ID exists
                string checkQuery = "SELECT COUNT(*) FROM CompaniesTbl WHERE companyId = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", company.id);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("company with the provided ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE CompaniesTbl " +
                    "SET name = @name, address = @address, rate = @rate WHERE companyId = @id";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@name", company.name);
                    updateCommand.Parameters.AddWithValue("@address", company.address);
                    updateCommand.Parameters.AddWithValue("@rate", company.rate);
                    updateCommand.Parameters.AddWithValue("@id", company.id);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("company updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating company: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public Dictionary<int, string> GetCompanyIdsAndNames()
        {
            Dictionary<int, string> companyIdsAndNames = new Dictionary<int, string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT companyId, name FROM CompaniesTbl";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int companyId = Convert.ToInt32(reader["companyId"]);
                            string companyName = reader["name"].ToString();
                            companyIdsAndNames.Add(companyId, companyName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving companies names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return companyIdsAndNames;
        }

        public string GetcompanyNameById(string companyId)
        {
            int id;
            if (int.TryParse(companyId, out id))
            {
                // Assuming you have access to your database and can execute a query to retrieve the dodhi name based on the dodhi ID
                try
                {
                    // Open connection with database
                    dbConnection.openConnection();

                    string query = "SELECT name FROM CompaniesTbl WHERE companyId = @id";
                    using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("company Id not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving company name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
                finally
                {
                    // Close database connection
                    dbConnection.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid company Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        

        public decimal getcompanyRate(string id)
        {
            decimal rate = 0; // Initialize rate

            if (int.TryParse(id, out int companyId))
            {
                try
                {
                    dbConnection.openConnection();

                    string query = "SELECT rate FROM CompaniesTbl WHERE companyId=@companyId";

                    using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                    {
                        command.Parameters.AddWithValue("@companyId", companyId);

                        object result = command.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out decimal rateValue))
                        {
                            rate = rateValue; // Assign rate from database if retrieval is successful
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving company rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close database connection
                    dbConnection.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Invalid company Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return rate;
        }


    }


}
