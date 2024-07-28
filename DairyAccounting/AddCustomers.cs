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
                    command.CommandText = "INSERT INTO CustomersTbl(name, address,dodhiId, dodhi, rate, creditLimit) " +
                                          "VALUES (@name, @address, @dodhiId, @dodhi, @rate, @creditLimit)";
                    command.Parameters.AddWithValue("@name", customers.name);
                    command.Parameters.AddWithValue("@address", customers.address);
                    command.Parameters.AddWithValue("@dodhiId", customers.dodhiId);
                    command.Parameters.AddWithValue("@dodhi", customers.dodhi);
                    command.Parameters.AddWithValue("@rate", customers.rate);
                    command.Parameters.AddWithValue("@creditLimit", customers.creditLimit);
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
                string query = "SELECT customerId, name, address, dodhiID, dodhi, rate, creditLimit FROM CustomersTbl";

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

                        


                        // Sort the records in descending order by customer ID
                        dataTable.DefaultView.Sort = "Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        // Set width of each column individually
                        dataGridView.Columns["Id"].Width = 60;
                        dataGridView.Columns["Customer Name"].Width = 150;
                        dataGridView.Columns["Customer Address"].Width = 100;
                        dataGridView.Columns["Dodhi Id"].Width = 70;
                        dataGridView.Columns["Dodhi Name"].Width = 130;
                        dataGridView.Columns["Purchase Rate"].Width = 100;
                        dataGridView.Columns["Credit Limit"].Width = 110;
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
                string checkQuery = "SELECT COUNT(*) FROM CustomersTbl WHERE CustomerId = @id";
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

                // Update SQL statement
                string updateQuery = "UPDATE CustomersTbl " +
                    "SET name = @name, address = @address, dodhiId=@dodhiId, dodhi = @dodhi, rate = @rate, creditLimit = @creditLimit " +
                    "WHERE CustomerId = @id";

                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@name", customer.name);
                    updateCommand.Parameters.AddWithValue("@address", customer.address);
                    updateCommand.Parameters.AddWithValue("@dodhiId", customer.dodhiId);
                    updateCommand.Parameters.AddWithValue("@dodhi", customer.dodhi);
                    updateCommand.Parameters.AddWithValue("@rate", customer.rate);
                    updateCommand.Parameters.AddWithValue("@creditLimit", customer.creditLimit);
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


        public void GetCustomerDetail(int id,out int cusId, out string name, out decimal rate, out int creditLimit,
            out int dodhiId, out string dodhiName, out string address)
        {
            cusId = 0;
            name = "";
            rate = 0;
            creditLimit = 0;
            dodhiId = 0;
            dodhiName = "";
            address = "";

            bool customerFound = false;

            try
            {
                dbConnection.openConnection();

                string query = "SELECT customerId,name,rate,dodhiId,dodhi,rate,creditLimit,address FROM CustomersTbl WHERE customerId=@id";

                using(SqlCommand command=new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        customerFound = true;

                        cusId = int.Parse(reader["customerId"].ToString());
                        name = reader["Name"].ToString();
                        rate = decimal.Parse(reader["rate"].ToString());
                        dodhiId = int.Parse(reader["dodhiId"].ToString());
                        dodhiName = reader["dodhi"].ToString();
                        address = reader["address"].ToString();
                        creditLimit = int.Parse(reader["creditLimit"].ToString());
                    }

                    if(!customerFound)
                    {
                        MessageBox.Show("Customer not fount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error retrieving customer detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
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
