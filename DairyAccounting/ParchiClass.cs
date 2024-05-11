using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyAccounting
{
    public class ParchiClass
    {
        Connection dbConnection;
        AddCustomers customers=new AddCustomers();
        AddCompanies company=new AddCompanies();

        public ParchiClass()
        {
            dbConnection = new Connection();
        }

        // to get all customers and their dodhi ids for comparison
        public Dictionary<int, int> GetCustomerAndDodhiID()
        {
            Dictionary<int, int> customerAndDodhiID = new Dictionary<int, int>();

            try
            {
                dbConnection.openConnection();

                string query = "SELECT customerId, dodhiId FROM CustomersTbl";
                using (SqlCommand command = new SqlCommand(query, dbConnection.connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerId = Convert.ToInt32(reader["customerId"]);
                            int dodhiId = Convert.ToInt32(reader["dodhiId"]);
                            customerAndDodhiID.Add(customerId, dodhiId);
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

            return customerAndDodhiID;
        }


        // to get parchi dodhi wise mean to get the customers only of the provided dodhi id 
        public void getCustomersParchi(out decimal grandTotalLiters, out decimal grandTotalMilkAmount,
            out decimal grandTotalParchiAmount, int dodhiId, int singleCustomerId,
            DateTime startDate, DateTime endDate, DataGridView dataGridView)
        {
            DataTable parchiTable = new DataTable();
            parchiTable.Columns.Add("Id");
            parchiTable.Columns.Add("Customer Name");
            parchiTable.Columns.Add("Previous Balance");
            parchiTable.Columns.Add("pStatus");
            parchiTable.Columns.Add("Total Liters");
            parchiTable.Columns.Add("Milk Amount");
            parchiTable.Columns.Add("Parchi Amount");
            parchiTable.Columns.Add("Closing Balance");
            parchiTable.Columns.Add("Status");

            decimal previousBalance;
            string previousStatus;// for previous balance status
            decimal totalLiters; // to get total liters of a specific customer
            decimal milkAmount; // to get milk amount of a customer
            decimal parchiAmount; // to store total parchi amount of cusotmer
            decimal closingBalance;
            string closingStatus; // for closing balance status
            string customerName; // to store customerName

            // for grand total of the above values
            grandTotalLiters = 0;
            grandTotalMilkAmount = 0;
            grandTotalParchiAmount = 0;

            try
            {
                dbConnection.openConnection();

                Dictionary<int,int> customerAndDodhiID= new Dictionary<int,int>();

                customerAndDodhiID = GetCustomerAndDodhiID();

                // to get parchi of all customer ralated to a single dodhi
                if(dodhiId!=-1)
                {
                    foreach (var item in customerAndDodhiID)
                    {
                        int customerId = item.Key;
                        int customerDodhiId = item.Value;

                        if (customerDodhiId == dodhiId)
                        {
                            customerName = customers.GetCustomerNameById(customerId);

                            // caling parchi function to generate parchi of the provide customer
                            getParchi(out previousBalance, out previousStatus, out totalLiters,
                            out milkAmount, out parchiAmount, out closingBalance, out closingStatus,
                            customerId, startDate.Date, endDate.Date);

                            // adding a row to the table as the new customer will come every time
                            parchiTable.Rows.Add(customerId, customerName, previousBalance, previousStatus,
                                totalLiters, milkAmount, parchiAmount, closingBalance, closingStatus);


                            grandTotalLiters += totalLiters;
                            grandTotalMilkAmount += milkAmount;
                            grandTotalParchiAmount += parchiAmount;

                            previousBalance = 0;
                            previousStatus = "";
                            totalLiters = 0;
                            milkAmount = 0;
                            parchiAmount = 0;
                            closingBalance = 0;
                            closingStatus = "";
                            customerName = "";
                        }
                    }
                }

                // to get only the searched customer parchi
                else if(singleCustomerId!=-1)
                {
                    customerName = customers.GetCustomerNameById(singleCustomerId);

                    getParchi(out previousBalance, out previousStatus, out totalLiters,
                                        out milkAmount, out parchiAmount, out closingBalance, out closingStatus,
                                        singleCustomerId, startDate.Date, endDate.Date);

                    // adding a row to the table as the new customer will come every time
                    parchiTable.Rows.Add(singleCustomerId, customerName, previousBalance, previousStatus,
                        totalLiters, milkAmount, parchiAmount, closingBalance, closingStatus);


                    grandTotalLiters += totalLiters;
                    grandTotalMilkAmount += milkAmount;
                    grandTotalParchiAmount += parchiAmount;

                    previousBalance = 0;
                    previousStatus = "";
                    totalLiters = 0;
                    milkAmount = 0;
                    parchiAmount = 0;
                    closingBalance = 0;
                    closingStatus = "";
                    customerName = "";
                }
                // to get all customers parchi once
                else
                {
                    foreach(var item in customerAndDodhiID)
                    {
                        int customerId = item.Key;

                        customerName = customers.GetCustomerNameById(customerId);


                        getParchi(out previousBalance, out previousStatus, out totalLiters,
                                        out milkAmount, out parchiAmount, out closingBalance, out closingStatus,
                                        customerId, startDate.Date, endDate.Date);

                        // adding a row to the table as the new customer will come every time
                        parchiTable.Rows.Add(customerId, customerName, previousBalance, previousStatus,
                            totalLiters, milkAmount, parchiAmount, closingBalance, closingStatus);


                        grandTotalLiters += totalLiters;
                        grandTotalMilkAmount += milkAmount;
                        grandTotalParchiAmount += parchiAmount;

                        previousBalance = 0;
                        previousStatus = "";
                        totalLiters = 0;
                        milkAmount = 0;
                        parchiAmount = 0;
                        closingBalance = 0;
                        closingStatus = "";
                        customerName = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating dodhi wise customers parchi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }

            dataGridView.DataSource = parchiTable;

            dataGridView.Columns["Id"].Width = 60;
            dataGridView.Columns["Customer Name"].Width = 160;
            dataGridView.Columns["Previous Balance"].Width = 130;
            dataGridView.Columns["pStatus"].Width = 70;
            dataGridView.Columns["Total Liters"].Width = 100;
            dataGridView.Columns["Milk Amount"].Width = 110;
            dataGridView.Columns["Parchi Amount"].Width = 115;
            dataGridView.Columns["Closing Balance"].Width = 125;
            dataGridView.Columns["Status"].Width = 70;
        }


        public void getParchi(out decimal previousBalance, out string balanceStatus, out decimal totalMilk, out decimal milkAmount, out decimal parchiAmount, out decimal closingBalance, out string closingStatus, int customerId, DateTime startDate, DateTime endDate)
        {
            previousBalance = 0;
            balanceStatus = "";
            totalMilk = 0;
            milkAmount = 0;
            parchiAmount = 0;
            closingBalance = 0;
            closingStatus = "";

            try
            {
                dbConnection.openConnection();

                // Calculate previous balance
                string previousBalanceQuery = @"
                SELECT ISNULL(SUM(amount), 0) AS totalAmount
                FROM (
                    SELECT amount FROM Purchases WHERE customerID = @customerId AND date < @startDate
                    UNION ALL
                    SELECT -Debit FROM OpeningBalances WHERE AccountId=@customerId
                    UNION ALL
                    SELECT credit From OpeningBalances WHERE AccountId=@customerId
                    UNION ALL
                    SELECT -Debit FROM JournalVoucher WHERE AccountId=@customerId
                    UNION ALL
                    SELECT Credit FROM JournalVoucher WHERE AccountId=@customerId
                    UNION ALL
                    SELECT -amount FROM Payments WHERE accountId = @customerId
                    UNION ALL
                    SELECT amount FROM Receipts WHERE accountId = @customerId
                ) AS TransactionAmounts";

                using (SqlCommand command = new SqlCommand(previousBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@startDate", startDate);

                    previousBalance = Convert.ToDecimal(command.ExecuteScalar());
                    balanceStatus = previousBalance >= 0 ? "Credit" : "Debit";
                    
                }

                // Calculate milk transactions
                string milkQuery = "SELECT ISNULL(SUM(liters), 0) AS totalLiters, ISNULL(SUM(amount), 0) AS totalAmount FROM Purchases WHERE CustomerID = @customerId AND date BETWEEN @startDate AND @endDate";

                using (SqlCommand command = new SqlCommand(milkQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalMilk = Convert.ToDecimal(reader["totalLiters"]);
                            milkAmount = Convert.ToDecimal(reader["totalAmount"]);
                        }
                    }
                }

                // Calculate parchi amount and closing balance
                parchiAmount = milkAmount + previousBalance;
                parchiAmount = parchiAmount < 0 ? 0 : parchiAmount;
                

                closingBalance = milkAmount + previousBalance;
                closingStatus = closingBalance < 0 ? "Debit" : "Credit";
                closingBalance = Math.Abs(closingBalance);
                previousBalance = Math.Abs(previousBalance);

                parchiAmount=Math.Round(parchiAmount,0);
                closingBalance = Math.Round(closingBalance, 0);
                previousBalance=Math.Round(previousBalance, 0);
                milkAmount=Math.Round(milkAmount,0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating customers parchi!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void getAllAccountsBalances(int dodhiId, bool isCompany, DataGridView dataGridView, 
            out decimal grandTotalDebit, out decimal grandTotalCredit)
        {
            DataTable balanceTable = new DataTable();

            balanceTable.Columns.Add("Id");
            balanceTable.Columns.Add("Account Name");
            balanceTable.Columns.Add("Opening Balance");
            balanceTable.Columns.Add("oStatus");
            balanceTable.Columns.Add("Debit");
            balanceTable.Columns.Add("Credit");
            balanceTable.Columns.Add("Closing Balance");
            balanceTable.Columns.Add("Status");


            grandTotalCredit = 0;
            grandTotalDebit = 0;

            decimal openingBalance = 0;
            string openingStatus = "";
            decimal totalDebit;
            decimal totalCredit;
            decimal closingBalance;
            string closingStatus = "";
            string accountName;

            try
            {
                dbConnection.openConnection();

                Dictionary<int, int> customerAndDodhiID = new Dictionary<int, int>();

                customerAndDodhiID = GetCustomerAndDodhiID();

                Dictionary<int, string> companies = new Dictionary<int, string>();

                companies = company.GetCompanyIdsAndNames();

                if(!isCompany)
                {
                    // to get parchi of all customer ralated to a single dodhi
                    if (dodhiId != -1)
                    {
                        foreach (var item in customerAndDodhiID)
                        {
                            int customerId = item.Key;
                            int customerDodhiId = item.Value;

                            if (customerDodhiId == dodhiId)
                            {
                                accountName = customers.GetCustomerNameById(customerId);

                                // caling parchi function to generate parchi of the provide customer
                                GetAccountSummary(out openingBalance, out openingStatus, out totalDebit, out totalCredit, out closingBalance, out closingStatus, customerId);

                                // adding a row to the table as the new customer will come every time
                                balanceTable.Rows.Add(customerId, accountName, openingBalance, openingStatus, totalDebit, totalCredit, closingBalance, closingStatus);


                                grandTotalCredit += totalCredit;
                                grandTotalDebit += totalDebit;

                                openingBalance = 0;
                                openingStatus = "";
                                totalDebit = 0;
                                totalCredit = 0;
                                closingBalance = 0;
                                closingStatus = "";
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in customerAndDodhiID)
                        {
                            int customerId = item.Key;

                            accountName = customers.GetCustomerNameById(customerId);

                            // caling parchi function to generate parchi of the provide customer
                            GetAccountSummary(out openingBalance, out openingStatus, out totalDebit, out totalCredit, out closingBalance, out closingStatus, customerId);

                            // adding a row to the table as the new customer will come every time
                            balanceTable.Rows.Add(customerId, accountName, openingBalance, openingStatus, totalDebit, totalCredit, closingBalance, closingStatus);


                            grandTotalCredit += totalCredit;
                            grandTotalDebit += totalDebit;

                            openingBalance = 0;
                            openingStatus = "";
                            totalDebit = 0;
                            totalCredit = 0;
                            closingBalance = 0;
                            closingStatus = "";

                        }
                    }
                }
                else // for companies balances
                {
                    foreach (var item in companies)
                    {
                        int companyId = item.Key;
                        string companyName = item.Value;
                        

                        // caling parchi function to generate parchi of the provide customer
                        GetAccountSummary(out openingBalance, out openingStatus,out totalDebit, out totalCredit, out closingBalance, out closingStatus, companyId);

                        // adding a row to the table as the new customer will come every time
                        balanceTable.Rows.Add(companyId, companyName, openingBalance, openingStatus, totalDebit, totalCredit, closingBalance, closingStatus);


                        grandTotalCredit += totalCredit;
                        grandTotalDebit += totalDebit;

                        openingBalance = 0;
                        openingStatus = "";
                        totalDebit = 0;
                        totalCredit = 0;
                        closingBalance = 0;
                        closingStatus = "";

                    }
                }

                

                dataGridView.DataSource = balanceTable;

                dataGridView.Columns["Id"].Width = 70;
                dataGridView.Columns["Account Name"].Width = 160;
                dataGridView.Columns["Opening Balance"].Width = 130;
                dataGridView.Columns["oStatus"].Width = 70;
                dataGridView.Columns["Debit"].Width = 100;
                dataGridView.Columns["Credit"].Width = 110;
                dataGridView.Columns["Closing Balance"].Width = 125;
                dataGridView.Columns["Status"].Width = 70;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error calculating accounts balances: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.closeConnection();
            }
        }

        public void GetAccountSummary(out decimal openingBalance, out string openingStatus ,out decimal totalDebit, out decimal totalCredit, out decimal closingBalance, out string closingStatus, int accountId)
        {
            openingBalance = 0;
            openingStatus = "";
            totalDebit = 0;
            totalCredit = 0;
            closingBalance = 0;
            closingStatus = "";

            try
            {
                dbConnection.openConnection();

                string openingBalanceQuery = "SELECT ISNULL(SUM(amount), 0) AS OpeningBalance" +
                    " FROM (SELECT -debit AS amount FROM OpeningBalances WHERE accountId=@accountId" +
                    " UNION ALL" +
                    " SELECT credit AS amount FROM OpeningBalances WHERE accountId=@accountID)" +
                    " AS TransactionAmounts";

                using (SqlCommand command = new SqlCommand(openingBalanceQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountId", accountId);

                    openingBalance = Convert.ToDecimal(command.ExecuteScalar());
                }

                // Calculate total debit (sum of negative amounts)
                string totalDebitQuery = @"
                SELECT ISNULL(SUM(amount), 0) AS totalDebit
                FROM (
                    SELECT amount FROM Payments WHERE accountId = @accountId
                    UNION ALL
                    SELECT amount FROM Sales WHERE companyId = @accountId
                    UNION ALL
                    SELECT Debit FROM JournalVoucher WHERE AccountId=@accountId
                ) AS TransactionAmount";


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
                    UNION ALL
                    SELECT Credit FROM JournalVoucher WHERE AccountId=@accountId
                ) AS TransactionAmounted";

                using (SqlCommand command = new SqlCommand(totalCreditQuery, dbConnection.connection))
                {
                    command.Parameters.AddWithValue("@accountId", accountId);

                    totalCredit = Convert.ToDecimal(command.ExecuteScalar());
                }

                // Calculate closing balance
                closingBalance = openingBalance + totalCredit - totalDebit;
                openingStatus = openingBalance < 0 ? "Debit" : "Credit";
                closingStatus = closingBalance < 0 ? "Debit" : "Credit";
                openingBalance = Math.Abs(openingBalance);
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
