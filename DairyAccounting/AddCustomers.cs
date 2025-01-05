using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Policy;

namespace DairyAccounting
{
    public class AddCustomers
    {
        private readonly Connection dbConnection;

        public int id { get; set; }
        public string name { get; set; }
        public decimal rate { get; set; }
        public decimal creditLimit { get; set; }
        public string address { get; set; }
        public int dodhiId { get; set; }
        public int installmentAdjustment { get; set; }
        public int registerPageNo { get; set; }
        public bool isActive { get; set; }
        public bool giveCreditOnParchi { get; set; }
        public string dodhi { get; set; }

        public AddCustomers()
        {
            dbConnection = new Connection();
        }

        // to insert customers in database
        public void saveCustomer(AddCustomers customers)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();

                // Check if the customer name already exists
                string checkQuery = "SELECT COUNT(*) FROM CustomersTbl WHERE name = @name OR customerId=@customerId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", customers.name);
                    checkCommand.Parameters.AddWithValue("@customerId", customers.id);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Customer with the same Id or Name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO CustomersTbl(name, address,dodhiId, dodhi, rate, creditLimit, phNo, registerPageNo, isActive, giveCreditOnParchi) " +
                                          "VALUES (@name, @address, @dodhiId, @dodhi, @rate, @creditLimit, @phNo, @registerPageNo, @isActive, @giveCreditOnParchi)";
                    command.Parameters.AddWithValue("@name", customers.name);
                    command.Parameters.AddWithValue("@address", customers.address);
                    command.Parameters.AddWithValue("@dodhiId", customers.dodhiId);
                    command.Parameters.AddWithValue("@dodhi", customers.dodhi);
                    command.Parameters.AddWithValue("@rate", customers.rate);
                    command.Parameters.AddWithValue("@creditLimit", customers.creditLimit);
                    command.Parameters.AddWithValue("@phNo", customers.installmentAdjustment);
                    command.Parameters.AddWithValue("@registerPageNo", customers.registerPageNo);
                    command.Parameters.AddWithValue("@isActive", customers.isActive);
                    command.Parameters.AddWithValue("@giveCreditOnParchi", customers.giveCreditOnParchi);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        // to show the saved data in datagridview of customer form
        public void showDataInGridView(DataGridView dataGridView)
        {
            try
            {
                dbConnection.openConnection();

                // Initialize query to select all records 
                string query = "SELECT customerId, name, address, dodhiID, dodhi, rate, creditLimit, phNo, registerPageNo, isActive, giveCreditOnParchi  FROM CustomersTbl";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["customerId"].ColumnName = "Id";
                        dataTable.Columns["name"].ColumnName = "Customer Name";
                        dataTable.Columns["address"].ColumnName = "Customer Address";
                        dataTable.Columns["dodhiId"].ColumnName = "Dodhi Id";
                        dataTable.Columns["dodhi"].ColumnName = "Dodhi Name";
                        dataTable.Columns["rate"].ColumnName = "Purchase Rate";
                        dataTable.Columns["creditLimit"].ColumnName = "Credit Limit";
                        dataTable.Columns["phNo"].ColumnName = "Installment Amount";
                        dataTable.Columns["registerPageNo"].ColumnName = "Khata No";
                        dataTable.Columns["isActive"].ColumnName = "isActive";
                        dataTable.Columns["giveCreditOnParchi"].ColumnName = "Give Credit";

                        


                        // Sort the records in descending order by customer ID
                        dataTable.DefaultView.Sort = "Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        // Set width of each column individually
                        dataGridView.Columns["Id"].Width = 60;
                        dataGridView.Columns["Customer Name"].Width = 175;
                        dataGridView.Columns["Customer Address"].Width = 100;
                        dataGridView.Columns["Dodhi Id"].Width = 70;
                        dataGridView.Columns["Dodhi Name"].Width = 130;
                        dataGridView.Columns["Purchase Rate"].Width = 90;
                        dataGridView.Columns["Credit Limit"].Width = 95;
                        dataGridView.Columns["Installment Amount"].Width = 95;
                        dataGridView.Columns["isActive"].Width = 60;
                        dataGridView.Columns["Give Credit"].Width = 60;
                        dataGridView.Columns["Khata No"].Width = 60;
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

        // display the id on form
        public int GetNextAvailableID()
        {
            // Logic to retrieve the next available ID from the database
            int nextID = 0;
            try
            {
                // Open connection to the database
                dbConnection.openConnection();

                // Execute a query to get the maximum ID value
                string query = "SELECT ISNULL(MAX(customerId), 0) + 1 FROM CustomersTbl";
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

        // for deletion of customer
        public void removeCustomer(int id)
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM CustomersTbl WHERE customerId=@id";

                using(SqlCommand deleteCommand=new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Customer removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch(Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updateCustomer(AddCustomers customer)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the customer ID exists
                string checkQuery = "SELECT COUNT(*) FROM CustomersTbl WHERE customerId = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", customer.id);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Customer with the provided ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement with all required fields
                string updateQuery = "UPDATE CustomersTbl " +
                    "SET name = @name, address = @address, dodhiId = @dodhiId, dodhi = @dodhi, rate = @rate, creditLimit = @creditLimit, " +
                    "phNo = @phNo, registerPageNo = @registerPageNo, isActive = @isActive, giveCreditOnParchi = @giveCreditOnParchi " +
                    "WHERE customerId = @id";

                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@name", customer.name);
                    updateCommand.Parameters.AddWithValue("@address", customer.address);
                    updateCommand.Parameters.AddWithValue("@dodhiId", customer.dodhiId);
                    updateCommand.Parameters.AddWithValue("@dodhi", customer.dodhi);
                    updateCommand.Parameters.AddWithValue("@rate", customer.rate);
                    updateCommand.Parameters.AddWithValue("@creditLimit", customer.creditLimit);
                    updateCommand.Parameters.AddWithValue("@phNo", customer.installmentAdjustment);
                    updateCommand.Parameters.AddWithValue("@registerPageNo", customer.registerPageNo);
                    updateCommand.Parameters.AddWithValue("@isActive", customer.isActive);
                    updateCommand.Parameters.AddWithValue("@giveCreditOnParchi", customer.giveCreditOnParchi);
                    updateCommand.Parameters.AddWithValue("@id", customer.id);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public Dictionary<int, string> GetCustomersIdsAndNames()
        {
            Dictionary<int, string> customerIdsAndNames = new Dictionary<int, string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT customerId, name FROM CustomersTbl";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerId = Convert.ToInt32(reader["customerId"]);
                            string customerName = reader["name"].ToString();
                            customerIdsAndNames.Add(customerId, customerName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customers names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return customerIdsAndNames;
        }

        public Dictionary<int, string> GetCustomersIdsAndNamesByDodhi(int dodhiId)
        {
            Dictionary<int, string> customerIdsAndNames = new Dictionary<int, string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT customerId, name FROM CustomersTbl WHERE dodhiId=@dodhiId";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@dodhiId", dodhiId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerId = Convert.ToInt32(reader["customerId"]);
                            string customerName = reader["name"].ToString();
                            customerIdsAndNames.Add(customerId, customerName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customers names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return customerIdsAndNames;
        }

        public string GetCustomerNameById(int customerId)
        {
            string customerName = "";
            // Assuming you have access to your database and can execute a query to retrieve the dodhi name based on the dodhi ID
            try
            {
                // Open connection with database
                dbConnection.openConnection();

                string query = "SELECT name FROM CustomersTbl WHERE customerId = @id";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@id", customerId);
                    
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            customerName = reader["name"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            finally
            {
                // Close database connection
                dbConnection.closeConnection();
            }

            return customerName;
            
        }

        public decimal getCustomerRate(string id)
        {
            decimal rate = 0; // Initialize rate

            if (int.TryParse(id, out int customerId))
            {
                try
                {
                    dbConnection.openConnection();

                    string query = "SELECT rate FROM CustomersTbl WHERE customerId=@customerId";

                    using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                    {
                        command.Parameters.AddWithValue("@customerId", customerId);

                        object result = command.ExecuteScalar();

                        if (result != null && decimal.TryParse(result.ToString(), out decimal rateValue))
                        {
                            rate = rateValue; // Assign rate from database if retrieval is successful
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving customer rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close database connection
                    dbConnection.closeConnection();
                }
            }


            return rate;
        }

        public int GetCustomerDodhiId(string customerId)
        {
            int dodhiId = 0;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT dodhiId FROM CustomersTbl WHERE customerId = @customerId";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        dodhiId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer dodhi ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close database connection
                dbConnection.closeConnection();
            }

            return dodhiId;
        }

        public List<string> getCustomersAddress()
        {
            List<string> addresses = new List<string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT address FROM CustomersTbl";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string address = reader["address"].ToString();
                            if (!addresses.Contains(address))
                            {
                                addresses.Add(address);
                            }
                        }
                    }
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retrieving customers addresses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return addresses;
        }

        public List<(int customerId, decimal creditLimit)> GetAllCustomerIdCreditLimit()
        {
            var customerDetails = new List<(int customerId, decimal creditLimit)>();

            try
            {
                // Open the database connection
                dbConnection.openConnection();

                // Query to fetch customerId and creditLimit for all customers
                string query = "SELECT customerId, creditLimit FROM CustomersTbl WHERE giveCreditOnParchi = @giveCreditOnParchi";


                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@giveCreditOnParchi", 1);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract values for each customer
                            int customerId = reader.GetInt32(0);
                            int creditLimit = reader.GetInt32(1);

                            // Add to the list as a tuple
                            customerDetails.Add((customerId, creditLimit));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                dbConnection.closeConnection();
            }

            return customerDetails;
        }

        public AddCustomers GetCustomerDetail(int id)
        {
            AddCustomers customer = null; // Initialize to null to indicate no customer found

            try
            {
                dbConnection.openConnection();

                // Query to retrieve customer details
                string query = @"
                SELECT 
                    customerId, 
                    name, 
                    rate, 
                    creditLimit, 
                    dodhiId, 
                    dodhi, 
                    address, 
                    phNo, 
                    registerPageNo, 
                    isActive, 
                    giveCreditOnParchi 
                FROM CustomersTbl 
                WHERE customerId = @id";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read()) // If a record is found
                    {
                        customer = new AddCustomers
                        {
                            id = reader["customerId"] != DBNull.Value ? Convert.ToInt32(reader["customerId"]) : 0,
                            name = reader["name"].ToString(),
                            rate = reader["rate"] != DBNull.Value ? Convert.ToDecimal(reader["rate"]) : 0m,
                            creditLimit = reader["creditLimit"] != DBNull.Value ? Convert.ToInt32(reader["creditLimit"]) : 0,
                            dodhiId = reader["dodhiId"] != DBNull.Value ? Convert.ToInt32(reader["dodhiId"]) : 0,
                            dodhi = reader["dodhi"]?.ToString() ?? string.Empty,
                            address = reader["address"]?.ToString() ?? string.Empty,
                            installmentAdjustment = reader["phNo"] != DBNull.Value ? Convert.ToInt32(reader["phNo"]) : 0,
                            registerPageNo = reader["registerPageNo"] != DBNull.Value ? Convert.ToInt32(reader["registerPageNo"]) : 0,
                            isActive = reader["isActive"] != DBNull.Value && Convert.ToBoolean(reader["isActive"]),
                            giveCreditOnParchi = reader["giveCreditOnParchi"] != DBNull.Value && Convert.ToBoolean(reader["giveCreditOnParchi"])
                        };
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return customer; // Return the customer object (or null if not found)
        }


        public void GetCustomerAddress(int id, out string address)
        {
            address = "";

            try
            {
                dbConnection.openConnection();

                string query = "SELECT address FROM CustomersTbl WHERE customerId=@id";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        address = reader["address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving customer address: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }


    }
}
