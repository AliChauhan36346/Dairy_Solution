using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class AddEmployees
    {
        private readonly Connection dbConnection;

        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public long phNO { get; set; }
        public int salary { get; set; }
        public string designation { get; set; }
        public DateTime hireDate { get; set; }

        public string status {  get; set; }
        public DateTime resignDate { get; set;}

        public AddEmployees()
        {
            dbConnection = new Connection();
        }

        

        public int saveEmployee(AddEmployees employee)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();

                // Check if the customer name already exists
                string checkQuery = "SELECT COUNT(*) FROM EmployeesTbl WHERE name = @name OR employeeId=@employeeId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", employee.name);
                    checkCommand.Parameters.AddWithValue("@employeeId", employee.id);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Employee with the same name OR Id already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0;
                    }
                }

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO EmployeesTbl(name, address, phNo, designation, salary, hireDate, resignDate, status) " +
                                          "VALUES (@name, @address, @phNo, @designation, @salary, @hireDate, @resignDate, @status)";
                    command.Parameters.AddWithValue("@name", employee.name);
                    command.Parameters.AddWithValue("@address", employee.address);
                    command.Parameters.AddWithValue("@phNo", employee.phNO);
                    command.Parameters.AddWithValue("@designation", employee.designation);
                    command.Parameters.AddWithValue("@salary", employee.salary);
                    command.Parameters.AddWithValue("@hireDate", employee.hireDate);
                    command.Parameters.AddWithValue("@resignDate", employee.resignDate);
                    command.Parameters.AddWithValue("@status", employee.status);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving Employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return 1;
        }

        public void showDataInGridView(DataGridView dataGridView)
        {
            try
            {
                dbConnection.openConnection();

                // Initialize query to select all records 
                string query = "SELECT employeeId, name, address, phNo, designation, salary, hireDate, resignDate, status FROM EmployeesTbl";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["EmployeeId"].ColumnName = "ID";
                        dataTable.Columns["name"].ColumnName = "Employee Name";
                        dataTable.Columns["address"].ColumnName = " Address ";
                        dataTable.Columns["phNO"].ColumnName = "Employee PhNo.";
                        dataTable.Columns["designation"].ColumnName = "Designation";
                        dataTable.Columns["salary"].ColumnName = "Salary";
                        dataTable.Columns["hireDate"].ColumnName = "Hire Date";
                        dataTable.Columns["status"].ColumnName = "Status";
                        dataTable.Columns["resignDate"].ColumnName = "Resign Date";
                        




                        // Sort the records in descending order by customer ID
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
                string query = "SELECT ISNULL(MAX(employeeId), 0) + 1 FROM EmployeesTbl";
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

        public void removeEmployee(int id) // to delete the employee
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM EmployeesTbl WHERE employeeId=@id";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding id parameter
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Employee removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
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

        public void updateEmployee(AddEmployees employees)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the customer ID exists
                string checkQuery = "SELECT COUNT(*) FROM EmployeesTbl WHERE employeeId = @id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@id", employees.id);
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Customer with the provided ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Update SQL statement
                string updateQuery = "UPDATE employeesTbl " +
                    "SET name = @name, address = @address, phno = @phNo, designation = @designation, salary = @salary, hireDate = @hireDate, resignDate = @resignDate, status=@status " +
                    "WHERE employeeId = @id";

                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@name", employees.name);
                    updateCommand.Parameters.AddWithValue("@address", employees.address);
                    updateCommand.Parameters.AddWithValue("@phNo", employees.phNO);
                    updateCommand.Parameters.AddWithValue("@designation", employees.designation);
                    updateCommand.Parameters.AddWithValue("@salary", employees.salary);
                    updateCommand.Parameters.AddWithValue("@hireDate", employees.hireDate);
                    updateCommand.Parameters.AddWithValue("@resignDate", employees.resignDate);
                    updateCommand.Parameters.AddWithValue("@status", employees.status);
                    updateCommand.Parameters.AddWithValue("@id", employees.id);

                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public Dictionary<int, string> GetEmployeeIdsAndNames()
        {
            Dictionary<int, string> employeeIdsAndNames = new Dictionary<int, string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT employeeId, name FROM EmployeesTbl WHERE designation='Dodhi' AND status='active'";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeId = Convert.ToInt32(reader["employeeId"]);
                            string employeeName = reader["name"].ToString();
                            employeeIdsAndNames.Add(employeeId, employeeName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return employeeIdsAndNames;
        }

        public string GetDodhiNameById(string dodhiId)
        {
            int id;
            if (int.TryParse(dodhiId, out id))
            {
                // Assuming you have access to your database and can execute a query to retrieve the dodhi name based on the dodhi ID
                try
                {
                    // Open connection with database
                    dbConnection.openConnection();

                    string query = "SELECT name FROM EmployeesTbl WHERE employeeId = @id";
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
                            //MessageBox.Show("Dodhi ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving Dodhi name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter a valid Dodhi Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public int getDodhiIdByName(string dodhiName)
        {
            int dodhiId = -1; // Default value if dodhiId is not found

            try
            {
                // Open connection with database
                dbConnection.openConnection();

                string query = "SELECT employeeId FROM EmployeesTbl WHERE name = @name AND designation='Dodhi'";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@name", dodhiName);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        dodhiId = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Dodhi Id not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving Dodhi name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close database connection
                dbConnection.closeConnection();
            }

            return dodhiId;
        }

        public List<string> GetDodhiNames()
        {
            List<string> dodhiNames = new List<string>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT name FROM EmployeesTbl WHERE designation='Dodhi' AND status='active'";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dodhiName = reader["name"].ToString();
                            dodhiNames.Add(dodhiName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error retrieving Dodhi names list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return dodhiNames;
        }
    }
}
