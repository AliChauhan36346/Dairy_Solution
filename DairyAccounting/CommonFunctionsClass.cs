using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class CommonFunctionsClass
    {
        AddCompanies companies=new AddCompanies();
        AddCustomers customers=new AddCustomers();
        AddAccounts accounts=new AddAccounts();
        AddEmployees employees=new AddEmployees();

        Connection dbConnection;

        public CommonFunctionsClass()
        {
            dbConnection = new Connection();
        }

        public decimal tsCalculator(decimal lr, decimal fat, decimal volume, int tsStandard)
        {
            decimal fatOperations;// for storing calculation with fat
            decimal lrOperations;// for storing calculation with lr
            decimal volumeOperations;// for volume calculations
            decimal snf; // for storing snf 
            decimal ts; // for storing ts

            fatOperations = .22m * fat + .72m;

            lrOperations = lr / 4m;

            snf = fatOperations + lrOperations;

            volumeOperations = (snf + fat) * volume;

            ts = volumeOperations / tsStandard;

            ts = Math.Round(ts, 2);

            return ts;

        }

        public void ShowAccountSuggestions(TextBox textBox, ListBox listBox, string accountType)
        {
            if (textBox.Focused)
            {
                listBox.Visible = true;
                string searchTerm = textBox.Text.Trim(); // Trim whitespace

                // Clear existing suggestions
                listBox.Items.Clear();

                // Get account IDs and names based on account type
                Dictionary<int, string> accountIdsAndNames;
                switch (accountType)
                {
                    case "company":
                        accountIdsAndNames = companies.GetCompanyIdsAndNames();
                        break;
                    case "customer":
                        accountIdsAndNames = customers.GetCustomersIdsAndNames();
                        break;
                    case "employee":
                        accountIdsAndNames = employees.GetEmployeeIdsAndNames();
                        break;
                    case "cash":
                        accountIdsAndNames = accounts.GetAccountIdsAndNames();
                        break;
                    default:
                        throw new ArgumentException("Invalid account type specified.");
                }

                // Find best-matched item and select it
                string bestMatch = null;
                foreach (var entry in accountIdsAndNames)
                {
                    int accountId = entry.Key;
                    string accountName = entry.Value;

                    if (accountId.ToString().Contains(searchTerm) || accountName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) // Check if either ID or name matches the search term (case-insensitive)
                    {
                        listBox.Items.Add($"{accountId} - {accountName}");
                        if (bestMatch == null || accountName.Length < bestMatch.Length)
                        {
                            bestMatch = accountName;
                        }
                    }
                }

                // Auto-select best matched item
                if (!string.IsNullOrEmpty(bestMatch))
                {
                    for (int i = 0; i < listBox.Items.Count; i++)
                    {
                        if (listBox.Items[i].ToString().Contains(bestMatch))
                        {
                            listBox.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        public void HandleAccountSuggestionKeyDown(TextBox id, TextBox name, ListBox listBox, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (listBox.Visible && listBox.SelectedItem != null)
                {
                    string selectedSuggestion = listBox.SelectedItem.ToString();
                    string[] parts = selectedSuggestion.Split(new[] { " - " }, StringSplitOptions.None);

                    // Transfer the selected suggestion to the TextBoxes
                    name.Text = parts[1]; // Name TextBox
                    id.Text = parts[0]; // ID TextBox

                    // Hide the suggestion list
                    listBox.Visible = false;

                    // Prevent the Enter key from being processed further
                    e.SuppressKeyPress = true;

                    // If the key pressed was Tab, manually move focus to the next control
                    if (e.KeyCode == Keys.Tab)
                    {
                        Control nextControl = name.Parent.GetNextControl(name, true);
                        nextControl.Focus();
                    }
                }
                else
                {
                    // Move focus to the next control
                    name.Parent.SelectNextControl(name, true, true, true, true);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (listBox.Visible)
                {
                    int newIndex = listBox.SelectedIndex - 1;
                    if (newIndex >= 0)
                    {
                        listBox.SelectedIndex = newIndex;
                    }
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (listBox.Visible)
                {
                    int newIndex = listBox.SelectedIndex + 1;
                    if (newIndex < listBox.Items.Count)
                    {
                        listBox.SelectedIndex = newIndex;
                    }
                }
            }
        }

        public void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox )
                {
                    textBox.Clear();

                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
                else if (control.HasChildren)
                {
                    // Recursively clear text boxes in child controls
                    ClearAllTextBoxes(control);
                }
            }
        }

        public Dictionary<int, string> GetAllAccountIdsAndNames()
        {
            Dictionary<int, string> allAccountIdsAndNames = new Dictionary<int, string>();

            

            // Retrieve IDs and names for customers and add them to the dictionary
            foreach (var entry in customers.GetCustomersIdsAndNames())
            {
                allAccountIdsAndNames.Add(entry.Key, entry.Value); // Prefix "C" for customers
            }

            // Retrieve IDs and names for companies and add them to the dictionary
            foreach (var entry in companies.GetCompanyIdsAndNames())
            {
                allAccountIdsAndNames.Add(entry.Key, entry.Value); // Prefix "CO" for companies
            }

            // Retrieve IDs and names for employees and add them to the dictionary
            foreach (var entry in employees.GetEmployeeIdsAndNames())
            {
                allAccountIdsAndNames.Add(entry.Key, entry.Value); // Prefix "E" for employees
            }

            // Retrieve IDs and names for accounts and add them to the dictionary
            foreach (var entry in accounts.GetAccountIdsAndNames())
            {
                allAccountIdsAndNames.Add(entry.Key, entry.Value); // Prefix "A" for accounts
            }

            return allAccountIdsAndNames;
        }

        public void ShowAllAccountSuggestions(string searchTerm,ListBox lstSuggestions)
        {
            lstSuggestions.Visible = true;

            // Clear existing suggestions
            lstSuggestions.Items.Clear();

            // Get account IDs and names
            Dictionary<int, string> allAccountIdsAndNames = GetAllAccountIdsAndNames();

            // Find best-matched item and select it
            string bestMatch = null;
            foreach (var entry in allAccountIdsAndNames)
            {
                int accountId = entry.Key;
                string accountName = entry.Value;

                if (accountId.ToString().Contains(searchTerm) || accountName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) // Check if either ID or name matches the search term
                {
                    lstSuggestions.Items.Add($"{accountId} - {accountName}");
                    if (bestMatch == null || accountName.Length < bestMatch.Length)
                    {
                        bestMatch = accountName;
                    }
                }
            }

            // Auto-select best matched item
            if (!string.IsNullOrEmpty(bestMatch))
            {
                for (int i = 0; i < lstSuggestions.Items.Count; i++)
                {
                    if (lstSuggestions.Items[i].ToString().Contains(bestMatch))
                    {
                        lstSuggestions.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        public void ClearAllTransactions(int entitiesAlso)
        {
            SqlTransaction transaction = null; // Declare the transaction object outside the try block

            string[] transactionTables;

            try
            {
                dbConnection.openConnection();
                transaction = dbConnection.connection.BeginTransaction(); // Initialize the transaction object here



                // Clear only transactions, not entities
                if (entitiesAlso == 0)
                {
                    transactionTables = new string[] { "ChilarReceive", "Expense", "Payments", "Purchases", "Receipts", "Sales", "JournalVoucher", "OpeningBalances" };
                }
                else//clears entities and transaction, all of the data
                {
                    transactionTables = new string[] { "ChilarReceive", "Expense", "Payments", "Purchases", "Receipts", "Sales", "cashBankAccount", "CompaniesTbl", "CustomersTbl", "EmployeesTbl", "Users", "JournalVoucher", "OpeningBalances" };
                }


                foreach (string table in transactionTables)
                {
                    string deleteQuery = $"TRUNCATE TABLE {table}";
                    using (SqlCommand command = new SqlCommand(deleteQuery, dbConnection.connection, transaction))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Commit the transaction
                transaction.Commit();

                MessageBox.Show("All transactions have been cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                if (transaction != null) // Check if transaction object is not null before rollback
                {
                    transaction.Rollback(); // Rollback the transaction if an exception occurs
                }
                MessageBox.Show("Error clearing transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (transaction != null) // Check if transaction object is not null before closing it
                {
                    transaction.Dispose(); // Dispose of the transaction object
                }
                dbConnection.closeConnection();
            }
        }

        public void ChangeDodhi(string currentDodhi, string newDodhi, bool allTables)
        {
            int currentDodhiId = employees.getDodhiIdByName(currentDodhi);
            int newDodhiId = employees.getDodhiIdByName(newDodhi);

            SqlTransaction dodhiChangeOperation= null;

            string dodhiChangeQuery;
            string [] transactionTables;
            int customerCount=0;

            try
            {
                dbConnection.openConnection();

                dodhiChangeOperation = dbConnection.connection.BeginTransaction();

                if(!allTables)
                {
                    transactionTables = new string[] { "CustomersTbl" };
                }
                else
                {
                    transactionTables = new string[] { "CustomersTbl","ChilarReceive","Purchases" };
                }

                foreach(string tableName in transactionTables)
                {
                    dodhiChangeQuery = $"UPDATE {tableName} SET dodhiId=@newDodhiId, dodhi=@newDodhiName WHERE dodhiId=@currentDodhiId";
                    using (SqlCommand command = new SqlCommand(dodhiChangeQuery, dbConnection.connection, dodhiChangeOperation))
                    {
                        command.Parameters.AddWithValue("@newDodhiId", newDodhiId);
                        command.Parameters.AddWithValue("@newDodhiName", newDodhi);

                        command.Parameters.AddWithValue("@currentDodhiId", currentDodhiId);

                        customerCount++;
                        command.ExecuteNonQuery();
                    }
                }

                dodhiChangeOperation.Commit();

                MessageBox.Show("Dodhi with Id: " + currentDodhiId + " Name: " + currentDodhi.Trim() + " has been updated with Dodhi Id: " +
                    + newDodhiId + " Name: " + newDodhi, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                if (dodhiChangeOperation != null) // Check if transaction object is not null before rollback
                {
                    dodhiChangeOperation.Rollback(); // Rollback the transaction if an exception occurs
                }

                MessageBox.Show("Error changing dodhi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public decimal AverageRate(bool isCustomer)
        {
            decimal averageRate = 0;

            string tableName = "";

            if(isCustomer)
            {
                tableName = "Purchases";
            }
            else
            {
                tableName = "Sales";
            }

            try
            {
                string query = $"SELECT SUM(amount) AS totalAmount, SUM(liters) AS totalLiters FROM {tableName}";

                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal totalAmount=1;
                        decimal totalLiters=1;
                        // Check if the totalAmount column is not null and retrieve its value
                        if (!reader.IsDBNull(reader.GetOrdinal("totalAmount")))
                        {
                            totalAmount = reader.GetDecimal(reader.GetOrdinal("totalAmount"));
                            // Use totalAmount as needed
                        }

                        // Check if the totalLiters column is not null and retrieve its value
                        if (!reader.IsDBNull(reader.GetOrdinal("totalLiters")))
                        {
                            totalLiters = reader.GetDecimal(reader.GetOrdinal("totalLiters"));
                            // Use totalLiters as needed
                        }

                        averageRate=totalAmount/totalLiters;
                    }
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating average rate: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            return averageRate;
        }

        public void GetAccountSummary(out decimal totalDebit, out decimal totalCredit, out decimal closingBalance, out string closingStatus, int accountId)
        {
            //decimal openingBalance = 0;
            //string openingStatus = "";
            totalDebit = 0;
            totalCredit = 0;
            closingBalance = 0;
            closingStatus = "";

            try
            {
                dbConnection.openConnection();

                // Calculate total debit (sum of negative amounts)
                string totalDebitQuery = @"
                SELECT ISNULL(SUM(amount), 0) AS totalDebit
                FROM (
                    SELECT amount FROM Payments WHERE accountId = @accountId
                    UNION ALL
                    SELECT amount FROM Sales WHERE companyId = @accountId
                ) AS TransactionAmounts";


                using (SqlCommand command = new SqlCommand(totalDebitQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountId", accountId);

                    totalDebit = Convert.ToDecimal(command.ExecuteScalar());
                }

                // Calculate total credit (sum of positive amounts)
                string totalCreditQuery = @"
                SELECT ISNULL(SUM(amount), 0) AS totalDebit
                FROM (
                    SELECT amount FROM Purchases WHERE customerID = @accountId
                    UNION ALL
                    SELECT amount FROM Receipts WHERE accountId = @accountId
                    UNION ALL
                    SELECT amountReceived FROM Sales WHERE companyId = @accountId
                ) AS TransactionAmounts";

                using (SqlCommand command = new SqlCommand(totalCreditQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountId", accountId);

                    totalCredit = Convert.ToDecimal(command.ExecuteScalar());
                }

                // Calculate closing balance
                closingBalance = totalCredit - totalDebit;
                closingStatus = closingBalance < 0 ? "Debit" : "Credit";
                closingBalance = Math.Abs(closingBalance);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating account summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

    }
}
