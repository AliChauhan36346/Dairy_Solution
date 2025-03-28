﻿using System;
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

        
        public Dictionary<int, string> changeSelectedCustomerDodhi(int dodhiId)
        {
            Dictionary<int, string> customerIdsNames= new Dictionary<int, string>();

            foreach(var entry in customers.GetCustomersIdsAndNamesByDodhi(dodhiId))
            {
                customerIdsNames.Add(entry.Key, entry.Value);
            }

            return customerIdsNames;
        }


        public void ChangeDodhiSelectedCustomers(string currentDodhi, string newDodhi, int customerId, int totalCustomers, int changedCustomers)
        {
            int currentDodhiId = employees.getDodhiIdByName(currentDodhi);
            int newDodhiId = employees.getDodhiIdByName(newDodhi);

            SqlTransaction dodhiChangeOperation = null;

            string dodhiChangeQuery;
            int customerCount = 0;

            try
            {
                dbConnection.openConnection();

                dodhiChangeOperation = dbConnection.connection.BeginTransaction();

                
                dodhiChangeQuery = $"UPDATE CustomersTbl SET dodhiId=@newDodhiId, dodhi=@newDodhiName WHERE dodhiId=@currentDodhiId AND customerId=@customerId";
                using (SqlCommand command = new SqlCommand(dodhiChangeQuery, dbConnection.connection, dodhiChangeOperation))
                {
                    command.Parameters.AddWithValue("@newDodhiId", newDodhiId);
                    command.Parameters.AddWithValue("@newDodhiName", newDodhi);

                    command.Parameters.AddWithValue("@currentDodhiId", currentDodhiId);

                    command.Parameters.AddWithValue("@customerId", customerId);

                    customerCount++;
                    command.ExecuteNonQuery();
                }
                

                dodhiChangeOperation.Commit();

                if(changedCustomers==totalCustomers)
                {
                    MessageBox.Show("Selected customers have been updated with new dodhi successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
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

        public void ShowAccountSuggestionsDodhiWise(TextBox textBox, ListBox listBox, int dodhiId)
        {
            if (textBox.Focused)
            {
                listBox.Visible = true;
                string searchTerm = textBox.Text.Trim(); // Trim whitespace

                // Clear existing suggestions
                listBox.Items.Clear();

                // Get account IDs and names based on account type
                Dictionary<int, string> accountIdsAndNames;

                accountIdsAndNames = customers.GetCustomersIdsAndNamesByDodhi(dodhiId);

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
    }
}
