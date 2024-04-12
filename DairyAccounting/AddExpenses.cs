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
    public class AddExpenses
    {
        Connection dbConnection;

        public int expenseId { get; set; }
        public DateTime date { get; set; }
        public int cashAccountId { get; set; }
        public string cashAccountName { get; set; }
        public string expenseType { get; set; }
        public decimal amount { get; set; }
        public string discription { get; set; }
        public int employeeId { get; set; }
        public string employeeName { get; set; }

        public AddExpenses()
        {
            dbConnection = new Connection();
        }

        public void saveExpense(AddExpenses expense)
        {
            try
            {
                // opening connection with database
                dbConnection.openConnection();
                // Check if the customer name already exists
                string checkQuery = "SELECT COUNT(*) FROM Expense WHERE expenseId=@expenseId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {

                    checkCommand.Parameters.AddWithValue("@expenseId", expense.expenseId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Record with the same expense id already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = dbConnection.connection;
                    command.CommandText = "INSERT INTO Expense(date, cashAccountId, cashAccountName, type, amount, discription, employeeId, employeeName) " +
                                          "VALUES (@date, @cashAccountId, @cashAccountName, @type, @amount, @discription, @employeeId, @employeeName)";
                    command.Parameters.AddWithValue("@date", expense.date);
                    command.Parameters.AddWithValue("@cashAccountId", expense.cashAccountId);
                    command.Parameters.AddWithValue("@cashAccountName", expense.cashAccountName);
                    command.Parameters.AddWithValue("@type", expense.expenseType);
                    command.Parameters.AddWithValue("@amount", expense.amount);
                    command.Parameters.AddWithValue("@discription", expense.discription);
                    command.Parameters.AddWithValue("@employeeId", expense.employeeId);
                    command.Parameters.AddWithValue("@employeeName", expense.employeeName);
                    

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Record was not saved! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public int GetNextAvailableId()
        {
            // Logic to retrieve the next available purchasepurchaseId from the database
            int nextExpenseId = 0;
            try
            {
                // Open connection to the database
                dbConnection.openConnection();

                // Execute a query to get the maximum purchasepurchaseId value
                string query = "SELECT ISNULL(MAX(ExpenseId), 0) + 1 FROM Expense";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextExpenseId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving next available expense Id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close connection to the database
                dbConnection.closeConnection();
            }
            return nextExpenseId;
        }

        public void showDataInGridView(DataGridView dataGridView, DateTime date)
        {
            DateTime today = date.Date;

            try
            {
                dbConnection.openConnection();

                // Initialize query to select all records 
                string query = $"SELECT Expenseid, date, cashAccountId, cashAccountName, type, amount, discription, employeeId, employeeName FROM Expense WHERE date = @Today";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    // Add a parameter for the date
                    command.Parameters.AddWithValue("@Today", today);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        // Specify the desired column names
                        dataTable.Columns["Expenseid"].ColumnName = "Id";
                        dataTable.Columns["date"].ColumnName = "Date";
                        dataTable.Columns["cashAccountId"].ColumnName = "Cash Id";
                        dataTable.Columns["cashAccountName"].ColumnName = "Cash Account Name";
                        dataTable.Columns["type"].ColumnName = "Expense Type";
                        dataTable.Columns["amount"].ColumnName = "Amount";
                        dataTable.Columns["discription"].ColumnName = "Description";
                        dataTable.Columns["employeeId"].ColumnName = "Employee Id";
                        dataTable.Columns["employeeName"].ColumnName = "Employee Name";

                        // Sort the records in descending order by expenseId
                        dataTable.DefaultView.Sort = "Id DESC";

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;

                        // Set column widths
                        dataGridView.Columns["Id"].Width = 60;
                        dataGridView.Columns["Date"].Width = 90;
                        dataGridView.Columns["Cash Id"].Width = 90;
                        dataGridView.Columns["Cash Account Name"].Width = 150;
                        dataGridView.Columns["Expense Type"].Width = 100;
                        dataGridView.Columns["Amount"].Width = 90;
                        dataGridView.Columns["Description"].Width = 140;
                        dataGridView.Columns["Employee Id"].Width = 90;
                        dataGridView.Columns["Employee Name"].Width = 150;
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


        public void removeExpenses(int expenseId) // to delete the expense
        {
            try
            {
                dbConnection.openConnection();

                // for deletionn
                string query = "DELETE FROM Expense WHERE ExpenseId=@ExpenseId";

                using (SqlCommand deleteCommand = new SqlCommand(query, dbConnection.connection))
                {
                    //adding purchasepurchaseId parameter
                    deleteCommand.Parameters.AddWithValue("@ExpenseId", expenseId);

                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Purchase record removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                //to handle any error during deletion
                MessageBox.Show("Error deleting expense record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                // closing connection
                dbConnection.closeConnection();
            }
        }

        public void updateExpense(AddExpenses expense)
        {
            try
            {
                dbConnection.openConnection();

                // Check if the customer purchasepurchaseId exists
                string checkQuery = "SELECT COUNT(*) FROM expense WHERE ExpenseId = @expenseId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, dbConnection.connection))
                {
                    checkCommand.Parameters.AddWithValue("@expenseId", expense.expenseId);

                    int count = (int)checkCommand.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Purchase record with the expense Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                // Update SQL statement
                string updateQuery = "UPDATE Expense " +
                    "SET date=@date, expenseId=@expenseId, cashAccountId=@cashAccountId, cashAccountName=@cashAccountName," +
                    " type=@type, amount=@amount, discription=@discription, employeeId=@employeeId, employeeName=@employeeName WHERE ExpenseId = @expenseId";


                // SQL command object
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, dbConnection.connection))
                {
                    updateCommand.Parameters.AddWithValue("@date", expense.date);
                    updateCommand.Parameters.AddWithValue("@expenseId", expense.expenseId);
                    updateCommand.Parameters.AddWithValue("@cashAccountId", expense.cashAccountId);
                    updateCommand.Parameters.AddWithValue("@cashAccountName", expense.cashAccountName);
                    updateCommand.Parameters.AddWithValue("@type", expense.expenseType);
                    updateCommand.Parameters.AddWithValue("@amount", expense.amount);
                    updateCommand.Parameters.AddWithValue("@discription", expense.discription);
                    updateCommand.Parameters.AddWithValue("@employeeId", expense.employeeId);
                    updateCommand.Parameters.AddWithValue("@amount", expense.amount);
                    updateCommand.Parameters.AddWithValue("@purchaseId", expense.expenseId);



                    updateCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Expense record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

    }
}
